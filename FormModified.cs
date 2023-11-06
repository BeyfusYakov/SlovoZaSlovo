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
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.Globalization;


namespace SlovoZaSlovo
{
    public partial class FormModified : Form
    {
        List<Answer> answerList = new List<Answer>();

        public FormModified()
        {
            InitializeComponent();
        }

        void WordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedItem = wordsListBox.SelectedItem.ToString();
            int indexOfAnswer = wordsListBox.SelectedIndex;
            //MessageBox.Show(answerList[indexOfAnswer].Word);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    {
                        (letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Highlight = false;
                    }
                }
            }


            foreach (var p in answerList[indexOfAnswer].Points)
            {
                (letterPanel.Controls[$"slovoTextBox{p.X + 1}{p.Y + 1}"] as SlovoTextBox).Highlight = true;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    {
                        (letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Refresh();
                    }
                }
            }

        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            Point[,] charArr = new Point[5, 5];
            HashSet<Answer> answersHashSet = new HashSet<Answer>();
            //List<string> StringList = new List<string>();
            //string path_nouns = "russian_nouns.txt";
            //string path_verbs = "russian_verbs.txt";
            string path_adject = "russian_adject.txt";
            //string[] paths = new string[3] { "russian_nouns.txt", "russian_verbs.txt", "russian_adject.txt" };
            string[] paths = new string[1] { "russian_nouns.txt"};
            int Rows = charArr.GetLength(0);
            int Cols = charArr.GetLength(1);
            var root = new TrieNode();
            Point[,] board = new Point[5, 5];


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
            string appPath = Application.StartupPath;


            //var files = Directory.EnumerateFiles(appPath, "russian*.txt");
            //var filesContent = files.Select(filePath => File.ReadAllLines(filePath));


            foreach (string path in paths)
            {
                var myList = File.ReadAllLines(path);
                foreach (var item in myList)
                {
                    root.Add(item, 0);
                }
            }

            #endregion


            #region удаление ненужных слов из словаря

            //StreamWriter f = new StreamWriter(path_adject + "out-.txt");
            //foreach (string word in myList)
            //{
            //    if (!word.Contains("-"))
            //    {
            //        f.WriteLine(word);
            //    }
            //}
            //f.Close();

            #endregion

            for (int i = 0; i < Rows; i++)
            {
                //board[i] = new char[Rows];
                for (int j = 0; j < Cols; j++)
                {
                    if (!string.IsNullOrEmpty((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text))
                    {
                        //charArr[i, j] = new Point(i, j, Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text), (byte)((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Factor));
                        //board[i,j] = Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text);
                        board[i, j] = new Point(i, j, Convert.ToChar((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Text), (byte)((letterPanel.Controls[$"slovoTextBox{i + 1}{j + 1}"] as SlovoTextBox).Factor));
                    }
                }
            }

            //answersHashSet = WordsClassTrie.FindWords(board, root);
            answerList = WordsClassTrie.FindWords(board, root).OrderByDescending(x => x.Cost).ToList();
            wordsListBox.DataSource = answerList;
            label1.Text = answerList.Count.ToString();
            wordsListBox.Focus();

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
            (letterPanel.Controls[$"slovoTextBox{2}{3}"] as SlovoTextBox).Text = "М";
            (letterPanel.Controls[$"slovoTextBox{2}{4}"] as SlovoTextBox).Text = "Ы";
            (letterPanel.Controls[$"slovoTextBox{2}{5}"] as SlovoTextBox).Text = "Й";

            (letterPanel.Controls[$"slovoTextBox{3}{1}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{3}{2}"] as SlovoTextBox).Text = "К";
            (letterPanel.Controls[$"slovoTextBox{3}{3}"] as SlovoTextBox).Text = "У";
            (letterPanel.Controls[$"slovoTextBox{3}{4}"] as SlovoTextBox).Text = "Л";
            (letterPanel.Controls[$"slovoTextBox{3}{5}"] as SlovoTextBox).Text = "А";

            (letterPanel.Controls[$"slovoTextBox{4}{1}"] as SlovoTextBox).Text = "К";
            (letterPanel.Controls[$"slovoTextBox{4}{2}"] as SlovoTextBox).Text = "У";
            (letterPanel.Controls[$"slovoTextBox{4}{3}"] as SlovoTextBox).Text = "П";
            (letterPanel.Controls[$"slovoTextBox{4}{4}"] as SlovoTextBox).Text = "И";
            (letterPanel.Controls[$"slovoTextBox{4}{5}"] as SlovoTextBox).Text = "Т";

            (letterPanel.Controls[$"slovoTextBox{5}{1}"] as SlovoTextBox).Text = "Б";
            (letterPanel.Controls[$"slovoTextBox{5}{2}"] as SlovoTextBox).Text = "О";
            (letterPanel.Controls[$"slovoTextBox{5}{3}"] as SlovoTextBox).Text = "Н";
            (letterPanel.Controls[$"slovoTextBox{5}{4}"] as SlovoTextBox).Text = "А";
            (letterPanel.Controls[$"slovoTextBox{5}{5}"] as SlovoTextBox).Text = "Ь";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach(Control control in letterPanel.Controls)
            {
                control.Text = string.Empty;
            }
            //wordsListBox.DataSource = null; ;
            //letterPanel.ResumeLayout();

            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        }

        private void FormModified_Load(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
        }
    }
}
