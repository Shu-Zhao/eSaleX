﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSaleX.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            Models.OrderService orderservice = new Models.OrderService();
            var order = orderservice.GetOrderById("111");
            ViewBag.CustId = order.CustId;
            ViewBag.CustName = order.CustName;
            return View();
        }


        public ActionResult Index2(string id)
        {
            ViewBag.id = id;
            return View();
        }
        


        public ActionResult InsertOrder()
        {
            return View();
        }

        [HttpPost()]

        public ActionResult InserOrder(Models.Order order)
        {
            return View("Index");
        }
    }
}