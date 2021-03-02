namespace Testo.Forms
{
    partial class SetUp
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
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrMsg = new System.Windows.Forms.Label();
            this.ConfirmTxtboxStat = new System.Windows.Forms.PictureBox();
            this.PassTxtboxStat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmTxtboxStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassTxtboxStat)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BackColor = System.Drawing.Color.White;
            this.NameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.NameTxtBox.Location = new System.Drawing.Point(26, 146);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(333, 29);
            this.NameTxtBox.TabIndex = 0;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя пользователя";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.BackColor = System.Drawing.Color.White;
            this.PassTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxtBox.ForeColor = System.Drawing.Color.Black;
            this.PassTxtBox.Location = new System.Drawing.Point(26, 244);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.Size = new System.Drawing.Size(333, 29);
            this.PassTxtBox.TabIndex = 3;
            this.PassTxtBox.UseSystemPasswordChar = true;
            this.PassTxtBox.TextChanged += new System.EventHandler(this.PassTxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подтверждение пароля";
            // 
            // ConfirmTxtBox
            // 
            this.ConfirmTxtBox.BackColor = System.Drawing.Color.White;
            this.ConfirmTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmTxtBox.ForeColor = System.Drawing.Color.Black;
            this.ConfirmTxtBox.Location = new System.Drawing.Point(26, 311);
            this.ConfirmTxtBox.Name = "ConfirmTxtBox";
            this.ConfirmTxtBox.Size = new System.Drawing.Size(333, 29);
            this.ConfirmTxtBox.TabIndex = 5;
            this.ConfirmTxtBox.UseSystemPasswordChar = true;
            this.ConfirmTxtBox.TextChanged += new System.EventHandler(this.ConfirmTxtBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(344, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Готово!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Настройте основного пользователя для дальнейших настроек\r\nпрограммы, а также наст" +
    "ройки других пользователей.";
            // 
            // ErrMsg
            // 
            this.ErrMsg.AutoSize = true;
            this.ErrMsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.ErrMsg.Location = new System.Drawing.Point(22, 343);
            this.ErrMsg.Name = "ErrMsg";
            this.ErrMsg.Size = new System.Drawing.Size(167, 21);
            this.ErrMsg.TabIndex = 9;
            this.ErrMsg.Text = "Пароли не совпадают";
            // 
            // ConfirmTxtboxStat
            // 
            this.ConfirmTxtboxStat.Image = global::Testo.Properties.Resources.Alert;
            this.ConfirmTxtboxStat.Location = new System.Drawing.Point(381, 307);
            this.ConfirmTxtboxStat.Name = "ConfirmTxtboxStat";
            this.ConfirmTxtboxStat.Size = new System.Drawing.Size(31, 33);
            this.ConfirmTxtboxStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConfirmTxtboxStat.TabIndex = 11;
            this.ConfirmTxtboxStat.TabStop = false;
            // 
            // PassTxtboxStat
            // 
            this.PassTxtboxStat.Image = global::Testo.Properties.Resources.Check;
            this.PassTxtboxStat.Location = new System.Drawing.Point(381, 240);
            this.PassTxtboxStat.Name = "PassTxtboxStat";
            this.PassTxtboxStat.Size = new System.Drawing.Size(31, 33);
            this.PassTxtboxStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassTxtboxStat.TabIndex = 10;
            this.PassTxtboxStat.TabStop = false;
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 469);
            this.Controls.Add(this.ConfirmTxtboxStat);
            this.Controls.Add(this.PassTxtboxStat);
            this.Controls.Add(this.ErrMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConfirmTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTxtBox);
            this.MaximizeBox = false;
            this.Name = "SetUp";
            this.Resizable = false;
            this.Text = "Настройка программы";
            this.Load += new System.EventHandler(this.FirstStartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmTxtboxStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassTxtboxStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PassTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrMsg;
        private System.Windows.Forms.PictureBox PassTxtboxStat;
        private System.Windows.Forms.PictureBox ConfirmTxtboxStat;
    }
}