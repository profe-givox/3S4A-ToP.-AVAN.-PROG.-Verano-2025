using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedWinFormsEF.model
{    
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public virtual ObservableCollectionListSource<Product> 
            Products { get; } = new();
    }

}
