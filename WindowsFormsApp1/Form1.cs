using System;
using System.Data;
using System.IO;
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
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
            }
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            Form2 loaded = new Form2();
            loaded.Owner = this;
            try
            {
                string nameOfFile = Path.GetFileNameWithoutExtension(Form2.docs + listBox1.SelectedItem.ToString());
                loaded.loadFileTema = nameOfFile;
                loaded.loadFileMessage = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), listBox1.SelectedItem.ToString()));
                loaded.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите файл!");
            }
            
        }

        private void delet_Click(object sender, EventArgs e)
        {
            try
            {
                string dirc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), listBox1.SelectedItem.ToString());

                File.Delete(dirc);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите файл!");
            }

            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString()); 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelected = listBox1.SelectedItem.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
            }
        }
    }
}
