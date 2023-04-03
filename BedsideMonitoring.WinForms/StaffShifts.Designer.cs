namespace BedsideMonitoring.WinForms
{
    partial class StaffShifts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deregisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registeringDerigesteringDatabaseDataSet = new RegisteringDerigesteringDatabaseDataSet();
            this.tableTableAdapter = new RegisteringDerigesteringDatabaseDataSetTableAdapters.TableTableAdapter();
            this.regBtn = new System.Windows.Forms.Button();
            this.staffIDTxt = new System.Windows.Forms.TextBox();
            this.staffIDLbl = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeregister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeringDerigesteringDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.registeredDataGridViewTextBoxColumn,
            this.deregisteredDataGridViewTextBoxColumn,
            this.shiftLengthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // registeredDataGridViewTextBoxColumn
            // 
            this.registeredDataGridViewTextBoxColumn.DataPropertyName = "Registered";
            this.registeredDataGridViewTextBoxColumn.HeaderText = "Registered";
            this.registeredDataGridViewTextBoxColumn.Name = "registeredDataGridViewTextBoxColumn";
            // 
            // deregisteredDataGridViewTextBoxColumn
            // 
            this.deregisteredDataGridViewTextBoxColumn.DataPropertyName = "Deregistered";
            this.deregisteredDataGridViewTextBoxColumn.HeaderText = "Deregistered";
            this.deregisteredDataGridViewTextBoxColumn.Name = "deregisteredDataGridViewTextBoxColumn";
            // 
            // shiftLengthDataGridViewTextBoxColumn
            // 
            this.shiftLengthDataGridViewTextBoxColumn.DataPropertyName = "Shift Length";
            this.shiftLengthDataGridViewTextBoxColumn.HeaderText = "Shift Length";
            this.shiftLengthDataGridViewTextBoxColumn.Name = "shiftLengthDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.registeringDerigesteringDatabaseDataSet;
            // 
            // registeringDerigesteringDatabaseDataSet
            // 
            this.registeringDerigesteringDatabaseDataSet.DataSetName = "RegisteringDerigesteringDatabaseDataSet";
            this.registeringDerigesteringDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(24, 241);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(75, 23);
            this.regBtn.TabIndex = 1;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // staffIDTxt
            // 
            this.staffIDTxt.Location = new System.Drawing.Point(78, 214);
            this.staffIDTxt.Name = "staffIDTxt";
            this.staffIDTxt.Size = new System.Drawing.Size(100, 20);
            this.staffIDTxt.TabIndex = 2;
            // 
            // staffIDLbl
            // 
            this.staffIDLbl.AutoSize = true;
            this.staffIDLbl.Location = new System.Drawing.Point(32, 217);
            this.staffIDLbl.Name = "staffIDLbl";
            this.staffIDLbl.Size = new System.Drawing.Size(43, 13);
            this.staffIDLbl.TabIndex = 3;
            this.staffIDLbl.Text = "StaffID:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(361, 230);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnDeregister
            // 
            this.btnDeregister.Location = new System.Drawing.Point(116, 241);
            this.btnDeregister.Name = "btnDeregister";
            this.btnDeregister.Size = new System.Drawing.Size(75, 23);
            this.btnDeregister.TabIndex = 5;
            this.btnDeregister.Text = "Deregister";
            this.btnDeregister.UseVisualStyleBackColor = true;
            this.btnDeregister.Click += new System.EventHandler(this.BtnDeregister_Click);
            // 
            // StaffShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 265);
            this.Controls.Add(this.btnDeregister);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.staffIDLbl);
            this.Controls.Add(this.staffIDTxt);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StaffShifts";
            this.ShowIcon = false;
            this.Text = "Staff Shifts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffShifts_FormClosing);
            this.Load += new System.EventHandler(this.StaffShifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeringDerigesteringDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RegisteringDerigesteringDatabaseDataSet registeringDerigesteringDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private RegisteringDerigesteringDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registeredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deregisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox staffIDTxt;
        private System.Windows.Forms.Label staffIDLbl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeregister;
    }
}