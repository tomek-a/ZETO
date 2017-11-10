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
    public partial class AddPerson : Form
    {
        public AddPerson()
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

        private void AddPerson_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var list_of_companies = db.Companies;
                comboBox1.DataSource = list_of_companies
                    .Select(c => new CBItem
                    {
                        Name = c.Name,
                        Value = c.Id
                    })
                    .ToArray();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                Person new_person = new Person();
                new_person.Name = textBox1.Text;
                new_person.Surname = textBox2.Text;
                new_person.Job = textBox3.Text;
                new_person.Phone = Int32.Parse(textBox4.Text);
                new_person.Mobile = Int32.Parse(textBox5.Text);
                new_person.Company = db.Companies.Find(((CBItem)comboBox1.SelectedItem).Value);
                db.People.Add(new_person);
                db.SaveChanges();
                MessageBox.Show("Person successfully added!");
                this.Close();
            }
        }
    }
}
