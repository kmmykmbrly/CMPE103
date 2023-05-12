using System;

namespace waffleO 
{
    class Program
    {
        static void Main()
        {
            int numOrder = 1;
            double total = 0;
            double finalTotal = 0;
            
            //  Shop Menu
            Console.WriteLine("Welcome to Waffle-O!");
            Console.WriteLine("******************* Menu *******************");
            Console.WriteLine("1. Plain Waffle      ---------------Php30.00");
            Console.WriteLine("2. Peanut Waffle     ---------------Php40.00");
            Console.WriteLine("3. Vanilla Waffle    ---------------Php45.00");
            Console.WriteLine("4. Chocolate Waffle  ---------------Php45.00");
            Console.WriteLine("5. Strawberry Waffle ---------------Php55.00");
            Console.WriteLine("--------------------------------------------");
            
            // Getting Order
            Console.WriteLine("Can I get your order po?");
            Console.WriteLine("Please select the number you want to order");
            string userInput = Console.ReadLine();
            
            // Condition
            if (userInput == "1"){ 
                Console.WriteLine("Plain Waffle = Php30.00");
                Console.WriteLine("How many?");
                numOrder = Convert.ToInt32(Console.ReadLine());
                total = numOrder * 30;

                Console.WriteLine("Dine in or Take out");
                Console.WriteLine("If take out, there is an additional fee of Php5.00");
                Console.WriteLine("Type A, if Dine In. Type B, If Take out");
                string cusInput = Console.ReadLine();
                
                if (cusInput == "A"){
                    Console.WriteLine("Your total bill: Php" + total);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
                if (cusInput == "B"){
                    finalTotal = total + 5;
                    Console.WriteLine("Your total bill: Php" + finalTotal);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
            }  
            
            if (userInput == "2"){ 
                Console.WriteLine("Peanut Waffle = Php40.00");
                Console.WriteLine("How many?");
                numOrder = Convert.ToInt32(Console.ReadLine());
                total = numOrder * 40;

                Console.WriteLine("Dine in or Take out");
                Console.WriteLine("If take out, there is an additional fee of Php5.00");
                Console.WriteLine("Type A, if Dine In. Type B, If Take out");
                string cusInput = Console.ReadLine();
                
                if (cusInput == "A"){
                    Console.WriteLine("Your total bill: Php" + total);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
                if (cusInput == "B"){
                    finalTotal = total + 5;
                    Console.WriteLine("Your total bill: Php" + finalTotal);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
            }
            
            if (userInput == "3"){ 
                Console.WriteLine("Vanilla Waffle = Php45.00");
                Console.WriteLine("How many?");
                numOrder = Convert.ToInt32(Console.ReadLine());
                total = numOrder * 45;

                Console.WriteLine("Dine in or Take out");
                Console.WriteLine("If take out, there is an additional fee of Php5.00");
                Console.WriteLine("Type A, if Dine In. Type B, If Take out");
                string cusInput = Console.ReadLine();
                
                if (cusInput == "A"){
                    Console.WriteLine("Your total bill: Php" + total);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
                if (cusInput == "B"){
                    finalTotal = total + 5;
                    Console.WriteLine("Your total bill: Php" + finalTotal);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
            }
            
            if (userInput == "4"){ 
                Console.WriteLine("Chocolate Waffle = Php45.00");
                Console.WriteLine("How many?");
                numOrder = Convert.ToInt32(Console.ReadLine());
                total = numOrder * 45;

                Console.WriteLine("Dine in or Take out");
                Console.WriteLine("If take out, there is an additional fee of Php5.00");
                Console.WriteLine("Type A, if Dine In. Type B, If Take out");
                string cusInput = Console.ReadLine();
                
                if (cusInput == "A"){
                    Console.WriteLine("Your total bill: Php" + total);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
                if (cusInput == "B"){
                    finalTotal = total + 5;
                    Console.WriteLine("Your total bill: Php" + finalTotal);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
            }
            
            if (userInput == "5"){ 
                Console.WriteLine("Strawberry Waffle = Php55.00");
                Console.WriteLine("How many?");
                numOrder = Convert.ToInt32(Console.ReadLine());
                total = numOrder * 55;

                Console.WriteLine("Dine in or Take out");
                Console.WriteLine("If take out, there is an additional fee of Php5.00");
                Console.WriteLine("Type A, if Dine In. Type B, If Take out");
                string cusInput = Console.ReadLine();
                
                if (cusInput == "A"){
                    Console.WriteLine("Your total bill: Php" + total);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
                if (cusInput == "B"){
                    finalTotal = total + 5;
                    Console.WriteLine("Your total bill: Php" + finalTotal);
                    Console.WriteLine("Thank you, have a great day ahead!");
                }
            }
            
        }
    }
}

