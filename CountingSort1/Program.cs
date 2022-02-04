﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "63 54 17 78 43 70 32 97 16 94 74 18 60 61 35 83 13 56 75 52 70 12 24 37 17 0 16 64 34 81 82 24 69 2 30 61 83 37 97 16 70 53 0 61 12 17 97 67 33 30 49 70 11 40 67 94 84 60 35 58 19 81 16 14 68 46 42 81 75 87 13 84 33 34 14 96 7 59 17 98 79 47 71 75 8 27 73 66 64 12 29 35 80 78 80 6 5 24 49 82";
            List<int> arr = str.Split(" ").Select(x => Convert.ToInt32(x)).ToList();

            List<int> result = countingSort(arr);

            List<int> sortedList = new List<int>();
            for (int i = 0; i < result.Count; i++)
            {
                if(result[i]>0)
                {
                    for(int j = 0; j < result[i]; j++)
                    {
                        sortedList.Add(i);
                    }
                }
            }


            Console.WriteLine(string.Join(",", sortedList));


        }

        private static List<int> countingSort(List<int> arr)
        {
            int[] occurences = new int[100];
            foreach (var item in arr)
                occurences[item]++;

            return occurences.ToList();
        }
    }
}
