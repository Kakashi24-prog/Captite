namespace Manage
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvcaps = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcaps)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.dgvcaps);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(276, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 384);
            this.panel1.TabIndex = 0;
            // 
            // dgvcaps
            // 
            this.dgvcaps.AllowUserToAddRows = false;
            this.dgvcaps.AllowUserToDeleteRows = false;
            this.dgvcaps.AllowUserToResizeColumns = false;
            this.dgvcaps.AllowUserToResizeRows = false;
            this.dgvcaps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcaps.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcaps.Location = new System.Drawing.Point(38, 55);
            this.dgvcaps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcaps.Name = "dgvcaps";
            this.dgvcaps.ReadOnly = true;
            this.dgvcaps.RowHeadersWidth = 62;
            this.dgvcaps.RowTemplate.Height = 28;
            this.dgvcaps.Size = new System.Drawing.Size(604, 309);
            this.dgvcaps.TabIndex = 7;
            this.dgvcaps.AllowUserToResizeColumnsChanged += new System.EventHandler(this.LoadFormPanel);
            this.dgvcaps.AllowUserToResizeRowsChanged += new System.EventHandler(this.LoadFormPanel);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 93);
            this.label2.TabIndex = 6;
            this.label2.Text = "CAPSTONE TITLES";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(48, 246);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "MANAGE CAPSTONE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(48, 181);
            this.btnGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(142, 38);
            this.btnGrade.TabIndex = 3;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 401);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcaps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcaps;
        private System.Windows.Forms.Button btnGrade;
    }
}

