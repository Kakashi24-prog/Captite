namespace Manage
{
    partial class signin
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PANEL1 ",
            "PANEL2 ",
            "PANEL CHAIRMAN",
            "ADVISER"});
            this.comboBox1.Location = new System.Drawing.Point(11, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(425, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.UseWaitCursor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(124, 72);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(192, 38);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(124, 146);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(192, 38);
            this.txtPass.TabIndex = 2;
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(124, 209);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(192, 44);
            this.btnSignin.TabIndex = 3;
            this.btnSignin.Text = "SIGN IN";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD";
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 295);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "signin";
            this.Text = "frmSignin";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}