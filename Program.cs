using System;

class GameState
{
    enum State
    {
        MAIN_MENU,

        MODE1_MENU, MODE1_LEVEL1, MODE1_LEVEL2, MODE1_LEVEL3,
        MODE2_MENU, MODE2_LEVEL1, MODE2_LEVEL2, MODE2_LEVEL3,
        MODE3_MENU, MODE3_LEVEL1, MODE3_LEVEL2, MODE3_LEVEL3
    }

    static State currentState = State.MAIN_MENU;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nSekarang di: " + currentState);
            ShowMenu();

            Console.Write("Input: ");
            string input = Console.ReadLine();

            if (currentState == State.MAIN_MENU && input == "0")
                break;

            HandleInput(input);
        }
    }

    static void ShowMenu()
    {
        switch (currentState)
        {
            case State.MAIN_MENU:
                Console.WriteLine("1. Mode 1");
                Console.WriteLine("2. Mode 2");
                Console.WriteLine("3. Mode 3");
                Console.WriteLine("0. Exit");
                break;

            case State.MODE1_MENU:
            case State.MODE2_MENU:
            case State.MODE3_MENU:
                Console.WriteLine("1. Start");
                Console.WriteLine("0. Main Menu");
                break;

            case State.MODE1_LEVEL3:
            case State.MODE2_LEVEL3:
            case State.MODE3_LEVEL3:
                Console.WriteLine("0. Main Menu");
                break;

            default:
                Console.WriteLine("1. Next");
                Console.WriteLine("0. Main Menu");
                break;
        }
    }

    static void HandleInput(string input)
    {
        switch (currentState)
        {
            case State.MAIN_MENU:
                if (input == "1") currentState = State.MODE1_MENU;
                else if (input == "2") currentState = State.MODE2_MENU;
                else if (input == "3") currentState = State.MODE3_MENU;
                break;

            // MODE MENU
            case State.MODE1_MENU:
                if (input == "1") currentState = State.MODE1_LEVEL1;
                else if (input == "0") currentState = State.MAIN_MENU;
                break;

            case State.MODE2_MENU:
                if (input == "1") currentState = State.MODE2_LEVEL1;
                else if (input == "0") currentState = State.MAIN_MENU;
                break;

            case State.MODE3_MENU:
                if (input == "1") currentState = State.MODE3_LEVEL1;
                else if (input == "0") currentState = State.MAIN_MENU;
                break;

            // MODE 1
            case State.MODE1_LEVEL1:
                currentState = NextOrMenu(input, State.MODE1_LEVEL2);
                break;
            case State.MODE1_LEVEL2:
                currentState = NextOrMenu(input, State.MODE1_LEVEL3);
                break;
            case State.MODE1_LEVEL3:
                if (input == "0") currentState = State.MAIN_MENU;
                break;

            // MODE 2
            case State.MODE2_LEVEL1:
                currentState = NextOrMenu(input, State.MODE2_LEVEL2);
                break;
            case State.MODE2_LEVEL2:
                currentState = NextOrMenu(input, State.MODE2_LEVEL3);
                break;
            case State.MODE2_LEVEL3:
                if (input == "0") currentState = State.MAIN_MENU;
                break;

            // MODE 3
            case State.MODE3_LEVEL1:
                currentState = NextOrMenu(input, State.MODE3_LEVEL2);
                break;
            case State.MODE3_LEVEL2:
                currentState = NextOrMenu(input, State.MODE3_LEVEL3);
                break;
            case State.MODE3_LEVEL3:
                if (input == "0") currentState = State.MAIN_MENU;
                break;
        }
    }

    static State NextOrMenu(string input, State next)
    {
        if (input == "1") return next;
        if (input == "0") return State.MAIN_MENU;
        return currentState;
    }
}