using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingConsoleApplication
{
    public static class MergeSort
    {
        public static int[] Sort(int[] input)
        {
            if (input == null || input.Length <= 1)
                return input;

            int middle = input.Length / 2;

            int[] left = Sort(input.Take(middle).ToArray());
            int[] right = Sort(input.Skip(middle).Take(input.Count() - middle).ToArray());

            return Merge(left, right);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> output = new List<int>();
            List<int> l = new List<int>(left);
            List<int> r = new List<int>(right);

            while (l.Count() > 0 || r.Count() > 0)
            {
                if (l.Count() > 0 && r.Count() > 0)
                {
                    if (l.First<int>() <= r.First<int>())
                    {
                        output.Add(l.First<int>());
                        l.RemoveAt(0);
                    }
                    else
                    {
                        output.Add(r.First<int>());
                        r.RemoveAt(0);
                    }
                }
                else if (l.Count() > 0)
                {
                    output.Add(l.First<int>());
                    l.RemoveAt(0);
                }
                else if (r.Count() > 0)
                {
                    output.Add(r.First<int>());
                    r.RemoveAt(0);
                }
            }

            return output.ToArray();
        }
    }
}
