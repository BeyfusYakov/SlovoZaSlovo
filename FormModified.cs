﻿using System;
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
            HashSet<Answer> answersList = new HashSet<Answer>();
            List<string> StringList = new List<string>();
            string path = "russian_nouns.txt";
            int Rows = charArr.GetLength(0);
            int Cols = charArr.GetLength(1);
            var root = new TrieNode();
            Point[,] board = new Point[5,5];


            #region первый вариант

            ///
            /// оба варианта работают практически одинаково долго)
            ///
            //using StreamReader reader = new StreamReader(path);
            //while (!reader.EndOfStream)
            //{
            //    wordsList.Add(reader.ReadLine()); //В лист работает гораздо быстрее
            //}
            #endregion


            #region второй вариант 
            var myList = File.ReadAllLines(path);
            foreach (var item in myList)
            {
                root.Add(item, 0);
            }

            #endregion


            //удаление ненужных слов из словаря
            //StreamWriter f = new StreamWriter("test.txt");
            //foreach (string word in wordsList)
            //{
            //    if (!word.Contains ("-"))
            //    {
            //        f.WriteLine(word);
            //    }
            //}
            //f.Close();


            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        if (!string.IsNullOrEmpty((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text))
            //        {
            //            charArr[i, j] = new Point(i,j,Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text), (byte)((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Factor));
            //        }
            //    }
            //}

            for (int i = 0; i < Rows; i++)
            {
                //board[i] = new char[Rows];
                for (int j = 0; j < Cols; j++)
                {
                    if (!string.IsNullOrEmpty((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text))
                    {
                        //charArr[i, j] = new Point(i, j, Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text), (byte)((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Factor));
                        //board[i,j] = Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text);
                        board[i,j] = new Point(i, j, Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text), (byte)((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Factor));
                    }
                }
            }

            answersList = WordsClassTrie.FindWords(board, root);


            //Graph SlovoGraph = new Graph(charArr, FormAges.CreateEdges(charArr));
            //answerList = WordClass.Find(SlovoGraph, wordsList);

            //foreach (var p in SlovoGraph.GetPointsList(charArr[1,1]) )
            //{
            //    wordsListBox.Items.Add(p.ToString());
            //}



            //wordsListBox.Items.Add(charArr[0,0].Val == charArr[0, 1].Val);
            //List<Point> charArr2 = new List<Point>() { charArr[0, 0], charArr[0, 1], charArr[0, 2] };
            //List<Point> charArr3 = new List<Point>() { charArr[0, 0], charArr[0, 1], charArr[0, 2] };
            //wordsListBox.Items.Add(charArr2 == charArr3);
            // wordsListBox.Items.Add(charArr2.SequenceEqual(charArr3));


            ////////      

            //wordsListBox.Items.AddRange(answerList.ToArray());
            //for (int i = 0; i < answerList.Count; i++)
            //{
            //    wordsListBox.Items.Add(answerList.ElementAt(i).ToString());
            //}

            //wordsListBox.DataSource = answerList;
            answerList.Sort();
            wordsListBox.DataSource = answersList.ToList();
            label1.Text = StringList.Count.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            (letterPanel.Controls[$"slovoTextBox{1}{1}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{1}{2}"] as SlovoTextBox).Text = "Р";
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
            (letterPanel.Controls[$"slovoTextBox{5}{3}"] as SlovoTextBox).Text = "Н";
            (letterPanel.Controls[$"slovoTextBox{5}{4}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{5}{5}"] as SlovoTextBox).Text = "С";

        }
    }
}
