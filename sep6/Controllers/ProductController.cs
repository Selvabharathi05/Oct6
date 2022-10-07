using sep6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sep6.Controllers
{
    public class ProductController : Controller
    {
        static List<myproducts> ProdList = new List<myproducts>();
        static ProductController()
        {
            ProdList.Add(new myproducts { Prodid = 1, Prodname = "Goodday", Count = 100, MfgDate = new DateTime(2022, 05, 03) });

            ProdList.Add(new myproducts { Prodid = 2, Prodname = "Oreo", Count = 200, MfgDate = new DateTime(2022, 06, 21) });
            ProdList.Add(new myproducts { Prodid = 3, Prodname = "Tiger", Count = 150, MfgDate = new DateTime(2022, 03, 01) });

        }
        public ActionResult Index()
        {
            return View(ProdList);
        }

        public ActionResult SearchProductById( int id)
        {
            myproducts foundProduct = ProdList.Find(myproducts => myproducts.Prodid == id);
            return View(foundProduct);
            
        }


    }
}