namespace Task2Csharp
{
    using System.Collections.Generic;

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
            this.button_read = new System.Windows.Forms.Button();
            this.pathToFile = new System.Windows.Forms.RichTextBox();
            this.button_write = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(62, 103);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(132, 48);
            this.button_read.TabIndex = 0;
            this.button_read.Text = "read from file";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // pathToFile
            // 
            this.pathToFile.Location = new System.Drawing.Point(62, 36);
            this.pathToFile.Name = "pathToFile";
            this.pathToFile.Size = new System.Drawing.Size(316, 38);
            this.pathToFile.TabIndex = 2;
            this.pathToFile.Text = "";
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(246, 103);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(132, 48);
            this.button_write.TabIndex = 3;
            this.button_write.Text = "write to file";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // table
            // 
            this.table.Location = new System.Drawing.Point(445, 36);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(491, 349);
            this.table.TabIndex = 4;
            this.table.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 518);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.pathToFile);
            this.Controls.Add(this.button_read);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.RichTextBox pathToFile;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.RichTextBox table;
        private List<string> rows = new List<string>();
    }
}

