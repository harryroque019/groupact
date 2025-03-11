using System;
using groupact;

class MainProgram
{
    public static void AddNewProduct()
    {

        groupact.ManageProduct.InsertNewProduct newProduct = new groupact.ManageProduct.InsertNewProduct();
        int productLimit = 5;
        int productCount = 0;

        while (productCount < productLimit)
        {

            Console.WriteLine(@"
 _     ___ _  _     _   _   _   _       _ ___                   _   
|_ |\ | | |_ |_)   |_) |_) / \ | \ | | /   |    |\ |  /\  |\/| |_ o 
|_ | \| | |_ | \   |   | \ \_/ |_/ |_| \_  |    | \| /--\ |  | |_ o 
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|
");
                string productName = Console.ReadLine();
                Console.Clear();

                int productPrice;
                while (true)
                {
                    Console.WriteLine(@"
 _     ___ _  _     _   _   _   _       _ ___    _   _  ___  _  _   
|_ |\ | | |_ |_)   |_) |_) / \ | \ | | /   |    |_) |_)  |  /  |_ o 
|_ | \| | |_ | \   |   | \ \_/ |_/ |_| \_  |    |   | \ _|_ \_ |_ o 
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|
");
                string input = Console.ReadLine();
                if (int.TryParse(input, out productPrice))
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("===========================");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("| WRONG INPUT, TRY AGAIN! |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("===========================");
                }
            }

            Console.WriteLine(@"
 _     ___ _  _     _   _   _   _       _ ___    _   _  __  _  _  ___  _ ___ ___  _         
|_ |\ | | |_ |_)   |_) |_) / \ | \ | | /   |    | \ |_ (_  /  |_)  |  |_) |   |  / \ |\ | o 
|_ | \| | |_ | \   |   | \ \_/ |_/ |_| \_  |    |_/ |_ __) \_ | \ _|_ |   |  _|_ \_/ | \| o
 ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ ______ 
|______|______|______|______|______|______|______|______|______|______|______|______|______|
");
            string productDescription = Console.ReadLine();
                Console.Clear();

                newProduct.InsertData(productName, productPrice, productDescription);

                productCount++;

                if (productCount == productLimit)
                {
                Console.WriteLine("========================================================");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("|YOU HAVE REACHED THE MAXIMUM LIMIT OF ADDING PRODUCTS!|");
                Console.WriteLine("|                                                      |");
                Console.WriteLine("========================================================");
                Menu.Main();
                break;
            }

            Console.WriteLine("==============================================");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|DO YOU WANT TO ADD ANOTHER PRODUCT? (YES/NO)|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("==============================================");
            string answer = Console.ReadLine().ToLower();
                Console.Clear();

            if (answer != "yes")
            {
                Menu.Main();
            }   
        }
    }
}
