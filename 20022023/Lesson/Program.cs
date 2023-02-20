using System;
using System.Reflection;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringList strList = new StringList();
            MyList<string> strList = new MyList<string>();

            strList.Add("Hikmet");
            strList.Add("Abbas");
            strList.Add("Nermin");
            strList.Add("Tofiq");



            foreach (var item in strList.Arr)
            {
                Console.WriteLine(item);
            }


            IntList intList = new IntList();

            intList.Add(10);
            intList.Add(15);
            intList.Add(19);



            MyList<double> dblList = new MyList<double>();

            MyList<char> chrList = new MyList<char>();







        }
    }
}
