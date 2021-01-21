using System;
using System.IO;
using System.Text;
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
            string filename = themeOfMessage.Text;
            
            
            string path = Path.Combine(Form1.pathWithFiles, filename + ".txt"); //moi dokumenti, mojno budet dobavit papku specialnuyu
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.Write(contentOfMessage.Text);
            sw.Close();
            Close();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            themeOfMessage.MaxLength = 255; //v vinde max kol-vo znakov v imeni fayla 255 simvolov
        }
        public string loadFileTema
        {
            get { return themeOfMessage.Text; }
            set { themeOfMessage.Text = value; }
        }
        public string loadFileMessage
        {
            get { return contentOfMessage.Text; }
            set { contentOfMessage.Text = value; }
        }

        
    }
}
