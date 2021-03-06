﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiekWk2
{
    class Merge
    {
        public int swap = 0,comp=0;
        

        public Merge()
        {
            int[] numbers_merge = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = numbers_merge.Length;
            Console.WriteLine("MergeSort By Recursive Method");
            MergeSort_Recursive(numbers_merge, 0, len - 1);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(numbers_merge[i]);

        }


        public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                this.comp++;
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }



        public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                this.swap++;
                numbers[right] = temp[right];
                right--;
            }
        }

    }
}
