using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LR
{
    public class LR
    {
        static int n;
        static int[] val;
        public LR()
        {
            n = int.Parse(Console.ReadLine());
            val = new int[n];
            string[] line = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
                val[i] = int.Parse(line[i]);
        }
        public int Count()
        {
            int k = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (val[i] >= Maxim(0, i) && val[i] <= Minim(i, n))
                    k++;
            }
            return k;
        }
        private int Minim(int v1, int v2)
        {
            int min = 1000000;
            for (int i = v1 + 1; i < v2; i++)
                if (val[i] < min)
                    min = val[i];
            return min;
        }

        private int Maxim(int v1, int v2)
        {
            int max = 0;
            for (int i = v1; i < v2; i++)
                if (val[i] > max)
                    max = val[i];
            return max;
        }
    }
}