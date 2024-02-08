using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class CuartoController : Controller
    {
        // GET: Cuarto
        public ActionResult Index()
        {

            using (DbModels context = new DbModels())
            {
                return View(context.Cuarto.ToList());
            }
            
        }

        // GET: Cuarto/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Cuarto.Where(x => x.idCuarto == id));
            }
        }

        // GET: Cuarto/Create
        public ActionResult Create()
        {
            return View();
            
        }

        // POST: Cuarto/Create
        [HttpPost]
        public ActionResult Create(Cuarto cuarto)
        {
            try
            {
                // TODO: Add insert logic here
                using (DbModels contetx = new DbModels())
                {
                    contetx.Cuarto.Add(cuarto);
                    contetx.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuarto/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Cuarto.Where(x => x.idCuarto == id).FirstOrDefault());
            }
        }

        // POST: Cuarto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cuarto cuarto)
        {
            try
            {
                // TODO: Add update logic here
                using (DbModels context = new DbModels())
                {
                    context.Entry(cuarto).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuarto/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Cuarto.Where(x => x.idCuarto == id).FirstOrDefault());
            }
        }

        // POST: Cuarto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                using (DbModels context = new DbModels())
                {
                    Cuarto cuarto = context.Cuarto.Where(x => x.idCuarto == id).FirstOrDefault();
                    context.Cuarto.Remove(cuarto);
                    context.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
