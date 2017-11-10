using System;

namespace Notebook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.companyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFromPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFromCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyListToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // companyListToolStripMenuItem
            // 
            this.companyListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyListToolStripMenuItem1,
            this.personListToolStripMenuItem,
            this.companyPeopleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.companyListToolStripMenuItem.Name = "companyListToolStripMenuItem";
            this.companyListToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.companyListToolStripMenuItem.Text = "Views";
            this.companyListToolStripMenuItem.Click += new System.EventHandler(this.companyListToolStripMenuItem_Click);
            // 
            // companyListToolStripMenuItem1
            // 
            this.companyListToolStripMenuItem1.Name = "companyListToolStripMenuItem1";
            this.companyListToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.companyListToolStripMenuItem1.Text = "Company List";
            this.companyListToolStripMenuItem1.Click += new System.EventHandler(this.companyListToolStripMenuItem1_Click);
            // 
            // personListToolStripMenuItem
            // 
            this.personListToolStripMenuItem.Name = "personListToolStripMenuItem";
            this.personListToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.personListToolStripMenuItem.Text = "Person List";
            this.personListToolStripMenuItem.Click += new System.EventHandler(this.personListToolStripMenuItem_Click);
            // 
            // companyPeopleToolStripMenuItem
            // 
            this.companyPeopleToolStripMenuItem.Name = "companyPeopleToolStripMenuItem";
            this.companyPeopleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.companyPeopleToolStripMenuItem.Text = "Company People";
            this.companyPeopleToolStripMenuItem.Click += new System.EventHandler(this.companyPeopleToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCompanyToolStripMenuItem,
            this.addPersonToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addCompanyToolStripMenuItem.Text = "Add company";
            this.addCompanyToolStripMenuItem.Click += new System.EventHandler(this.addCompanyToolStripMenuItem_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addPersonToolStripMenuItem.Text = "Add person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchFromPeopleToolStripMenuItem,
            this.searchFromCompaniesToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchFromPeopleToolStripMenuItem
            // 
            this.searchFromPeopleToolStripMenuItem.Name = "searchFromPeopleToolStripMenuItem";
            this.searchFromPeopleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.searchFromPeopleToolStripMenuItem.Text = "Search from people";
            this.searchFromPeopleToolStripMenuItem.Click += new System.EventHandler(this.searchFromPeopleToolStripMenuItem_Click);
            // 
            // searchFromCompaniesToolStripMenuItem
            // 
            this.searchFromCompaniesToolStripMenuItem.Name = "searchFromCompaniesToolStripMenuItem";
            this.searchFromCompaniesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.searchFromCompaniesToolStripMenuItem.Text = "Search from companies";
            this.searchFromCompaniesToolStripMenuItem.Click += new System.EventHandler(this.searchFromCompaniesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem companyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyPeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFromPeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFromCompaniesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}