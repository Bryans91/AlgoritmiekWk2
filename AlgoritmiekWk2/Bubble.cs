using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiekWk2
{
    class Bubble
    {

        public int swap = 0, comp = 0;
        public Bubble()
        {
            BubbleSort();
        }

        public int BubbleSort()
        {
            Console.Write("\nProgram for Ascending order of Numeric Values using BUBBLE SORT");
            Console.Write("\n\nEnter the total number of elements: ");
            int max = 9;

            int[] numarray = { 1, 4, 3, 6, 5, 8, 9, 7, 2 };
            Console.Write("Before Sorting   : ");
            for (int k = 0; k < max; k++)
                Console.Write(numarray[k] + " ");
            Console.Write("\n");

            for (int i = 1; i < max; i++)
            {
                for (int j = 0; j < max - i; j++)
                {
                    this.comp++;
                    if (numarray[j] > numarray[j + 1])
                    {
                        this.swap++;
                        int temp = numarray[j];
                        numarray[j] = numarray[j + 1];
                        numarray[j + 1] = temp;
                    }
                }


                Console.Write("After iteration " + i.ToString() + ": ");
                for (int k = 0; k < max; k++)
                    Console.Write(numarray[k] + " ");
                Console.Write("/*** " + (i + 1).ToString() + " biggest number(s) is(are) pushed to the end of the array ***/\n");
            }

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");
                Console.Write(numarray[i]);
                Console.Write("\n");
            }
            return 0;
        }
    }
}
