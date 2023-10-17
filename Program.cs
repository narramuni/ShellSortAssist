using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellSortAssist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        static void runApp()
        {
            int[] marks = new int[6];
            marks[0] = 86;
            marks[1] = 96;
            marks[2] = 72;
            marks[3] = 76;
            marks[4] = 92;
            marks[5] = 96;

            int n = marks.Length;
           
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = marks[i];
                    int j;
                    for (j = i; j >= gap && marks[j - gap] > temp; j -= gap)
                    {
                        marks[j] = marks[j - gap];
                    }
                    marks[j] = temp;
                }
            }

            Console.WriteLine("Sorted List of Marks in Ascending Order:");
            foreach (var mark in marks)
            {
                Console.WriteLine($"Mark: {mark}");
                Console.ReadLine();
            }
        }


    
    }
}
