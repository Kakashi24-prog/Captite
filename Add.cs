using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Manage
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=dbcapstone;User=root;Password=1234";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query1 = "INSERT INTO capstone(title, `group`) VALUES (@title, @group)";
                        long capsId; 
                        using (MySqlCommand cmd1 = new MySqlCommand(query1, conn, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@title", txtTitle.Text);
                            cmd1.Parameters.AddWithValue("@group", txtGroup.Text);
                            cmd1.ExecuteNonQuery();
                            capsId = cmd1.LastInsertedId;
                        }
                        string input = txtMembers.Text;
                        string[] names = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                        string query2 = "INSERT INTO members(name,title_id) VALUES (@name,@title)";
                        foreach (var name in names)
                        {
                            using (MySqlCommand cmd2 = new MySqlCommand(query2, conn, transaction))
                            {
                                cmd2.Parameters.AddWithValue("@name", name.Trim());
                                cmd2.Parameters.AddWithValue("@title", capsId);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        MessageBox.Show("Data saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Do you Want to Exit?", "Confirmation", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
               Form1 form = new Form1();
               form.ShowDialog();
            }
            else
            {
                txtGroup.Clear();
                txtMembers.Clear();
                txtTitle.Clear();
            }
        }
    }
}