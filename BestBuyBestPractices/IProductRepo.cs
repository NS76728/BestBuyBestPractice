using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyBestPractices
{
    interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
       public void CreateProduct(string name, double price, int categoryID);
    }
}
