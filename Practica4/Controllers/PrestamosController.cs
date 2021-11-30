using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica4.Controllers
{
    public class PrestamosController : Controller
    {
        // GET: Prestamos
        #region Contexto

        private PRACTICA4Entities _contexto;

        public PRACTICA4Entities Contexto
        {

            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new PRACTICA4Entities();
                return _contexto;
            }
        }
        #endregion
        public ActionResult Index()
        {
            return View(Contexto.Prestamos.ToList());
        }

        public ActionResult Details(int id)
        {

            var librosPorprestamo = from p in Contexto.Libro
                                        orderby p.Titulo ascending
                                        where p.IdLibro == id
                                        select p;
            return View(librosPorprestamo.ToList());
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            Prestamos CategoriaEditar = Contexto.Prestamos.Find(id);

            if (CategoriaEditar == null)
                return HttpNotFound();

            return View(CategoriaEditar);
        }

        [HttpPost]
        public ActionResult Edit(Prestamos PrestamoEditar)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Entry(PrestamoEditar).State = System.Data.Entity.EntityState.Modified;
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(PrestamoEditar);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            Prestamos PrestamoEliminar = Contexto.Prestamos.Find(id);

            if (PrestamoEliminar == null)
                return HttpNotFound();

            return View(PrestamoEliminar);
        }

        [HttpPost]
        public ActionResult Delete(int? id, Prestamos Prestamo1)
        {
            try
            {
                Prestamos PrestamoEliminar = new Prestamos();
                if (ModelState.IsValid)
                {
                    if (ModelState.IsValid)
                        return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

                    PrestamoEliminar = Contexto.Prestamos.Find(id);

                    if (PrestamoEliminar == null)
                        return HttpNotFound();

                    Contexto.Prestamos.Remove(PrestamoEliminar);
                    Contexto.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(PrestamoEliminar);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Prestamos nuevoPrestamo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Contexto.Prestamos.Add(nuevoPrestamo);
                    Contexto.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(nuevoPrestamo);
            }
            catch
            {
                return View();
            }
        }
    }
}