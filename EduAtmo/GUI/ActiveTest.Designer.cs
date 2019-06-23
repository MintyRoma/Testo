namespace EduAtmo.GUI
{
    partial class ActiveTest
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
            this.TestIDLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TskTextLabel = new System.Windows.Forms.Label();
            this.Labellabel = new System.Windows.Forms.Label();
            this.SubjectNameLable = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TestIDLabel
            // 
            this.TestIDLabel.AutoSize = true;
            this.TestIDLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TestIDLabel.Location = new System.Drawing.Point(35, 46);
            this.TestIDLabel.Name = "TestIDLabel";
            this.TestIDLabel.Size = new System.Drawing.Size(73, 35);
            this.TestIDLabel.TabIndex = 0;
            this.TestIDLabel.Text = "NUM";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(202, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 211);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.TskTextLabel);
            this.panel2.Location = new System.Drawing.Point(202, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 131);
            this.panel2.TabIndex = 2;
            // 
            // TskTextLabel
            // 
            this.TskTextLabel.AutoSize = true;
            this.TskTextLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TskTextLabel.Location = new System.Drawing.Point(4, 4);
            this.TskTextLabel.Name = "TskTextLabel";
            this.TskTextLabel.Size = new System.Drawing.Size(76, 20);
            this.TskTextLabel.TabIndex = 0;
            this.TskTextLabel.Text = "TASKTEXT";
            // 
            // Labellabel
            // 
            this.Labellabel.AutoSize = true;
            this.Labellabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Labellabel.Location = new System.Drawing.Point(205, 23);
            this.Labellabel.Name = "Labellabel";
            this.Labellabel.Size = new System.Drawing.Size(60, 25);
            this.Labellabel.TabIndex = 3;
            this.Labellabel.Text = "LABEL";
            // 
            // SubjectNameLable
            // 
            this.SubjectNameLable.AutoSize = true;
            this.SubjectNameLable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SubjectNameLable.Location = new System.Drawing.Point(29, 208);
            this.SubjectNameLable.Name = "SubjectNameLable";
            this.SubjectNameLable.Size = new System.Drawing.Size(79, 25);
            this.SubjectNameLable.TabIndex = 4;
            this.SubjectNameLable.Text = "SUBJECT";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TimeLabel.Location = new System.Drawing.Point(31, 246);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(51, 25);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "TIME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Задание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Время на выполнение";
            // 
            // ActiveTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.SubjectNameLable);
            this.Controls.Add(this.Labellabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TestIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ActiveTest";
            this.Text = "ActiveTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActiveTest_FormClosing);
            this.Load += new System.EventHandler(this.ActiveTest_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestIDLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TskTextLabel;
        private System.Windows.Forms.Label Labellabel;
        private System.Windows.Forms.Label SubjectNameLable;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}