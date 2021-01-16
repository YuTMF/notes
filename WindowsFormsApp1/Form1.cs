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
        static public string currentTheme;
        static public string currentMessage;
        
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

        public void Form1_Load(object sender, EventArgs e)
        {
            spisok = new DataTable();
            spisok.Columns.Add("Список файлов", typeof(String));
            spisok.Columns.Add("Сообщение", typeof(String));
            dataGridView1.DataSource = spisok;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].Width = 216;
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            try
            {
                int indexOfCurrent = dataGridView1.CurrentCell.RowIndex;

                if (indexOfCurrent > -1)
                {
                    currentTheme = spisok.Rows[indexOfCurrent].ItemArray[0].ToString();
                    currentMessage = spisok.Rows[indexOfCurrent].ItemArray[1].ToString();
                }
            } catch(System.NullReferenceException)
            {
                MessageBox.Show("Не выбран файл");
            }
            Form2 loaded = new Form2();
            loaded.Owner = this;
            loaded.loadFileTema = currentTheme;
            loaded.loadFileMessage = currentMessage;
            loaded.ShowDialog();
        }
    }
}
