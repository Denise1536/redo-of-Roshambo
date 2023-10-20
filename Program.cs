using redo_of_Roshambo;

bool keepPlaying;
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
Console.WriteLine();

do
{
    
    //If the user makes an invalid selection, the application should display an appropriate
    //error message and prompt the user again until the user makes a valid selection.

    //Validate your user inputs throughout your app. Try catch blocks, if statements, or any
    //other method of validation is good.

    Console.WriteLine($"Hi {name}, would you like to play against Laura or Jon?");
    string opponentChoice = Console.ReadLine();
    Console.WriteLine();

    
    int humanValue = -2;
    HumanPlayer User = new HumanPlayer();
    Roshambo humanPlayerResult = User.GenerateRoshambo();
    humanValue = (int)humanPlayerResult;

    int rockValue = -1;
    int randomValue = -1;

    switch (opponentChoice)
    {
        case "Jon":
            RockPlayer Jon = new RockPlayer();
            Roshambo rockPlayerResult = Jon.GenerateRoshambo();

            Console.WriteLine($"Your opponent chose {Jon.GenerateRoshambo()}.");
            rockValue = (int)rockPlayerResult;

            break;

        case "Laura":
            RandomPlayer Laura = new RandomPlayer();
            Roshambo randomPlayerResult = Laura.GenerateRoshambo();

            Console.WriteLine($"Your opponent chose {Laura.GenerateRoshambo()}.");
            randomValue = (int)randomPlayerResult;

           break;
    }

    DetermineRandomResult(randomValue, humanValue);
    DetermineRockResult(rockValue, humanValue);

    //The application continues until the user doesn’t want to play anymore.
    Console.WriteLine("Do you want to play again? (y/n)");
    string yesno = Console.ReadLine();

    if (yesno == "y")
    { keepPlaying = true; }
    else if (yesno == "n")
    { keepPlaying = false; }




    string DetermineRandomResult(int randomValue, int humanValue)
    {
        if (randomValue != -1)
        {
            if (randomValue == humanValue)
            { return "You tied!"; }

            else if (randomValue == 1 && humanValue == 2)
            { return "You win!"; }

            else if (randomValue == 2 && humanValue == 3)
            { return "You lost!"; }

            else if (randomValue == 3 && humanValue == 1)
            { return "You win!"; }

            else if (randomValue == 1 && humanValue == 3)
            { return "You lost!"; }

            else if (randomValue == 2 && humanValue == 1)
            { return "You lost!"; }

            else if (randomValue == 3 && humanValue == 2)
            { return "You lost!"; }

            else //user shouldn't see this
            { return "Lizard"; }

        }

        else { return "Good game!"; }

    }


    string DetermineRockResult(int rockValue, int humanValue)
    {
     if (rockValue != -1)
        {
            if (rockValue == humanValue)
            { return "You tie!"; }

            else if (rockValue == 1 && humanValue == 2)
            { return "You win!"; }

            else if (rockValue == 1 && humanValue == 3)
            { return "You lost!"; }

            else //user shouldn't see this
            { return "Lizard!"; }

        }

        else { return "Good game!"; }

    }


} while (keepPlaying = true);
