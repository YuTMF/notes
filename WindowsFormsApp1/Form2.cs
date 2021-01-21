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
        /* Кнопка сохранения файла
        На данный момент, сохранение файла, тема которого совпадает с уже существующим файлом,
        последний просто перезаписывается*/
        private void button1_Click(object sender, EventArgs e)
        {
            string filename = themeOfMessage.Text;
            
            
            string path = Path.Combine(Form1.pathWithFiles, filename + ".txt"); //moi dokumenti, mojno budet dobavit papku specialnuyu
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.Write(contentOfMessage.Text);
            sw.Close();
            Form1 mainForm = this.Owner as Form1;
            if (mainForm != null)
            {
                mainForm.RefreshList();
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//Кнопка закрытия(Ну или отмены)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            themeOfMessage.MaxLength = 255; //В ОС Windwos Максимальное колво знаков в имени файла - 255
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
