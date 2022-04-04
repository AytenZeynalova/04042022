using System;
using LibraryClass;

namespace _04042022
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello6";
            int i = 7;
            Console.WriteLine($"is it odd? -> {i.IsOdd()}");
            Console.WriteLine($"is it even?-> {i.IsEven()}");
            Console.WriteLine($"has digit? -> {str.HasDigit()}");
            Console.WriteLine($"to capitalize letters -> {str.ToCapitalize()}");

            //////////////////////////////////////////////////////////////////////
            string GroupNo = "";
            do
            {
                Console.WriteLine("include group num ");
                GroupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(GroupNo));
            Console.WriteLine(GroupNo);

            Console.WriteLine("include age");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(age);
        }
    }
}
