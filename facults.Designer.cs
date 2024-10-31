namespace WindowsFormsApp1
{
    partial class facults
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
            this.studentsDataSet = new WindowsFormsApp1.studentsDataSet();
            this.факультеты1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.факультеты1TableAdapter = new WindowsFormsApp1.studentsDataSetTableAdapters.Факультеты1TableAdapter();
            this.iDФакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиефакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествопреподавателейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультеты1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDФакультетаDataGridViewTextBoxColumn,
            this.названиефакультетаDataGridViewTextBoxColumn,
            this.числоместDataGridViewTextBoxColumn,
            this.количествопреподавателейDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.факультеты1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 438);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // факультеты1BindingSource
            // 
            this.факультеты1BindingSource.DataMember = "Факультеты1";
            this.факультеты1BindingSource.DataSource = this.studentsDataSet;
            // 
            // факультеты1TableAdapter
            // 
            this.факультеты1TableAdapter.ClearBeforeFill = true;
            // 
            // iDФакультетаDataGridViewTextBoxColumn
            // 
            this.iDФакультетаDataGridViewTextBoxColumn.DataPropertyName = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.HeaderText = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.Name = "iDФакультетаDataGridViewTextBoxColumn";
            // 
            // названиефакультетаDataGridViewTextBoxColumn
            // 
            this.названиефакультетаDataGridViewTextBoxColumn.DataPropertyName = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.HeaderText = "Название_факультета";
            this.названиефакультетаDataGridViewTextBoxColumn.Name = "названиефакультетаDataGridViewTextBoxColumn";
            // 
            // числоместDataGridViewTextBoxColumn
            // 
            this.числоместDataGridViewTextBoxColumn.DataPropertyName = "Число_мест";
            this.числоместDataGridViewTextBoxColumn.HeaderText = "Число_мест";
            this.числоместDataGridViewTextBoxColumn.Name = "числоместDataGridViewTextBoxColumn";
            // 
            // количествопреподавателейDataGridViewTextBoxColumn
            // 
            this.количествопреподавателейDataGridViewTextBoxColumn.DataPropertyName = "Количество_преподавателей";
            this.количествопреподавателейDataGridViewTextBoxColumn.HeaderText = "Количество_преподавателей";
            this.количествопреподавателейDataGridViewTextBoxColumn.Name = "количествопреподавателейDataGridViewTextBoxColumn";
            // 
            // facults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "facults";
            this.Text = "facults";
            this.Load += new System.EventHandler(this.facults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.факультеты1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource факультеты1BindingSource;
        private studentsDataSetTableAdapters.Факультеты1TableAdapter факультеты1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиефакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествопреподавателейDataGridViewTextBoxColumn;
    }
}