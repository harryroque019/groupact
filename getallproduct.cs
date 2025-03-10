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
                    Console.Clear();
                    conn.Open();
                    Console.WriteLine(@"
                                                         (         (      ____ 
   (                              )     (         )      )\ )  (   )\ )  |   / 
   )\                    (     ( /(  (  )\ )   ( /(     (()/(( )\ (()/(  |  /  
 (((_)  (   (     (     ))\ (  )\())))\(()/(   )\())(    /(_))((_) /(_)) | /   
 )\___  )\  )\ )  )\ ) /((_))\(_))//((_)((_)) (_))/ )\  (_))((_)_ (_))   |/    
((/ __|((_)_(_/( _(_/((_)) ((_| |_(_))  _| |  | |_ ((_) / __|/ _ \| |   (      
 | (__/ _ | ' \)| ' \)/ -_/ _||  _/ -_/ _` |  |  _/ _ \ \__ | (_) | |__ )\     
  \___\___|_||_||_||_|\___\__| \__\___\__,_|   \__\___/ |___/\__\_|____((_)                                                                                                                                               
                     ");

                    string query = "SELECT * FROM products";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("-----------------------------------------------------------------------------------------------");
                            Console.WriteLine("ID\tName\t\t\tPrice\t\t\tDescription");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------");

                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["product_id"]}\t{reader["productName"],-15}\t\t{reader["productPrice"],-10}\t\t{reader["productDescription"]}");
                            }

                            Console.WriteLine("-----------------------------------------------------------------------------------------------");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(@" 

    --------------------------------------------------------------------------------------------------------------
      ░▒▓█▓▒░            ░▒▓████████▓▒░▒▓███████▓▒░░▒▓███████▓▒░ ░▒▓██████▓▒░░▒▓███████▓▒░             ░▒▓█▓▒░ 
      ░▒▓█▓▒░            ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░            ░▒▓█▓▒░ 
      ░▒▓█▓▒░            ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░            ░▒▓█▓▒░ 
      ░▒▓█▓▒░            ░▒▓██████▓▒░ ░▒▓███████▓▒░░▒▓███████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓███████▓▒░             ░▒▓█▓▒░ 
      ░▒▓█▓▒░            ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░            ░▒▓█▓▒░ 
                         ░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░                    
      ░▒▓█▓▒░            ░▒▓████████▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░            ░▒▓█▓▒░ 
                                                                                                         
     ------------------------------------------------------------------------------------------------------------                                                                                                                                                                                                                                                                                       
" + ex.Message);
                }
            }
        }
    }
}
