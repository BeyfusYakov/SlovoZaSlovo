namespace SlovoZaSlovo
{
    partial class FormModified
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
            this.szStextBox1 = new SlovoZaSlovo.SZStextBox();
            this.SuspendLayout();
            // 
            // szStextBox1
            // 
            this.szStextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.szStextBox1.BorderSize = 2;
            this.szStextBox1.Location = new System.Drawing.Point(21, 12);
            this.szStextBox1.Name = "szStextBox1";
            this.szStextBox1.Size = new System.Drawing.Size(41, 41);
            this.szStextBox1.TabIndex = 0;
            this.szStextBox1.UnderLine = false;
            // 
            // FormModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.szStextBox1);
            this.Name = "FormModified";
            this.Text = "FormModified";
            this.ResumeLayout(false);

        }

        #endregion

        private SZStextBox szStextBox1;
    }
}