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

            Console.WriteLine("Enter Product Name: ");
            string productName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter Product Price: ");
            int productPrice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Enter Product Description: ");
            string productDescription = Console.ReadLine();
            Console.Clear();

            newProduct.InsertData(productName, productPrice, productDescription);

            productCount++;

            if (productCount == productLimit)
            {
                Console.WriteLine("You have reached the maximum limit of adding products.");
                break;
            }

            Console.WriteLine("Do you want to add another product? (yes/no)");
            string answer = Console.ReadLine().ToLower();
            Console.Clear();

            if (answer != "yes")
            {
                Menu.Main();
            }   

        }
        
    }

}
