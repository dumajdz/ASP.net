using DoAnWebNangCao.Models;
using DoAnWebNangCao.Models.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWebNangCao.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Admin/Products
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index(int? page)
        {
            
            IEnumerable<Product> items = db.Products.OrderByDescending(x => x.Id);
            var pageSize = 5;           
            if (page == null)
            {
                page = 1;
            }            
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;           
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}