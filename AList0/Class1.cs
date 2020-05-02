using System;
using System.Collections.Generic;
using System.Text;

namespace AList0
{
    public class AL0
    {
        private int[] myArray;

        public AL0(int[] arrayCopy) //конструктор класса
        {
            myArray = arrayCopy;
        }

        public int[] MyArray
        {
            get
            {
                return myArray;
            }
        }

        public int[] CopyArray()
        {
            int[] arrayCopy = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                arrayCopy[i] = myArray[i];
            }
            return arrayCopy;
        }

        public void PrintMyArray()
        {

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine();
        }

        public int[] AddElement(int element)
        {
            // AL0 arrayControl = new AL0(new)
            int[] arrayCopy = new int[myArray.Length + 1];
            int j = 0;
            for (int i = 0; i < this.myArray.Length; i++)
            {
                arrayCopy[i] = myArray[i + j];
            }
            arrayCopy[this.myArray.Length] = element;

            this.myArray = arrayCopy;

            return this.myArray;
        }

        public int[] AddElement(int addelement, int addindex)
        {
            int[] arrayAdd = new int[this.myArray.Length + 1];
            int j = 0;
            for (int i = 0; i <= this.myArray.Length; i++)
            {
                if (i == addindex)
                {
                    j = 1;
                    arrayAdd[i] = addelement;
                }
                else
                {
                    arrayAdd[i] = this.myArray[i - j];
                }
            }

            this.myArray = arrayAdd;

            return this.myArray;
        }

        public int[] DelElement(int index)
        {
            int[] arrayCopy = new int[myArray.Length - 1];
            int j = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (i == index)
                {
                    j++;
                }
                arrayCopy[i] = myArray[i + j];
            }
            this.myArray = arrayCopy;

            return this.myArray;
        }
        public int MaxElement()
        {
            CopyArray();
            int max = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (max < myArray[i])
                {
                    max = myArray[i];
                }
            }

            return max;
        }

        public int MaxElementIndex()
        {
            int max_i = 0;
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[max_i] < myArray[i])
                {
                    max_i = i;
                }
            }

            return max_i;
        }

        public int MinElement()
        {
            int min = myArray[0];
            for (int i = 1; i < myArray.Length; i++)
            {
                if (min > myArray[i])
                {
                    min = myArray[i];
                }
            }

            return min;
        }

        public int MinElementIndex()
        {
            int min_i = 0;
            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[min_i] > myArray[i])
                {
                    min_i = i;
                }
            }

            return min_i;

        }

        public int SumElement()
        {
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }
            return sum;
        }

        public int[] Half_array()
        {
            int n = this.myArray.Length, temp;
            int[] arrayCopy = new int[this.myArray.Length];

            arrayCopy = CopyArray();

            for (int i = 0; i < (n / 2); i++)
            {
                if ((n % 2) != 0)
                {
                    temp = arrayCopy[i];
                    arrayCopy[i] = arrayCopy[i + (n / 2) + 1];
                    arrayCopy[i + (n / 2) + 1] = temp;
                }
                else
                {
                    temp = arrayCopy[i];
                    arrayCopy[i] = arrayCopy[i + (n / 2)];
                    arrayCopy[i + (n / 2)] = temp;
                }
            }

            this.myArray = arrayCopy;
            return this.myArray;
        }

        public int[] Revers()
        {
            int temp;
            int[] arrayCopy = new int[myArray.Length];
            arrayCopy = CopyArray();

            for (int i = 0, j = arrayCopy.Length - 1; i != j && i < j; i++, j--)
            {

                temp = arrayCopy[i];
                arrayCopy[i] = arrayCopy[j];
                arrayCopy[j] = temp;
            }

            this.myArray = arrayCopy;
            return this.myArray;
        }

        public int[] Sort_Bubble()
        {
            int temp;
            int[] arrayCopy = new int[myArray.Length];
            arrayCopy = CopyArray();

            for (int i = 0; i < arrayCopy.Length; i++)
            {
                for (int j = arrayCopy.Length - 1; j > i; j--)
                {
                    if (arrayCopy[j - 1] > arrayCopy[j])
                    {
                        temp = arrayCopy[j];
                        arrayCopy[j] = arrayCopy[j - 1];
                        arrayCopy[j - 1] = temp;
                    }
                }
            }

            this.myArray = arrayCopy;
            return this.myArray;
        }

        public int[] Sort_Select()
        {
            int temp, min;
            int[] arrayCopy = new int[myArray.Length];
            arrayCopy = CopyArray();

            for (int i = 0; i < arrayCopy.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arrayCopy.Length; j++)
                {
                    if (arrayCopy[min] > arrayCopy[j])
                    {
                        min = j;

                    }
                }

                temp = arrayCopy[min];
                arrayCopy[min] = arrayCopy[i];
                arrayCopy[i] = temp;
            }

            this.myArray = arrayCopy;
            return this.myArray;
        }

        public int[] Sort_Insert()
        {
            int temp;
            int[] arrayCopy = new int[myArray.Length];
            arrayCopy = CopyArray();


            for (int i = 0; i < arrayCopy.Length; i++)
            {

                for (int j = i; j > 0 && arrayCopy[j - 1] > arrayCopy[j]; j--)
                {
                    temp = arrayCopy[j - 1];
                    arrayCopy[j - 1] = arrayCopy[j];
                    arrayCopy[j] = temp;

                }

            }

            this.myArray = arrayCopy;
            return this.myArray;
        }

        public int[] AddArray(int[] arrayAdd)
        {
            int[] arrayCopy = new int[this.myArray.Length + arrayAdd.Length];
            

            for (int j=0, i = 0; i < arrayCopy.Length; i++)
            {
                if(i<myArray.Length)
                {
                    arrayCopy[i] = myArray[i];
                }
                else
                {
                    arrayCopy[i] = arrayAdd[j];
                    j++;
                }
                
            }
            this.myArray = arrayCopy;
            return this.myArray;

        }

        public int[] MixArray()
        {
            int temp,k;
            Random r = new Random();
            int[] arrayCopy = new int[myArray.Length];
            arrayCopy = CopyArray();

            for(int i=1;i<arrayCopy.Length;i++)
            {
                k = r.Next(i, arrayCopy.Length);
                temp = arrayCopy[i-1];
                arrayCopy[i-1] = arrayCopy[k];
                arrayCopy[k] = temp;
                
            }

            this.myArray = arrayCopy;
            return this.myArray;
        }
    }
}

