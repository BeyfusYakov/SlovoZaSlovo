using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SlovoZaSlovo
{
    public partial class FormModified : Form
    {
        public FormModified()
        {
            InitializeComponent();
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            char[,,] charArr  = new char[5,5,2];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!string.IsNullOrEmpty((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).UCtextBox.Text))
                        charArr[i, j, 0] = Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).UCtextBox.Text);
                        charArr[i, j, 1] = Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Factor);
                }
            }

            //wordsListBox.Items.Add(slovoTextBox14.Text);

            string path = "russian_nouns.txt";
            //string data;


            #region первый вариант
            //var myList = File.ReadAllLines(path);
            //foreach (var item in myList)
            //{
            //    wordsListBox.Items.Add(item);
            //}
            #endregion


            #region второй вариант 
            ///
            /// оба варианта работают практически одинаково долго)
            ///
            using (StreamReader reader = new StreamReader(path))
            {
                //List<string> myList = new List<string>();
                while (!reader.EndOfStream)
                {
                    //myList.Add(reader.ReadLine()); //В лист работает гораздо быстрее
                    wordsListBox.Items.Add(reader.ReadLine());
                }
            }
            #endregion

        }
    }
}
