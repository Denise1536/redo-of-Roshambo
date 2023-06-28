//retry of Roshambo Lab

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

    Console.WriteLine($"Hi {name}, would you like to play against Rock Player or Random Player?");
    string opponentChoice = Console.ReadLine();
    Console.WriteLine();

    
    int humanValue = -1;
    HumanPlayer Bob = new HumanPlayer();
    Roshambo humanPlayerResult = Bob.GenerateRoshambo();
    humanValue = (int)humanPlayerResult;

    int rockValue = -1;
    int randomValue = -1;

    switch (opponentChoice)
    {
        case "Rock Player":
            RockPlayer Peter = new RockPlayer();
            Roshambo rockPlayerResult = Peter.GenerateRoshambo();

            Console.WriteLine($"Your opponent chose {Peter.GenerateRoshambo()}.");
            rockValue = (int)rockPlayerResult;
            break;

        case "Random Player":
            RandomPlayer Frank = new RandomPlayer();
            Roshambo randomPlayerResult = Frank.GenerateRoshambo();

            Console.WriteLine($"Your opponent chose {Frank.GenerateRoshambo()}.");
            randomValue = (int)randomPlayerResult;
            break;
    }

    DetermineResult();

    //The application continues until the user doesn’t want to play anymore.
    Console.WriteLine("Do you want to play again? (y/n)");
    string yesno = Console.ReadLine();

    if (yesno == "y")
    { keepPlaying = true; }
    else if (yesno == "n")
    { keepPlaying = false; }




    string DetermineResult()
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
        else if (rockValue != -1)
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

        else { return "Lizard!"; }

    }

} while (keepPlaying = true);
