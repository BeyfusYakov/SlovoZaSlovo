﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordClass
    {
        public static List<Answer> Find(char[,] Arr, List<string> Source) //ref нельзя в локальных функциях?
        {
            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);

            List <Answer> answers = new List <Answer>();
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    {
                        FindLocFunc(new List<Point>() { new Point(i,j)});
                    }
                }
            }

            void FindLocFunc(List<Point> lp)
            {
                if (Source.Contains(ComposeWord(lp))  )
                {
                    answers.Add(new Answer { word = ComposeWord(lp), cost = 0, points = lp });
                }

                Point lastPoint = lp.Last();
                if (lp.Count<25)
                {
                    if(lastPoint.X-1 > 0 && lastPoint.Y-1>0)
                    {
                        lp.Add(new Point(lastPoint.X - 1, lastPoint.Y - 1));
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X - 1 > 0)
                    {
                        lp.Add(new Point(lastPoint.X - 1, lastPoint.Y));
                        FindLocFunc(lp);
                    }

                    if (lastPoint.X - 1 > 0 && lastPoint.Y + 1 < cols)
                    {
                        lp.Add(new Point(lastPoint.X - 1, lastPoint.Y + 1));
                        FindLocFunc(lp);
                    }
                    if (lastPoint.Y - 1 > 0)
                    {
                        lp.Add(new Point(lastPoint.X, lastPoint.Y - 1));
                        FindLocFunc(lp);
                    }
                    if (lastPoint.Y + 1 < rows)
                    {
                        lp.Add(new Point(lastPoint.X, lastPoint.Y + 1));
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X + 1 < rows && lastPoint.Y - 1 > 0)
                    {
                        lp.Add(new Point(lastPoint.X + 1, lastPoint.Y - 1));
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X + 1 < rows )
                    {
                        lp.Add(new Point(lastPoint.X + 1, lastPoint.Y));
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X + 1 < rows && lastPoint.Y + 1 < cols)
                    {
                        lp.Add(new Point(lastPoint.X + 1, lastPoint.Y + 1));
                        FindLocFunc(lp);
                    }
                }
            }

            string ComposeWord (List<Point> lp)
            {
                StringBuilder sb = new StringBuilder(25);
                foreach (Point p in lp) sb.Append(Arr[p.X,p.Y]);
                return sb.ToString();
            }




            answers.Add(new Answer { cost = 10, points = new List<Point>(), word = "алюляка" });
            return answers;
        }



    }
}
