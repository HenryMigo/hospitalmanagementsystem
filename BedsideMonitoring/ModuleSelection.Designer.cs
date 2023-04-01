namespace BedsideMonitoring
{
    partial class ModuleSelection
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
            this.lblModuleSelection1 = new System.Windows.Forms.Label();
            this.lblModuleSelection2 = new System.Windows.Forms.Label();
            this.lblModuleSelection3 = new System.Windows.Forms.Label();
            this.lblModuleSelection4 = new System.Windows.Forms.Label();
            this.cmbbModule1 = new System.Windows.Forms.ComboBox();
            this.cmbbModule2 = new System.Windows.Forms.ComboBox();
            this.cmbbModule3 = new System.Windows.Forms.ComboBox();
            this.cmbbModule4 = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblModuleSelection1
            // 
            this.lblModuleSelection1.AutoSize = true;
            this.lblModuleSelection1.Location = new System.Drawing.Point(12, 9);
            this.lblModuleSelection1.Name = "lblModuleSelection1";
            this.lblModuleSelection1.Size = new System.Drawing.Size(51, 13);
            this.lblModuleSelection1.TabIndex = 0;
            this.lblModuleSelection1.Text = "Module 1";
            // 
            // lblModuleSelection2
            // 
            this.lblModuleSelection2.AutoSize = true;
            this.lblModuleSelection2.Location = new System.Drawing.Point(12, 49);
            this.lblModuleSelection2.Name = "lblModuleSelection2";
            this.lblModuleSelection2.Size = new System.Drawing.Size(51, 13);
            this.lblModuleSelection2.TabIndex = 1;
            this.lblModuleSelection2.Text = "Module 2";
            // 
            // lblModuleSelection3
            // 
            this.lblModuleSelection3.AutoSize = true;
            this.lblModuleSelection3.Location = new System.Drawing.Point(12, 89);
            this.lblModuleSelection3.Name = "lblModuleSelection3";
            this.lblModuleSelection3.Size = new System.Drawing.Size(51, 13);
            this.lblModuleSelection3.TabIndex = 2;
            this.lblModuleSelection3.Text = "Module 3";
            // 
            // lblModuleSelection4
            // 
            this.lblModuleSelection4.AutoSize = true;
            this.lblModuleSelection4.Location = new System.Drawing.Point(12, 129);
            this.lblModuleSelection4.Name = "lblModuleSelection4";
            this.lblModuleSelection4.Size = new System.Drawing.Size(51, 13);
            this.lblModuleSelection4.TabIndex = 3;
            this.lblModuleSelection4.Text = "Module 4";
            // 
            // cmbbModule1
            // 
            this.cmbbModule1.FormattingEnabled = true;
            this.cmbbModule1.Location = new System.Drawing.Point(12, 25);
            this.cmbbModule1.Name = "cmbbModule1";
            this.cmbbModule1.Size = new System.Drawing.Size(264, 21);
            this.cmbbModule1.TabIndex = 4;
            this.cmbbModule1.SelectionChangeCommitted += new System.EventHandler(this.CmbbModule_SelectionChangeCommitted);
            // 
            // cmbbModule2
            // 
            this.cmbbModule2.FormattingEnabled = true;
            this.cmbbModule2.Location = new System.Drawing.Point(12, 65);
            this.cmbbModule2.Name = "cmbbModule2";
            this.cmbbModule2.Size = new System.Drawing.Size(264, 21);
            this.cmbbModule2.TabIndex = 5;
            this.cmbbModule2.SelectionChangeCommitted += new System.EventHandler(this.CmbbModule_SelectionChangeCommitted);
            // 
            // cmbbModule3
            // 
            this.cmbbModule3.FormattingEnabled = true;
            this.cmbbModule3.Location = new System.Drawing.Point(12, 105);
            this.cmbbModule3.Name = "cmbbModule3";
            this.cmbbModule3.Size = new System.Drawing.Size(264, 21);
            this.cmbbModule3.TabIndex = 6;
            this.cmbbModule3.SelectionChangeCommitted += new System.EventHandler(this.CmbbModule_SelectionChangeCommitted);
            // 
            // cmbbModule4
            // 
            this.cmbbModule4.FormattingEnabled = true;
            this.cmbbModule4.Location = new System.Drawing.Point(12, 145);
            this.cmbbModule4.Name = "cmbbModule4";
            this.cmbbModule4.Size = new System.Drawing.Size(264, 21);
            this.cmbbModule4.TabIndex = 7;
            this.cmbbModule4.SelectionChangeCommitted += new System.EventHandler(this.CmbbModule_SelectionChangeCommitted);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 214);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(264, 24);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Control;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(46, 169);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Module 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient Name:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(12, 188);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(264, 20);
            this.txtPatientName.TabIndex = 11;
            // 
            // ModuleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 250);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbbModule4);
            this.Controls.Add(this.cmbbModule3);
            this.Controls.Add(this.cmbbModule2);
            this.Controls.Add(this.cmbbModule1);
            this.Controls.Add(this.lblModuleSelection4);
            this.Controls.Add(this.lblModuleSelection3);
            this.Controls.Add(this.lblModuleSelection2);
            this.Controls.Add(this.lblModuleSelection1);
            this.Name = "ModuleSelection";
            this.ShowIcon = false;
            this.Text = "Module Selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModuleSelection_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModuleSelection1;
        private System.Windows.Forms.Label lblModuleSelection2;
        private System.Windows.Forms.Label lblModuleSelection3;
        private System.Windows.Forms.Label lblModuleSelection4;
        private System.Windows.Forms.ComboBox cmbbModule1;
        private System.Windows.Forms.ComboBox cmbbModule2;
        private System.Windows.Forms.ComboBox cmbbModule3;
        private System.Windows.Forms.ComboBox cmbbModule4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientName;
    }
}