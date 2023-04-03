namespace BedsideMonitoring.WinForms
{
    partial class BedsideMonitor
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
            this.btnSetModuleLimits = new System.Windows.Forms.Button();
            this.lblBed = new System.Windows.Forms.Label();
            this.btn_mute = new System.Windows.Forms.Button();
            this.bedsideModule4 = new BedsideModule();
            this.bedsideModule3 = new BedsideModule();
            this.bedsideModule2 = new BedsideModule();
            this.bedsideModule1 = new BedsideModule();
            this.SuspendLayout();
            // 
            // btnSetModuleLimits
            // 
            this.btnSetModuleLimits.Location = new System.Drawing.Point(267, 437);
            this.btnSetModuleLimits.Name = "btnSetModuleLimits";
            this.btnSetModuleLimits.Size = new System.Drawing.Size(75, 23);
            this.btnSetModuleLimits.TabIndex = 4;
            this.btnSetModuleLimits.Text = "&Set Limits";
            this.btnSetModuleLimits.UseVisualStyleBackColor = true;
            this.btnSetModuleLimits.Click += new System.EventHandler(this.BtnSetModuleLimits_Click);
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(13, 446);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(79, 29);
            this.lblBed.TabIndex = 9;
            this.lblBed.Text = "label1";
            // 
            // btn_mute
            // 
            this.btn_mute.Location = new System.Drawing.Point(98, 437);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(69, 23);
            this.btn_mute.TabIndex = 10;
            this.btn_mute.Text = "Mute Bitches";
            this.btn_mute.UseVisualStyleBackColor = true;
            this.btn_mute.Click += new System.EventHandler(this.Btn_mute_Click);
            // 
            // bedsideModule4
            // 
            this.bedsideModule4.Location = new System.Drawing.Point(12, 333);
            this.bedsideModule4.MaximumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule4.MinimumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule4.Name = "bedsideModule4";
            this.bedsideModule4.Size = new System.Drawing.Size(330, 100);
            this.bedsideModule4.TabIndex = 8;
            // 
            // bedsideModule3
            // 
            this.bedsideModule3.Location = new System.Drawing.Point(12, 226);
            this.bedsideModule3.MaximumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule3.MinimumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule3.Name = "bedsideModule3";
            this.bedsideModule3.Size = new System.Drawing.Size(330, 100);
            this.bedsideModule3.TabIndex = 7;
            // 
            // bedsideModule2
            // 
            this.bedsideModule2.Location = new System.Drawing.Point(13, 119);
            this.bedsideModule2.MaximumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule2.MinimumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule2.Name = "bedsideModule2";
            this.bedsideModule2.Size = new System.Drawing.Size(330, 100);
            this.bedsideModule2.TabIndex = 6;
            // 
            // bedsideModule1
            // 
            this.bedsideModule1.Location = new System.Drawing.Point(12, 12);
            this.bedsideModule1.MaximumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule1.MinimumSize = new System.Drawing.Size(330, 100);
            this.bedsideModule1.Name = "bedsideModule1";
            this.bedsideModule1.Size = new System.Drawing.Size(330, 100);
            this.bedsideModule1.TabIndex = 5;
            // 
            // BedsideMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 475);
            this.Controls.Add(this.btn_mute);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.bedsideModule4);
            this.Controls.Add(this.bedsideModule3);
            this.Controls.Add(this.bedsideModule2);
            this.Controls.Add(this.bedsideModule1);
            this.Controls.Add(this.btnSetModuleLimits);
            this.MaximumSize = new System.Drawing.Size(370, 513);
            this.MinimumSize = new System.Drawing.Size(370, 513);
            this.Name = "BedsideMonitor";
            this.ShowIcon = false;
            this.Text = "Bedside Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BedsideMonitor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button btnSetModuleLimits;//
        private BedsideModule bedsideModule1;
        private BedsideModule bedsideModule2;
        private BedsideModule bedsideModule3;
        private BedsideModule bedsideModule4;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Button btn_mute;
    }
}