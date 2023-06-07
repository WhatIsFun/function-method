using System.ComponentModel;

namespace functions_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _     _  _______  ___      _______  _______  __   __  _______    _______  _______ ");
            Console.WriteLine("| | _ | ||       ||   |    |       ||       ||  |_|  ||       |  |       ||       | ");
            Console.WriteLine("| || || ||    ___||   |    |       ||   _   ||       ||    ___|  |_     _||   _   | ");
            Console.WriteLine("|       ||   |___ |   |    |       ||  | |  ||       ||   |___     |   |  |  | |  | ");
            Console.WriteLine("|       ||    ___||   |___ |      _||  |_|  ||       ||    ___|    |   |  |  |_|  | ");
            Console.WriteLine("|   _   ||   |___ |       ||     |_ |       || ||_|| ||   |___     |   |  |       | ");
            Console.WriteLine("| __||__||_______||_______||_______||_______||_|  |_||_______|     |___|  |_______|");
            Console.WriteLine(" _     _  __   __  _______  _______  ___   _______  _______  __   __  __    _       ");
            Console.WriteLine("| | _ | ||  | |  ||   _   ||       ||   | |       ||       ||  | |  ||  |  | |      ");
            Console.WriteLine("| || || ||  |_|  ||  |_|  ||_     _||   | |  _____||    ___||  | |  ||   |_| |      ");
            Console.WriteLine("|       ||       ||       |  |   |  |   | | |_____ |   |___ |  |_|  ||       |      ");
            Console.WriteLine("|       ||       ||       |  |   |  |   | |_____  ||    ___||       ||  _    |      ");         
            Console.WriteLine("|   _   ||   _   ||   _   |  |   |  |   |  _____| ||   |    |       || | |   |      ");
            Console.WriteLine("|__| |__||__| |__||__| |__|  |___|  |___| |_______||___|    |_______||_|  |__|      ");
            Console.WriteLine(" _______  _______  ___      _______  __   __  ___      _______  _______  _______  ______");
            Console.WriteLine("|       ||   _   ||   |    |       ||  | |  ||   |    |   _   ||       ||       ||    _ |");
            Console.WriteLine("|       ||  |_|  ||   |    |       ||  | |  ||   |    |  |_|  ||_     _||   _   ||   | ||");
            Console.WriteLine("|       ||       ||   |    |       ||  |_|  ||   |    |       |  |   |  |  | |  ||   |_||_");
            Console.WriteLine("|      _||       ||   |___ |      _||       ||   |___ |       |  |   |  |  |_|  ||    __  |");
            Console.WriteLine("|     |_ |   _   ||       ||     |_ |       ||       ||   _   |  |   |  |       ||   |  | |");
            Console.WriteLine("|_______||__| |__||_______||_______||_______||_______||__| |__|  |___|  |_______||___|  |_|");
            

            printMenu();
        }

        static void printMenu() {
            Console.WriteLine("***************************");
            Console.Write("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a method to continue");
            Console.WriteLine("\\\\\\\\\\\\////////////");
            Console.WriteLine("A) Addition");
            Console.WriteLine("B) Subtraction");
            Console.WriteLine("C) Multiplication");
            Console.WriteLine("D) Division");
            Console.WriteLine("\\\\\\\\\\\\////////////");
            Console.WriteLine("* * * Print exit to exit the program * * *");
            
            Console.Write("Choose your operation>>>> ");
            string task = Console.ReadLine();
            int res;
            string value;

            switch (task) { 
                case "A" or "a":
                    add();
                    break;
                case "B" or "b":
                    subtract();
                    break;
                case "C" or "c":
                    multiple();
                    break;
                case "D" or "d":
                    div();
                    break;
                case "exit":
                    endProgram();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    printMenu();
                    break;

            }
             void add()
            {
                res = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + res);
                continueProgram();
            }
            void subtract()
            {
                res = num1 - num2;
                Console.WriteLine(num1 +" - " + num2 + " = " + res);
                continueProgram();

            }
            void multiple()
            {
                res = num1 * num2;
                Console.WriteLine(num1 + " x " + num2 + " = " + res);
                continueProgram();
            }

            void div()
            {
                res = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + res);
                continueProgram();
            }
            void endProgram()
            {
                Console.WriteLine("\\\\ Thank You For Using WhatIsFun Calculator ////");
                Console.ReadLine();
            }
            void continueProgram()
            {
                Console.Write("Do you want to continue(y/n):");
                string value = Console.ReadLine();
                if (value == "y")
                {
                    printMenu();
                }
                else
                {
                    endProgram();
                }
            }
        



        }
    }
}