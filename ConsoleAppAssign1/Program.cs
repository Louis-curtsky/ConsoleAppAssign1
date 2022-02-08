using System;

namespace ConsoleAppAssign1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            do
            {
                PrintMenu();

                int assignmentSel = int.Parse(Console.ReadLine() ?? "0");

                if (assignmentSel < 5)
                {
                    MathOperation(assignmentSel);
                }
                else if (assignmentSel == 9)
                {
                        keepGoing = false;
                        Console.WriteLine("Good bye!!!");
                }
                else 
                { 
                        Console.WriteLine("Invalid selection !!!");                
                }
                Console.ResetColor();
                Console.WriteLine("Press any key to continue !");
                // key press hidden with (True)
                Console.ReadKey();
                Console.Clear();
            } while (keepGoing);
        }// End of Main

        /* 
         * Math Operation. Obtain numbers from user
         * 1:  Add two number
         * 2:  Subtract second number from First number
         * 3:  Multiply first and second number
         * 4:  Divide first number by second number. Zero is checked in second
        */

        static void MathOperation(int selection) 
        {

            int firstnum = UserInputNumber("Enter 1st number");
            int secondnum = UserInputNumber("Enter 2nd number");
            switch(selection)
            {
                case 1:
                    Console.WriteLine(firstnum + " + " + secondnum + " is = " + Add2num(firstnum, secondnum));
                    break;
                case 2:
                    Console.WriteLine(firstnum + " - " + secondnum + " is = " + Sub2num(firstnum, secondnum));
                    break;
                case 3:
                    Console.WriteLine(firstnum + " * " + secondnum + " is = " + Mul2num(firstnum, secondnum));
                    break;
                case 4:
                    if (secondnum > 0)
                    {
                        Console.WriteLine(firstnum + " / " + secondnum + " is = " + Div2num(firstnum, secondnum));
                    } 
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are trying to divide by ZERO !!!");
                    }
                    break;
            }
        }

        static int UserInputNumber(string what)
        {
            string inputed = UserInputStr(what);
            int number = Convert.ToInt32(inputed);
            return number;
        }

        static string UserInputStr(string userinputstr)
        {
            Console.Write("Please enter " + userinputstr + ": ");
            return Console.ReadLine();
        }

        static void PrintMenu()
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1: ADD Operation");
            Console.WriteLine("2: SUBTRACT Operation");
            Console.WriteLine("3: MULTIPLICATION Operation");
            Console.WriteLine("4: DIVISION Operation");
            Console.WriteLine("9: Exit program");
            Console.WriteLine("\nEnter you choice: ");
        }

        static int Add2num(int num1, int num2)
        {
            int tot = num1 + num2;
            return tot;
        }

        static int Sub2num(int num1, int num2) 
        {
            int tot = num1 - num2;
            return tot;
        }

        static int Mul2num(int num1, int num2) 
        {
            int tot = num1 * num2;
            return tot;
        }

        static double Div2num(double num1, double num2)
        {
            double tot = num1 / num2;
            return tot;
        }
    }
}
