namespace lab1RWP
{
    partial class MainForm
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
            this.button_CreatePeople = new System.Windows.Forms.Button();
            this.button_EditPeople = new System.Windows.Forms.Button();
            this.button_DeletePeople = new System.Windows.Forms.Button();
            this.button_LoadtoFile = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_CreatePage = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_CreatePeople
            // 
            this.button_CreatePeople.Location = new System.Drawing.Point(468, 37);
            this.button_CreatePeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CreatePeople.Name = "button_CreatePeople";
            this.button_CreatePeople.Size = new System.Drawing.Size(249, 48);
            this.button_CreatePeople.TabIndex = 1;
            this.button_CreatePeople.Text = "Создать новую запись";
            this.button_CreatePeople.UseVisualStyleBackColor = true;
            this.button_CreatePeople.Click += new System.EventHandler(this.button_CreatePeople_Click);
            // 
            // button_EditPeople
            // 
            this.button_EditPeople.Location = new System.Drawing.Point(468, 115);
            this.button_EditPeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_EditPeople.Name = "button_EditPeople";
            this.button_EditPeople.Size = new System.Drawing.Size(249, 53);
            this.button_EditPeople.TabIndex = 2;
            this.button_EditPeople.Text = "Изменить выбранную";
            this.button_EditPeople.UseVisualStyleBackColor = true;
            this.button_EditPeople.Click += new System.EventHandler(this.button_EditPeople_Click);
            // 
            // button_DeletePeople
            // 
            this.button_DeletePeople.Location = new System.Drawing.Point(468, 200);
            this.button_DeletePeople.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DeletePeople.Name = "button_DeletePeople";
            this.button_DeletePeople.Size = new System.Drawing.Size(249, 54);
            this.button_DeletePeople.TabIndex = 3;
            this.button_DeletePeople.Text = "Удалить выбранную";
            this.button_DeletePeople.UseVisualStyleBackColor = true;
            this.button_DeletePeople.Click += new System.EventHandler(this.button_DeletePeople_Click);
            // 
            // button_LoadtoFile
            // 
            this.button_LoadtoFile.Location = new System.Drawing.Point(617, 290);
            this.button_LoadtoFile.Name = "button_LoadtoFile";
            this.button_LoadtoFile.Size = new System.Drawing.Size(100, 60);
            this.button_LoadtoFile.TabIndex = 4;
            this.button_LoadtoFile.Text = "Сохранить";
            this.button_LoadtoFile.UseVisualStyleBackColor = true;
            this.button_LoadtoFile.Click += new System.EventHandler(this.button_LoadtoFile_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 338);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Page1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Page2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_CreatePage
            // 
            this.button_CreatePage.Location = new System.Drawing.Point(468, 290);
            this.button_CreatePage.Name = "button_CreatePage";
            this.button_CreatePage.Size = new System.Drawing.Size(126, 60);
            this.button_CreatePage.TabIndex = 6;
            this.button_CreatePage.Text = "Добавить новую вкладку";
            this.button_CreatePage.UseVisualStyleBackColor = true;
            this.button_CreatePage.Click += new System.EventHandler(this.button_CreatePage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 374);
            this.Controls.Add(this.button_CreatePage);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_LoadtoFile);
            this.Controls.Add(this.button_DeletePeople);
            this.Controls.Add(this.button_EditPeople);
            this.Controls.Add(this.button_CreatePeople);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_CreatePeople;
        private System.Windows.Forms.Button button_EditPeople;
        private System.Windows.Forms.Button button_DeletePeople;
        private System.Windows.Forms.Button button_LoadtoFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_CreatePage;
    }
}

