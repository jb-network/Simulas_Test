// This is challenge work for the "C# Players Guide"
// Level 16 Simula's Test Challenge
// The goal is to use enumeration to track the state of a chest
//The chest has four three states OPEN <> CLOSED <> LOCKED
//The user can do the following actions (in lowercase) OPEN > close > CLOSED, OPEN < open < CLOSED, CLOSED > locked > LOCKED, CLOSED < unlocked < LOCKED

// Set up
ChestState Chest = ChestState.LOCKED;

while (true)
{
    string menu = UserInteraction(Chest);
    Chest = ChestChange(menu, Chest);



    //Methods -----------------

    //Provides status and captures user's input
    //Convert to lower to capture user input errors on word
    //Other input errors will be handled by StateChange method
    string UserInteraction(ChestState Chest)
    {
        Console.WriteLine($"\nThe chest is {Chest}.  What do you want to do?");
        Console.WriteLine("Actions are based on status: " +
            "\n1) Chest Status: 'OPEN'       Enter: 'close' to change to'CLOSED'" +
            "\n2) Chest Status: 'CLOSED'     Enter: 'lock' to change to 'LOCKED'" +
            "\n3) Chest Status: 'LOCKED      Enter: 'unlock' to change to 'CLOSED'" +
            "\n4) Chest Status: 'CLOSED      Enter: 'open' to change to 'OPEN'");
        Console.Write("Input your action: ");
        string action = Console.ReadLine().ToLower();
        return action;
    }

    //Checks chest and use selection to change chest status
    //Error checking provided by else statment.  If the user's input was no correct error message provide and chest is not change.
    ChestState ChestChange(string menu, ChestState Chest)
    {
        if (Chest == ChestState.OPEN && menu == "close")
        {
            Chest = ChestState.CLOSED;
            return Chest;
        }
        else if (Chest == ChestState.CLOSED && menu == "lock")
        {
            Chest = ChestState.LOCKED;
            return Chest;
        }
        else if (Chest == ChestState.LOCKED && menu == "unlock")
        {
            Chest = ChestState.CLOSED;
            return Chest;
        }
        else if (Chest == ChestState.CLOSED && menu == "open")
        {
            Chest = ChestState.OPEN;
            return Chest;
        }
        else
        {
            Console.WriteLine($"\nYou entered {menu} for the status of {Chest}. This is not a correct option, please try again!");
            return Chest;
        }
    }
}


// Enumerant -----------------
enum ChestState { OPEN, CLOSED, LOCKED }

