using groupact;
using System;

public static class Menu
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine(@"

                              _    _      _                            _   _               
                             | |  | |    | |                          | | | |              
                             | |  | | ___| | ___ ___  _ __ ___   ___  | | | |___  ___ _ __ 
                             | |/\| |/ _ \ |/ __/ _ \| '_ ` _ \ / _ \ | | | / __|/ _ \ '__|
                             \  /\  /  __/ | (_| (_) | | | | | |  __/ | |_| \__ \  __/ |   
                              \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \___/|___/\___|_|   

                 _____       _____           _         _      __    _     _   _            _____         
                |_   ____   |  _  |___ ___ _| |_ _ ___| |_   |  |  |_|___| |_|_|___ ___   |  _  |___ ___ 
                  | || . |  |   __|  _| . | . | | |  _|  _|  |  |__| |_ -|  _| |   | . |  |     | . | . |
                  |_||___|  |__|  |_| |___|___|___|___|_|    |_____|_|___|_| |_|_|_|_  |  |__|__|  _|  _|
                                                                                   |___|        |_| |_|                                                                                                                  
        ");

        int centerY = Console.WindowHeight / 2 - 2; 

        CenterText("1. Add New Product", centerY + 1);
        CenterText("2. Show All Products", centerY + 2);
        CenterText("3. Exit", centerY + 3);
        CenterText("Select an option", centerY + 5);

        static void CenterText(string text, int y)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, y);
            Console.WriteLine(text);
        }

        Console.SetCursorPosition((Console.WindowWidth - "Select an option ".Length) / 2 + "Select an option ".Length / 2, centerY + 6);
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Clear();
                MainProgram.AddNewProduct();
                break;
            case "2":
                ShowDB show = new ShowDB();
                show.ShowAllData();
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
                Main();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option. Press any key to try again...");
                Console.ReadKey();
                Main();
                break;
        }
    }
}
