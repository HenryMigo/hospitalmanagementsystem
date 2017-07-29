namespace BedsideMonitoring
{
    partial class RegisterConsultant
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
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblConName = new System.Windows.Forms.Label();
            this.lblConEmail = new System.Windows.Forms.Label();
            this.tbConName = new System.Windows.Forms.TextBox();
            this.tbConEmail = new System.Windows.Forms.TextBox();
            this.btnRegConClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(91, 9);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(200, 13);
            this.lblHelp.TabIndex = 0;
            this.lblHelp.Text = "Please Enter Consultant Name and Email";
            // 
            // lblConName
            // 
            this.lblConName.AutoSize = true;
            this.lblConName.Location = new System.Drawing.Point(31, 26);
            this.lblConName.Name = "lblConName";
            this.lblConName.Size = new System.Drawing.Size(54, 13);
            this.lblConName.TabIndex = 1;
            this.lblConName.Text = "Full Name";
            // 
            // lblConEmail
            // 
            this.lblConEmail.AutoSize = true;
            this.lblConEmail.Location = new System.Drawing.Point(12, 50);
            this.lblConEmail.Name = "lblConEmail";
            this.lblConEmail.Size = new System.Drawing.Size(73, 13);
            this.lblConEmail.TabIndex = 2;
            this.lblConEmail.Text = "Email Address";
            // 
            // tbConName
            // 
            this.tbConName.Location = new System.Drawing.Point(91, 26);
            this.tbConName.Name = "tbConName";
            this.tbConName.Size = new System.Drawing.Size(265, 20);
            this.tbConName.TabIndex = 3;
            // 
            // tbConEmail
            // 
            this.tbConEmail.Location = new System.Drawing.Point(91, 52);
            this.tbConEmail.Name = "tbConEmail";
            this.tbConEmail.Size = new System.Drawing.Size(265, 20);
            this.tbConEmail.TabIndex = 4;
            // 
            // btnRegConClose
            // 
            this.btnRegConClose.Location = new System.Drawing.Point(241, 78);
            this.btnRegConClose.Name = "btnRegConClose";
            this.btnRegConClose.Size = new System.Drawing.Size(115, 23);
            this.btnRegConClose.TabIndex = 5;
            this.btnRegConClose.Text = "Register Consultant";
            this.btnRegConClose.UseVisualStyleBackColor = true;
            this.btnRegConClose.Click += new System.EventHandler(this.btnRegConClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 77);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RegisterConsultant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 119);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegConClose);
            this.Controls.Add(this.tbConEmail);
            this.Controls.Add(this.tbConName);
            this.Controls.Add(this.lblConEmail);
            this.Controls.Add(this.lblConName);
            this.Controls.Add(this.lblHelp);
            this.Name = "RegisterConsultant";
            this.ShowIcon = false;
            this.Text = "Register Consultant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterConsultant_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblConName;
        private System.Windows.Forms.Label lblConEmail;
        private System.Windows.Forms.TextBox tbConName;
        private System.Windows.Forms.TextBox tbConEmail;
        private System.Windows.Forms.Button btnRegConClose;
        private System.Windows.Forms.Button btnBack;
    }
}