using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatter
{
    public static class Displays
    {
        //Print the content of a list
        public static void printList(List<int> mylist)
        {
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.Write(mylist[i] + " ");
            }
        }

        //Displays the content of an array
        public static void displayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
