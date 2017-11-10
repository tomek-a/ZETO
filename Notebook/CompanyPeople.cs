using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; //query doesn't work without it

namespace Notebook
{
    public partial class CompanyPeople : Form
    {
        public CompanyPeople()
        {
            InitializeComponent();
        }

        List<Company> list = new List<Company>();

        private void CompanyPeople_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())
            {
                var list_of_companies = db.Companies.Include(p => p.Person).ToList();
                foreach (Company c in list_of_companies)
                {
                    listView1.Items.Add(c.Name);
                    list.Add(c);
                }
            };
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView2.Items.Clear();
                int index = listView1.SelectedItems[0].Index;
                var people_list = list[index].Person.ToList();
                foreach (Person p in people_list)
                {
                    listView2.Items.Add(String.Format("{0} {1}", p.Name, p.Surname));
                }
            }
        }
    }
}
