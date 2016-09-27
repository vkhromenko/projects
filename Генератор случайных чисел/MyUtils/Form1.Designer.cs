namespace MyUtils
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btBuffer = new System.Windows.Forms.Button();
            this.tbListPass = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.lbLength = new System.Windows.Forms.Label();
            this.nudPassLength = new System.Windows.Forms.NumericUpDown();
            this.cblProp = new System.Windows.Forms.CheckedListBox();
            this.tcNote = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
            this.tcNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btBuffer);
            this.tabPage2.Controls.Add(this.tbListPass);
            this.tabPage2.Controls.Add(this.btGenerate);
            this.tabPage2.Controls.Add(this.lbLength);
            this.tabPage2.Controls.Add(this.nudPassLength);
            this.tabPage2.Controls.Add(this.cblProp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 290);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btBuffer
            // 
            this.btBuffer.Location = new System.Drawing.Point(223, 36);
            this.btBuffer.Name = "btBuffer";
            this.btBuffer.Size = new System.Drawing.Size(82, 23);
            this.btBuffer.TabIndex = 5;
            this.btBuffer.Text = "В буфер";
            this.btBuffer.UseVisualStyleBackColor = true;
            this.btBuffer.Click += new System.EventHandler(this.btBuffer_Click);
            // 
            // tbListPass
            // 
            this.tbListPass.Location = new System.Drawing.Point(9, 104);
            this.tbListPass.Multiline = true;
            this.tbListPass.Name = "tbListPass";
            this.tbListPass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbListPass.Size = new System.Drawing.Size(296, 178);
            this.tbListPass.TabIndex = 4;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(223, 6);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(82, 23);
            this.btGenerate.TabIndex = 3;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // lbLength
            // 
            this.lbLength.AutoSize = true;
            this.lbLength.Location = new System.Drawing.Point(6, 80);
            this.lbLength.Name = "lbLength";
            this.lbLength.Size = new System.Drawing.Size(79, 13);
            this.lbLength.TabIndex = 2;
            this.lbLength.Text = "Длина пароля";
            // 
            // nudPassLength
            // 
            this.nudPassLength.Location = new System.Drawing.Point(90, 78);
            this.nudPassLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPassLength.Name = "nudPassLength";
            this.nudPassLength.Size = new System.Drawing.Size(127, 20);
            this.nudPassLength.TabIndex = 1;
            this.nudPassLength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cblProp
            // 
            this.cblProp.CheckOnClick = true;
            this.cblProp.FormattingEnabled = true;
            this.cblProp.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы"});
            this.cblProp.Location = new System.Drawing.Point(7, 7);
            this.cblProp.Name = "cblProp";
            this.cblProp.Size = new System.Drawing.Size(210, 64);
            this.cblProp.TabIndex = 0;
            // 
            // tcNote
            // 
            this.tcNote.Controls.Add(this.tabPage2);
            this.tcNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcNote.Location = new System.Drawing.Point(0, 24);
            this.tcNote.Name = "tcNote";
            this.tcNote.SelectedIndex = 0;
            this.tcNote.Size = new System.Drawing.Size(321, 316);
            this.tcNote.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 340);
            this.Controls.Add(this.tcNote);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(337, 379);
            this.MinimumSize = new System.Drawing.Size(337, 379);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
            this.tcNote.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btBuffer;
        private System.Windows.Forms.TextBox tbListPass;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label lbLength;
        private System.Windows.Forms.NumericUpDown nudPassLength;
        private System.Windows.Forms.CheckedListBox cblProp;
        private System.Windows.Forms.TabControl tcNote;
    }
}

