﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyBestPractices
{
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CatagoryID { get; set; }
        public bool OnSale { get; set; }
        public int StockLevel { get; set; }


    }
}
