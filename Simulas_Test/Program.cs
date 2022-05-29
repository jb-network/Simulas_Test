// This is challenge work for the "C# Players Guide"
// Level 16 Simula's Test Challenge
// The goal is to use enumeration for the state of a chest
//The chest has four three states OPEN <> CLOSED <> LOCKED
//The user can do the following actions (in lowercase) OPEN > close > CLOSED, OPEN < open < CLOSED, CLOSED > locked > LOCKED, CLOSED < unlocked < LOCKED


//Main
// WHILE TRUE ADD

// Set up
// ChestState Chest = ChestState.LOCKED;

//Console.WriteLine($"The chest is {Chest}.  What do you want to do?"
ChestState ChestAction();

//Methods
//ADD METHOD FOR CHEST STATE, RETURN STATUS

//ADD USER ACTION

//ADD VALIDATE USER INPUT

// Enumerant
enum ChestState { OPEN, CLOSED, LOCKED }

