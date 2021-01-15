using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        static public DataTable spisok;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newfile = new Form2();
            newfile.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            spisok = new DataTable();
            spisok.Columns.Add("Тема", typeof(String));

            dataGridView1.DataSource = spisok;
        }

       
    }
}
