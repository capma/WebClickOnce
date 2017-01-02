using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// ADD START
using WCF_Northwind.Contract;
// ADD END

namespace WebClickOnce.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
    }
}