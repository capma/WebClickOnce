using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// ADD START 
//using WCF_Northwind;
using WebClickOnce.Models;
using WCF_Northwind.Contract;
// ADD END

namespace WebClickOnce.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindServiceReference.NorthwindServiceClient db = new NorthwindServiceReference.NorthwindServiceClient();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AjaxHandler()
        {
            List<ProductModel> listProduct = db.GetAllProducts().ToList();
            return View(listProduct);
        }
    }
}