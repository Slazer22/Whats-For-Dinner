/* This Program will prompt the user to choose an Entree for dinner.*/

using System;




namespace Dinner
{

    class Menu
    {


        public static void Main(string[] args)
        {
            int response;

            Console.WriteLine("What are you eating tonight?");
            Console.ReadKey();

            Console.WriteLine("1. Shrimp Scampi");
            Console.WriteLine("2. Chicken Alfredo");
            Console.WriteLine("3. Lobster Tail");

            response = Console.Read();

            switch(response) 
            {
                case '1':
                    Console.WriteLine("Shrimp Scampi coming right up!");
                    break;

                case '2':
                    Console.WriteLine("Chicken Alfredo Coming right up!");
                        break;

                case '3':
                    Console.WriteLine("Ooohhhh You Fancy huh, Lobster Tail coming right up!");
                    break;


                default: Console.WriteLine("Do you need more time to look at the menu");
                    break;



            }

        }

    }
}
