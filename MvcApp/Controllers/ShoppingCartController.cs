using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.Models;
using MvcApp.DAL;


namespace MvcApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private MvcAppDataContext db = new MvcAppDataContext();
        private int isExisting(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Pr.Id == id)
                    return i;
            }
            return -1;
        }
        [HttpGet]
        public ActionResult Cart(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(db.Products.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Item(db.Products.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }
            
            return RedirectToAction("CartShow");
        }
        [HttpGet]
        public ActionResult CartShow()
        {
            List<Item> cart = (List<Item>)Session["cart"];
            Session["cart"] = cart;
            return View("CartShow");
        }
        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("CartShow");
        }
    }
}