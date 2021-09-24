using System;

namespace CSharpMethod
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Tek ededlerin sayi:
            //int n = 5;
            //int m = 15;
            //int count = 0;
            //for (int i = n; i <= m; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion

            #region Sade ve ya murekkeb
            //int n = 81;
            //int count = 0;
            //for (int i = 2; i*i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        count++;
            //        break;
            //    }
            //}

            //if (count > 0)
            //{
            //    Console.WriteLine("murekkeb");
            //}
            //else
            //{
            //    Console.WriteLine("Sade");
            //}
            #endregion

            #region Method
            //int a = 10;
            //int b = 15;
            //Console.WriteLine(Sum(a, b)); //a,b - arguments
            //Console.WriteLine(Avg(5,6));
            //Console.WriteLine(Sum(2,12,30));

            //int[] arr = { 10, 21, 3, 41, 55,67 };
            //Console.WriteLine(SumItem(60,70,80,90,1));
            //Concat("Salam","Hello","Hi");
            //Console.WriteLine(Sum(10,2));
            //Print("Kamran");
            //Print("Aga", "Agazade", 20);
            Test(20);
            #endregion
        }

        //Method signature - method name,method parametrs count,parametrs type
        //Method overloading
        
        static void Test(params int[] arr)
        {
            Console.WriteLine($"params: {arr[0]}");
        }

        //static void Test(int n)
        //{
        //    Console.WriteLine($"one:{n}");
        //}

        static void Test(int n, int m = 10)
        {
            Console.WriteLine($"default:{n + m}");
        }
        static void Print()
        {
            Console.WriteLine("Hello");
        }
        static void Print(string name)
        {
            if (name == "Kamran")
            {
                Console.WriteLine("teacher");
                return;
            }
            Console.WriteLine("student");
        }

        static void Print(string name,string surname)
        {
            Console.WriteLine($"{name} {surname}");
        }

        static void Print(string name, string surname,int age)
        {
            Console.WriteLine($"{name} {surname} {age}");
        }

        static int Sum(int n1, int n2) //n1,n2 - parametrs
        {
            if (n1 > n2)
            {
                int sum = n1 + n2;
                return sum;
            }

            return -1;

        }

        static void Concat(params string[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int SumItem(params int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }

        

        //static double Avg(int n,int m)
        //{
        //    double avg =(double) Sum(n, m) / 2;
        //    return avg;
        //}

    }
}
