using System;
using MySql.Data.MySqlClient;

namespace groupact
{
    class ShowDB
    {
        private string server = "localhost";
        private string database = "productlisting";
        private string username = "root";
        private string password = "";
        private string connString;

        public ShowDB()
            {
            connString = $"Server={server};Database={database};User ID={username};Password={password};";
            }
        public void ShowAllData()
        { 
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        Console.WriteLine("Connected to MySQL!");

                        string query = "SELECT * FROM products";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                Console.WriteLine("\nProduct List:");
                                Console.WriteLine("ID\tName\t\tPrice\t\tDescription");

                                while (reader.Read())
                                {
                                    Console.WriteLine($"{reader["id"]}\t{reader["productName"]}\t\t{reader["productPrice"]}\t\t{reader["productDescription"]}");
                                }

                                Console.WriteLine("Press any key to return to menu...");
                                Console.ReadKey();
                             }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }