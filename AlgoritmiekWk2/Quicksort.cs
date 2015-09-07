using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiekWk2
{
    class Quicksort
    {

        public int swap = 0, comp = 0;

        public Quicksort(bool recursive = false)
        {
           
            int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = numbers.Length;

            QuickSort_Recursive(numbers, 0, len - 1,recursive);
            for (int i = 0; i < len; i++)
                Console.WriteLine(numbers[i]);
        }




       public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                    this.swap++;
                }
                else
                {
                    return right;
                }
            }
        }

        public void QuickSort_Recursive(int[] arr, int left, int right,bool qs3)
        {
            this.comp++;
            // For Recusrion
            if (left < right)
            {
                int pivot =0;

                if (qs3)
                {
                    pivot = PartitionQs3(arr, left, right);
                }
                else
                {
                   pivot = Partition(arr, left, right);
                }
                

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1,qs3);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right,qs3);
            }
        }

        private int PartitionQs3(int[] arr, int left, int right)
        {

            int mid = arr[arr.Length / 2];
            int midval = arr[mid];
            int leftval = arr[left];
            int rightval = arr[right];

            if(midval > leftval )
            {
                if(leftval > rightval)
                {
                    return left;
                }else if(midval > rightval)
                {
                    return right;
                }
                else
                {
                    return mid;
                }
            } else
            {
                if(midval > rightval)
                {
                    return mid;
                } else if (leftval > rightval)
                {
                    return right;
                } else
                {
                    return left;
                }
            }
        }
    }
}
