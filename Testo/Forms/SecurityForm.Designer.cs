namespace Testo.Forms
{
    partial class SecurityForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.statuslabel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.29607F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.70393F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.passwordTxtBox);
            this.panel1.Controls.Add(this.statuslabel);
            this.panel1.Location = new System.Drawing.Point(9, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 179);
            this.panel1.TabIndex = 1;
            // 
            // passwordTxtBox
            // 
            // 
            // 
            // 
            this.passwordTxtBox.CustomButton.Image = null;
            this.passwordTxtBox.CustomButton.Location = new System.Drawing.Point(298, 2);
            this.passwordTxtBox.CustomButton.Name = "";
            this.passwordTxtBox.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.passwordTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTxtBox.CustomButton.TabIndex = 1;
            this.passwordTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTxtBox.CustomButton.UseSelectable = true;
            this.passwordTxtBox.DisplayIcon = true;
            this.passwordTxtBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passwordTxtBox.Icon = global::Testo.Properties.Resources.Login2;
            this.passwordTxtBox.IconRight = true;
            this.passwordTxtBox.Lines = new string[0];
            this.passwordTxtBox.Location = new System.Drawing.Point(90, 71);
            this.passwordTxtBox.MaxLength = 32767;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '•';
            this.passwordTxtBox.PromptText = "Введите пароль здесь";
            this.passwordTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTxtBox.SelectedText = "";
            this.passwordTxtBox.SelectionLength = 0;
            this.passwordTxtBox.SelectionStart = 0;
            this.passwordTxtBox.ShortcutsEnabled = true;
            this.passwordTxtBox.ShowButton = true;
            this.passwordTxtBox.ShowClearButton = true;
            this.passwordTxtBox.Size = new System.Drawing.Size(326, 30);
            this.passwordTxtBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.passwordTxtBox.TabIndex = 1;
            this.passwordTxtBox.UseSelectable = true;
            this.passwordTxtBox.WaterMark = "Введите пароль здесь";
            this.passwordTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // statuslabel
            // 
            this.statuslabel.BackColor = System.Drawing.Color.White;
            this.statuslabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statuslabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statuslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.statuslabel.Location = new System.Drawing.Point(23, 23);
            this.statuslabel.Multiline = true;
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.ReadOnly = true;
            this.statuslabel.Size = new System.Drawing.Size(464, 42);
            this.statuslabel.TabIndex = 10000;
            this.statuslabel.Text = "Для подтверждения введите пароль учителя\r\n";
            this.statuslabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Testo.Properties.Resources.shield1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 400);
            this.MinimumSize = new System.Drawing.Size(570, 400);
            this.Name = "SecurityForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Ограничение доступа";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox passwordTxtBox;
        private System.Windows.Forms.TextBox statuslabel;
    }
}