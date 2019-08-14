namespace Testo
{
    partial class EditSubject
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Добавить задание");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Параметры", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.TaskTree = new System.Windows.Forms.TreeView();
            this.PropsPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.limitasksUND = new System.Windows.Forms.NumericUpDown();
            this.limittasksCKB = new System.Windows.Forms.CheckBox();
            this.RateSystemBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeForTaskNUD = new System.Windows.Forms.NumericUpDown();
            this.RandomAnswerCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomTaskCheckBox = new System.Windows.Forms.CheckBox();
            this.SetupTimerCheckBox = new System.Windows.Forms.CheckBox();
            this.AllowReanswerCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowRightCheckBox = new System.Windows.Forms.CheckBox();
            this.dotFileTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubjectFileNameTxtBox = new System.Windows.Forms.TextBox();
            this.SubjectNameTxtBox = new System.Windows.Forms.TextBox();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.TaskInfoPanel = new System.Windows.Forms.Panel();
            this.AnswersBtn = new System.Windows.Forms.Button();
            this.BroowseImageBtn = new System.Windows.Forms.Button();
            this.ImageView = new System.Windows.Forms.ListView();
            this.TextTaskBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HeaderTask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteTaskBtn = new System.Windows.Forms.Button();
            this.DeleteImageBtn = new System.Windows.Forms.Button();
            this.PropsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitasksUND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeForTaskNUD)).BeginInit();
            this.TaskInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskTree
            // 
            this.TaskTree.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskTree.Location = new System.Drawing.Point(13, 13);
            this.TaskTree.Name = "TaskTree";
            treeNode9.Name = "AddTaskNode";
            treeNode9.Text = "Добавить задание";
            treeNode10.Name = "SubjectRoot";
            treeNode10.Text = "Параметры";
            treeNode10.ToolTipText = "Параметры файла заданий";
            this.TaskTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.TaskTree.ShowRootLines = false;
            this.TaskTree.Size = new System.Drawing.Size(241, 461);
            this.TaskTree.TabIndex = 0;
            this.TaskTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TaskTree_AfterSelect);
            // 
            // PropsPanel
            // 
            this.PropsPanel.Controls.Add(this.label7);
            this.PropsPanel.Controls.Add(this.limitasksUND);
            this.PropsPanel.Controls.Add(this.limittasksCKB);
            this.PropsPanel.Controls.Add(this.RateSystemBtn);
            this.PropsPanel.Controls.Add(this.label3);
            this.PropsPanel.Controls.Add(this.TimeForTaskNUD);
            this.PropsPanel.Controls.Add(this.RandomAnswerCheckBox);
            this.PropsPanel.Controls.Add(this.RandomTaskCheckBox);
            this.PropsPanel.Controls.Add(this.SetupTimerCheckBox);
            this.PropsPanel.Controls.Add(this.AllowReanswerCheckBox);
            this.PropsPanel.Controls.Add(this.ShowRightCheckBox);
            this.PropsPanel.Controls.Add(this.dotFileTxt);
            this.PropsPanel.Controls.Add(this.label2);
            this.PropsPanel.Controls.Add(this.label1);
            this.PropsPanel.Controls.Add(this.SubjectFileNameTxtBox);
            this.PropsPanel.Controls.Add(this.SubjectNameTxtBox);
            this.PropsPanel.Location = new System.Drawing.Point(260, 12);
            this.PropsPanel.Name = "PropsPanel";
            this.PropsPanel.Size = new System.Drawing.Size(528, 421);
            this.PropsPanel.TabIndex = 1;
            this.PropsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PropsPanel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(27, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Количество заданий для прохождения теста";
            // 
            // limitasksUND
            // 
            this.limitasksUND.Enabled = false;
            this.limitasksUND.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limitasksUND.Location = new System.Drawing.Point(435, 338);
            this.limitasksUND.Maximum = new decimal(new int[] {
            2700,
            0,
            0,
            0});
            this.limitasksUND.Name = "limitasksUND";
            this.limitasksUND.Size = new System.Drawing.Size(86, 26);
            this.limitasksUND.TabIndex = 20;
            this.limitasksUND.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // limittasksCKB
            // 
            this.limittasksCKB.AutoSize = true;
            this.limittasksCKB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.limittasksCKB.Location = new System.Drawing.Point(11, 312);
            this.limittasksCKB.Name = "limittasksCKB";
            this.limittasksCKB.Size = new System.Drawing.Size(307, 23);
            this.limittasksCKB.TabIndex = 19;
            this.limittasksCKB.Text = "Ограниченное количество заданий";
            this.limittasksCKB.UseVisualStyleBackColor = true;
            this.limittasksCKB.CheckedChanged += new System.EventHandler(this.LimittasksCKB_CheckedChanged);
            // 
            // RateSystemBtn
            // 
            this.RateSystemBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RateSystemBtn.Location = new System.Drawing.Point(11, 378);
            this.RateSystemBtn.Name = "RateSystemBtn";
            this.RateSystemBtn.Size = new System.Drawing.Size(234, 33);
            this.RateSystemBtn.TabIndex = 18;
            this.RateSystemBtn.Text = "Система оценивания";
            this.RateSystemBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(27, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Время (в секундах)";
            // 
            // TimeForTaskNUD
            // 
            this.TimeForTaskNUD.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeForTaskNUD.Location = new System.Drawing.Point(435, 277);
            this.TimeForTaskNUD.Maximum = new decimal(new int[] {
            2700,
            0,
            0,
            0});
            this.TimeForTaskNUD.Name = "TimeForTaskNUD";
            this.TimeForTaskNUD.Size = new System.Drawing.Size(86, 26);
            this.TimeForTaskNUD.TabIndex = 16;
            this.TimeForTaskNUD.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // RandomAnswerCheckBox
            // 
            this.RandomAnswerCheckBox.AutoSize = true;
            this.RandomAnswerCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomAnswerCheckBox.Location = new System.Drawing.Point(11, 222);
            this.RandomAnswerCheckBox.Name = "RandomAnswerCheckBox";
            this.RandomAnswerCheckBox.Size = new System.Drawing.Size(262, 23);
            this.RandomAnswerCheckBox.TabIndex = 12;
            this.RandomAnswerCheckBox.Text = "Ответы в случайном порядке";
            this.RandomAnswerCheckBox.UseVisualStyleBackColor = true;
            // 
            // RandomTaskCheckBox
            // 
            this.RandomTaskCheckBox.AutoSize = true;
            this.RandomTaskCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomTaskCheckBox.Location = new System.Drawing.Point(11, 193);
            this.RandomTaskCheckBox.Name = "RandomTaskCheckBox";
            this.RandomTaskCheckBox.Size = new System.Drawing.Size(271, 23);
            this.RandomTaskCheckBox.TabIndex = 12;
            this.RandomTaskCheckBox.Text = "Задания в случайном порядке";
            this.RandomTaskCheckBox.UseVisualStyleBackColor = true;
            // 
            // SetupTimerCheckBox
            // 
            this.SetupTimerCheckBox.AutoSize = true;
            this.SetupTimerCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetupTimerCheckBox.Location = new System.Drawing.Point(11, 251);
            this.SetupTimerCheckBox.Name = "SetupTimerCheckBox";
            this.SetupTimerCheckBox.Size = new System.Drawing.Size(361, 23);
            this.SetupTimerCheckBox.TabIndex = 13;
            this.SetupTimerCheckBox.Text = "Установить таймер для каждого задания";
            this.SetupTimerCheckBox.UseVisualStyleBackColor = true;
            this.SetupTimerCheckBox.CheckedChanged += new System.EventHandler(this.SetupTimerCheckBox_CheckedChanged);
            // 
            // AllowReanswerCheckBox
            // 
            this.AllowReanswerCheckBox.AutoSize = true;
            this.AllowReanswerCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllowReanswerCheckBox.Location = new System.Drawing.Point(11, 164);
            this.AllowReanswerCheckBox.Name = "AllowReanswerCheckBox";
            this.AllowReanswerCheckBox.Size = new System.Drawing.Size(199, 23);
            this.AllowReanswerCheckBox.TabIndex = 14;
            this.AllowReanswerCheckBox.Text = "Разрешать пересдачу";
            this.AllowReanswerCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowRightCheckBox
            // 
            this.ShowRightCheckBox.AutoSize = true;
            this.ShowRightCheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowRightCheckBox.Location = new System.Drawing.Point(11, 135);
            this.ShowRightCheckBox.Name = "ShowRightCheckBox";
            this.ShowRightCheckBox.Size = new System.Drawing.Size(235, 23);
            this.ShowRightCheckBox.TabIndex = 15;
            this.ShowRightCheckBox.Text = "Показывать верный ответ";
            this.ShowRightCheckBox.UseVisualStyleBackColor = true;
            // 
            // dotFileTxt
            // 
            this.dotFileTxt.BackColor = System.Drawing.Color.White;
            this.dotFileTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.dotFileTxt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotFileTxt.Location = new System.Drawing.Point(461, 85);
            this.dotFileTxt.Name = "dotFileTxt";
            this.dotFileTxt.ReadOnly = true;
            this.dotFileTxt.Size = new System.Drawing.Size(60, 26);
            this.dotFileTxt.TabIndex = 11;
            this.dotFileTxt.TabStop = false;
            this.dotFileTxt.Text = ".sft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя файла";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя/Предмет";
            // 
            // SubjectFileNameTxtBox
            // 
            this.SubjectFileNameTxtBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectFileNameTxtBox.Location = new System.Drawing.Point(11, 85);
            this.SubjectFileNameTxtBox.Name = "SubjectFileNameTxtBox";
            this.SubjectFileNameTxtBox.Size = new System.Drawing.Size(444, 26);
            this.SubjectFileNameTxtBox.TabIndex = 7;
            // 
            // SubjectNameTxtBox
            // 
            this.SubjectNameTxtBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectNameTxtBox.Location = new System.Drawing.Point(11, 25);
            this.SubjectNameTxtBox.Name = "SubjectNameTxtBox";
            this.SubjectNameTxtBox.Size = new System.Drawing.Size(510, 26);
            this.SubjectNameTxtBox.TabIndex = 8;
            this.SubjectNameTxtBox.TextChanged += new System.EventHandler(this.SubjectNameTxtBox_TextChanged);
            // 
            // ImportBtn
            // 
            this.ImportBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportBtn.Location = new System.Drawing.Point(402, 440);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(126, 33);
            this.ImportBtn.TabIndex = 18;
            this.ImportBtn.Text = "Импорт";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(665, 440);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(122, 34);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(534, 440);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 34);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // TaskInfoPanel
            // 
            this.TaskInfoPanel.Controls.Add(this.DeleteImageBtn);
            this.TaskInfoPanel.Controls.Add(this.AnswersBtn);
            this.TaskInfoPanel.Controls.Add(this.BroowseImageBtn);
            this.TaskInfoPanel.Controls.Add(this.ImageView);
            this.TaskInfoPanel.Controls.Add(this.TextTaskBox);
            this.TaskInfoPanel.Controls.Add(this.label6);
            this.TaskInfoPanel.Controls.Add(this.label5);
            this.TaskInfoPanel.Controls.Add(this.HeaderTask);
            this.TaskInfoPanel.Controls.Add(this.label4);
            this.TaskInfoPanel.Controls.Add(this.DeleteTaskBtn);
            this.TaskInfoPanel.Location = new System.Drawing.Point(260, 13);
            this.TaskInfoPanel.Name = "TaskInfoPanel";
            this.TaskInfoPanel.Size = new System.Drawing.Size(528, 420);
            this.TaskInfoPanel.TabIndex = 19;
            // 
            // AnswersBtn
            // 
            this.AnswersBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.AnswersBtn.Location = new System.Drawing.Point(16, 340);
            this.AnswersBtn.Name = "AnswersBtn";
            this.AnswersBtn.Size = new System.Drawing.Size(201, 34);
            this.AnswersBtn.TabIndex = 4;
            this.AnswersBtn.Text = "Ответы";
            this.AnswersBtn.UseVisualStyleBackColor = true;
            this.AnswersBtn.Click += new System.EventHandler(this.AnswersBtn_Click);
            // 
            // BroowseImageBtn
            // 
            this.BroowseImageBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.BroowseImageBtn.Location = new System.Drawing.Point(434, 231);
            this.BroowseImageBtn.Name = "BroowseImageBtn";
            this.BroowseImageBtn.Size = new System.Drawing.Size(87, 33);
            this.BroowseImageBtn.TabIndex = 3;
            this.BroowseImageBtn.Text = "Обзор";
            this.BroowseImageBtn.UseVisualStyleBackColor = true;
            this.BroowseImageBtn.Click += new System.EventHandler(this.BroowseImageBtn_Click);
            // 
            // ImageView
            // 
            this.ImageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageView.HideSelection = false;
            this.ImageView.Location = new System.Drawing.Point(16, 231);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(412, 103);
            this.ImageView.TabIndex = 2;
            this.ImageView.UseCompatibleStateImageBehavior = false;
            this.ImageView.DoubleClick += new System.EventHandler(this.ImageView_DoubleClick);
            // 
            // TextTaskBox
            // 
            this.TextTaskBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.TextTaskBox.Location = new System.Drawing.Point(16, 75);
            this.TextTaskBox.Multiline = true;
            this.TextTaskBox.Name = "TextTaskBox";
            this.TextTaskBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextTaskBox.Size = new System.Drawing.Size(505, 131);
            this.TextTaskBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Изображения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Текст задания";
            // 
            // HeaderTask
            // 
            this.HeaderTask.Font = new System.Drawing.Font("Consolas", 12F);
            this.HeaderTask.Location = new System.Drawing.Point(16, 24);
            this.HeaderTask.Name = "HeaderTask";
            this.HeaderTask.Size = new System.Drawing.Size(505, 26);
            this.HeaderTask.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.Location = new System.Drawing.Point(12, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Заголовок";
            // 
            // DeleteTaskBtn
            // 
            this.DeleteTaskBtn.BackColor = System.Drawing.Color.Tomato;
            this.DeleteTaskBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.DeleteTaskBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteTaskBtn.Location = new System.Drawing.Point(332, 377);
            this.DeleteTaskBtn.Name = "DeleteTaskBtn";
            this.DeleteTaskBtn.Size = new System.Drawing.Size(193, 33);
            this.DeleteTaskBtn.TabIndex = 19;
            this.DeleteTaskBtn.Text = "Удалить задание";
            this.DeleteTaskBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteImageBtn
            // 
            this.DeleteImageBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteImageBtn.Location = new System.Drawing.Point(434, 270);
            this.DeleteImageBtn.Name = "DeleteImageBtn";
            this.DeleteImageBtn.Size = new System.Drawing.Size(87, 31);
            this.DeleteImageBtn.TabIndex = 20;
            this.DeleteImageBtn.Text = "Удалить";
            this.DeleteImageBtn.UseVisualStyleBackColor = true;
            this.DeleteImageBtn.Click += new System.EventHandler(this.DeleteImageBtn_Click);
            // 
            // EditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PropsPanel);
            this.Controls.Add(this.TaskTree);
            this.Controls.Add(this.TaskInfoPanel);
            this.Name = "EditSubject";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PropsPanel.ResumeLayout(false);
            this.PropsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitasksUND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeForTaskNUD)).EndInit();
            this.TaskInfoPanel.ResumeLayout(false);
            this.TaskInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TaskTree;
        private System.Windows.Forms.Panel PropsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TimeForTaskNUD;
        private System.Windows.Forms.CheckBox RandomTaskCheckBox;
        private System.Windows.Forms.CheckBox SetupTimerCheckBox;
        private System.Windows.Forms.CheckBox AllowReanswerCheckBox;
        private System.Windows.Forms.CheckBox ShowRightCheckBox;
        private System.Windows.Forms.TextBox dotFileTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubjectFileNameTxtBox;
        private System.Windows.Forms.TextBox SubjectNameTxtBox;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button RateSystemBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox RandomAnswerCheckBox;
        private System.Windows.Forms.Panel TaskInfoPanel;
        private System.Windows.Forms.Button AnswersBtn;
        private System.Windows.Forms.Button BroowseImageBtn;
        private System.Windows.Forms.ListView ImageView;
        private System.Windows.Forms.TextBox TextTaskBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HeaderTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteTaskBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown limitasksUND;
        private System.Windows.Forms.CheckBox limittasksCKB;
        private System.Windows.Forms.Button DeleteImageBtn;
    }
}

