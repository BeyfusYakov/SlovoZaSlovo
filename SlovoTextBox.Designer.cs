namespace SlovoZaSlovo
{
    partial class SlovoTextBox
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
            this.UCPanel = new System.Windows.Forms.Panel();
            this.UClabel = new System.Windows.Forms.Label();
            this.UCtextBox = new System.Windows.Forms.TextBox();
            this.UCPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UCPanel
            // 
            this.UCPanel.BackColor = System.Drawing.SystemColors.Window;
            this.UCPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UCPanel.Controls.Add(this.UClabel);
            this.UCPanel.Controls.Add(this.UCtextBox);
            this.UCPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCPanel.Location = new System.Drawing.Point(0, 0);
            this.UCPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UCPanel.Name = "UCPanel";
            this.UCPanel.Size = new System.Drawing.Size(60, 60);
            this.UCPanel.TabIndex = 2;
            // 
            // UClabel
            // 
            this.UClabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UClabel.AutoSize = true;
            this.UClabel.BackColor = System.Drawing.SystemColors.Window;
            this.UClabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UClabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.UClabel.Location = new System.Drawing.Point(0, 43);
            this.UClabel.Margin = new System.Windows.Forms.Padding(0);
            this.UClabel.Name = "UClabel";
            this.UClabel.Size = new System.Drawing.Size(22, 13);
            this.UClabel.TabIndex = 1;
            this.UClabel.Text = "C0";
            this.UClabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UClabel.Click += new System.EventHandler(this.UClabel_Click);
            // 
            // UCtextBox
            // 
            this.UCtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UCtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UCtextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UCtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UCtextBox.Location = new System.Drawing.Point(0, 6);
            this.UCtextBox.Margin = new System.Windows.Forms.Padding(0);
            this.UCtextBox.MaxLength = 1;
            this.UCtextBox.Name = "UCtextBox";
            this.UCtextBox.Size = new System.Drawing.Size(59, 43);
            this.UCtextBox.TabIndex = 0;
            this.UCtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UCtextBox.Click += new System.EventHandler(this.UCtextBox_Click);
            // 
            // SlovoTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UCPanel);
            this.Name = "SlovoTextBox";
            this.Size = new System.Drawing.Size(60, 60);
            this.UCPanel.ResumeLayout(false);
            this.UCPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UCtextBox;
        private System.Windows.Forms.Label UClabel;
        private System.Windows.Forms.Panel UCPanel;
    }
}
