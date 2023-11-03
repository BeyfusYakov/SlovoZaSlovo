using System.Windows.Forms;
using System;

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
            startButton = new Button();
            wordsListBox = new ListBox();
            letterPanel = new Panel();
            slovoTextBox55 = new SlovoTextBox();
            slovoTextBox51 = new SlovoTextBox();
            slovoTextBox54 = new SlovoTextBox();
            slovoTextBox53 = new SlovoTextBox();
            slovoTextBox52 = new SlovoTextBox();
            slovoTextBox45 = new SlovoTextBox();
            slovoTextBox41 = new SlovoTextBox();
            slovoTextBox44 = new SlovoTextBox();
            slovoTextBox43 = new SlovoTextBox();
            slovoTextBox42 = new SlovoTextBox();
            slovoTextBox35 = new SlovoTextBox();
            slovoTextBox31 = new SlovoTextBox();
            slovoTextBox34 = new SlovoTextBox();
            slovoTextBox33 = new SlovoTextBox();
            slovoTextBox32 = new SlovoTextBox();
            slovoTextBox25 = new SlovoTextBox();
            slovoTextBox21 = new SlovoTextBox();
            slovoTextBox24 = new SlovoTextBox();
            slovoTextBox23 = new SlovoTextBox();
            slovoTextBox22 = new SlovoTextBox();
            slovoTextBox15 = new SlovoTextBox();
            slovoTextBox11 = new SlovoTextBox();
            slovoTextBox14 = new SlovoTextBox();
            slovoTextBox13 = new SlovoTextBox();
            slovoTextBox12 = new SlovoTextBox();
            button1 = new Button();
            label1 = new Label();
            ClearButton = new Button();
            letterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new System.Drawing.Point(217, 549);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(245, 65);
            startButton.TabIndex = 2;
            startButton.Text = "СТАРТ";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // wordsListBox
            // 
            wordsListBox.FormattingEnabled = true;
            wordsListBox.ItemHeight = 20;
            wordsListBox.Location = new System.Drawing.Point(479, 31);
            wordsListBox.Margin = new Padding(4, 5, 4, 5);
            wordsListBox.Name = "wordsListBox";
            wordsListBox.Size = new System.Drawing.Size(571, 584);
            wordsListBox.TabIndex = 3;
            wordsListBox.SelectedIndexChanged += WordsListBox_SelectedIndexChanged;
            // 
            // letterPanel
            // 
            letterPanel.Controls.Add(slovoTextBox55);
            letterPanel.Controls.Add(slovoTextBox51);
            letterPanel.Controls.Add(slovoTextBox54);
            letterPanel.Controls.Add(slovoTextBox53);
            letterPanel.Controls.Add(slovoTextBox52);
            letterPanel.Controls.Add(slovoTextBox45);
            letterPanel.Controls.Add(slovoTextBox41);
            letterPanel.Controls.Add(slovoTextBox44);
            letterPanel.Controls.Add(slovoTextBox43);
            letterPanel.Controls.Add(slovoTextBox42);
            letterPanel.Controls.Add(slovoTextBox35);
            letterPanel.Controls.Add(slovoTextBox31);
            letterPanel.Controls.Add(slovoTextBox34);
            letterPanel.Controls.Add(slovoTextBox33);
            letterPanel.Controls.Add(slovoTextBox32);
            letterPanel.Controls.Add(slovoTextBox25);
            letterPanel.Controls.Add(slovoTextBox21);
            letterPanel.Controls.Add(slovoTextBox24);
            letterPanel.Controls.Add(slovoTextBox23);
            letterPanel.Controls.Add(slovoTextBox22);
            letterPanel.Controls.Add(slovoTextBox15);
            letterPanel.Controls.Add(slovoTextBox11);
            letterPanel.Controls.Add(slovoTextBox14);
            letterPanel.Controls.Add(slovoTextBox13);
            letterPanel.Controls.Add(slovoTextBox12);
            letterPanel.Location = new System.Drawing.Point(16, 19);
            letterPanel.Margin = new Padding(4, 5, 4, 5);
            letterPanel.Name = "letterPanel";
            letterPanel.Size = new System.Drawing.Size(455, 521);
            letterPanel.TabIndex = 1;
            // 
            // slovoTextBox55
            // 
            slovoTextBox55.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox55.Location = new System.Drawing.Point(365, 418);
            slovoTextBox55.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox55.Name = "slovoTextBox55";
            slovoTextBox55.Size = new System.Drawing.Size(80, 92);
            slovoTextBox55.TabIndex = 50;
            // 
            // slovoTextBox51
            // 
            slovoTextBox51.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox51.Location = new System.Drawing.Point(12, 418);
            slovoTextBox51.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox51.Name = "slovoTextBox51";
            slovoTextBox51.Size = new System.Drawing.Size(80, 92);
            slovoTextBox51.TabIndex = 46;
            // 
            // slovoTextBox54
            // 
            slovoTextBox54.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox54.Location = new System.Drawing.Point(276, 418);
            slovoTextBox54.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox54.Name = "slovoTextBox54";
            slovoTextBox54.Size = new System.Drawing.Size(80, 92);
            slovoTextBox54.TabIndex = 49;
            // 
            // slovoTextBox53
            // 
            slovoTextBox53.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox53.Location = new System.Drawing.Point(188, 418);
            slovoTextBox53.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox53.Name = "slovoTextBox53";
            slovoTextBox53.Size = new System.Drawing.Size(80, 92);
            slovoTextBox53.TabIndex = 48;
            // 
            // slovoTextBox52
            // 
            slovoTextBox52.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox52.Location = new System.Drawing.Point(100, 418);
            slovoTextBox52.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox52.Name = "slovoTextBox52";
            slovoTextBox52.Size = new System.Drawing.Size(80, 92);
            slovoTextBox52.TabIndex = 47;
            // 
            // slovoTextBox45
            // 
            slovoTextBox45.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox45.Location = new System.Drawing.Point(365, 315);
            slovoTextBox45.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox45.Name = "slovoTextBox45";
            slovoTextBox45.Size = new System.Drawing.Size(80, 92);
            slovoTextBox45.TabIndex = 45;
            // 
            // slovoTextBox41
            // 
            slovoTextBox41.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox41.Location = new System.Drawing.Point(12, 315);
            slovoTextBox41.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox41.Name = "slovoTextBox41";
            slovoTextBox41.Size = new System.Drawing.Size(80, 92);
            slovoTextBox41.TabIndex = 41;
            // 
            // slovoTextBox44
            // 
            slovoTextBox44.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox44.Location = new System.Drawing.Point(276, 317);
            slovoTextBox44.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox44.Name = "slovoTextBox44";
            slovoTextBox44.Size = new System.Drawing.Size(80, 92);
            slovoTextBox44.TabIndex = 44;
            // 
            // slovoTextBox43
            // 
            slovoTextBox43.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox43.Location = new System.Drawing.Point(188, 317);
            slovoTextBox43.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox43.Name = "slovoTextBox43";
            slovoTextBox43.Size = new System.Drawing.Size(80, 92);
            slovoTextBox43.TabIndex = 43;
            // 
            // slovoTextBox42
            // 
            slovoTextBox42.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox42.Location = new System.Drawing.Point(100, 315);
            slovoTextBox42.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox42.Name = "slovoTextBox42";
            slovoTextBox42.Size = new System.Drawing.Size(80, 92);
            slovoTextBox42.TabIndex = 42;
            // 
            // slovoTextBox35
            // 
            slovoTextBox35.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox35.Location = new System.Drawing.Point(365, 214);
            slovoTextBox35.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox35.Name = "slovoTextBox35";
            slovoTextBox35.Size = new System.Drawing.Size(80, 92);
            slovoTextBox35.TabIndex = 40;
            // 
            // slovoTextBox31
            // 
            slovoTextBox31.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox31.Location = new System.Drawing.Point(12, 214);
            slovoTextBox31.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox31.Name = "slovoTextBox31";
            slovoTextBox31.Size = new System.Drawing.Size(80, 92);
            slovoTextBox31.TabIndex = 36;
            // 
            // slovoTextBox34
            // 
            slovoTextBox34.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox34.Location = new System.Drawing.Point(276, 215);
            slovoTextBox34.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox34.Name = "slovoTextBox34";
            slovoTextBox34.Size = new System.Drawing.Size(80, 92);
            slovoTextBox34.TabIndex = 39;
            // 
            // slovoTextBox33
            // 
            slovoTextBox33.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox33.Location = new System.Drawing.Point(188, 215);
            slovoTextBox33.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox33.Name = "slovoTextBox33";
            slovoTextBox33.Size = new System.Drawing.Size(80, 92);
            slovoTextBox33.TabIndex = 38;
            // 
            // slovoTextBox32
            // 
            slovoTextBox32.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox32.Location = new System.Drawing.Point(100, 214);
            slovoTextBox32.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox32.Name = "slovoTextBox32";
            slovoTextBox32.Size = new System.Drawing.Size(80, 92);
            slovoTextBox32.TabIndex = 37;
            // 
            // slovoTextBox25
            // 
            slovoTextBox25.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox25.Location = new System.Drawing.Point(365, 112);
            slovoTextBox25.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox25.Name = "slovoTextBox25";
            slovoTextBox25.Size = new System.Drawing.Size(80, 92);
            slovoTextBox25.TabIndex = 35;
            // 
            // slovoTextBox21
            // 
            slovoTextBox21.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox21.Location = new System.Drawing.Point(12, 112);
            slovoTextBox21.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox21.Name = "slovoTextBox21";
            slovoTextBox21.Size = new System.Drawing.Size(80, 92);
            slovoTextBox21.TabIndex = 31;
            // 
            // slovoTextBox24
            // 
            slovoTextBox24.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox24.Location = new System.Drawing.Point(276, 114);
            slovoTextBox24.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox24.Name = "slovoTextBox24";
            slovoTextBox24.Size = new System.Drawing.Size(80, 92);
            slovoTextBox24.TabIndex = 34;
            // 
            // slovoTextBox23
            // 
            slovoTextBox23.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox23.Location = new System.Drawing.Point(188, 114);
            slovoTextBox23.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox23.Name = "slovoTextBox23";
            slovoTextBox23.Size = new System.Drawing.Size(80, 92);
            slovoTextBox23.TabIndex = 33;
            // 
            // slovoTextBox22
            // 
            slovoTextBox22.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox22.Location = new System.Drawing.Point(100, 112);
            slovoTextBox22.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox22.Name = "slovoTextBox22";
            slovoTextBox22.Size = new System.Drawing.Size(80, 92);
            slovoTextBox22.TabIndex = 32;
            // 
            // slovoTextBox15
            // 
            slovoTextBox15.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox15.Location = new System.Drawing.Point(365, 11);
            slovoTextBox15.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox15.Name = "slovoTextBox15";
            slovoTextBox15.Size = new System.Drawing.Size(80, 92);
            slovoTextBox15.TabIndex = 30;
            // 
            // slovoTextBox11
            // 
            slovoTextBox11.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox11.Location = new System.Drawing.Point(12, 11);
            slovoTextBox11.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox11.Name = "slovoTextBox11";
            slovoTextBox11.Size = new System.Drawing.Size(80, 92);
            slovoTextBox11.TabIndex = 0;
            // 
            // slovoTextBox14
            // 
            slovoTextBox14.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox14.Location = new System.Drawing.Point(276, 12);
            slovoTextBox14.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox14.Name = "slovoTextBox14";
            slovoTextBox14.Size = new System.Drawing.Size(80, 92);
            slovoTextBox14.TabIndex = 29;
            // 
            // slovoTextBox13
            // 
            slovoTextBox13.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox13.Location = new System.Drawing.Point(188, 12);
            slovoTextBox13.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox13.Name = "slovoTextBox13";
            slovoTextBox13.Size = new System.Drawing.Size(80, 92);
            slovoTextBox13.TabIndex = 28;
            // 
            // slovoTextBox12
            // 
            slovoTextBox12.Factor = SlovoTextBox.FactorValue.None;
            slovoTextBox12.Location = new System.Drawing.Point(100, 11);
            slovoTextBox12.Margin = new Padding(5, 6, 5, 6);
            slovoTextBox12.Name = "slovoTextBox12";
            slovoTextBox12.Size = new System.Drawing.Size(80, 92);
            slovoTextBox12.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(17, 551);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(92, 62);
            button1.TabIndex = 49;
            button1.Text = "Заполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(479, 622);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 50;
            label1.Text = "label1";
            // 
            // ClearButton
            // 
            ClearButton.Location = new System.Drawing.Point(116, 551);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new System.Drawing.Size(94, 62);
            ClearButton.TabIndex = 51;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // FormModified
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1067, 692);
            Controls.Add(ClearButton);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(letterPanel);
            Controls.Add(wordsListBox);
            Controls.Add(startButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormModified";
            Text = "FormModified";
            letterPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.Panel letterPanel;
        private SlovoTextBox slovoTextBox55;
        private SlovoTextBox slovoTextBox51;
        private SlovoTextBox slovoTextBox54;
        private SlovoTextBox slovoTextBox53;
        private SlovoTextBox slovoTextBox52;
        private SlovoTextBox slovoTextBox45;
        private SlovoTextBox slovoTextBox41;
        private SlovoTextBox slovoTextBox44;
        private SlovoTextBox slovoTextBox43;
        private SlovoTextBox slovoTextBox42;
        private SlovoTextBox slovoTextBox35;
        private SlovoTextBox slovoTextBox31;
        private SlovoTextBox slovoTextBox34;
        private SlovoTextBox slovoTextBox33;
        private SlovoTextBox slovoTextBox32;
        private SlovoTextBox slovoTextBox25;
        private SlovoTextBox slovoTextBox21;
        private SlovoTextBox slovoTextBox24;
        private SlovoTextBox slovoTextBox23;
        private SlovoTextBox slovoTextBox22;
        private SlovoTextBox slovoTextBox15;
        private SlovoTextBox slovoTextBox11;
        private SlovoTextBox slovoTextBox14;
        private SlovoTextBox slovoTextBox13;
        private SlovoTextBox slovoTextBox12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Button ClearButton;
    }
}