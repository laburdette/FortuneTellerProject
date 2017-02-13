using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2ProjectLindseyLoweFortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {//beginning of project

            Console.WriteLine("Welcome to the Fortune Teller program!  My crytal ball needs to ask you a few \nquestions to get started...");
            
            //Save code below to work on bonus question-- pushing "quit" to end program.
            //string userQuit = Console.ReadLine().ToLower();
            //string quit = userQuit;



            //PART 1: Save all responses from user to use later 
            Console.WriteLine("What is your first name?");
            string userFirstName = Console.ReadLine().ToLower();


            Console.WriteLine("What is your last name?");
            string userLastName = Console.ReadLine().ToLower();


            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born in? Enter in the number representing the month: ");
            int userBirthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color? Type \"help\" if you need an explanation.");
            string userColor = Console.ReadLine().ToLower(); //saves user answer from either the 'help' section or the ROYGBIV question

            string[] allColors = { "R = Red", "O = Orange", "Y = Yellow", "G = Green", "B = Blue", "I = Indigo", "V = Violet" };
            //colors saved as elements in an array
            if (userColor == "help") //if user types in 'help' they get a definition of ROYGBIV
            {
                foreach (string color in allColors) //each element ('color') in array printed
                
                {
                    Console.WriteLine(color);
                }
                Console.WriteLine("What is your favorite color?"); //reminds user to enter in answer after definition displayed
                userColor = Console.ReadLine().ToLower(); //saves answer
            }

            Console.WriteLine("How many siblings do you have?");
            int userSiblings = int.Parse(Console.ReadLine());


            //Part 2

            //Age even or odd:

            int retireAge;
            if (userAge % 2 == 0)
            {
                retireAge = 50;

            }
            else
            {
                retireAge = 20;

            }

            //Number of siblings:

            string siblingAmount = Convert.ToString(userSiblings);
            if (userSiblings == 0)
            {
                siblingAmount = "Bahamas";
            }

            else if (userSiblings == 1)
            {
                siblingAmount = "Sweden";
            }

            else if (userSiblings == 2)
            {
                siblingAmount = "Ohio";
            }

           else if (userSiblings == 3)
            {
                siblingAmount = "Bermuda";
            }

            else if (userSiblings > 3)
            {
                siblingAmount = "Florida";
            }

            else
            {
                siblingAmount = "a tent";
            }


            //Mode of transportation:

            string transport;
            if (userColor == allColors[0]) 
            {
                transport = "car";
            }
            else if (userColor == allColors[1]) 
            {
                transport = "boat";
            }
            else if (userColor == allColors[2]) 
            {
                transport =  "Cadillac";
            }
            else if (userColor == allColors[3]) 
            {
                transport =  "helicopter";
            }
           else if (userColor == allColors[4]) 
            {
                transport = "a sled pulled by cats";
            }
            else if (userColor == allColors[5]) 
            {
                transport = "motorcycle";
            }
            else
            {
                transport = "plane";
            }

            //Use birth month to decide money in the bank:

            int bankAmount;
            if (userBirthMonth <5)
            {
                bankAmount = 100;
            }
            else if (userBirthMonth <9)
            {
                bankAmount = 500;
            }
            else if (userBirthMonth <13)
            {
                bankAmount = 900;
            }
            else
            {
                bankAmount = 0;
            }

            //Part 3: display fortune

            Console.WriteLine(userFirstName + " " + userLastName + ", I see in my crystal ball that you will retire in " + retireAge + " years with \n  $" + bankAmount + " in the bank!  Your vacation home will be in " + siblingAmount + " and you will be getting around by " + transport + "!");








        }  //end of program
    }
}
