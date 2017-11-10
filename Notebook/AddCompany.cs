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
    public partial class AddCompany : Form
    {
        public AddCompany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                Company new_company = new Company();
                new_company.Name = textBox1.Text;
                new_company.NIP = Int32.Parse(textBox5.Text);
                new_company.Address = textBox2.Text;
                new_company.City = textBox3.Text;
                new_company.Code = Int32.Parse(textBox4.Text);
                new_company.Phone = Int32.Parse(textBox6.Text);
                new_company.Notes = textBox7.Text;
                db.Companies.Add(new_company);
                db.SaveChanges();
                MessageBox.Show("Company successfully added!");
                this.Close();
            }
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {

        }
    }
}
