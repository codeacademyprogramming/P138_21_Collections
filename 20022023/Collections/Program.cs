using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(10);
            arrList.Add(20);
            arrList.Add("Hikmet");
            arrList.Add('c');
            arrList.Add(20);


            //arrList.Remove(20);
            //arrList.RemoveAt(2);

            arrList.Insert(3, 10);
            //arrList.Clear();

            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n=========Queue============");

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            var value = queue.Dequeue();
            value = queue.Peek();
            value = queue.Dequeue();


            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n=========Stack============");

            Stack<int> stack = new Stack<int>();

            stack.Push(45);
            stack.Push(15);
            stack.Push(25);
            stack.Push(55);


            value = stack.Peek();
            value = stack.Pop();
            value = stack.Peek();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            arrList.AddRange(stack);

            Console.WriteLine("ArrList");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }


            SortedList sortedList = new SortedList();
            sortedList.Add("Elnur", 25);
            sortedList.Add("Hikmet", 95);
            sortedList.Add("Nermin", 85);
            sortedList.Add("Abbas", 'c');


            Console.WriteLine(sortedList["Hikmet"]);


            List<int> numberList = new List<int>();

            numberList.Add(34);
            numberList.Add(14);
            numberList.Add(34);
            numberList.Add(54);
            numberList.Add(64);
            numberList.Add(74);


            var num = numberList[1];

            numberList.RemoveRange(3, 2);


            SortedList<string, double> products = new SortedList<string, double>();

            products.Add("Milla Ayran 1L", 4.5);
            products.Add("Anchor yag 1kg", 54);
            products.Add("Mal eti", 14.5);
            products.Add("Kinder", 2.5);


            foreach (var item in products)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }
            Console.WriteLine(products["Kinder"]);


            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(111, "Hikmet");
            students.Add(102, "Nermin");
            students.Add(103, "Abbas");
            students.Add(104, "Tofiq");
            students.Add(105, "Abbas");

            int no;
            do
            {
                Console.WriteLine("Student no:");
                no = Convert.ToInt32(Console.ReadLine());
            } while (students.ContainsKey(no));
         

            Console.WriteLine("Student name:");
            string name = Console.ReadLine();


            students.Add(no, name);

            foreach (var item in students)
            {
                Console.WriteLine(item.Key+" - "+item.Value);
            }



        }
    }
}
