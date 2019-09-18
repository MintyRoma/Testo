namespace Testo
{
    partial class TaskBuild
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
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.Info = new System.Windows.Forms.Label();
            this.stat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Progress
            // 
            this.Progress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(119)))), ((int)(((byte)(217)))));
            this.Progress.Location = new System.Drawing.Point(54, 81);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(470, 10);
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progress.TabIndex = 0;
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(50, 94);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(276, 21);
            this.Info.TabIndex = 1;
            this.Info.Text = "Идет попытка сборки файла задания";
            // 
            // stat
            // 
            this.stat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stat.AutoSize = true;
            this.stat.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.stat.ForeColor = System.Drawing.Color.White;
            this.stat.Location = new System.Drawing.Point(51, 115);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(82, 13);
            this.stat.TabIndex = 2;
            this.stat.Text = "Статус сборки";
            this.stat.Click += new System.EventHandler(this.Stat_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(441, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Собрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TaskBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(572, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskBuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskBuild";
            this.Load += new System.EventHandler(this.TaskBuild_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label stat;
        private System.Windows.Forms.Button button1;
    }
}