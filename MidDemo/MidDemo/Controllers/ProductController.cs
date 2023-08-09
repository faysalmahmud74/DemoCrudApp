using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MidDemo.Models;

namespace MidDemo.Controllers
{
    public class ProductController : Controller
    {

        // GET: Employee
        ProductRepo repo;

        public ProductController()
        {
            this.repo = new ProductRepo();
        }

        // GET: StudentF
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductModel student)
        {
            if (ModelState.IsValid)
            {
                var count = repo.AddProduct(student);
                if (count > 0)
                {
                    ViewBag.Okay = "Data Added";
                }
            }
            return View();
        }

        public ActionResult GetAll()
        {
            var data = repo.GetAllData();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data = repo.GetDetails(id);
            return View(data);
        }

        public ActionResult Edit(int id)
        {
            var data = repo.GetDetails(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(int id, ProductModel student)
        {
            if (ModelState.IsValid)
            {
                var count = repo.UpdateData(id, student);

                return RedirectToAction("GetAll");

            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var data = repo.DeleteData(id);
            return RedirectToAction("GetAll");
        }
    }
}