using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// ADD START
using WebClickOnce.ViewModels;
using WCF_Northwind.Contract;
// ADD END

namespace WebClickOnce.Controllers
{
    public class OrderController : Controller
    {
        private NorthwindServiceReference.NorthwindServiceClient db = new NorthwindServiceReference.NorthwindServiceClient();

        // GET: Order
        public ActionResult Index(int? CategoryID)
        {
            CategoryIndexData viewModel = new CategoryIndexData();
            viewModel.Categories = db.GetAllCategories().ToList();
            
            if (CategoryID != null)
            {
                ViewBag.CategoryID = CategoryID.Value;
                viewModel.Products = db.GetProductByCategoryID(CategoryID.Value).ToList();
            }

            return View(viewModel);
        }
    }
}