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
            //Removes Incorrect Input
            if (int.TryParse(choice, out int CHOICE))
            {
                switch (CHOICE)
                {
                    case 1:
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
                            else
                            {
                                Console.WriteLine("Invalid Number, Enter A correct Value(1,2,3,...)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Number, Enter a Correct Value(1,2,3,...)");
                        }
                        break;
                    case 2:
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
                            else
                            {
                                Console.WriteLine("Invalid Number, Enter  a Correct Value(1,2,3,...)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Inavild Number, Enter a Correct Number(1,2,3,...)");
                        }
                        break;
                    case 3:
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
                            else
                            {
                                Console.WriteLine("Inavild Number, Enter a Correct Number(1,2,3,...)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Inavild Number, Enter a Correct Number(1,2,3,...)");
                        }
                        break;
                    case 4:
                        Console.Write("Enter First Number: ");
                        string e = Console.ReadLine();
                        if (double.TryParse(e, out double E))
                        {
                            Console.Write("Enter Second Number: ");
                            string f = Console.ReadLine();
                            if (double.TryParse(f, out double F))
                            {
                                if (F == 0)
                                {
                                    Console.WriteLine("Division by zero is undefined (infinity).");
                                }
                                else
                                {
                                    double DIV = Div(E, F);
                                    Console.WriteLine("The Division of " + E + " and " + F + " is " + DIV);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Inavild Number, Enter a Correct Number(1,2,3,...)");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Inavild Number, Enter a Correct Number(1,2,3,...)");
                        }
                        break;
                    default:
                        Console.WriteLine(choice + " is  not an Option, Enter a Correct Option(1,2,3 or 4)");
                        break;
                }
            }
            else
            {
                Console.WriteLine(choice + " is  not an Option, Enter a Correct Option(1,2,3 or 4)");
            }
        }

        static double Add(double A, double B)
        {

            double Addition = (A + B);
            return Addition;
        }

        static double Sub(double Y, double Z)
        {
            double Subtraction = Y - Z; return Subtraction;
        }
        static double Times(double A, double B)
        {
            double Times = A * B;
            return Times;
        }
        static double Div(double A, double B)
        {
            double Divition = A / B;
            return Divition;
        }

    }
}
