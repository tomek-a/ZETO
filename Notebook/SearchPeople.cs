using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Notebook
{
    public partial class SearchPeople : Form
    {
        public SearchPeople()
        {
            InitializeComponent();
        }

        // creating list of all people from database
        List<Person> list = new List<Person>();

        // loading data from database
        private void SearchPeople_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var people_list = db.People.Include(c => c.Company);
                foreach (Person p in people_list)
                {
                    list.Add(p);
                }
            };
        }

        // searching in local list 'list'
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string name = textBox1.Text.ToLower();
            string surname = textBox2.Text.ToLower();
            string job = textBox3.Text.ToLower();
            string company = textBox4.Text.ToLower();

            foreach (Person p in list)
            {
                if (p.Name.ToLower().Contains(name) && 
                   p.Surname.ToLower().Contains(surname) &&
                   p.Job.ToLower().Contains(job) &&
                   p.Company.Name.ToLower().Contains(company))
                {
                    listView1.Items.Add(String.Format("{0} {1}   |   {2}", p.Name, p.Surname, p.Company.Name));
                }
            }
        }
    }
}
