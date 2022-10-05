using BL.AppServices;
using BL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        OrderAppService orderAppService = new OrderAppService();
        // GET: Order
        public ActionResult Index()
        {
            return View(orderAppService.GetAllOrder());
        }
        public ActionResult Create()=> View();
        
        [HttpPost]
        public ActionResult Create(OrderViewModel newOrder)
        {
            if (ModelState.IsValid == false)
                return View(newOrder);
            orderAppService.SaveNewOrder(newOrder);
            return RedirectToAction("Index"); 
        }
    }

}