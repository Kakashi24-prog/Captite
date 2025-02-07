using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage
{
    public partial class Form1 : Form
    {
     public static  Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance= this;
           
        }
 
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            LoadFormPanel();
        }
        private void LoadFormPanel()
        {
            Add add = new Add();
            add.FormBorderStyle = FormBorderStyle.None;
            add.TopLevel = false;

            add.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(add);

            add.Show();
        }
        private void LoadFormPanel(object sender, EventArgs e)
        {
            string connectionstring = "server = localhost;database = dbcapstone;user = root;password =1234;";
            using (MySqlConnection conn = new MySqlConnection(connectionstring))

            {
                conn.Open();
                string query = "SELECT title, `group` FROM capstone";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvcaps.DataSource = dt;
                    dgvcaps.Columns["title"].HeaderText = "Title";
                    dgvcaps.Columns["group"].HeaderText = "Group";
                
                }
                else
                {
                    dgvcaps.DataSource = "No capstone";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}