﻿using System;
using System.Collections;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Guid());
            QueryStringArray();
            Console.WriteLine();
            QueryArrayList();
            Console.WriteLine();
            foreach (var num in QueryIntArray())
            {
                Console.WriteLine(num);
            }
        }

        static void QueryArrayList()
        {
            var intArrList = new ArrayList {4, 5, 8, 9, 10, 1, 2, 6, 3, 12};
            var lt10 = from num in intArrList.OfType<int>()
                where num < 10
                orderby num descending
                select num;
            foreach (var num in lt10)
            {
                Console.WriteLine(num);
            }
        }
        static void QueryStringArray()
        {
            string[] strings = {"Artem Vovchenko", "Cool", "You knwo this", "yess", "Other", "Wooow", "Yesterday"};
            var withSpaces = from str in strings
                where str.Contains(" ")
                orderby str
                select str;

            foreach (var withSpace in withSpaces)
            {
                Console.WriteLine(withSpace);
            }
        }

        static int[] QueryIntArray()
        {
            int[] nums = {5, 10, 2, 16, 78, 25, 1587, 0, -456, -5, 8, 6};
            var numsBiggerThanFive = from num in nums
                where num > 5
                orderby num
                select num;
            return numsBiggerThanFive.ToArray();
        }
    }
}