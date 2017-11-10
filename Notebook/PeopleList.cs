using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class PeopleList : Form
    {
        public PeopleList()
        {
            InitializeComponent();
        }

        public class CBItem
        {
            public string Name { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        // list of people for filling text boxes
        List<dynamic> people = new List<dynamic>();

        // filling listview with people from database
        private void PeopleList_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var list_of_people = (from p in db.People
                                      join c in db.Companies on p.Company.Id equals c.Id
                                      select new { p, c }).ToList();
                foreach (var data in list_of_people)
                {
                    listView1.Items.Add(String.Format("{0} {1}", data.p.Name, data.p.Surname));
                    people.Add(data);
                };

                var list_of_companies = db.Companies;
                comboBox1.DataSource = list_of_companies
                    .Select(c => new CBItem
                    {
                        Name = c.Name,
                        Value = c.Id
                    })
                    .ToArray();
                comboBox1.Text = null;
            }
        }

        // filling text boxes with people details
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //error occuring while switching between items, this prevents error
            {
                textBox1.Text = people[listView1.SelectedItems[0].Index].p.Name;
                textBox2.Text = people[listView1.SelectedItems[0].Index].p.Surname;
                textBox3.Text = people[listView1.SelectedItems[0].Index].p.Job;
                textBox4.Text = "" + people[listView1.SelectedItems[0].Index].p.Phone;
                textBox5.Text = "" + people[listView1.SelectedItems[0].Index].p.Mobile;
                comboBox1.Text = people[listView1.SelectedItems[0].Index].c.Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select person");
            }
            else
            {
                using (var db = new DataContext())
                {
                    int person_id = people[listView1.SelectedItems[0].Index].p.PersonId;
                    Person p = db.People.Find(person_id);
                    db.People.Remove(p);
                    people.Remove(listView1.SelectedItems[0].Index);
                    db.SaveChanges();
                    MessageBox.Show("Person deleted");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select person");
            }
            else
            {
                using (var db = new DataContext())
                {
                    int person_id = people[listView1.SelectedItems[0].Index].p.PersonId;
                    Person person = db.People.Find(person_id);
                    person.Name = textBox1.Text;
                    person.Surname = textBox2.Text;
                    person.Job = textBox3.Text;
                    person.Phone = Int32.Parse(textBox4.Text);
                    person.Mobile = Int32.Parse(textBox5.Text);
                    person.Company = db.Companies.Find(((CBItem)comboBox1.SelectedItem).Value);
                    db.SaveChanges();
                    MessageBox.Show("Company deleted");
                    this.Close();
                }
            }
        }
    }    
}
