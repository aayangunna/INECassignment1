//A program that detects the number of time a user register on INEC portal
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace INECassignment
{
    internal class Program
    {		//Using Main method
        static void Main(string[] args)
        {
            // Creating a sortedlist
            // Using SortedList class
            SortedList<string, int> sortList = new SortedList<string, int>();

            string[] inecArray = { "Messi", "Benzema", "Neymar", "Lewandoski", "Mane", "Neymar", "Messi", "Mane", "Messi", "Mabappe" };


             // Using foreach loop to access the names of the SortedList.
            foreach (var name in inecArray)
            {
                int count = 0;
                if (sortList.ContainsKey(name))
                {
                    continue;
                }
                for (int i = 0; i < inecArray.Length; i++)
                {
                    if (name == inecArray[i])
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    sortList.Add(name, count);
                }
            }
            foreach (var item in sortList)
            {
                //Printing out the result
                Console.WriteLine(item);

            }
        }
    }
}
