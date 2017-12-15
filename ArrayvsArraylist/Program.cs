﻿using System;
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
            const int miliarda = 100000000;
            int[] miliardaPole = new int[miliarda];
            ArrayList miliardaArraylist = new ArrayList();

            Random r = new Random();
            Stopwatch stopky = new Stopwatch();

            stopky.Start();
            for (int i = 0; i < miliarda; i++)
            {
                miliardaPole[i] = r.Next();
            }
            stopky.Stop();
            Console.WriteLine("naplnenie pola {0}", stopky.Elapsed);


            stopky.Restart();
            for (int i = 0; i < miliarda; i++)
            {
                miliardaArraylist.Add(r.Next());
            }
            stopky.Stop();
            Console.WriteLine("naplnenie arraylistu {0}", stopky.Elapsed);

            Console.ReadKey();
        }
    }
}
