namespace Testo
{
    partial class AnswerComponent
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
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.chkcBox = new System.Windows.Forms.CheckBox();
            this.radbtn = new System.Windows.Forms.RadioButton();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.SystemColors.Control;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67398F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.32602F));
            this.table.Controls.Add(this.textBox, 1, 0);
            this.table.Controls.Add(this.chkcBox, 0, 0);
            this.table.Controls.Add(this.radbtn, 0, 0);
            this.table.Controls.Add(this.numUD, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Size = new System.Drawing.Size(319, 69);
            this.table.TabIndex = 0;
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(52, 52);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(264, 20);
            this.textBox.TabIndex = 0;
            // 
            // chkcBox
            // 
            this.chkcBox.AutoSize = true;
            this.chkcBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkcBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkcBox.Location = new System.Drawing.Point(21, 52);
            this.chkcBox.Name = "chkcBox";
            this.chkcBox.Size = new System.Drawing.Size(25, 14);
            this.chkcBox.TabIndex = 1;
            this.chkcBox.UseVisualStyleBackColor = true;
            // 
            // radbtn
            // 
            this.radbtn.AutoSize = true;
            this.radbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.radbtn.Location = new System.Drawing.Point(32, 3);
            this.radbtn.Name = "radbtn";
            this.radbtn.Size = new System.Drawing.Size(14, 43);
            this.radbtn.TabIndex = 1;
            // 
            // numUD
            // 
            this.numUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUD.Font = new System.Drawing.Font("Consolas", 12F);
            this.numUD.Location = new System.Drawing.Point(52, 11);
            this.numUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(264, 26);
            this.numUD.TabIndex = 0;
            this.numUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AnswerComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.table);
            this.Location = new System.Drawing.Point(22, 3);
            this.Name = "AnswerComponent";
            this.Size = new System.Drawing.Size(319, 69);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox chkcBox;
        private System.Windows.Forms.RadioButton radbtn;
        private System.Windows.Forms.NumericUpDown numUD;
    }
}
