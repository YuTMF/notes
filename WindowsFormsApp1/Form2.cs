using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = Tema.Text;
            
            string docs = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string path = System.IO.Path.Combine(docs, filename + ".txt"); //moi dokumenti, mojno budet dobavit papku specialnuyu
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.Write(Soderjanie.Text);
            Form1.spisok.Rows.Add(Tema.Text, Soderjanie.Text);
            sw.Close();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Tema.MaxLength = 255; //v vinde max kol-vo znakov v imeni fayla 255 simvolov
        }
        public string loadFileTema
        {
            get { return Tema.Text; }
            set { Tema.Text = value; }
        }
        public string loadFileMessage
        {
            get { return Soderjanie.Text; }
            set { Soderjanie.Text = value; }
        }
    }
}
