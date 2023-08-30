using System;
using System.Windows.Forms;

namespace LoginClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            treeView1.Nodes.Add("Manage Registration");
            treeView1.Nodes[0].Nodes.Add("Create New Registration");
            treeView1.Nodes[0].Nodes.Add("Edit Registration");
            treeView1.Nodes[0].Nodes.Add("View Registrations");

            treeView1.Nodes.Add("Manage E-Form");
            treeView1.Nodes[1].Nodes.Add("Create New E-Form");
            treeView1.Nodes[1].Nodes.Add("Edit E-Form");
            treeView1.Nodes[1].Nodes.Add("Form Notifications");

            treeView1.Nodes.Add("Manage Case");
            treeView1.Nodes[2].Nodes.Add("Create New Case");
            treeView1.Nodes[2].Nodes.Add("Edit Case");
            treeView1.Nodes[2].Nodes.Add("Case Notifications");

            treeView1.Nodes.Add("Manage Business Rules");

            treeView1.Nodes.Add("Manage Partner");

            treeView1.Nodes.Add("Manage Product");

            treeView1.Nodes.Add("Manage Party");
            treeView1.Nodes[6].Nodes.Add("Add New Party");
            treeView1.Nodes[6].Nodes.Add("Data Privacy and Security");
            treeView1.Nodes[6].Nodes.Add("Party Analytics");
            treeView1.Nodes[6].Nodes.Add("Party Categorization");

            treeView1.Nodes.Add("Manage User");
            treeView1.Nodes[7].Nodes.Add("User Registration");
            treeView1.Nodes[7].Nodes.Add("Search and Filter Users");
            treeView1.Nodes[7].Nodes.Add("User Notifications");
            treeView1.Nodes[7].Nodes.Add("User Self-Service");
            treeView1.Nodes[7].Nodes.Add("Data Privacy and Security");
        }

        /*private void button5_Click(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode();
            rootNode.Nodes.Add("Child node 1");
            rootNode.Nodes.Add("Child node 2");

            treeView1.Nodes.Add(rootNode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Create New E-Form");
            treeView1.Nodes.Add("Edit E-Form");
            treeView1.Nodes.Add("Form Notifications");
            treeView1.Nodes.Add("Form Security");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Create New Case");
            treeView1.Nodes.Add("Edit Case");
            treeView1.Nodes.Add("Case Notifications");
            treeView1.Nodes.Add("Case Security");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("Add New Party");
            treeView1.Nodes.Add("Data Privacy and Security");
            treeView1.Nodes.Add("Party Analytics");
            treeView1.Nodes.Add("Party Categorization");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("User Registration");
            treeView1.Nodes.Add("Search and Filter Users");
            treeView1.Nodes.Add("User Notifications");
            treeView1.Nodes.Add("User Self-Service");
            treeView1.Nodes.Add("Data Privacy and Security");
        }*/
    }
}
