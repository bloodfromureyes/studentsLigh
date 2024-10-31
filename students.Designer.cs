namespace WindowsFormsApp1
{
    partial class students
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
            this.студенты1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.студенты1TableAdapter = new WindowsFormsApp1.studentsDataSetTableAdapters.Студенты1TableAdapter();
            this.iDСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.семейноеположениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммастипендииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годзачисленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.студенты1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСтудентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.курсDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.семейноеположениеDataGridViewTextBoxColumn,
            this.суммастипендииDataGridViewTextBoxColumn,
            this.годзачисленияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.студенты1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-40, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // студенты1BindingSource
            // 
            this.студенты1BindingSource.DataMember = "Студенты1";
            this.студенты1BindingSource.DataSource = this.studentsDataSet;
            // 
            // студенты1TableAdapter
            // 
            this.студенты1TableAdapter.ClearBeforeFill = true;
            // 
            // iDСтудентаDataGridViewTextBoxColumn
            // 
            this.iDСтудентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Студента";
            this.iDСтудентаDataGridViewTextBoxColumn.HeaderText = "ID_Студента";
            this.iDСтудентаDataGridViewTextBoxColumn.Name = "iDСтудентаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // курсDataGridViewTextBoxColumn
            // 
            this.курсDataGridViewTextBoxColumn.DataPropertyName = "Курс";
            this.курсDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.курсDataGridViewTextBoxColumn.Name = "курсDataGridViewTextBoxColumn";
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // семейноеположениеDataGridViewTextBoxColumn
            // 
            this.семейноеположениеDataGridViewTextBoxColumn.DataPropertyName = "Семейное_положение";
            this.семейноеположениеDataGridViewTextBoxColumn.HeaderText = "Семейное_положение";
            this.семейноеположениеDataGridViewTextBoxColumn.Name = "семейноеположениеDataGridViewTextBoxColumn";
            // 
            // суммастипендииDataGridViewTextBoxColumn
            // 
            this.суммастипендииDataGridViewTextBoxColumn.DataPropertyName = "Сумма_стипендии";
            this.суммастипендииDataGridViewTextBoxColumn.HeaderText = "Сумма_стипендии";
            this.суммастипендииDataGridViewTextBoxColumn.Name = "суммастипендииDataGridViewTextBoxColumn";
            // 
            // годзачисленияDataGridViewTextBoxColumn
            // 
            this.годзачисленияDataGridViewTextBoxColumn.DataPropertyName = "Год_зачисления";
            this.годзачисленияDataGridViewTextBoxColumn.HeaderText = "Год_зачисления";
            this.годзачисленияDataGridViewTextBoxColumn.Name = "годзачисленияDataGridViewTextBoxColumn";
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "students";
            this.Text = "students";
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.студенты1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource студенты1BindingSource;
        private studentsDataSetTableAdapters.Студенты1TableAdapter студенты1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСтудентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn семейноеположениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммастипендииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годзачисленияDataGridViewTextBoxColumn;
    }
}