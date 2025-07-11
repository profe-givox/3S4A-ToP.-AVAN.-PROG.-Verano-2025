﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosWinForm.model
{
    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }       
        public override string ToString()
        {
            return $"{CategoryID} - {CategoryName}";
        }
    }
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryID { get; set; }
        public override string ToString()
        {
            return $"{ProductID} - {ProductName}";
        }
    }
}
