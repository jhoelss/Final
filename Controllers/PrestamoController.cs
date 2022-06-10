using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tienda.Data;
using Tienda.Logic;

namespace Financiera.AppWeb.Controllers
{
    public class PrestamoController : Controller
    {
        // GET: Prestamo
        public ActionResult Index()
        {
            var listado = PrestamoBL.Listar();
            return View(listado);
           
        }
        //public ActionResult Crear()
        //{
        //    return View();

        //}
        //[HttpPost]
        //public ActionResult Crear(PrestamoBL prestamo)
        //{
        //    using (var db = new FinancieraEntities())
        //    {
        //        ;
        //        db.Prestamo.Add(prestamo);
        //        db.SaveChanges();
        //    }
        //    return View("index");

        //}
    }
}