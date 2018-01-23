using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome. If your fortune is what you seek, you are in the right place! \nWhat is your first name?");
            string userFirstName = Console.ReadLine();
            switch (userFirstName)
            {
                case "Pete":
                    Console.WriteLine("Uh oh....might be trouble ahead");
                    break;
            }
            Console.WriteLine("What is your last name?");
            string userLastName = Console.ReadLine();
            switch (userLastName)
            {
                case "Fittante":
                    Console.WriteLine("oh man");
                    break;
}
            Console.WriteLine("Please enter your current age");
            int userAge = int.Parse(Console.ReadLine());
            int workYears = userAge % 2;

            switch (workYears)
            {
                case 1:
                    workYears = 30;
                    break;
                default:
                    workYears = 35;
                    break;
            }


            Console.WriteLine("Please enter the month you were born.");  
            int userBirthMonth = int.Parse(Console.ReadLine());

            
            string moneyTotal = "1";

            if ((userBirthMonth <= 0) || (userBirthMonth >= 13))
            {
                moneyTotal = "$0.00";
            }
            if ((userBirthMonth >= 1) && (userBirthMonth <= 4))

            {
                moneyTotal = "$1,000,000";
            }


            if ((userBirthMonth >= 9) && (userBirthMonth <= 12))
            {
                moneyTotal = "$5,000,000";
            }

            else if ((userBirthMonth >= 5) && (userBirthMonth <= 8))
            {
                moneyTotal = "$9,000,000";
            }

            Console.WriteLine("From the ROYGBIV sequence, choose your favorite color");
            string userColor = Console.ReadLine().ToLower();
            string userVehicle = "car";
            switch (userColor)
            {
                case "red":
                    userVehicle = "1967 VW Beetle";
                    break;
                case "orange":
                    userVehicle = "1969 Dodge Charger";
                    break;

                case "yellow":
                    userVehicle = "2002 Daewoo Lanos";
                    break;
                case "green":
                    userVehicle = "Mercedes-AMG GT R";
                    break;
                case "blue":
                    userVehicle = "2006 Honda Civic";
                    break;
                case "indigo":
                    userVehicle = "2010 Chevy Cruze";
                    break;
                case "violet":
                    userVehicle = "2011 Porsche Carrera";
                    break;
                case "help":
                    Console.WriteLine("Choose from red, orange, yellow, green, blue, indigo, violet.");
                    break;
                default:
                    Console.WriteLine("Choose from red, orange, yellow, green, blue, indigo, violet.");
                    break;

            }

            userColor = Console.ReadLine().ToLower();

            switch (userColor)

            {
                case "red":
                    break;
                case "orange":
                    break;
                case "yellow":
                    break;
                case "green":
                    break;
                case "indigo":
                    break;
                case "violet":
                    break;


            }

            switch (userColor)
            {
                case "red":
                    userVehicle = "1967 VW Beetle";
                    break;
                case "orange":
                    userVehicle = "1969 Dodge Charger";
                    break;

                case "yellow":
                    userVehicle = "2002 Daewoo Lanos";
                    break;
                case "green":
                    userVehicle = "Mercedes-AMG GT R";
                    break;
                case "blue":
                    userVehicle = "2006 Honda Civic";
                    break;
                case "indigo":
                    userVehicle = "2010 Chevy Cruze";
                    break;
                case "violet":
                    userVehicle = "2011 Porsche Carrera";
                    break;
            }



            Console.WriteLine("How many siblings do you have?");
            int userSiblings = int.Parse(Console.ReadLine());
            string location = "home";

            switch (userSiblings)
            {
                case 0:
                    location = "Seattle";
                    break;
                case 1:
                    location = "Sandusky";
                    break;
                case 2:
                    location = "Toledo";
                    break;
                case 3:
                    location = "Detroit";
                    break;
            }

            if (userSiblings < 0)
                location = "North Korea";
            if (userSiblings > 3)
                location = "Florida";

            Console.WriteLine("\nOne moment while I prepare your fortune for you...\n");

            Console.WriteLine(userFirstName + " " + userLastName + " will retire in " + workYears + " years with " + moneyTotal + " in the bank, \na vacation home in " + location + " and a " + userVehicle + ".");











        }
    }
}











