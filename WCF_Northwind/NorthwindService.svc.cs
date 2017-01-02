using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// ADD START
using WCF_Northwind.Contract;
// ADD END

namespace WCF_Northwind
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NorthwindService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select NorthwindService.svc or NorthwindService.svc.cs at the Solution Explorer and start debugging.
    public class NorthwindService : INorthwindService
    {
        private NorthwindEntities db = new NorthwindEntities();

        public List<CategoryModel> GetAllCategories()
        {
            try
            {
                List<CategoryModel> listCategory = new List<CategoryModel>();

                IEnumerable<CategoryModel> categories =
                    from Category in db.Categories
                    select new CategoryModel
                    {
                        CategoryID = Category.CategoryID ,
                        CategoryName = Category.CategoryName,
                        Description = Category.Description
                        //,
                        //Picture = Category.Picture
                    };

                listCategory = categories.ToList();
                return listCategory;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductModel> GetAllProducts()
        {
            try
            {
                List<ProductModel> listProduct = new List<ProductModel>();

                IEnumerable<ProductModel> products =
                    from product in db.Products
                    select new ProductModel
                                        {
                                            ProductID = product.ProductID
                                            , ProductName = product.ProductName
                                            , SupplierID = product.SupplierID
                                            , CategoryID = product.CategoryID
                                            , QuantityPerUnit = product.QuantityPerUnit
                                            , UnitPrice = product.UnitPrice
                                            , UnitsInStock = product.UnitsInStock
                                            , UnitsOnOrder = product.UnitsOnOrder
                                            , ReorderLevel = product.ReorderLevel
                                            , Discontinued = product.Discontinued
                                        };


                listProduct = products.ToList();
                return listProduct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductModel> GetProductByCategoryID(int CategoryID)
        {
            try
            {
                List<ProductModel> listProduct = new List<ProductModel>();

                IEnumerable<ProductModel> products =
                    from product in db.Products
                    where product.CategoryID == CategoryID
                    select new ProductModel
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        SupplierID = product.SupplierID,
                        CategoryID = product.CategoryID,
                        QuantityPerUnit = product.QuantityPerUnit,
                        UnitPrice = product.UnitPrice,
                        UnitsInStock = product.UnitsInStock,
                        UnitsOnOrder = product.UnitsOnOrder,
                        ReorderLevel = product.ReorderLevel,
                        Discontinued = product.Discontinued
                    };

                listProduct = products.ToList();
                return listProduct;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
