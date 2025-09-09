using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator");
            Console.WriteLine("Pick an Operation\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int CHOICE))
            {
                if (CHOICE == 1)
                {
                    Console.Write("Enter First Number: ");
                    string a = Console.ReadLine();
                    if (int.TryParse(a, out int A))
                    {
                        Console.Write("Enter Second Number: ");
                        string b = Console.ReadLine();
                        if (int.TryParse(b, out int B))
                        {
                            int ADD = Add(A, B);
                            Console.WriteLine("The Sum of " + A + " and " + B + " is " + ADD);
                        }
                    }
                } else if (CHOICE == 2)
                {
                    Console.Write("Enter First Number: ");
                    string a = Console.ReadLine();
                    if (int.TryParse(a, out int A))
                    {
                        Console.Write("Enter Second Number: ");
                        string b = Console.ReadLine();
                        if (int.TryParse(b, out int B))
                        {
                            int SUB = Sub(A, B);
                            Console.WriteLine("The Subtraction of " + A + " and " + B + " is " + SUB);
                        }
                    }
                } else if (CHOICE == 3)
                {
                    Console.Write("Enter First Number: ");
                    string a = Console.ReadLine();
                    if (int.TryParse(a, out int A))
                    {
                        Console.Write("Enter Second Number: ");
                        string b = Console.ReadLine();
                        if (int.TryParse(b, out int B))
                        {
                            int TIMES = Times(A, B);
                            Console.WriteLine("The Multipliation of " + A + " and " + B + " is " + TIMES);
                        }
                    }
                } else if (CHOICE == 4)
                {
                    Console.Write("Enter First Number: ");
                    string a = Console.ReadLine();
                    if (int.TryParse(a, out int A))
                    {
                        Console.Write("Enter Second Number: ");
                        string b = Console.ReadLine();
                        if (int.TryParse(b, out int B))
                        {
                            int DIV = Div(A, B);
                            Console.WriteLine("The Division of " + A + " and " + B + " is " + DIV);
                        }
                    }
                }
            }
        }

        static int Add (int A, int B)
        {
           
            int Addition = (A + B);
            return Addition;
        }

        static int Sub (int Y, int Z)
        {
            int Subtraction = Y - Z; return Subtraction;  
        }
        static int Times ( int A,int B)
        {
            int Times = A * B;
            return Times;
        }
        static int Div (int A, int B)
        {
            int Divition = A / B;
            return Divition;
        }

    }
}
