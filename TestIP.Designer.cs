namespace Testo
{
    partial class TestIP
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
            this.Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.AnswersBox = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(217, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(136, 25);
            this.Label.TabIndex = 0;
            this.Label.Text = "Label is here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(16)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 454);
            this.panel1.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(222, 37);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(566, 136);
            this.textBox.TabIndex = 2;
            // 
            // AnswersBox
            // 
            this.AnswersBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AnswersBox.Location = new System.Drawing.Point(222, 239);
            this.AnswersBox.Name = "AnswersBox";
            this.AnswersBox.Size = new System.Drawing.Size(566, 150);
            this.AnswersBox.TabIndex = 3;
            this.AnswersBox.Paint += new System.Windows.Forms.PaintEventHandler(this.AnswersBox_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(686, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswersBox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label);
            this.MaximizeBox = false;
            this.Name = "TestIP";
            this.Text = "TestIP";
            this.Load += new System.EventHandler(this.TestIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Panel AnswersBox;
        private System.Windows.Forms.Button button1;
    }
}