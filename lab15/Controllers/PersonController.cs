using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab15.Models;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Data.Entity;
using System.Web.Helpers;
using System.Collections;

namespace lab15.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        #region Contexto

        private SchoolEntities _contexto;

        public SchoolEntities Contexto
        {
            set { _contexto = value; }
            get
            {
                if (_contexto == null)
                    _contexto = new SchoolEntities();
                return _contexto;
            }
        }

        #endregion
        public ActionResult Index()
        {
            return View(Contexto.Person.ToList());
        }

        public ActionResult reporte()
        {
            List<Person> listado = new List<Person>();
            listado = Contexto.Person.ToList();

            var rptViewer = new ReportViewer();
            rptViewer.ProcessingMode = ProcessingMode.Local;
            rptViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reporte.rdlc";

            ReportDataSource rptdatasource = new ReportDataSource("dsPersona", listado);
            rptViewer.LocalReport.DataSources.Add(rptdatasource);
            rptViewer.SizeToReportContent = true;

            ViewBag.ReportViewer = rptViewer;

            return View();

        }

        [HttpPost]
        public ActionResult reporte(string FirstName)
        {
            List<Person> listado = new List<Person>();
            listado = (from p in Contexto.Person
                       where p.FirstName.Contains(FirstName)
                       select p).ToList();

            var rptViewer = new ReportViewer();
            rptViewer.ProcessingMode = ProcessingMode.Local;
            rptViewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reporte.rdlc";

            ReportDataSource rptdatasource = new ReportDataSource("dsPersona", listado);
            rptViewer.LocalReport.DataSources.Add(rptdatasource);
            rptViewer.SizeToReportContent = true;

            ViewBag.ReportViewer = rptViewer;


            return View();
        }

        public ActionResult Graficos()
        {
            return View();
        }

        public ActionResult GraficoColumnas()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));

            new Chart(width: 600, height: 400, theme: ChartTheme.Green)
                .AddTitle("Gráfico de Columnas")
                .AddSeries("Default", chartType: "Column", xValue: x, yValues: y)
                .Write("bmp");


            return null;
        }

        public ActionResult GraficoBarras()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));

            new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
                .AddTitle("Gráfico de Barras")
                .AddSeries("Default", chartType: "Bar", xValue: x, yValues: y)
                .Write("bmp");


            return null;
        }

        public ActionResult GraficoTarta()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));

            new Chart(width: 600, height: 400, theme: ChartTheme.Blue)
                .AddTitle("PIE")
                .AddSeries("Default", chartType: "Pie", xValue: x, yValues: y)
                .Write("bmp");


            return null;
        }

        public ActionResult GraficoRadar()
        {
            ArrayList x = new ArrayList();
            ArrayList y = new ArrayList();

            var query = (from c in Contexto.Course select c);
            query.ToList().ForEach(r => x.Add(r.Title));
            query.ToList().ForEach(r => y.Add(r.Credits));

            new Chart(width: 600, height: 400, theme: ChartTheme.Yellow)
                .AddTitle("Radar")
                .AddSeries("Default", chartType: "Radar", xValue: x, yValues: y)
                .Write("bmp");


            return null;
        }
    }
}