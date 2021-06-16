namespace Testo.Forms.SetingsPages
{
    partial class EditSub
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.AllowReamakeChckBox = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.TasksAmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.AmountDescription = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LimitTasksChckBox = new MetroFramework.Controls.MetroCheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TimeUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeDescription = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UseTimeChckBox = new MetroFramework.Controls.MetroCheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.RandomTasksChckBox = new MetroFramework.Controls.MetroCheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowRightChckBox = new MetroFramework.Controls.MetroCheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksAmountUpDown)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeUpDown)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(49, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(175, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Настройки предмета";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.NameTxtBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 94);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(52, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "То как предмет будет отображаться при выборе предметов.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название предмета";
            // 
            // NameTxtBox
            // 
            // 
            // 
            // 
            this.NameTxtBox.CustomButton.Image = null;
            this.NameTxtBox.CustomButton.Location = new System.Drawing.Point(448, 1);
            this.NameTxtBox.CustomButton.Name = "";
            this.NameTxtBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.NameTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTxtBox.CustomButton.TabIndex = 1;
            this.NameTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTxtBox.CustomButton.UseSelectable = true;
            this.NameTxtBox.CustomButton.Visible = false;
            this.NameTxtBox.Lines = new string[0];
            this.NameTxtBox.Location = new System.Drawing.Point(55, 52);
            this.NameTxtBox.MaxLength = 32767;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PasswordChar = '\0';
            this.NameTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTxtBox.SelectedText = "";
            this.NameTxtBox.SelectionLength = 0;
            this.NameTxtBox.SelectionStart = 0;
            this.NameTxtBox.ShortcutsEnabled = true;
            this.NameTxtBox.Size = new System.Drawing.Size(476, 29);
            this.NameTxtBox.TabIndex = 0;
            this.NameTxtBox.UseSelectable = true;
            this.NameTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AllowReamakeChckBox
            // 
            this.AllowReamakeChckBox.AutoSize = true;
            this.AllowReamakeChckBox.Location = new System.Drawing.Point(34, 12);
            this.AllowReamakeChckBox.Name = "AllowReamakeChckBox";
            this.AllowReamakeChckBox.Size = new System.Drawing.Size(143, 15);
            this.AllowReamakeChckBox.TabIndex = 0;
            this.AllowReamakeChckBox.Text = "Разрешить пересдачу";
            this.AllowReamakeChckBox.UseSelectable = true;
            this.AllowReamakeChckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(52, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Разрешить студентам проходить тестирование по данному предмету несколько раз";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 450);
            this.panel3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.TasksAmountUpDown);
            this.panel8.Controls.Add(this.AmountDescription);
            this.panel8.Controls.Add(this.AmountLabel);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.LimitTasksChckBox);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 324);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(604, 125);
            this.panel8.TabIndex = 8;
            // 
            // TasksAmountUpDown
            // 
            this.TasksAmountUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasksAmountUpDown.Location = new System.Drawing.Point(455, 70);
            this.TasksAmountUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TasksAmountUpDown.Name = "TasksAmountUpDown";
            this.TasksAmountUpDown.Size = new System.Drawing.Size(76, 29);
            this.TasksAmountUpDown.TabIndex = 5;
            // 
            // AmountDescription
            // 
            this.AmountDescription.AutoSize = true;
            this.AmountDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.AmountDescription.Location = new System.Drawing.Point(52, 89);
            this.AmountDescription.Name = "AmountDescription";
            this.AmountDescription.Size = new System.Drawing.Size(52, 13);
            this.AmountDescription.TabIndex = 4;
            this.AmountDescription.Text = "Заданий";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(51, 68);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(93, 21);
            this.AmountLabel.TabIndex = 3;
            this.AmountLabel.Text = "Количество";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label12.Location = new System.Drawing.Point(52, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(439, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Из всех заданий предмета будет выбранно только определенное число заданий\r\nна кот" +
    "орые студент должен ответить.";
            // 
            // LimitTasksChckBox
            // 
            this.LimitTasksChckBox.AutoSize = true;
            this.LimitTasksChckBox.Location = new System.Drawing.Point(34, 12);
            this.LimitTasksChckBox.Name = "LimitTasksChckBox";
            this.LimitTasksChckBox.Size = new System.Drawing.Size(203, 30);
            this.LimitTasksChckBox.TabIndex = 0;
            this.LimitTasksChckBox.Text = "Ограничить количество заданий\r\n";
            this.LimitTasksChckBox.UseSelectable = true;
            this.LimitTasksChckBox.CheckedChanged += new System.EventHandler(this.LimitTasksChckBox_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TimeUpDown);
            this.panel7.Controls.Add(this.TimeDescription);
            this.panel7.Controls.Add(this.TimeLabel);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.UseTimeChckBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 199);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(604, 125);
            this.panel7.TabIndex = 7;
            // 
            // TimeUpDown
            // 
            this.TimeUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeUpDown.Location = new System.Drawing.Point(455, 70);
            this.TimeUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeUpDown.Name = "TimeUpDown";
            this.TimeUpDown.Size = new System.Drawing.Size(76, 29);
            this.TimeUpDown.TabIndex = 5;
            this.TimeUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // TimeDescription
            // 
            this.TimeDescription.AutoSize = true;
            this.TimeDescription.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TimeDescription.Location = new System.Drawing.Point(52, 89);
            this.TimeDescription.Name = "TimeDescription";
            this.TimeDescription.Size = new System.Drawing.Size(62, 13);
            this.TimeDescription.TabIndex = 4;
            this.TimeDescription.Text = "В секундах";
            this.TimeDescription.Click += new System.EventHandler(this.Label9_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(51, 68);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(55, 21);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Время";
            this.TimeLabel.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(52, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "За отведенное время студент должен ответить на каждый вопрос,\r\nиначе  ответ помеч" +
    "ается как неверный";
            // 
            // UseTimeChckBox
            // 
            this.UseTimeChckBox.AutoSize = true;
            this.UseTimeChckBox.Location = new System.Drawing.Point(34, 12);
            this.UseTimeChckBox.Name = "UseTimeChckBox";
            this.UseTimeChckBox.Size = new System.Drawing.Size(245, 30);
            this.UseTimeChckBox.TabIndex = 0;
            this.UseTimeChckBox.Text = "Установить таймер для каждого задания\r\n";
            this.UseTimeChckBox.UseSelectable = true;
            this.UseTimeChckBox.CheckedChanged += new System.EventHandler(this.UseTimeChckBox_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.RandomTasksChckBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(604, 73);
            this.panel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(52, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 26);
            this.label6.TabIndex = 1;
            this.label6.Text = "Задания даются студенту в случайном порядке, чтобы исключить (или попытаться)\r\nсп" +
    "исывание\r\n";
            // 
            // RandomTasksChckBox
            // 
            this.RandomTasksChckBox.AutoSize = true;
            this.RandomTasksChckBox.Location = new System.Drawing.Point(34, 12);
            this.RandomTasksChckBox.Name = "RandomTasksChckBox";
            this.RandomTasksChckBox.Size = new System.Drawing.Size(190, 15);
            this.RandomTasksChckBox.TabIndex = 0;
            this.RandomTasksChckBox.Text = "Задания в случайном порядке";
            this.RandomTasksChckBox.UseSelectable = true;
            this.RandomTasksChckBox.CheckedChanged += new System.EventHandler(this.RandomTasksChckBox_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.ShowRightChckBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 63);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(52, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(387, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "После принятия ответа, студенту показывается верный вариант ответа";
            // 
            // ShowRightChckBox
            // 
            this.ShowRightChckBox.AutoSize = true;
            this.ShowRightChckBox.Location = new System.Drawing.Point(34, 12);
            this.ShowRightChckBox.Name = "ShowRightChckBox";
            this.ShowRightChckBox.Size = new System.Drawing.Size(165, 15);
            this.ShowRightChckBox.TabIndex = 0;
            this.ShowRightChckBox.Text = "Показывать верный ответ";
            this.ShowRightChckBox.UseSelectable = true;
            this.ShowRightChckBox.CheckedChanged += new System.EventHandler(this.ShowRightChckBox_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.AllowReamakeChckBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 63);
            this.panel4.TabIndex = 4;
            // 
            // EditSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditSub";
            this.Size = new System.Drawing.Size(604, 608);
            this.Load += new System.EventHandler(this.EditSub_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TasksAmountUpDown)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeUpDown)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroCheckBox AllowReamakeChckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown TimeUpDown;
        private System.Windows.Forms.Label TimeDescription;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroCheckBox UseTimeChckBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroCheckBox RandomTasksChckBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroCheckBox ShowRightChckBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown TasksAmountUpDown;
        private System.Windows.Forms.Label AmountDescription;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroCheckBox LimitTasksChckBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
