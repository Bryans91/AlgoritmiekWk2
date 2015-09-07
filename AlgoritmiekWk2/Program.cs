using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AlgoritmiekWk2
{
    class Program
    {
        private int mswap;
        private int mcomp;

        static void Main(string[] args)
        {

            Stopwatch s = new Stopwatch();


        
            //quicksort recursive
            s.Start();
            Console.WriteLine("Quicksort Recursive");
            Quicksort q = new Quicksort();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds+"ms");
            Console.WriteLine ("SWAP: " + q.swap + " COMP: " + q.comp);


            s.Reset();
            s.Start();
            Console.WriteLine("Quicksort Recursive");
            Quicksort qs = new Quicksort(true);
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds + "ms");
            Console.WriteLine("SWAP: " + qs.swap + " COMP: " + qs.comp);

           

            s.Reset();
            s.Start();
            //Bubblesort
            Bubble b = new Bubble();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds + "ms");
            Console.WriteLine("SWAP: " + b.swap + " COMP: " + b.comp);

            s.Reset();
            s.Start();
            //Mergesort
            Merge m = new Merge(); 
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds+"ms");
            Console.WriteLine("SWAP: " + m.swap + " COMP: " + m.comp);


            //Keep console open
            Console.WriteLine();
            Console.ReadLine();
        }




        

       


    }
}