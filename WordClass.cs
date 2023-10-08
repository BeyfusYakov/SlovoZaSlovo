using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordClass
    {
        public static List<List<Point>> VariantCollection = new(); // хранит все получившиеся варианты
        public static List<Answer> Answers = new List<Answer>();   //коллекция ответов
        public static List<Answer> Find(Graph slovoGraph, List<string> source)
        {
            Point[,] Arr = slovoGraph.Points;
            int Rows = Arr.GetLength(0);
            int Cols = Arr.GetLength(1);
            string ComposedWord;
            bool NotContainPoint;
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch composewatch = new Stopwatch();
            Stopwatch CloneAndAddWatch = new Stopwatch();
            Stopwatch ContainWatch = new Stopwatch();
            Stopwatch ContainPointWatch = new Stopwatch();
            Stopwatch GetPointsWatch = new Stopwatch();

            stopwatch.Start();
            
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    {
                        VariantCollection.Add(new List<Point> { Arr[i, j] });
                        //VariantCollection.Add(new List<Point> { Arr[0, 0] });
                        FindFunc(VariantCollection.Last());

                    }
                }
            }
            stopwatch.Stop();

            void FindFunc(List<Point> points)
            {
                GetPointsWatch.Start();
                var NextPointList = slovoGraph.GetPointsList(points.Last());
                GetPointsWatch.Stop();
                foreach (var NextPoint in NextPointList)
                {
                    ContainPointWatch.Start();
                    NotContainPoint = !VariantCollection.Last().Contains(NextPoint);
                    ContainPointWatch.Stop();
                    if (NotContainPoint)
                    {
                        CloneAndAddWatch.Start();
                        VariantCollection.Add(points.CloneAndAdd(NextPoint));
                        CloneAndAddWatch.Stop();
                        ComposedWord = ComposeWord(VariantCollection.Last());
                        ContainWatch.Start();

                        if (source.BinarySearch(ComposedWord) >= 0) 
                        {
                           Answers.Add(new Answer(ComposedWord, 0, VariantCollection.Last()));
                        }
                        ContainWatch.Stop();
                        FindFunc(VariantCollection.Last());
                        VariantCollection.RemoveAt(VariantCollection.Count - 1);
                    }
                }

            }

            string ComposeWord (List<Point> lp)
            {
                composewatch.Start();
                StringBuilder sb = new StringBuilder(25);
                foreach (Point p in lp) sb.Append(p.Val);
                composewatch.Stop();
                return sb.ToString();
                
            }




            //Засекаем производительность
            Answers.Add(new Answer(stopwatch.ElapsedMilliseconds.ToString() + " - общее время", 0, new List<Point>()));
            Answers.Add(new Answer(composewatch.ElapsedMilliseconds.ToString() + " composewatch", 0, new List<Point>()));
            Answers.Add(new Answer(CloneAndAddWatch.ElapsedMilliseconds.ToString() + " CloneAndAddWatch", 0, new List<Point>()));
            Answers.Add(new Answer(ContainWatch.ElapsedMilliseconds.ToString() + " ContainWatch", 0, new List<Point>()));
            Answers.Add(new Answer(ContainPointWatch.ElapsedMilliseconds.ToString() + " ContainPointWatch", 0, new List<Point>()));
            Answers.Add(new Answer(GetPointsWatch.ElapsedMilliseconds.ToString() + " GetPointsWatch", 0, new List<Point>())); 

            return Answers;
        }



    }
}
