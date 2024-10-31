namespace WindowsFormsApp1
{
    partial class groups
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
            this.группы1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группы1TableAdapter = new WindowsFormsApp1.studentsDataSetTableAdapters.Группы1TableAdapter();
            this.iDГруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDФакультетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаобученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаокончанияобученияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСтудентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группы1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDГруппыDataGridViewTextBoxColumn,
            this.iDФакультетаDataGridViewTextBoxColumn,
            this.датаначалаобученияDataGridViewTextBoxColumn,
            this.датаокончанияобученияDataGridViewTextBoxColumn,
            this.iDСтудентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группы1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группы1BindingSource
            // 
            this.группы1BindingSource.DataMember = "Группы1";
            this.группы1BindingSource.DataSource = this.studentsDataSet;
            // 
            // группы1TableAdapter
            // 
            this.группы1TableAdapter.ClearBeforeFill = true;
            // 
            // iDГруппыDataGridViewTextBoxColumn
            // 
            this.iDГруппыDataGridViewTextBoxColumn.DataPropertyName = "ID_Группы";
            this.iDГруппыDataGridViewTextBoxColumn.HeaderText = "ID_Группы";
            this.iDГруппыDataGridViewTextBoxColumn.Name = "iDГруппыDataGridViewTextBoxColumn";
            // 
            // iDФакультетаDataGridViewTextBoxColumn
            // 
            this.iDФакультетаDataGridViewTextBoxColumn.DataPropertyName = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.HeaderText = "ID_Факультета";
            this.iDФакультетаDataGridViewTextBoxColumn.Name = "iDФакультетаDataGridViewTextBoxColumn";
            // 
            // датаначалаобученияDataGridViewTextBoxColumn
            // 
            this.датаначалаобученияDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала_обучения";
            this.датаначалаобученияDataGridViewTextBoxColumn.HeaderText = "Дата_начала_обучения";
            this.датаначалаобученияDataGridViewTextBoxColumn.Name = "датаначалаобученияDataGridViewTextBoxColumn";
            // 
            // датаокончанияобученияDataGridViewTextBoxColumn
            // 
            this.датаокончанияобученияDataGridViewTextBoxColumn.DataPropertyName = "Дата_окончания_обучения";
            this.датаокончанияобученияDataGridViewTextBoxColumn.HeaderText = "Дата_окончания_обучения";
            this.датаокончанияобученияDataGridViewTextBoxColumn.Name = "датаокончанияобученияDataGridViewTextBoxColumn";
            // 
            // iDСтудентаDataGridViewTextBoxColumn
            // 
            this.iDСтудентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Студента";
            this.iDСтудентаDataGridViewTextBoxColumn.HeaderText = "ID_Студента";
            this.iDСтудентаDataGridViewTextBoxColumn.Name = "iDСтудентаDataGridViewTextBoxColumn";
            // 
            // groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "groups";
            this.Text = "groups";
            this.Load += new System.EventHandler(this.groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группы1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource группы1BindingSource;
        private studentsDataSetTableAdapters.Группы1TableAdapter группы1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDФакультетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаобученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаокончанияобученияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСтудентаDataGridViewTextBoxColumn;
    }
}