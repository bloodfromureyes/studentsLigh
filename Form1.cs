using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
        public partial class Form1 : Form
        {
            public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\students\\students.mdb";
            private OleDbConnection myConnection;
            public Form1()
            {
                InitializeComponent();
                myConnection = new OleDbConnection(connectionString);
                myConnection.Open();
            }

           
        

        private void button1_Click(object sender, EventArgs e)
        {
            students form2 = new students();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            facults form3 = new facults();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groups form4 = new groups();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          

        }
    }
}
