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
            Point[,] charArr  = new Point[5,5];
            List<Answer> answerList = new List<Answer>();
            List<string> wordsList = new List<string>();
            string path = "russian_nouns.txt";


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
            using StreamReader reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                wordsList.Add(reader.ReadLine()); //В лист работает гораздо быстрее
                //wordsListBox.Items.Add(reader.ReadLine());
            }
            #endregion


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (!string.IsNullOrEmpty((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text))
                    {
                        charArr[i, j] = new Point(i,j,Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text), (byte)((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Factor));
                    }
                }
            }



            //wordsListBox.Items.Add(charArr[0,0].Val == charArr[0, 1].Val);
            //List<Point> charArr2 = new List<Point>() { charArr[0, 0], charArr[0, 1], charArr[0, 2] };
            //List<Point> charArr3 = new List<Point>() { charArr[0, 0], charArr[0, 1], charArr[0, 2] };
            //wordsListBox.Items.Add(charArr2 == charArr3);
            // wordsListBox.Items.Add(charArr2.SequenceEqual(charArr3));
            
            
            answerList = WordClass.Find(charArr, wordsList);

            //wordsListBox.Items.AddRange(answerList.ToArray());
            for (int i = 0; i < answerList.Count; i++)
            {
                wordsListBox.Items.Add(answerList.ElementAt(i).word +" - " +answerList.ElementAt(i).cost);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            (letterPanel.Controls[$"slovoTextBox{1}{1}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{1}{2}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{1}{3}"] as SlovoTextBox).Text = "Б";
            (letterPanel.Controls[$"slovoTextBox{1}{4}"] as SlovoTextBox).Text = "У";
            (letterPanel.Controls[$"slovoTextBox{1}{5}"] as SlovoTextBox).Text = "З";

            (letterPanel.Controls[$"slovoTextBox{2}{1}"] as SlovoTextBox).Text = "З";
            (letterPanel.Controls[$"slovoTextBox{2}{2}"] as SlovoTextBox).Text = "И";
            (letterPanel.Controls[$"slovoTextBox{2}{3}"] as SlovoTextBox).Text = "П";
            (letterPanel.Controls[$"slovoTextBox{2}{4}"] as SlovoTextBox).Text = "У";
            (letterPanel.Controls[$"slovoTextBox{2}{5}"] as SlovoTextBox).Text = "Н";

            (letterPanel.Controls[$"slovoTextBox{3}{1}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{3}{2}"] as SlovoTextBox).Text = "К";
            (letterPanel.Controls[$"slovoTextBox{3}{3}"] as SlovoTextBox).Text = "У";
            (letterPanel.Controls[$"slovoTextBox{3}{4}"] as SlovoTextBox).Text = "Л";
            (letterPanel.Controls[$"slovoTextBox{3}{5}"] as SlovoTextBox).Text = "А";

            (letterPanel.Controls[$"slovoTextBox{4}{1}"] as SlovoTextBox).Text = "К";
            (letterPanel.Controls[$"slovoTextBox{4}{2}"] as SlovoTextBox).Text = "Р";
            (letterPanel.Controls[$"slovoTextBox{4}{3}"] as SlovoTextBox).Text = "У";
            (letterPanel.Controls[$"slovoTextBox{4}{4}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{4}{5}"] as SlovoTextBox).Text = "С";

            (letterPanel.Controls[$"slovoTextBox{5}{1}"] as SlovoTextBox).Text = "Б";
            (letterPanel.Controls[$"slovoTextBox{5}{2}"] as SlovoTextBox).Text = "О";
            (letterPanel.Controls[$"slovoTextBox{5}{3}"] as SlovoTextBox).Text = "Т";
            (letterPanel.Controls[$"slovoTextBox{5}{4}"] as SlovoTextBox).Text = "Н";
            (letterPanel.Controls[$"slovoTextBox{5}{5}"] as SlovoTextBox).Text = "А";

        }
    }
}
