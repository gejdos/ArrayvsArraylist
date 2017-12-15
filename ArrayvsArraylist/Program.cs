using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayvsArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            const int miliarda = 1000000000;
            int[] miliardaPole = new int[miliarda];
            ArrayList miliardaArraylist = new ArrayList();

            Random r = new Random();
            Stopwatch stopky = new Stopwatch();

            stopky.Start();
            for (int i = 0; i < miliardaPole.Length; i++)
            {
                miliardaPole[i] = r.Next();
            }


            for (int i = 0; i < miliardaArraylist.Count; i++)
            {
                miliardaArraylist.Add(r.Next());
            }

        }
    }
}
