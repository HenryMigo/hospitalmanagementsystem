namespace BedsideMonitoring
{
    partial class AlarmTimes
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
            this.components = new System.ComponentModel.Container();
            this.registeringDerigesteringDatabaseDataSet = new BedsideMonitoring.RegisteringDerigesteringDatabaseDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new BedsideMonitoring.RegisteringDerigesteringDatabaseDataSetTableAdapters.TableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registeringDerigesteringDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registeringDerigesteringDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeringDerigesteringDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registeringDerigesteringDatabaseDataSet
            // 
            this.registeringDerigesteringDatabaseDataSet.DataSetName = "RegisteringDerigesteringDatabaseDataSet";
            this.registeringDerigesteringDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = this.registeringDerigesteringDatabaseDataSet;
            this.tableBindingSource.Position = 0;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // registeringDerigesteringDatabaseDataSetBindingSource
            // 
            this.registeringDerigesteringDatabaseDataSetBindingSource.DataSource = this.registeringDerigesteringDatabaseDataSet;
            this.registeringDerigesteringDatabaseDataSetBindingSource.Position = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(295, 241);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AlarmTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 276);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AlarmTimes";
            this.ShowIcon = false;
            this.Text = "Alarm Times";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlarmTimes_FormClosing);
            this.Load += new System.EventHandler(this.AlarmTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registeringDerigesteringDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeringDerigesteringDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RegisteringDerigesteringDatabaseDataSet registeringDerigesteringDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private RegisteringDerigesteringDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource registeringDerigesteringDatabaseDataSetBindingSource;
        private System.Windows.Forms.Button btnBack;
    }
}