using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Manage
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Server=localhost;database=dbcapstone;user=root;password=1234";
            using(MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                try
                {
                    conn.Open();
                    string query = "Insert into usr(usr_name,passwordHash,designation)values(@user,@pass,@desig)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        string hashedPassword = hashPassword(txtPass.Text);

                        cmd.Parameters.AddWithValue("@user", txtUser.Text);
                        cmd.Parameters.AddWithValue("@pass", hashedPassword);
                        cmd.Parameters.AddWithValue("@desig", comboBox1.SelectedItem?.ToString() ?? "");


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK);
                        txtPass.Clear();
                        txtUser.Clear();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
        private string hashPassword(string password)//para sa hash for password
        {
            using(SHA1 sha1 = SHA1.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);//iconvert 
                byte[] hashbytes = sha1.ComputeHash(passwordBytes);//icompute

                StringBuilder hashtring = new StringBuilder();
                foreach(byte b in hashbytes)
                {
                    hashtring.Append(b.ToString("x2"));
                }
                return hashtring.ToString();
            }
           

        }
    }
}
