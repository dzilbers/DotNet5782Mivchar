using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj1;

            obj1 = new(10);
            Console.WriteLine(obj1);

            obj1.F1 = 10;
            Console.WriteLine(obj1.F1);

            var obj2 = new MyClass() { F1 = 7 };

            MyStruct str1;
            //str1.F1 = 10;

            //Console.WriteLine(str1);

            Console.WriteLine("Hello World!");

            int[] arr = new int[5];
            foreach (int i in arr)
                Console.Write(" " + i);
            Console.WriteLine();

            int[] arr2 = { 1, 2, 3, 4, 5, 6 };
            arr = arr2;

            int[,] matrix = new int[4, 6];

            int[,] matrix2 =
            {
                { 1, 2, 3 },
                { 4, 5, 8 }
            };

            int[][] arrOfArr = new int[10][];

            int[][] arrOfArr2 =
            {
                new int[] { 1, 2, 3},
                new int[] {1,2,3,4,5,6,7}
            };

            Console.WriteLine(arr2 is Array ? "ARRAY" : "NOT ARRAY");

            int a = 2, b = 6;
            MyClass.Swap(ref a, ref b);

            obj1.F1 = int.TryParse(Console.ReadLine(), out int parcelId) ? parcelId : 0;
            obj1.F1 = int.TryParse(Console.ReadLine(), out int id) ? id : 0;

            MyStruct str2;
            str2 = new() { F1 = 8 };
            Console.WriteLine(str2);

            Func2(ref a, out int c);
            Console.WriteLine(c);

            Console.WriteLine(sum(1, 2, 3));

            stam(p2: "Yossi", p1: 9, p3: 9.5);

            double choice = 5;
            switch (choice)
            {
                case 2:
                    break;
                case > 3.1:
                    break;
            }

            int? xNullable = 7;
            int y = 23;
            object yBoxed = y;
            if (xNullable is int nn1 && yBoxed is int nn2)
            {
                Console.WriteLine(nn1 + nn2);  // output: 30
            }

            int[] array = new int[100];

            var it1 = array.GetEnumerator();
            while(it1.MoveNext())
            {
                Console.WriteLine((int)it1.Current);
            }

            foreach (var n in array)
            {
                Console.WriteLine(n);
            }

            var it2 = list.GetEnumerator();
            while (it2.MoveNext())
            {
                Console.WriteLine((int)it2.Current);
            }

            foreach (var n in list)
            {
                Console.WriteLine(n);
            }

            int index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 10)
                    index = i;
            }

        }

        static List<int> list = new();

        static void stam(int p1, string p2, double p3) { }

        static int sum(params int[] nums)
        {
            int s = 0;
            foreach (var n in nums)
                s += n;
            return s;
        }
        static string Classify(double measurement) => measurement switch
        {
            < -40.0 => "Too low",
            >= -40.0 and < 0 => "Low",
            >= 0 and < 10.0 => "Acceptable",
            >= 10.0 and < 20.0 => "High",
            >= 20.0 => "Too high",
            double.NaN => "Unknown",
        };

        static string GetCalendarSeason(DateTime date) => date.Month switch
        {
            3 or 4 or 5 => "spring",
            6 or 7 or 8 => "summer",
            9 or 10 or 11 => "autumn",
            12 or 1 or 2 => "winter",
            _ => throw new ArgumentOutOfRangeException(nameof(date), $"Date with unexpected month: {date.Month}."),
        };


        static void Func2(ref int p1, out int p2)
        {
            Console.WriteLine(p1);
            p2 = p1;
        }


        class MyClass
        {
            int f1 = 8;


            public int F1
            {
                get
                {
                    Console.WriteLine("GETTER");
                    return f1;
                }

                set => f1 = value;

            }


            public int F2 { get; private set; } = 10;

            public static void Swap(ref int number1, ref int number2)
            {
                int temp = number1;
                number1 = number2;
                number2 = temp;
            }

            public DateTime MyDate { get => DateTime.Now; }

            /// <summary>
            /// My best constructor
            /// </summary>
            /// <param name="parm">it's the most important number parameter</param>
            internal MyClass(int parm) => f1 = parm;
            public MyClass() { }
        }

        struct MyStruct
        {
            internal int F1 { get; set; }

            public MyStruct(int parm) => F1 = parm;

            //public MyStruct() { }
        }


        struct Drone
        {
            public int Id { get; set; }
            public int Status { get; set; }
        }
    }

    class Father
    {
        public Father(int p) { }
        public Father() { }
    }

    class Son : Father, IDoing
    {
        public Son(int pp) : base(pp) { }

        public Son() : this(0) { }

        public string Do(int num)
        {
            return String.Format($"{num}");
        }
    }

    interface IDoing
    {
        string Do(int num);
        int Do(string str) => int.Parse(str);
    }
}

