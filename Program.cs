using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            numbers = Initializer(numbers);

            Displays.displayArray(numbers);
            Console.WriteLine(" ");

            int[] abtmin = minNum(numbers);
            Console.WriteLine("Minimum number is " + abtmin[0] + " and it is at index " + abtmin[1]);



            List<int> primeNumbers = new List<int>();
            primeNumbers = findPrimenumbers(numbers);

            Console.WriteLine("Prime numbers in array are ");
            Displays.printList(primeNumbers);

            Console.WriteLine(" ");


            int[] mysort = Statistics.selectionSort(numbers);

            Console.WriteLine("Sorted array");
            Displays.displayArray(mysort);

            Console.WriteLine(" ");  
            
            int[] numbers2 = { 1,3,2,3,1,4,9,4, 2,1,3,1 };
            int mode = Statistics.Mode(numbers2);
            double mean = Statistics.Mean(numbers2);
            double median= Statistics.Median(numbers2);

            Console.WriteLine("New array");
            Displays.displayArray(numbers2);

            Console.WriteLine(" ");    
            Console.WriteLine($"Mode of new array   {mode}");
            Console.WriteLine($"Median of new array   {median}");
            Console.WriteLine($"Mean of new array   {mean}");

            Console.Read();
        }

        //Intialize an array with random numbers from 10 to 50
        static int[] Initializer(int[] numbers)
        {
            
            Random random = new Random();
            for (int i=0; i<numbers.Length; i++)
            {
                numbers[i] = random.Next(10,50); 
            }

            return numbers;
        }

        //Copy the contents of an array
        static int[] copyArray(int[] numbers)
        {
            int[] copy = new int[numbers.Length];   

            for(int i=0; i<numbers.Length; i++)
            {
                copy[i] = numbers[i];   
            }

            return copy;

        }
      
        

        //Returns the minimum and the location of the minimum number
        static int[] minNum(int[] numbers)
        {
            int[] abtMin = new int[2];
            abtMin[0] = numbers[0];

            for(int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] < abtMin[0])
                {
                    abtMin[0] = numbers[i];
                    abtMin[1] = i;
                }
            }

            return abtMin;
        }

        //Check if a number is prime or not
        static Boolean isprime(int num) 
        {
            int counter = 0;
            for(int i=1; i<=num; i++)
            {
                if (num % i == 0) 
                    counter++; 
            }
            if(counter == 2)
            {
                return true;
            }
            return false;
           
        }

       // Returns prime numbers present in an array of numbers
        static List<int> findPrimenumbers(int[] numbers )
        {
            List<int> primeNumbers = new List<int>();


            for(int i=0; i<numbers.Length; i++)
            {
                  
                if (isprime(numbers[i]) == true) { 
                    primeNumbers.Add(numbers[i]);
                }
            }


            return primeNumbers;
        }

    }
}
