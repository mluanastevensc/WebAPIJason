﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace Mock_BestBuy_API
{
    public class Product
    {
      
        public int ProductID { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public double Price { get; set; }

        [BindProperty]
        public int CategoryID { get; set; }

        public bool OnSale { get; set; }
        public int StockLevel { get; set; }



    }
}

