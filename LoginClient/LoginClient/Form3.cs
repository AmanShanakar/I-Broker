﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginClient
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            treeView1.Nodes.Add("Dashboard");
            treeView1.Nodes.Add("Manage Registration");
            treeView1.Nodes[1].Nodes.Add("View Registration");
            treeView1.Nodes.Add("Manage E-Forms");
            treeView1.Nodes.Add("Manage Case");
            treeView1.Nodes.Add("Manage Rules");
            treeView1.Nodes.Add("Manage Partner");
            treeView1.Nodes.Add("Manage Product");
            treeView1.Nodes.Add("Manage Party");
            treeView1.Nodes.Add("Manage User");
            DataGrid();
        }       
        

        private void DataGrid()
        {
            List<Person> person = new List<Person>();
            person.Add(new Person("Aman", "Some Text", "Completed", System.DateTime.Now, "AB-1", ""));
            person.Add(new Person("Abhimanyu", "Some Text", "In-progress", System.DateTime.Now, "AB-2", ""));
            person.Add(new Person("Madhav", "Some Text", "OnHold", System.DateTime.Now, "AB-3", ""));
            person.Add(new Person("Upendra", "Some Text", "Rejected", System.DateTime.Now, "AB-4", ""));
            person.Add(new Person("Atul", "Some Text", "In-progress", System.DateTime.Now, "AB-5", ""));
            person.Add(new Person("Supriye", "Some Text", "Completed", System.DateTime.Now, "AB-6", ""));
            person.Add(new Person("Manish", "Some Text", "OnHold", System.DateTime.Now, "AB-7", ""));
            person.Add(new Person("Ranjit", "Some Text", "Rejected", System.DateTime.Now, "AB-8", ""));
            person.Add(new Person("Himanshu", "Some Text", "Completed", System.DateTime.Now, "AB-9", ""));

            foreach (Person p in person)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells[0].Value = p.User;
                row.Cells[1].Value = p.Case_Description;
                row.Cells[2].Value = p.Status;
                row.Cells[3].Value = p.Last_Updated;
                row.Cells[4].Value = p.Tracking_Id;
                row.Cells[5].Value = p.Image;
            }
        }
    }
}
