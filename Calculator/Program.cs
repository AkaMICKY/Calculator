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
            Console.Write("--Option: ");
            string choice = Console.ReadLine();
            if (int.TryParse(choice, out int CHOICE))
            {
                if (CHOICE == 1)
                {
                    Console.Write("Enter First Number: ");
                    string a = Console.ReadLine();
                    if (double.TryParse(a, out double A))
                    {
                        Console.Write("Enter Second Number: ");
                        string b = Console.ReadLine();
                        if (double.TryParse(b, out double B))
                        {
                            double ADD = Add(A, B);
                            Console.WriteLine("The Sum of " + A + " and " + B + " is " + ADD);
                        }
                    }
                } else if (CHOICE == 2)
                {
                    Console.Write("Enter First Number: ");
                    string y = Console.ReadLine();
                    if (double.TryParse(y, out double Y))
                    {
                        Console.Write("Enter Second Number: ");
                        string z = Console.ReadLine();
                        if (double.TryParse(z, out double Z))
                        {
                            double SUB = Sub(Y, Z);
                            Console.WriteLine("The Subtraction of " + Y + " and " + Z + " is " + SUB);
                        }
                    }
                } else if (CHOICE == 3)
                {
                    Console.Write("Enter First Number: ");
                    string c = Console.ReadLine();
                    if (double.TryParse(c, out double C))
                    {
                        Console.Write("Enter Second Number: ");
                        string d = Console.ReadLine();
                        if (double.TryParse(d, out double D))
                        {
                            double TIMES = Times(C, D);
                            Console.WriteLine("The Multipliation of " + C + " and " + D + " is " + TIMES);
                        }
                    }
                } else if (CHOICE == 4)
                {
                    Console.Write("Enter First Number: ");
                    string e = Console.ReadLine();
                    if (double.TryParse(e, out double E))
                    {
                        Console.Write("Enter Second Number: ");
                        string f = Console.ReadLine();
                        if (double.TryParse(f, out double F))
                        {
                            double DIV = Div(E, F);
                            Console.WriteLine("The Division of " + E + " and " + F + " is " + DIV);
                        }
                    }
                }
            }
        }

        static double Add (double A, double B)
        {
           
            double Addition = (A + B);
            return Addition;
        }

        static double Sub (double Y, double Z)
        {
            double Subtraction = Y - Z; return Subtraction;  
        }
        static double Times ( double A,double B)
        {
            double Times = A * B;
            return Times;
        }
        static double Div (double A, double B)
        {
            double Divition = A / B;
            return Divition;
        }

    }
}
