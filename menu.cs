using groupact;
using System;

public static class Menu
{
    public static void Main()
    {
            Console.Clear();
            Console.WriteLine("1. Add New Product:");
            Console.WriteLine("2. Show All Product:");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    MainProgram.AddNewProduct();
                    break;
                case "2":
                ShowDB.ShowAllData();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Press any key to try again...");
                    Console.ReadKey();
                Console.WriteLine();
                Main();
                break;
        }
        
    }
    
}