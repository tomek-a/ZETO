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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void companyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //COMPANY LIST MENU BUTTON
        CompanyList clForm;
        private void companyListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clForm == null)
            {
                clForm = new CompanyList
                {
                    MdiParent = this
                };
                clForm.FormClosed += new FormClosedEventHandler(clForm_FormClosed);
                clForm.Show();
            }
            else
                clForm.Activate();
        }
        private void clForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            clForm = null;
        }

        //PERSON LIST MENU BUTTON
        PeopleList plForm;
        private void personListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (plForm == null)
            {
                plForm = new PeopleList
                {
                    MdiParent = this
                };
                plForm.FormClosed += new FormClosedEventHandler(plForm_FormClosed);
                plForm.Show();
            }
            else
                plForm.Activate();
        }
        private void plForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            plForm = null;
        }

        //ADD COMPANY MENU BUTTON
        AddCompany acForm;
        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acForm == null)
            {
                acForm = new AddCompany
                {
                    MdiParent = this
                };
                acForm.FormClosed += new FormClosedEventHandler(acForm_FormClosed);
                acForm.Show();
            }
            else
                acForm.Activate();
        }
        private void acForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            acForm = null;
        }

        //ADD PERSON MENU BUTTON
        AddPerson apForm;
        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (apForm == null)
            {
                apForm = new AddPerson
                {
                    MdiParent = this
                };
                apForm.FormClosed += new FormClosedEventHandler(apForm_FormClosed);
                apForm.Show();
            }
            else
                apForm.Activate();
        }
        private void apForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            apForm = null;
        }

        //COMPANY PEOPLE LIST BUTTON
        CompanyPeople cpForm;
        private void companyPeopleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (cpForm == null)
            {
                cpForm = new CompanyPeople
                {
                    MdiParent = this
                };
                cpForm.FormClosed += new FormClosedEventHandler(cpForm_FormClosed);
                cpForm.Show();
            }
            else
                cpForm.Activate();
        }
        private void cpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cpForm = null;
        }


        //SEARCH PEOPLE BUTTON
        SearchPeople spForm;
        private void searchFromPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spForm == null)
            {
                spForm = new SearchPeople
                {
                    MdiParent = this
                };
                spForm.FormClosed += new FormClosedEventHandler(spForm_FormClosed);
                spForm.Show();
            }
            else
                spForm.Activate();
        }

        private void spForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            spForm = null;
        }


        //SEARCH COMPANIES BUTTON
        SearchCompanies scForm;
        private void searchFromCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (scForm == null)
            {
                scForm = new SearchCompanies
                {
                    MdiParent = this
                };
                scForm.FormClosed += new FormClosedEventHandler(scForm_FormClosed);
                scForm.Show();
            }
            else
                scForm.Activate();
        }

        private void scForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            scForm = null;
        }
    }
}
