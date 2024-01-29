//Gathering name data to be used in console statements
//establish do while loop to allow repeated play

using System;



//This code is outside of loop so i only ask name once
Console.WriteLine("Thank you for using the number analyzer!");
Console.Write("Please enter your name here >> ");
string userName = "";
userName = Console.ReadLine();
Console.Write($"Nice to meet you {userName}! ");
bool userFirstPlay = true;
bool userEngagement = true;
do
{   
    //input if else based off of user first play
    if (userFirstPlay == true) {
        Console.WriteLine($"Please enter a number between 1 and 100.");
        Console.WriteLine("...Pst!! You can also pick 1 or 100, But nothing else!!");
        userFirstPlay = false;
    }
    else
    {
        Console.WriteLine($"You know the rules! Number between 1 and 100, GO! ");
    }
    
    Console.Write(">>");


    //number analyzer starts
    int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 != 0 && userNumber < 60 && userNumber >= 1)
            {
                Console.WriteLine($"{userNumber} is a odd number and is less than 60.");
            }
            else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
            {
                Console.WriteLine($"{userNumber} is a even number and is less than 25.");
            }
            else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
            {
                Console.WriteLine($"{userNumber} is a even number and is less than 60 inclusive.");
            }
            else if (userNumber % 2 == 0 && userNumber > 60 && userNumber <= 100)
            {
                Console.WriteLine($"{userNumber} is a even number and is greater than 60.");
            }
            else if (userNumber % 2 != 0 && userNumber >= 60 && userNumber <= 100)
            {
                Console.WriteLine($"{userNumber} is a odd number and is greater than 60.");
            }
            else
            {
                Console.WriteLine($"That is not a valid number {userName}!");
            }
    


    //requesting if user wants to loop again
    Console.Write("Do you want to use the number analyzer again? (yes/no)");
    string userEngagementAnswer = Console.ReadLine();
    if(userEngagementAnswer.ToLower().Trim() == "yes"){
        Console.WriteLine($"Alright {userName}! lets go again!");
        Console.WriteLine("");
        userFirstPlay = false;
    }
    else if(userEngagementAnswer.ToLower().Trim() == "no")
    {
        Console.WriteLine($"You're breaking my heart {userName}! Okay... see you next time :(");
        userEngagement = false;
    }
    else
    {
        Console.WriteLine($"I dont recognize that anwser {userName}... " +
            $"you could have just said no. Ending program!");
        userEngagement = false;
    }

}while (userEngagement == true) ;