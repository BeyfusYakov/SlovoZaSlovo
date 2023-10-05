using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlovoZaSlovo
{
    internal static class WordClass
    {
        public static List<List<Point>> VariantCollection = new(); // хранит все получившиеся варианты
        public static List<List<Point>> VariantList = new(); //использую для хранения обрабатываемых элементов, для добавления к ним по одной букве
        public static List<Answer> Answers = new List<Answer>(); //коллекция ответов
        public static List<Answer> Find(Graph slovoGraph, List<string> source)
        {
            Point[,] Arr = slovoGraph.Points;
            int rows = Arr.GetLength(0);
            int cols = Arr.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    {
                        //FindLocFunc(new List<Point>() { Arr[i,j] });
                        //VariantList.Add(new List<Point> { Arr[i, j] });
                        //FindFunc(VariantList);
                        VariantCollection.Add(new List<Point> { Arr[i, j] });
                        FindFunc(VariantCollection.Last());
                    }
                }
            }
            Answers.Add(new Answer("кпст", 10, new List<Point>()));

            void FindFunc(List<Point> points)
            {
                var NextPointList = slovoGraph.GetPointsList(points.Last());
                foreach (var NextPoint in NextPointList)
                {
                    if (!VariantCollection.Last().Contains(NextPoint))
                    {
                        VariantCollection.Add(points.CloneAndAdd(NextPoint));
                        if (source.Contains( ComposeWord(VariantCollection.Last())) )
                        { Answers.Add(new Answer(ComposeWord(VariantCollection.Last()), 0, VariantCollection.Last())); }
                        FindFunc(VariantCollection.Last());
                    }
                }

            }

            void FindLocFunc(List<Point> lp)
            {
                Stack<Point> stack = new Stack<Point>();
                stack.Push(lp[0]);

                if (source.Contains(ComposeWord(lp))  )
                {
                    Answers.Add(new Answer (ComposeWord(lp), 0, lp));
                }

                //variantCollection.Add(lp.CLone());
                //lp.RemoveAt(lp.Count - 1);

                Point lastPoint = lp.Last();
                if (lp.Count < 25)
                { 

                }
                
                
            }

            string ComposeWord (List<Point> lp)
            {
                StringBuilder sb = new StringBuilder(25);
                foreach (Point p in lp) sb.Append(p.Val);
                return sb.ToString();
            }





            Answers.Add(new Answer("прчк", 10, new List<Point>()));
            return Answers;
        }



    }
}
