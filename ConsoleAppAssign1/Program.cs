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
                if (assignmentSel < 9)
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
 
                Console.WriteLine("Press any key to continue !");
                // key press hiden with (True)
                Console.ReadKey();
                Console.Clear();
            } while (keepGoing);
        }// End of Main

        // Menu selection 1:  Obtain 2 numbers from user and add together
        static void MathOperation(int selection) 
        {

            int firstnum = UserInputNumber("Enter 1st number");
            int secondnum = UserInputNumber("Enter 2nd number");
            switch(selection)
            {
                case 1:
                    Console.WriteLine(firstnum + " + " + secondnum + " is = " + (firstnum + secondnum));
                    break;
                case 2:
                    Console.WriteLine(firstnum + " - " + secondnum + " is = " + (firstnum - secondnum));
                    break;
            } // End of MathOperation Switch

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
            Console.WriteLine("3: xxxxx");
            Console.WriteLine("4: xxxxx");
            Console.WriteLine("9: Exit program");
        }

    }
}
