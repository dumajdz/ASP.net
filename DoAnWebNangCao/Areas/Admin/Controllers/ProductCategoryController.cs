﻿using DoAnWebNangCao.Models;
using DoAnWebNangCao.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWebNangCao.Areas.Admin.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: Admin/ProductCategory       
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var items = db.ProductCategories;
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = DoAnWebNangCao.Models.Common.Filter.FilterChar(model.Title);
                db.ProductCategories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var item = db.ProductCategories.Find(id);
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductCategory model)
        {
            if (ModelState.IsValid)
            {
                model.ModifiedDate = DateTime.Now;
                model.Alias = DoAnWebNangCao.Models.Common.Filter.FilterChar(model.Title);
                db.ProductCategories.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.ProductCategories.Find(id);
            if (item != null)
            {
                db.ProductCategories.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        //[HttpPost]
        //public ActionResult IsActive(int id)
        //{
        //    var item = db.ProductCategories.Find(id);
        //    if (item != null)
        //    {
        //        item.IsActive = !item.IsActive;
        //        db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        //        db.SaveChanges();
        //        return Json(new { success = true, isAcive = item.IsActive });
        //    }

        //    return Json(new { success = false });
        //}

        [HttpPost]
        public ActionResult DeleteAll(string ids)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = ids.Split(',');
                if (items != null && items.Any())
                {
                    foreach (var item in items)
                    {
                        var obj = db.ProductCategories.Find(Convert.ToInt32(item));
                        db.ProductCategories.Remove(obj);
                        db.SaveChanges();
                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}