using System;
using System.IO;

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
            while (n != 0)
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
                if (evenSum > oddSum)
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

        static void Task1()
        {
            //
        }

        static void CopyContent(string source, string dest)
        {
            using (StreamReader streamReader = new StreamReader(
              source))
            {
                using (StreamWriter streamWriter = new StreamWriter(dest))
                {

                }
                while (!streamReader.EndOfStream)
                {
                    string input = streamReader.ReadLine();

                    using (StreamWriter streamWriter = new StreamWriter(dest, true))
                    {
                        streamWriter.WriteLine(input);
                    }
                }
            }
        }

        static void OnlyWithoutDigits()
        {
            using (StreamReader streamReader = new StreamReader(
                @"C:\Users\Sviatoslav_Samoilenk\Desktop\test.txt"))
            {
                using (StreamWriter streamWriter = new StreamWriter(
                    @"C:\Users\Sviatoslav_Samoilenk\Desktop\test2.txt"))
                {

                }
                while (!streamReader.EndOfStream)
                {
                    string input = streamReader.ReadLine();//read source string
                    bool isValid = true;
                    foreach (var item in input)//checking does string contain digits
                    {
                        if (char.IsDigit(item))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)//if not contain -> write
                    {
                        using (StreamWriter streamWriter = new StreamWriter(
                            @"C:\Users\Sviatoslav_Samoilenk\Desktop\test2.txt", true))
                        {
                            streamWriter.WriteLine(input);
                        }
                    }
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Reverse(int[,] arr)
        {
            int count = arr.Length / 2;
            for (int i = 0; i < arr.GetLength(0) && count > 0; i++)
            {
                for (int j = 0; j < arr.GetLength(1) && count > 0; j++, --count)
                {
                    Swap(ref arr[i, j],
                        ref arr[arr.GetLength(0) - 1 - i, arr.GetLength(1) - 1 - j]);
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if(i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }

        }
    }
}
