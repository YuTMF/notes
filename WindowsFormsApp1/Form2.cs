using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 backToForm = new Form1();
        static public string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = Tema.Text;
            
            
            string path = System.IO.Path.Combine(docs, filename + ".txt"); //moi dokumenti, mojno budet dobavit papku specialnuyu
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.Write(Soderjanie.Text);
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
