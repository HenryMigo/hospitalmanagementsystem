namespace BedsideMonitoring
{
    partial class BedsideModule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPatientVital = new System.Windows.Forms.Label();
            this.lblBedsideModule = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientVital
            // 
            this.lblPatientVital.AutoSize = true;
            this.lblPatientVital.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblPatientVital.Location = new System.Drawing.Point(3, 29);
            this.lblPatientVital.Name = "lblPatientVital";
            this.lblPatientVital.Size = new System.Drawing.Size(98, 46);
            this.lblPatientVital.TabIndex = 0;
            this.lblPatientVital.Text = "Vital";
            // 
            // lblBedsideModule
            // 
            this.lblBedsideModule.AutoSize = true;
            this.lblBedsideModule.Location = new System.Drawing.Point(3, 0);
            this.lblBedsideModule.Name = "lblBedsideModule";
            this.lblBedsideModule.Size = new System.Drawing.Size(42, 13);
            this.lblBedsideModule.TabIndex = 1;
            this.lblBedsideModule.Text = "Module";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown1.Location = new System.Drawing.Point(272, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 30);
            this.numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown2.Location = new System.Drawing.Point(272, 54);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 30);
            this.numericUpDown2.TabIndex = 3;
            // 
            // BedsideModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblBedsideModule);
            this.Controls.Add(this.lblPatientVital);
            this.MaximumSize = new System.Drawing.Size(330, 100);
            this.MinimumSize = new System.Drawing.Size(330, 100);
            this.Name = "BedsideModule";
            this.Size = new System.Drawing.Size(330, 100);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPatientVital;
        public System.Windows.Forms.Label lblBedsideModule;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}
