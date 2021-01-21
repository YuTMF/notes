namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addNewFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.listWithFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addNewFile
            // 
            this.addNewFile.BackColor = System.Drawing.Color.GhostWhite;
            this.addNewFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addNewFile.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewFile.ForeColor = System.Drawing.Color.Black;
            this.addNewFile.Location = new System.Drawing.Point(122, 15);
            this.addNewFile.Margin = new System.Windows.Forms.Padding(4);
            this.addNewFile.Name = "addNewFile";
            this.addNewFile.Size = new System.Drawing.Size(86, 86);
            this.addNewFile.TabIndex = 0;
            this.addNewFile.Text = "+";
            this.addNewFile.UseVisualStyleBackColor = false;
            this.addNewFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFile
            // 
            this.openFile.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFile.ForeColor = System.Drawing.Color.Black;
            this.openFile.Location = new System.Drawing.Point(17, 459);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(144, 46);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Открыть";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteFile.ForeColor = System.Drawing.Color.Black;
            this.deleteFile.Location = new System.Drawing.Point(165, 459);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(144, 46);
            this.deleteFile.TabIndex = 3;
            this.deleteFile.Text = "Удалить";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.delet_Click);
            // 
            // listWithFiles
            // 
            this.listWithFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listWithFiles.FormattingEnabled = true;
            this.listWithFiles.ItemHeight = 29;
            this.listWithFiles.Location = new System.Drawing.Point(17, 108);
            this.listWithFiles.Name = "listWithFiles";
            this.listWithFiles.Size = new System.Drawing.Size(292, 323);
            this.listWithFiles.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(325, 517);
            this.Controls.Add(this.listWithFiles);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.addNewFile);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zametki";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewFile;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.ListBox listWithFiles;
    }
}

