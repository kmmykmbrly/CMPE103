using System;
using System.Collections.Generic;

namespace waffleO
{
    class Program
    {
        static void Main()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;
            string orderAgain;
            bool Menu = true;
            while (Menu) 

            {
                //  Shop Menu
                waffleOMenu();

                // Getting Order
                string userInput = Console.ReadLine();

                // Condition
                if (userInput == "1")
                {
                    conditionOne();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                   
                }

                if (userInput == "2")
                {
                    conditionTwo ();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }

                if (userInput == "3")
                {
                    conditionThree ();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }

                if (userInput == "4")
                {
                    conditionFour ();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }

                if (userInput == "5")
                {
                    conditionFive ();
                    orderAgain = Console.ReadLine();
                    if (orderAgain != "Y")
                        Menu = false;
                    if (orderAgain == "N")
                    {
                        Console.WriteLine("OKAY, THANK YOU AND WE HOPE YOU COME AGAIN!!! ");
                    }
                }

            }
        }

        static void waffleOMenu()
        {
            var waffleOMenu = new List<string>()
            { "Welcome to Waffle-O!", "******************* Menu *******************", "1. Plain Waffle      ---------------Php30.00",
            "2. Peanut Waffle     ---------------Php40.00", "3. Vanilla Waffle    ---------------Php45.00",
            "4. Chocolate Waffle  ---------------Php45.00", "5. Strawberry Waffle ---------------Php55.00",
            "--------------------------------------------", " "};

            foreach (string i in waffleOMenu)
            {
                Console.WriteLine(i);
            }

            var gettingOrder = new List<string>()
            {"Can I get your order po?", "Please select the number you want to order", " "};

            foreach (string i in gettingOrder)
            {
                Console.WriteLine(i);
            }

        }

        static void conditionOne()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;

            var conditionOne = new List<string>()
            {"Plain Waffle = Php30.00", " ", "How many?"};
            
            foreach (string i in conditionOne)
            {
                Console.WriteLine(i);
            }

            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 30;

            var dineInOrtakeOut = new List<string>()
            {"Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out", 
            " "};
            
            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }

        static void conditionTwo() 
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;

            var conditionTwo = new List<string>() 
            {"Peanut Waffle = Php40.00", "How many?", " "}; 
            
            foreach (string i in conditionTwo) 
            {
                Console.WriteLine(i);
            }
            
            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 40;

            var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out", 
            " "};
            
            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }
        
        static void conditionThree() 
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;
            
            var conditionThree = new List<string>() 
            {"Vanilla Waffle = Php45.00", "How many?", " "};
            
            foreach (string i in conditionThree) 
            {
                Console.WriteLine(i);
            }
            
            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 45;
            
             var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out", 
            " "};
            
            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }
        
        static void conditionFour()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;
            
            var conditionFour = new List<string>() 
            {"Chocolate Waffle = Php45.00", "How many?", " "};
            
            foreach (string i in conditionFour) 
            {
                Console.WriteLine(i);
            }
            
            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 45;
            
             var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out", 
            " "};
            
            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
        }
        
        static void conditionFive() 
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;
            
            var conditionFive = new List<string>() 
            {"Strawberry Waffle = Php55.00", "How many?", " "};
            
            foreach (string i in conditionFive) 
            {
                Console.WriteLine(i);
            }
            
            numOrder = Convert.ToInt32(Console.ReadLine());
            total = numOrder * 55;
            
             var dineInOrtakeOut = new List<string>()
            {" ", "Dine in?? or Take out??", "If take out, there is an additional fee of Php5.00", "Type A, if Dine In. Type B, If Take out", 
            " "};
            
            foreach (string i in dineInOrtakeOut)
            {
                Console.WriteLine(i);
            }

            string cusInput = Console.ReadLine();

            if (cusInput == "A")
            {
                Console.WriteLine("Your total bill: Php" + total);
                Console.WriteLine("Thank you, have a great day ahead!");
            }
            if (cusInput == "B")
            {
                finalTotal = total + 5;
                Console.WriteLine("Your total bill: Php" + finalTotal);
                Console.WriteLine("Thank you, have a great day ahead!");
            }

            Console.WriteLine("Would you like to order again??");
            Console.WriteLine("If you like to order again press 'Y', if no press 'N' ");
            
        }
    }
}
