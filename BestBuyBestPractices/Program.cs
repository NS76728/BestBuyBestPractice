using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


namespace BestBuyBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);
            var repo = new DapperDepartmentRepository(conn);
            Console.WriteLine("Type a new department name");
            var newDepartment = Console.ReadLine();
            repo.InsertDepartment(newDepartment);
            var departments = repo.GetAllDepartments();
            foreach(var x in departments)
            {
                Console.WriteLine(x.Name);
            }

            var repo2 = new DapperProductRepository(conn);
            Console.WriteLine("Create a new product name ");
            var name = Console.ReadLine();
            Console.WriteLine("Product price ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Product ID ");
            int categoryID = Convert.ToInt32(Console.ReadLine());
            repo2.CreateProduct(name,price,categoryID);
            var products = repo2.GetAllProducts();
            foreach (var x in products)
            {
                Console.WriteLine(x.Name, x.Price, x.CatagoryID);
            }
        }
    }
}
