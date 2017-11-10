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
    public partial class SearchCompanies : Form
    {
        public SearchCompanies()
        {
            InitializeComponent();
        }

        // creating list of all companies from database
        List<Company> list = new List<Company>();

        // loading data from database
        private void SearchCompanies_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var companies_list = db.Companies;
                foreach (Company c in companies_list)
                {
                    list.Add(c);
                }
            };
        }

        // searching in local list 'list'
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string name = textBox1.Text.ToLower();
            string NIP = textBox2.Text;
            string city = textBox3.Text.ToLower();
            string code = textBox4.Text;

            foreach (Company c in list)
            {
                if (c.Name.ToLower().Contains(name) &&
                   c.NIP.ToString().Contains(NIP) &&
                   c.City.ToLower().Contains(city) &&
                   c.Code.ToString().Contains(code))
                {
                    listView1.Items.Add(String.Format("{0}   |   {1}", c.Name, c.NIP));
                }
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            
        }
    }
}
