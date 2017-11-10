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
    public partial class CompanyList : Form
    {
        public CompanyList()
        {
            InitializeComponent();
        }
        // list of companies for filling text boxes
        List<Company> companies = new List<Company>();

        // filling listview with companies from database
        private void CompanyList_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var list_of_companies = db.Companies;
                foreach (Company c in list_of_companies)
                {
                    listView1.Items.Add(c.Name);
                    companies.Add(c);
                }
                
            }
        }

        // filling text boxes with company details
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) //error occuring while switching between items, this prevents error
            {
                textBox7.Text = companies[listView1.SelectedItems[0].Index].Name;
                textBox1.Text = companies[listView1.SelectedItems[0].Index].Address;
                textBox2.Text = "" + companies[listView1.SelectedItems[0].Index].Code;
                textBox3.Text = companies[listView1.SelectedItems[0].Index].City;
                textBox4.Text = "" + companies[listView1.SelectedItems[0].Index].NIP;
                textBox5.Text = "" + companies[listView1.SelectedItems[0].Index].Phone;
                textBox6.Text = companies[listView1.SelectedItems[0].Index].Notes;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select company");
            }
            else
            {
                using (var db = new DataContext())
                {
                    int company_id = companies[listView1.SelectedItems[0].Index].Id;
                    Company company = db.Companies.Find(company_id);
                    company.Name = textBox7.Text;
                    company.Address = textBox1.Text;
                    company.Code = Int32.Parse(textBox2.Text);
                    company.City = textBox3.Text;
                    company.NIP = Int32.Parse(textBox4.Text);
                    company.Phone = Int32.Parse(textBox5.Text);
                    company.Notes = textBox6.Text;
                    db.SaveChanges();
                    MessageBox.Show("Company details modified");
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select company");
            }
            else
            {
                using (var db = new DataContext())
                {
                    int company_id = companies[listView1.SelectedItems[0].Index].Id;
                    Company c = db.Companies.Include(p => p.Person).SingleOrDefault(p => p.Id == company_id);
                    db.Companies.Remove(c);
                    companies.Remove(c);
                    db.SaveChanges();
                    MessageBox.Show("Company deleted");
                    this.Close();
                }
            }
        }
    }    
}
