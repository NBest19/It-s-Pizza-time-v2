using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using static It_s_Pizza_time.SmallPizza;
using static It_s_Pizza_time.SmallPizza.MediumPizza;

namespace It_s_Pizza_time
{
    internal class Pizza_Select
    {

       
      
        public Pizza_Select()
        {
            // links to PizzaSize class// 

            SmallPizza smallPizza = new SmallPizza();

            MediumPizza mediumPizza = new MediumPizza();

            LargePizza largePizza = new LargePizza();

            //Count for amount of Pizzas// 

            int smallCount = 0, mediumCount = 0, largeCount = 0;

            
          var SmallAmount = smallCount * smallPizza.Price;

            string pizzaSize;

            while (true)
            {
                Console.Write("Please select a pizza base: Small, Medium, Or Large " +
                   "To place your order please enter Confirm: ");

                pizzaSize = Console.ReadLine();

                if (pizzaSize.Trim() == "Small" || pizzaSize == "small")
                {
                    smallCount++;
                }
                else if (pizzaSize.Trim() == "Medium" || pizzaSize == "medium")

                    mediumCount++;

                else if (pizzaSize.Trim() == "Large" || pizzaSize == "large")
                {
                    largeCount++;
                }
                   
                 else if (string.IsNullOrEmpty(pizzaSize))
            {
                Console.WriteLine("Invalid Input.");
                    
            }
                else if (pizzaSize == "Confirm" || pizzaSize == "confirm")
                {
                    Console.WriteLine($"Your order has been confirmed: {smallCount} Small Pizza £" + smallCount * smallPizza.Price);
                    Console.WriteLine($"Your order has been confirmed: {mediumCount} Medium Pizza £" + mediumCount * mediumPizza.Price);
                    Console.WriteLine($"Your order has been confirmed: {largeCount} Large Pizza £" + largeCount * largePizza.Price);

                    break;
                }
            
          
               

              
            }

        }

    }
}