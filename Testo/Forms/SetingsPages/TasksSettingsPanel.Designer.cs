namespace Testo.Forms.SetingsPages
{
    partial class TasksSettingsPanel
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DelSub = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.EditSub = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.NewSub = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SubjectsList = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ChildViever = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 0);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование предметов";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 538);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 155);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(604, 383);
            this.panel6.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.DelSub);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.EditSub);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.NewSub);
            this.panel8.Location = new System.Drawing.Point(451, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(141, 171);
            this.panel8.TabIndex = 1;
            // 
            // DelSub
            // 
            this.DelSub.BackColor = System.Drawing.Color.Crimson;
            this.DelSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.DelSub.FlatAppearance.BorderSize = 0;
            this.DelSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelSub.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DelSub.ForeColor = System.Drawing.Color.White;
            this.DelSub.Location = new System.Drawing.Point(0, 135);
            this.DelSub.Name = "DelSub";
            this.DelSub.Size = new System.Drawing.Size(141, 35);
            this.DelSub.TabIndex = 1;
            this.DelSub.Text = "Удалить";
            this.DelSub.UseVisualStyleBackColor = false;
            this.DelSub.EnabledChanged += new System.EventHandler(this.DelSub_EnabledChanged);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 125);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(141, 10);
            this.panel14.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Экспортировать";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 80);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(141, 10);
            this.panel10.TabIndex = 4;
            // 
            // EditSub
            // 
            this.EditSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.EditSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditSub.FlatAppearance.BorderSize = 0;
            this.EditSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSub.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EditSub.ForeColor = System.Drawing.Color.White;
            this.EditSub.Location = new System.Drawing.Point(0, 45);
            this.EditSub.Name = "EditSub";
            this.EditSub.Size = new System.Drawing.Size(141, 35);
            this.EditSub.TabIndex = 0;
            this.EditSub.Text = "Редактировать";
            this.EditSub.UseVisualStyleBackColor = false;
            this.EditSub.EnabledChanged += new System.EventHandler(this.EditSub_EnabledChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 35);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(141, 10);
            this.panel9.TabIndex = 3;
            // 
            // NewSub
            // 
            this.NewSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.NewSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewSub.FlatAppearance.BorderSize = 0;
            this.NewSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewSub.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NewSub.ForeColor = System.Drawing.Color.White;
            this.NewSub.Location = new System.Drawing.Point(0, 0);
            this.NewSub.Name = "NewSub";
            this.NewSub.Size = new System.Drawing.Size(141, 35);
            this.NewSub.TabIndex = 2;
            this.NewSub.Text = "Новый предмет";
            this.NewSub.UseVisualStyleBackColor = false;
            this.NewSub.Click += new System.EventHandler(this.NewSub_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.SubjectsList);
            this.panel7.Location = new System.Drawing.Point(34, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(411, 356);
            this.panel7.TabIndex = 0;
            // 
            // SubjectsList
            // 
            this.SubjectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectsList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubjectsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectsList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SubjectsList.FormattingEnabled = true;
            this.SubjectsList.ItemHeight = 21;
            this.SubjectsList.Location = new System.Drawing.Point(0, 0);
            this.SubjectsList.Name = "SubjectsList";
            this.SubjectsList.Size = new System.Drawing.Size(411, 356);
            this.SubjectsList.TabIndex = 0;
            this.SubjectsList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.SubjectsList_DrawItem);
            this.SubjectsList.SelectedIndexChanged += new System.EventHandler(this.SubjectsList_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 41);
            this.panel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(31, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(505, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Это список всех предметов которые могут пройти студенты. Чем больше заданий - тем" +
    " чаще\r\nстуденты посещают компьютерный кабинет\r\n";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 41);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Список предметов";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 73);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "Редактирование предметов";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button1);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 538);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(604, 166);
            this.panel11.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Импортировать задание";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 41);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(604, 41);
            this.panel12.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(31, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(526, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "С помощью данной опции вы можете добавить уже существующий файл предмета с задани" +
    "ями.\r\nПросто нажмите кнопку и выберите файл содержащий задания.\r\n";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label6);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(604, 41);
            this.panel13.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Импорт";
            // 
            // ChildViever
            // 
            this.ChildViever.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChildViever.BackColor = System.Drawing.Color.Transparent;
            this.ChildViever.Location = new System.Drawing.Point(0, 0);
            this.ChildViever.Name = "ChildViever";
            this.ChildViever.Size = new System.Drawing.Size(604, 704);
            this.ChildViever.TabIndex = 2;
            this.ChildViever.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildViever_Paint);
            // 
            // TasksSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChildViever);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Name = "TasksSettingsPanel";
            this.Size = new System.Drawing.Size(604, 704);
            this.Load += new System.EventHandler(this.TasksSettingsPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox SubjectsList;
        private System.Windows.Forms.Button NewSub;
        private System.Windows.Forms.Button DelSub;
        private System.Windows.Forms.Button EditSub;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel ChildViever;
    }
}
