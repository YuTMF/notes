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
        static public string pathWithFiles = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FolderWithNotes\\"); //Полный путь до папки C:/Users/username/MyDocuments/FolderWithNotes/
        public void RefreshList() //Функция обновления листа с файлами
        {
            listWithFiles.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(pathWithFiles);
            FileInfo[] files = dir.GetFiles("*.txt");
            foreach (FileInfo fi in files)
            {
                var stringFile = fi.ToString();
                var fileWithoutTXT = stringFile.Remove(stringFile.Length - 4, 4);
                listWithFiles.Items.Add(fileWithoutTXT);
            }
        }
        public Form1()
        {
            InitializeComponent();
            bool existingDirectory = Directory.Exists(pathWithFiles);
            if (!existingDirectory) Directory.CreateDirectory(pathWithFiles);
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка нового файла
        {
            Form2 newfile = new Form2();
            newfile.Owner = this;
            newfile.ShowDialog();
        }

        public void Form1_Load(object sender, EventArgs e) 
        {
            RefreshList();
        }

        private void openfile_Click(object sender, EventArgs e) //Кнопка загрузки файла
        {
            Form2 loaded = new Form2();
            loaded.Owner = this;
            try
            {
                string nameOfFile = Path.GetFileNameWithoutExtension(pathWithFiles + listWithFiles.SelectedItem.ToString());
                loaded.loadFileTema = nameOfFile;
                loaded.loadFileMessage = File.ReadAllText(Path.Combine(pathWithFiles, listWithFiles.SelectedItem.ToString()) + ".txt");
                loaded.ShowDialog();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите файл!");
            } 
        }

        private void delet_Click(object sender, EventArgs e) //Кнопка удаления файла
        {
            try
            {
                string directoryOfFile = Path.Combine(pathWithFiles, listWithFiles.SelectedItem.ToString() + ".txt");

                File.Delete(directoryOfFile);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите файл!");
            }

            listWithFiles.Items.Clear();
            RefreshList();
        }
    }
}
