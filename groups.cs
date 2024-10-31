using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class groups : Form
    {
        public groups()
        {
            InitializeComponent();
        }

        private void groups_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Группы1". При необходимости она может быть перемещена или удалена.
            this.группы1TableAdapter.Fill(this.studentsDataSet.Группы1);

        }
    }
}
