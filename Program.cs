using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM
{
    class Program
    {
        public static void targil8(int num)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                default:
                    Console.WriteLine("Number not in range");
                    break;
            }
        }
        //9.
        public static void PrintNumber1to10()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        private static bool PrintNumbers(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(i + ", ");
            }
            if (number >= 1 && number <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void targil10(int num)
        {
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine(num);
                targil10(num + 1);
            }
        }
        //ריקורסיה
        public static void targil10_(int num)
        {
            if (num != 11)
            {
                targil10_(num + 1);
                Console.WriteLine(num);
            }
        }
        //11.
        private static int IsPrime(int number)
        {
            int m = 2;
            int count = 0;
            while (m <= number)
            {
                if (number % m == 0)
                {
                    count++;
                }
                m++;
            }

            if (count == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private static void CheckArrayForPrimeNumbers(int[] arr)
        {
            int count, m;

            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;
                m = 2;
                while (m < arr[i])
                {
                    if (arr[i] % m == 0)
                    {
                        count++;
                        if (count == 1)
                        {
                            Console.WriteLine(arr[i] + " not prime");
                        }
                    }
                    m++;
                }

                if (count == 0)
                {
                    Console.WriteLine(arr[i] + " prime");
                }
            }
        }

        //13.
        private static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            //  בהנחה ששני המערכים לא שווים בגודלם אשתמש בשני לולאות
            // אם הם שווים בגודלם אחשב את סכום שני המערכים בלולאה אחת 
            int sum1 = 0, sum2 = 0;
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum1 += arr1[i];
                    sum2 += arr2[i];
                }
                if (sum1 > sum2)
                {
                    return 1;
                }
                else if (sum1 == sum2)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    sum1 += arr1[i];
                }
                for (int i = 0; i < arr2.Length; i++)
                {
                    sum2 += arr2[i];
                }
                if (sum1 > sum2)
                {
                    return 1;
                }
                else if (sum1 == sum2)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
        //14.
        public static int[,] CreateRandomMatrix()
        {
            int[,] arr = new int[10, 10];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(100);
                }
            }
            return arr;
        }
        private static void CheckIfExist(int[,] theMatrix)
        {
            Console.WriteLine("enter num");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < theMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < theMatrix.GetLength(1); j++)
                {
                    if (theMatrix[i, j] == num)
                    {
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                Console.WriteLine("exist");
            }
            else
            {
                Console.WriteLine("not exist");
            }
        }

        public static void targil14_(int[,] arr)
        {
            Console.WriteLine("Enter num");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == num)
                    {
                        Console.WriteLine("exist");
                    }
                    else
                    {
                        Console.WriteLine(" not exist");
                    }
                }
            }
        }
        public static void targil15(int[] arr)
        {
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    min = arr[j - 1];
                    if (min > arr[j])
                    {
                        arr[j - 1] = arr[j];
                        arr[j] = min;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //int[,] multi_arr = CreateRandomMatrix();
            //for (int i = 0; i < 10; i++)
            //{
            //    CheckIfExist(multi_arr);
            //}
            //CheckIfExist(multi_arr);
            int[] arr = { 100, 5, 2, 15, 10, -5 };
            int[] arr_ = { 17, 13, 9, 4, 2 };
            //int[] arr1 = { 17, 13, 9, 4, 2 };
            //int[] arr2 = { 17, 13, 9, 4, 2 };
            //int res = WhichArrayIsBigger(arr1, arr2);
            //targil15(arr);
            //targil10(1);
            //PrintNumbers(11);
            //PrintNumber1to10();
            //targil8(7);
            //targil10_(1);
            ////int a = IsPrime(15);
            //CheckArrayForPrimeNumbers(arr_);
            //Console.WriteLine(a);
            Console.ReadLine();


        }
    }
}
