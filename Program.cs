﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBasic4
{
    class MyMath
    {
        public static double PI = 3.141592;
        public static void Hello()
        {
            Console.WriteLine("Greeting~");
        }
    }
    class Product
    {
        public string name = "default";
        public int price = 1000;

        public override string ToString()
        {
            return this.name + " / " + this.price;
        }
    }
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SerInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
    class Program
    {
        /* 클래스 이름 충돌!
        class Math
        {

        }*/
        static void Main(string[] args)
        {
            Car[] cars = new Car[10];

            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 100);

            List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
            }
            list.Remove(52);
            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\titem : " + item);
                //list.Remove(item);
            }

            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

            Product product = new Product();
            Console.WriteLine(product);
            Product productA = new Product() { name = "감자", price = 2000 };
            Console.WriteLine(productA);
            Product productB = new Product() { name = "고구마", price = 3000 };
            Console.WriteLine(productB);

            Console.WriteLine(MyMath.PI);
            MyMath.Hello();
        }
    }
    class SecondClass
    {
        class ChildClass
        {

        }
    }
}
