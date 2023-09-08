using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordClass
    {
        static List<List<Point>> allVers = new();
        static List<Answer> answers = new List<Answer>();

        public static List<Answer> Find(ref char[,] Arr, List<string> Source) //ref нельзя в локальных функциях?
        {
            

            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    {
                        FindLocFunc(new List<Point>() { new Point(i,j)});
                    }
                }
            }

           
            answers.Add(new Answer { cost = 10, points = new List<Point>(), word = "прчк" });
            return answers;
        }

        public static  string ComposeWord(ref char[,] Arr, List<Point> lp)
        {
            StringBuilder sb = new StringBuilder(25);
            foreach (Point p in lp) sb.Append(Arr[p.Y, p.X]);
            return sb.ToString();
        }

        static void FindLocFunc(List<Point> lp)
        {
            allVers.Add(lp);
            if (Source.Contains(ComposeWord(Arr, lp)))
            {
                answers.Add(new Answer { word = ComposeWord(Arr, lp), cost = 0, points = lp });
            }

            Point lastPoint = lp.Last();
            if (lp.Count < 25)
            {
                if (lastPoint.X - 1 >= 0 && lastPoint.Y - 1 >= 0 && !lp.Contains(new Point(lastPoint.X - 1, lastPoint.Y - 1)))
                {
                    lp.Add(new Point(lastPoint.X - 1, lastPoint.Y - 1));
                    FindLocFunc(lp);
                }
                if (lastPoint.X - 1 >= 0 && !lp.Contains(new Point(lastPoint.X - 1, lastPoint.Y)))
                {
                    lp.Add(new Point(lastPoint.X - 1, lastPoint.Y));
                    FindLocFunc(lp);
                }

                if (lastPoint.X - 1 >= 0 && lastPoint.Y + 1 < cols && !lp.Contains(new Point(lastPoint.X - 1, lastPoint.Y + 1)))
                {
                    lp.Add(new Point(lastPoint.X - 1, lastPoint.Y + 1));
                    FindLocFunc(lp);
                }
                if (lastPoint.Y - 1 >= 0 && !lp.Contains(new Point(lastPoint.X, lastPoint.Y - 1)))
                {
                    lp.Add(new Point(lastPoint.X, lastPoint.Y - 1));
                    FindLocFunc(lp);
                }
                if (lastPoint.Y + 1 < rows && !lp.Contains(new Point(lastPoint.X, lastPoint.Y + 1)))
                {
                    lp.Add(new Point(lastPoint.X, lastPoint.Y + 1));
                    FindLocFunc(lp);
                }
                if (lastPoint.X + 1 < rows && lastPoint.Y - 1 >= 0 && !lp.Contains(new Point(lastPoint.X + 1, lastPoint.Y - 1)))
                {
                    lp.Add(new Point(lastPoint.X + 1, lastPoint.Y - 1));
                    FindLocFunc(lp);
                }
                if (lastPoint.X + 1 < rows && !lp.Contains(new Point(lastPoint.X + 1, lastPoint.Y)))
                {
                    lp.Add(new Point(lastPoint.X + 1, lastPoint.Y));
                    FindLocFunc(lp);
                }
                if (lastPoint.X + 1 < rows && lastPoint.Y + 1 < cols && !lp.Contains(new Point(lastPoint.X + 1, lastPoint.Y + 1)))
                {
                    lp.Add(new Point(lastPoint.X + 1, lastPoint.Y + 1));
                    FindLocFunc(lp);
                }
            }
        }



    }
}
