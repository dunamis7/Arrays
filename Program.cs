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

            display(numbers);
            Console.WriteLine(" "); 

            int[] abtmin = minNum(numbers);
            Console.WriteLine("Minimum nuber is " + abtmin[0] + " and it is at index " + abtmin[1]);



            //List<int>  myprimelist = findPrimenumbers(numbers);

            //Console.WriteLine("Prime numbers in the array is :");
            //display(myprimelist);

            Boolean prime = isprime(5);

            Console.WriteLine(prime);


            List<int> list = new List<int>();
           list = findPrimenumbers(numbers);

            printList(list);

            Console.WriteLine(" ");


            int[] mysort = selectionSort(numbers);

            display(mysort);

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
        //Displays the content of an array
        static void display(int[] numbers)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
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


        //Print the content of a list
        static void printList(List<int> mylist)
        {
            for(int i=0; i<mylist.Count; i++)
            {
                Console.Write(mylist[i] + " ");
            }
        }


        //Selection sort algorithm

        static int[] selectionSort(int[] numbers )
        {
            int[] myclone = copyArray(numbers);

            for(int i=0; i<myclone.Length-1; i++)
                
            {
                int min = i;
                for (int j=i+1; j<myclone.Length; j++)
                {
                    if (myclone[j] < myclone[min])
                    {
                        min = j;
                    }
                }
                //Swapping
               int temp = myclone[min];
                myclone[min] = myclone[i];
                myclone[i] = temp;

            }
            return myclone;
        }



    }
}
