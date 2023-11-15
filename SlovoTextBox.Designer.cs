using System.Drawing;
using System.Windows.Forms;

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
            UCPanel = new Panel();
            UClabel = new Label();
            UCtextBox = new TextBox();
            UCPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UCPanel
            // 
            UCPanel.BackColor = SystemColors.Window;
            UCPanel.BorderStyle = BorderStyle.FixedSingle;
            UCPanel.Controls.Add(UClabel);
            UCPanel.Controls.Add(UCtextBox);
            UCPanel.Dock = DockStyle.Fill;
            UCPanel.Location = new System.Drawing.Point(0, 0);
            UCPanel.Margin = new Padding(0);
            UCPanel.Name = "UCPanel";
            UCPanel.Size = new Size(80, 92);
            UCPanel.TabIndex = 2;
            UCPanel.Click += UC_Click;
            // 
            // UClabel
            // 
            UClabel.Anchor = AnchorStyles.Left;
            UClabel.AutoSize = true;
            UClabel.BackColor = SystemColors.Window;
            UClabel.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            UClabel.ForeColor = Color.CornflowerBlue;
            UClabel.Location = new System.Drawing.Point(1, 67);
            UClabel.Margin = new Padding(0);
            UClabel.Name = "UClabel";
            UClabel.Size = new Size(27, 17);
            UClabel.TabIndex = 1;
            UClabel.Text = "C0";
            UClabel.TextAlign = ContentAlignment.BottomLeft;
            UClabel.Click += UC_Click;
            // 
            // UCtextBox
            // 
            UCtextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UCtextBox.BorderStyle = BorderStyle.None;
            UCtextBox.CharacterCasing = CharacterCasing.Upper;
            UCtextBox.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            UCtextBox.Location = new System.Drawing.Point(1, 9);
            UCtextBox.Margin = new Padding(0);
            UCtextBox.MaxLength = 1;
            UCtextBox.Name = "UCtextBox";
            UCtextBox.Size = new Size(74, 53);
            UCtextBox.TabIndex = 0;
            UCtextBox.TextAlign = HorizontalAlignment.Center;
            //UCtextBox.Click += UC_Click;
            //UCtextBox.KeyUp += UC_KeyPress;
            UCtextBox.KeyPress += UC_KeyPress;
            UCtextBox.MouseWheel += UC_KeyWhell;
            UCtextBox.GotFocus += UCtextBox_GotFocus;
            // 
            // SlovoTextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UCPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SlovoTextBox";
            Size = new Size(80, 92);
            UCPanel.ResumeLayout(false);
            UCPanel.PerformLayout();
            ResumeLayout(false);
            
        }

        private void UCtextBox_GotFocus(object sender, System.EventArgs e)
        {
            //(sender as TextBox).SelectAll();
            // if (sender is TextBox)
            ((TextBox)sender).SelectAll();
        }

        #endregion

        private System.Windows.Forms.TextBox UCtextBox;
        private System.Windows.Forms.Label UClabel;
        private System.Windows.Forms.Panel UCPanel;

    }
}
