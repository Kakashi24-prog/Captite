namespace Manage
{
    partial class Add
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtMembers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(38, 78);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(483, 36);
            this.txtTitle.TabIndex = 0;
            // 
            // txtMembers
            // 
            this.txtMembers.Location = new System.Drawing.Point(38, 167);
            this.txtMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMembers.Multiline = true;
            this.txtMembers.Name = "txtMembers";
            this.txtMembers.Size = new System.Drawing.Size(392, 163);
            this.txtMembers.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEMBERS";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(560, 78);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGroup.Multiline = true;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(79, 36);
            this.txtGroup.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "TITLE";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 192);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(502, 250);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(684, 339);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMembers);
            this.Controls.Add(this.txtTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtMembers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}