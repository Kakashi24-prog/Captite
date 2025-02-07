using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage
{
    public partial class frmsign : Form
    {
        public frmsign()
        {
            InitializeComponent();
            
        }
        private void LoadFormPanel2()
        {
            log logf = new log();
            logf.Dock = DockStyle.Fill;
            logf.TopLevel = false;

            logf.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Clear();
            panel2.Controls.Add(logf);
   
            logf.Show();

        }
        private void btnlog_Click(object sender, EventArgs e)
        {
            LoadFormPanel2();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
            LoadFormPanel();
        }
        private void LoadFormPanel()
        {
            signin sin = new signin();
            sin.TopLevel = false;
            sin.Dock = DockStyle.Fill;
            sin.FormBorderStyle = FormBorderStyle.None;

            panel2.Controls.Clear();
            panel2.Controls.Add(sin);

            sin.Show();

        }

        private void sign_Load(object sender, EventArgs e)
        {

        }
    }
}
