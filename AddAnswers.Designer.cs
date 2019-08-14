namespace Testo
{
    partial class AddAnswers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnswerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.stringanswerpanel = new System.Windows.Forms.Panel();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnswersPanel.SuspendLayout();
            this.stringanswerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnswerTypeComboBox
            // 
            this.AnswerTypeComboBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.AnswerTypeComboBox.FormattingEnabled = true;
            this.AnswerTypeComboBox.Items.AddRange(new object[] {
            "Один ответ из нескольких вариантов",
            "Несколько вариантов ответа",
            "Строка",
            "Порядок"});
            this.AnswerTypeComboBox.Location = new System.Drawing.Point(12, 43);
            this.AnswerTypeComboBox.Name = "AnswerTypeComboBox";
            this.AnswerTypeComboBox.Size = new System.Drawing.Size(323, 27);
            this.AnswerTypeComboBox.TabIndex = 0;
            this.AnswerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип ответа";
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.AutoScroll = true;
            this.AnswersPanel.Controls.Add(this.stringanswerpanel);
            this.AnswersPanel.Location = new System.Drawing.Point(13, 77);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(322, 326);
            this.AnswersPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // stringanswerpanel
            // 
            this.stringanswerpanel.Controls.Add(this.label2);
            this.stringanswerpanel.Controls.Add(this.textbox);
            this.stringanswerpanel.Location = new System.Drawing.Point(4, 110);
            this.stringanswerpanel.Name = "stringanswerpanel";
            this.stringanswerpanel.Size = new System.Drawing.Size(315, 64);
            this.stringanswerpanel.TabIndex = 0;
            // 
            // textbox
            // 
            this.textbox.Font = new System.Drawing.Font("Consolas", 12F);
            this.textbox.Location = new System.Drawing.Point(0, 22);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(315, 26);
            this.textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Строковой ответ";
            // 
            // AddAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswersPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswerTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAnswers";
            this.Text = "AddAnswers";
            this.Load += new System.EventHandler(this.AddAnswers_Load);
            this.AnswersPanel.ResumeLayout(false);
            this.stringanswerpanel.ResumeLayout(false);
            this.stringanswerpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AnswerTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel stringanswerpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox;
    }
}