using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage
{
    public partial class log : Form
    {
       
        public log()
        {
            InitializeComponent();
      

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPass.Text;

            if (authenticate(username, password))
            {
                MessageBox.Show("Login Successful");

                //string designation = getUserRole(username);
                //configureUIRole(designation); 

                Form1 form = new Form1();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
        private bool authenticate(string username, string password)
        {
            string connectionstring = "Server=localhost;database=dbcapstone;user=root;password=1234";

            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT passwordHash FROM usr WHERE usr_name = @username;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["passwordHash"].ToString().Trim();
                            string hashedPassword = hashPassword(password).Trim(); 

                          
                            Console.WriteLine("Stored Hash: " + storedHash);
                            Console.WriteLine("Input Hash: " + hashedPassword);

                            if (hashedPassword.Equals(storedHash, StringComparison.OrdinalIgnoreCase))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        private string hashPassword(string password)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password); 
                byte[] hashBytes = sha1.ComputeHash(passwordBytes); 

                
                StringBuilder hashString = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2"));
                }
                return hashString.ToString();
            }
        }
        //private void configureUIRole(string designation)
        //{
        //    if (designation == "ADVISER")
        //    {
        //        form1.EnableAddButton();
        //    }
        //    else
        //    {
        //        //form1.SetbuttonAdd(true);
        //    }
        //}
        private string getUserRole(string username)
        {
            string connectionstring = "Server=localhost;database=dbcapstone;user=root;password=1234";
            using(MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = "SELECT designation FROM usr WHERE usr_name = @username";
                using(MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    return cmd.ExecuteScalar()?.ToString();

                }
            }
        }

        private void log_Load(object sender, EventArgs e)
        {

        }
    }
}

