using System;
using System.Collections.Generic;

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

                if (assignmentSel < 7 && assignmentSel > 0)
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection !!!");                
                }
                Console.ResetColor();
                Console.WriteLine("Press any key to continue !");
                // key press hidden with (True)
                Console.ReadKey();
                Console.Clear();
            } while (keepGoing);
        }
// -------------- End of Main --------------

        /* 
         * Math Operation. Obtain numbers from user
         * 1:  Add two number
         * 2:  Subtract second number from First number
         * 3:  Multiply first and second number
         * 4:  Divide first number by second number. Zero is checked in second
        */

        static void MathOperation(int selection) 
        {
                int firstnum = 0;
                int secondnum = 0;
                
            switch(selection)
            {
                case 1:
                    firstnum = UserInputNumber("Enter 1st number");
                    secondnum = UserInputNumber("Enter 2nd number");
                    Console.WriteLine(firstnum + " + " + secondnum + " is = " + Add2num(firstnum, secondnum));
                    break;
                case 2:
                    firstnum = UserInputNumber("Enter 1st number");
                    secondnum = UserInputNumber("Enter 2nd number");
                    Console.WriteLine(firstnum + " - " + secondnum + " is = " + Sub2num(firstnum, secondnum));
                    break;
                case 3:
                    firstnum = UserInputNumber("Enter 1st number");
                    secondnum = UserInputNumber("Enter 2nd number");
                    Console.WriteLine(firstnum + " * " + secondnum + " is = " + Mul2num(firstnum, secondnum));
                    break;
                case 4:
                    firstnum = UserInputNumber("Enter 1st number");
                    secondnum = UserInputNumber("Enter 2nd number");
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
                case 5:
                    firstnum = UserInputNumber("Enter 1st number");
                    secondnum= UserInputNumber("Enter 2nd number");
                    var msg = firstnum > secondnum ? 
                            $"{firstnum} is greater than {secondnum}"
                            : $"{firstnum} is less than {secondnum}";
                    Console.WriteLine($"{firstnum} % {secondnum} is = "+ firstnum % secondnum);
                    break;
                case 6:
                    Console.WriteLine("--- Option 5 Area and Volume Computation --- ");
                    Exe7N8();
                    break;
                case 7:
                    Console.WriteLine("--- Option 6 List ---´\n");
                    ListEx();
                    break;
            }
        }

        private static void ListEx()
        {
            List<int> list = new List<int>() { 2, 3, 7, 11 };
            Console.WriteLine("List of Prime Numbers\n");
            foreach (int prime in list)
            {
                Console.WriteLine($"Prime Number: {prime}");
            }
            Console.WriteLine($"There are total {list.Count} in this list.");
        }

        private static void Exe7N8()
        {
            double num1Dou = UserInputDouble("Radius");

            Console.WriteLine($"The Area of {num1Dou} is: " + 2*Math.PI*num1Dou);
            Console.WriteLine($"The Volume of {num1Dou} is: " + (4*Math.PI*Math.Pow(num1Dou,3))/3);
        }

        private static double UserInputDouble(string Desc)
        {
            double numDou = 0;
            bool parseIndicator = false;

            while (parseIndicator == false)
            {
                Console.Write($"Enter a {Desc} : ");
                parseIndicator = double.TryParse(Console.ReadLine(), out numDou);

                if (!parseIndicator)
                {
                    Console.WriteLine("Indicator shows " + parseIndicator + " so please enter a valid number");
                }
            }
            return numDou;
        }

        // -------------- Math Operation --------------

        static int UserInputNumber(string what)
        {
            string inputed = UserInputStr(what);
            int number = Convert.ToInt32(inputed);
            return number;
        }
// ---------- End of UserInputNumber ----------

        static string UserInputStr(string userinputstr)
        {
            Console.Write("Please enter " + userinputstr + ": ");
            return Console.ReadLine();
        }
// ---------- End of UserInputStr ----------

        static void PrintMenu()
        {
            Console.WriteLine("----- Menu -----");
            Console.WriteLine("1: ADD Operation");
            Console.WriteLine("2: SUBTRACT Operation");
            Console.WriteLine("3: MULTIPLICATION Operation");
            Console.WriteLine("4: DIVISION Operation");
            Console.WriteLine("5  Other Operators");
            Console.WriteLine("6: Area and Volume Computation");
            Console.WriteLine("7: List Excercise");
            Console.WriteLine("9: Exit program");
            Console.Write("\nEnter you choice: ");
        }
// ---------- End of PrintMenu ----------

        static int Add2num(int num1, int num2)
        {
            int tot = num1 + num2;
            return tot;
        }
// ---------- End of End of Add2Num ----------

        static int Sub2num(int num1, int num2) 
        {
            int tot = num1 - num2;
            return tot;
        }
// ---------- End of End of Sub2Num ----------

        static int Mul2num(int num1, int num2) 
        {
            int tot = num1 * num2;
            return tot;
        }
// ---------- End of End of Mul2Num ----------

        static double Div2num(double num1, double num2)
        {
            double tot = num1 / num2;
            return tot;
        }
// ---------- End of End of Div2num ----------
    }// End of Class
}// End of NameSpace
