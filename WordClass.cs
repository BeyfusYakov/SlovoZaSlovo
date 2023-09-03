using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordClass
    {
        public static List<List<Point>> variantCollection = new();
        public static List<Answer> Find(Point[,] Arr, List<string> Source)
        {
            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);

            List <Answer> answers = new List <Answer>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    {
                        FindLocFunc(new List<Point>() { Arr[i,j] });
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
                if (lp.Count < 25)
                {
                    if (lastPoint.X - 1 >= 0 && lastPoint.Y - 1 >= 0 && !lp.Contains(Arr[lastPoint.X - 1, lastPoint.Y - 1]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X - 1, lastPoint.Y - 1]);
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X - 1 >= 0 && !lp.Contains(Arr[lastPoint.X - 1, lastPoint.Y]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X - 1, lastPoint.Y]);
                        FindLocFunc(lp);
                    }

                    if (lastPoint.X - 1 >= 0 && lastPoint.Y + 1 < cols && !lp.Contains(Arr[lastPoint.X - 1, lastPoint.Y + 1]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X - 1, lastPoint.Y + 1]);
                        FindLocFunc(lp);
                    }
                    if (lastPoint.Y - 1 >= 0 && !lp.Contains(Arr[lastPoint.X, lastPoint.Y - 1]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X, lastPoint.Y - 1]);
                        FindLocFunc(lp);
                    }
                    if (lastPoint.Y + 1 < rows && !lp.Contains(Arr[lastPoint.X, lastPoint.Y + 1]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X, lastPoint.Y + 1]);
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X + 1 < rows && lastPoint.Y - 1 >= 0 && !lp.Contains(Arr[lastPoint.X + 1, lastPoint.Y - 1]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X + 1, lastPoint.Y - 1]);
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X + 1 < rows && !lp.Contains(Arr[lastPoint.X + 1, lastPoint.Y]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X + 1, lastPoint.Y]);
                        FindLocFunc(lp);
                    }
                    if (lastPoint.X + 1 < rows && lastPoint.Y + 1 < cols && !lp.Contains(Arr[lastPoint.X + 1, lastPoint.Y + 1]) && !variantCollection.Any(x => x.SequenceEqual(lp)))
                    {
                        lp.Add(Arr[lastPoint.X + 1, lastPoint.Y + 1]);
                        FindLocFunc(lp);
                    }
                }
                variantCollection.Add(lp);
            }

            string ComposeWord (List<Point> lp)
            {
                StringBuilder sb = new StringBuilder(25);
                foreach (Point p in lp) sb.Append(p.Val);
                return sb.ToString();
            }




            answers.Add(new Answer { cost = 10, points = new List<Point>(), word = "прчк" });
            return answers;
        }



    }
}
