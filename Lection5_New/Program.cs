using System;

namespace Lection5_New
{
    class Program
    {
        static int[] GetElements(int a)
        {
            int maxValue = 1000;
            int[] array = new int[maxValue / a];
            for (int i = a, j = 0; i <= maxValue; i += a)
            {
                array[j++] = i;
            }

            return array;
        }

        static (int oddSum, int evenSum) GetValueParts(int n)
        {
            int oddSum = 0;
            int evenSum = 0;
            while(n != 0)
            {
                if (n % 2 == 0)
                {
                    evenSum += n % 10;
                }
                else
                {
                    oddSum += n % 10;
                }

                n /= 10;
            }

            return (oddSum, evenSum);
        }

        static int[] GetValues(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                (int oddSum, int evenSum) = GetValueParts(i);
                if(evenSum > oddSum)
                {
                    ++count;
                }
            }

            int[] array = new int[count];
            for (int i = 1, j = 0; i <= n; i++)
            {
                (int oddSum, int evenSum) = GetValueParts(i);
                if (evenSum > oddSum)
                {
                    array[j++] = i;
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];

        }
    }
}
