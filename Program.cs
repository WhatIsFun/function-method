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
            Console.Write("Enter first number: ");//User input first number
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: "); //User input second number
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick a method to continue"); 
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine("A) Addition");
            Console.WriteLine("B) Subtraction");
            Console.WriteLine("C) Multiplication");
            Console.WriteLine("D) Division");
            Console.WriteLine("//////////////////////");
            Console.WriteLine("* * * Print exit to quit the program * * *"); // to quit the program
            
            Console.Write("Choose your operation>>>> "); //User choose which operation want
            string task = Console.ReadLine();
            int res;
            string value;

            switch (task) { // switch statment 
                case "A" or "a":
                    add(); // addition method
                    break;
                case "B" or "b":
                    subtract(); // subtraction method
                    break;
                case "C" or "c":
                    multiple(); // multiplication method
                    break;
                case "D" or "d":
                    div(); // division method
                    break;
                case "exit":
                    endProgram();
                    break;
                default:
                    Console.WriteLine("Wrong input"); // if user enter another value the program will print Wrong input and return to the menu
                    printMenu();
                    break;

            }
             void add()
            {
                res = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + res); // num1+num2 = result
                continueProgram();
            }
            void subtract()
            {
                res = num1 - num2;
                Console.WriteLine(num1 +" - " + num2 + " = " + res);// num1-num2 = result
                continueProgram();

            }
            void multiple()
            {
                res = num1 * num2;
                Console.WriteLine(num1 + " x " + num2 + " = " + res);// num1xnum2 = result
                continueProgram();
            }

            void div()
            {
                res = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + res); // num1/num2 = result
                continueProgram();
            }
            void endProgram() // this method to end the program 
            {
                Console.WriteLine("\\\\ Thank You For Using WhatIsFun Calculator ////");
                Console.ReadLine();
            }
            void continueProgram() // this method to keep the program after the operation done, it will ask the user if want to continue or not. if not the program will exit
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