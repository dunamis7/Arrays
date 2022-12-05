using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatter
{
    public static class Statistics
    {
        //mean
        public static double Mean(int[] array)
        {
            int size = array.Length;
            double sum = 0;
            double mean = 0;   
            for(int i=0; i<array.Length; i++)
            {
                sum = sum +  array[i];
            }
            mean = sum/size;
            return mean;
        }


        //Mode
        public static int Mode(int[] array)
        {
            int count = 0;
            int frequencyOfCurrentElement = 0;
            int frequencyOfLastElement = 0;
            int mode = 0;
            for(int i=0; i<array.Length; i++)
            {
                for (int j=0; j<array.Length; j++)
                {
                    if(array[j] == array[i])
                    {
                        count++;
                    }
                    if (j == array.Length - 1)
                    {
                        frequencyOfCurrentElement = count;
                        count = 0;

                        if (i != 0)
                        {
                            if (frequencyOfCurrentElement > frequencyOfLastElement)
                            {
                                mode = array[i];
                            }
                        }
                        frequencyOfLastElement = frequencyOfCurrentElement;


                    }
                }

               
            }
            return mode;
        }


        //Median
        public static double Median(int[] array)
        {
            int[] sortedArray = selectionSort(array); 
            double arraySize = sortedArray.Length;
            double middle;

            if (arraySize % 2 == 1)
            {
                int k = (int)(arraySize / 2 - 0.5);
                middle = sortedArray[k];

            }
            else
            {
                int firstnum = (int)((arraySize - 1) / 2);
                int secondnum = (int)((arraySize) / 2);


                double middle1 = sortedArray[firstnum];
                double middle2 = sortedArray[secondnum];

                middle = (middle1 + middle2) / 2;

            }
            return middle;
        }




        //Selection sort algorithm
       public static int[] selectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)

            {
                int min = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }
                //Swapping
                int temp = numbers[min];
                numbers[min] = numbers[i];
                numbers[i] = temp;

            }
            return numbers;
        }




    }
}
