using System;

namespace UnitOneDeliverableOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize vacationType (string), groupSize (int), result (string)
            string vacationType="";
            int groupSize = 0;
            string result="";

            //get user input on type of trip to take, Musical, Tropical, or Adventurous
            Console.Write("What kind of trip would you like to go on: musical, tropical, or adventurous? : ");
            vacationType = Console.ReadLine();
            //get user input re: size of the group
            Console.Write("How many are in your group? ");
            groupSize = int.Parse(Console.ReadLine());
            //setting logical output variables
            string destination = "";
            string travelSuggestion = "";

            //logic
            //logic for vacationType
            if (vacationType == "Musical" || vacationType=="musical")
            {
                destination = "New Orleans";
            }
            else if (vacationType == "Tropical" || vacationType=="tropical")
            {
                destination = "Beach Vacation in Mexico";
            }
            else if (vacationType == "Adventurous" || vacationType=="adventurous")
            {
                destination = "Whitewater Rafting the Grand Canyon";
            }
            //logic for groupSize
            if (groupSize > 0 && groupSize <= 2) 
            {
                travelSuggestion = "First Class";
            }
            else if (groupSize>=3&&groupSize<=5)
            {
                travelSuggestion = "Helicopter";
            }
            else if (groupSize>=6)
            {
                travelSuggestion = "Charter Flight";
            }
            //set result string as concat
            result = "Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should travel by " + travelSuggestion + " to " + destination;
            Console.WriteLine(result);



        }
    }
}
