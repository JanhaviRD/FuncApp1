using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyNameSpace
{
    public class MyMaths
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }

    public class MyString
    {
        public string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string[] Split(string str, char delimiter)
        {
            return str.Split(delimiter);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyMaths maths = new MyMaths();
            Console.WriteLine("\n-----------------------------------MATHS OPERATIONS------------------------------------\n");
            Console.Write("Enter first integer:\n ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer:\n ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1.Addition of two integers:\n " + maths.Add(num1, num2));
            Console.WriteLine("2.Subtraction of two integers:\n " + maths.Sub(num1, num2));
            Console.WriteLine("3.Multiplication of two integers:\n " + maths.Mul(num1, num2));
            Console.WriteLine("-----------------------------------------------------------------------------------------\n\n\n");
            Console.WriteLine("\n-----------------------------------STRING OPERATIONS-----------------------------------\n");
            MyString str = new MyString();

            Console.Write("1.Enter a string to reverse: \n");
            string strToReverse = Console.ReadLine();

            Console.WriteLine("Reverse of the string: \n" + str.Reverse(strToReverse));

            Console.Write("2.Enter a string to split: \n");
            string strToSplit = Console.ReadLine();

            Console.Write("Enter a delimiter to split by:\n ");
            char delimiter = char.Parse(Console.ReadLine());

            string[] splitStrings = str.Split(strToSplit, delimiter);

            Console.WriteLine("Splitting the string: \n");

            foreach (string s in splitStrings)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}

