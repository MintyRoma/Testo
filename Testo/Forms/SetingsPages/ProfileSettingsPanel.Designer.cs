namespace Testo.Forms.SetingsPages
{
    partial class ProfileSettingsPanel
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
            this.Nametxtbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChangepasPanel = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.SavePasBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmpasTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newpasTxtBox = new System.Windows.Forms.TextBox();
            this.changepasBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ChangepasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.Nametxtbox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(96, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 94);
            this.panel1.TabIndex = 1;
            // 
            // Nametxtbox
            // 
            this.Nametxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Nametxtbox.BackColor = System.Drawing.Color.White;
            this.Nametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nametxtbox.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nametxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Nametxtbox.Location = new System.Drawing.Point(3, 33);
            this.Nametxtbox.Name = "Nametxtbox";
            this.Nametxtbox.Size = new System.Drawing.Size(357, 58);
            this.Nametxtbox.TabIndex = 0;
            this.Nametxtbox.Text = "{Name}";
            this.Nametxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nametxtbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 561);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.ChangepasPanel);
            this.panel2.Controls.Add(this.changepasBtn);
            this.panel2.Location = new System.Drawing.Point(52, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 394);
            this.panel2.TabIndex = 2;
            // 
            // ChangepasPanel
            // 
            this.ChangepasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangepasPanel.Controls.Add(this.Cancel);
            this.ChangepasPanel.Controls.Add(this.SavePasBtn);
            this.ChangepasPanel.Controls.Add(this.label2);
            this.ChangepasPanel.Controls.Add(this.confirmpasTxtBox);
            this.ChangepasPanel.Controls.Add(this.label1);
            this.ChangepasPanel.Controls.Add(this.newpasTxtBox);
            this.ChangepasPanel.Location = new System.Drawing.Point(3, 38);
            this.ChangepasPanel.Name = "ChangepasPanel";
            this.ChangepasPanel.Size = new System.Drawing.Size(463, 353);
            this.ChangepasPanel.TabIndex = 6;
            this.ChangepasPanel.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Cancel.Location = new System.Drawing.Point(310, 319);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 29);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Button3_Click);
            // 
            // SavePasBtn
            // 
            this.SavePasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePasBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(16)))), ((int)(((byte)(105)))));
            this.SavePasBtn.FlatAppearance.BorderSize = 0;
            this.SavePasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePasBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SavePasBtn.ForeColor = System.Drawing.Color.White;
            this.SavePasBtn.Location = new System.Drawing.Point(90, 319);
            this.SavePasBtn.Name = "SavePasBtn";
            this.SavePasBtn.Size = new System.Drawing.Size(214, 29);
            this.SavePasBtn.TabIndex = 5;
            this.SavePasBtn.Text = "Сменить пароль";
            this.SavePasBtn.UseVisualStyleBackColor = false;
            this.SavePasBtn.Click += new System.EventHandler(this.SavePasBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(148, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Повторите новый пароль";
            // 
            // confirmpasTxtBox
            // 
            this.confirmpasTxtBox.BackColor = System.Drawing.Color.White;
            this.confirmpasTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmpasTxtBox.Location = new System.Drawing.Point(78, 170);
            this.confirmpasTxtBox.Name = "confirmpasTxtBox";
            this.confirmpasTxtBox.Size = new System.Drawing.Size(317, 29);
            this.confirmpasTxtBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(148, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите новый пароль";
            // 
            // newpasTxtBox
            // 
            this.newpasTxtBox.BackColor = System.Drawing.Color.White;
            this.newpasTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newpasTxtBox.Location = new System.Drawing.Point(78, 101);
            this.newpasTxtBox.Name = "newpasTxtBox";
            this.newpasTxtBox.Size = new System.Drawing.Size(317, 29);
            this.newpasTxtBox.TabIndex = 1;
            // 
            // changepasBtn
            // 
            this.changepasBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changepasBtn.FlatAppearance.BorderSize = 0;
            this.changepasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changepasBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changepasBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.changepasBtn.Location = new System.Drawing.Point(154, 3);
            this.changepasBtn.Name = "changepasBtn";
            this.changepasBtn.Size = new System.Drawing.Size(173, 29);
            this.changepasBtn.TabIndex = 0;
            this.changepasBtn.Text = "Сменить пароль";
            this.changepasBtn.UseVisualStyleBackColor = true;
            this.changepasBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Testo.Properties.Resources.edit_dark;
            this.pictureBox1.Location = new System.Drawing.Point(366, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Мой профиль";
            // 
            // ProfileSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(574, 561);
            this.Name = "ProfileSettingsPanel";
            this.Size = new System.Drawing.Size(574, 561);
            this.Load += new System.EventHandler(this.ProfileSettingsPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ChangepasPanel.ResumeLayout(false);
            this.ChangepasPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Nametxtbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SavePasBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmpasTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newpasTxtBox;
        private System.Windows.Forms.Button changepasBtn;
        private System.Windows.Forms.Panel ChangepasPanel;
        private System.Windows.Forms.Label label3;
    }
}
