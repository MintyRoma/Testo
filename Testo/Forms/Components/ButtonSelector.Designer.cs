namespace Testo.Forms.Components
{
    partial class ButtonSelector
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
            this.But = new System.Windows.Forms.Button();
            this.Indicator = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // But
            // 
            this.But.Dock = System.Windows.Forms.DockStyle.Fill;
            this.But.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But.Location = new System.Drawing.Point(0, 0);
            this.But.Name = "But";
            this.But.Size = new System.Drawing.Size(300, 150);
            this.But.TabIndex = 0;
            this.But.Text = "Example";
            this.But.UseVisualStyleBackColor = true;
            this.But.Click += new System.EventHandler(this.But_Click);
            // 
            // Indicator
            // 
            this.Indicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Indicator.AutoCheck = false;
            this.Indicator.AutoSize = true;
            this.Indicator.BackColor = System.Drawing.Color.Transparent;
            this.Indicator.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Indicator.Location = new System.Drawing.Point(272, 15);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(15, 14);
            this.Indicator.TabIndex = 1;
            this.Indicator.UseVisualStyleBackColor = false;
            // 
            // ButtonSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.But);
            this.MinimumSize = new System.Drawing.Size(150, 75);
            this.Name = "ButtonSelector";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But;
        private System.Windows.Forms.CheckBox Indicator;
    }
}
