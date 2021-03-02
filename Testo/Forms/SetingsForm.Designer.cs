namespace Testo.Forms
{
    partial class SetingsForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.UsersBtn = new System.Windows.Forms.Button();
            this.GraphBtn = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.SubjectsBtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.ViewerPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.ExitBtn);
            this.menuPanel.Controls.Add(this.UsersBtn);
            this.menuPanel.Controls.Add(this.GraphBtn);
            this.menuPanel.Controls.Add(this.History);
            this.menuPanel.Controls.Add(this.SubjectsBtn);
            this.menuPanel.Controls.Add(this.ProfileBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(20, 60);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(210, 520);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.ForeColor = System.Drawing.Color.Crimson;
            this.ExitBtn.Image = global::Testo.Properties.Resources.log_out;
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(0, 205);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(210, 41);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Выход на главную";
            this.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UsersBtn
            // 
            this.UsersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UsersBtn.FlatAppearance.BorderSize = 0;
            this.UsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersBtn.ForeColor = System.Drawing.Color.Black;
            this.UsersBtn.Image = global::Testo.Properties.Resources.users;
            this.UsersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersBtn.Location = new System.Drawing.Point(0, 164);
            this.UsersBtn.Name = "UsersBtn";
            this.UsersBtn.Size = new System.Drawing.Size(210, 41);
            this.UsersBtn.TabIndex = 5;
            this.UsersBtn.Text = "Пользователи";
            this.UsersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UsersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UsersBtn.UseVisualStyleBackColor = true;
            // 
            // GraphBtn
            // 
            this.GraphBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.GraphBtn.FlatAppearance.BorderSize = 0;
            this.GraphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphBtn.ForeColor = System.Drawing.Color.Black;
            this.GraphBtn.Image = global::Testo.Properties.Resources.trending_up;
            this.GraphBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GraphBtn.Location = new System.Drawing.Point(0, 123);
            this.GraphBtn.Name = "GraphBtn";
            this.GraphBtn.Size = new System.Drawing.Size(210, 41);
            this.GraphBtn.TabIndex = 4;
            this.GraphBtn.Text = "Статистика";
            this.GraphBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GraphBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GraphBtn.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.Dock = System.Windows.Forms.DockStyle.Top;
            this.History.FlatAppearance.BorderSize = 0;
            this.History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.History.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.ForeColor = System.Drawing.Color.Black;
            this.History.Image = global::Testo.Properties.Resources.calendar;
            this.History.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History.Location = new System.Drawing.Point(0, 82);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(210, 41);
            this.History.TabIndex = 3;
            this.History.Text = "История";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.History.UseVisualStyleBackColor = true;
            // 
            // SubjectsBtn
            // 
            this.SubjectsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubjectsBtn.FlatAppearance.BorderSize = 0;
            this.SubjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectsBtn.ForeColor = System.Drawing.Color.Black;
            this.SubjectsBtn.Image = global::Testo.Properties.Resources.database;
            this.SubjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectsBtn.Location = new System.Drawing.Point(0, 41);
            this.SubjectsBtn.Name = "SubjectsBtn";
            this.SubjectsBtn.Size = new System.Drawing.Size(210, 41);
            this.SubjectsBtn.TabIndex = 2;
            this.SubjectsBtn.Text = "Предметы";
            this.SubjectsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubjectsBtn.UseVisualStyleBackColor = true;
            this.SubjectsBtn.Click += new System.EventHandler(this.SubjectsBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileBtn.ForeColor = System.Drawing.Color.Black;
            this.ProfileBtn.Image = global::Testo.Properties.Resources.briefcase;
            this.ProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.Location = new System.Drawing.Point(0, 0);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(210, 41);
            this.ProfileBtn.TabIndex = 1;
            this.ProfileBtn.Text = "Профиль";
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfileBtn.UseVisualStyleBackColor = true;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // ViewerPanel
            // 
            this.ViewerPanel.BackColor = System.Drawing.Color.White;
            this.ViewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewerPanel.Location = new System.Drawing.Point(230, 60);
            this.ViewerPanel.Name = "ViewerPanel";
            this.ViewerPanel.Size = new System.Drawing.Size(600, 520);
            this.ViewerPanel.TabIndex = 1;
            // 
            // SetingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.ViewerPanel);
            this.Controls.Add(this.menuPanel);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "SetingsForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Setings_Load);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel ViewerPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button UsersBtn;
        private System.Windows.Forms.Button GraphBtn;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button SubjectsBtn;
        private System.Windows.Forms.Button ProfileBtn;
    }
}