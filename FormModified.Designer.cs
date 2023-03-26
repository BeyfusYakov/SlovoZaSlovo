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
            this.slovoTextBox1 = new SlovoZaSlovo.SlovoTextBox();
            this.slovoTextBox2 = new SlovoZaSlovo.SlovoTextBox();
            this.slovoTextBox3 = new SlovoZaSlovo.SlovoTextBox();
            this.slovoTextBox4 = new SlovoZaSlovo.SlovoTextBox();
            this.slovoTextBox5 = new SlovoZaSlovo.SlovoTextBox();
            this.SuspendLayout();
            // 
            // slovoTextBox1
            // 
            this.slovoTextBox1.Factor = SlovoZaSlovo.SlovoTextBox.FactorValue.None;
            this.slovoTextBox1.Location = new System.Drawing.Point(12, 12);
            this.slovoTextBox1.Name = "slovoTextBox1";
            this.slovoTextBox1.Size = new System.Drawing.Size(60, 60);
            this.slovoTextBox1.TabIndex = 0;
            // 
            // slovoTextBox2
            // 
            this.slovoTextBox2.Factor = SlovoZaSlovo.SlovoTextBox.FactorValue.None;
            this.slovoTextBox2.Location = new System.Drawing.Point(78, 12);
            this.slovoTextBox2.Name = "slovoTextBox2";
            this.slovoTextBox2.Size = new System.Drawing.Size(60, 60);
            this.slovoTextBox2.TabIndex = 1;
            // 
            // slovoTextBox3
            // 
            this.slovoTextBox3.Factor = SlovoZaSlovo.SlovoTextBox.FactorValue.None;
            this.slovoTextBox3.Location = new System.Drawing.Point(144, 12);
            this.slovoTextBox3.Name = "slovoTextBox3";
            this.slovoTextBox3.Size = new System.Drawing.Size(60, 60);
            this.slovoTextBox3.TabIndex = 2;
            // 
            // slovoTextBox4
            // 
            this.slovoTextBox4.Factor = SlovoZaSlovo.SlovoTextBox.FactorValue.None;
            this.slovoTextBox4.Location = new System.Drawing.Point(210, 12);
            this.slovoTextBox4.Name = "slovoTextBox4";
            this.slovoTextBox4.Size = new System.Drawing.Size(60, 60);
            this.slovoTextBox4.TabIndex = 3;
            // 
            // slovoTextBox5
            // 
            this.slovoTextBox5.Factor = SlovoZaSlovo.SlovoTextBox.FactorValue.None;
            this.slovoTextBox5.Location = new System.Drawing.Point(276, 12);
            this.slovoTextBox5.Name = "slovoTextBox5";
            this.slovoTextBox5.Size = new System.Drawing.Size(60, 60);
            this.slovoTextBox5.TabIndex = 4;
            // 
            // FormModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slovoTextBox5);
            this.Controls.Add(this.slovoTextBox4);
            this.Controls.Add(this.slovoTextBox3);
            this.Controls.Add(this.slovoTextBox2);
            this.Controls.Add(this.slovoTextBox1);
            this.Name = "FormModified";
            this.Text = "FormModified";
            this.ResumeLayout(false);

        }

        #endregion

        private SlovoTextBox slovoTextBox1;
        private SlovoTextBox slovoTextBox2;
        private SlovoTextBox slovoTextBox3;
        private SlovoTextBox slovoTextBox4;
        private SlovoTextBox slovoTextBox5;
    }
}