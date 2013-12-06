using CocoFarm.DataAccess;
using CocoFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CocoFarm.Controllers
{
    public class CatalogProduseController : Controller
    {
        private IDataStore<Produs> store = new MemoryDataStore<Produs>();
        private IDataStore<Proprietate> proprietatiStore = new MemoryDataStore<Proprietate>();
        
        public ActionResult Index()
        {
            IEnumerable<Produs> produse = store.GetAll();
            return View(produse);
        }

        public ActionResult Details(int id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produs produs)
        {
            try
            {
                store.Create(produs);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        [HttpPost]
        public ActionResult Edit(Produs produs)
        {
            try
            {
                store.Update(produs);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(produs);
            }
        }

        public ActionResult Delete(int id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        [HttpPost]
        public ActionResult Delete(Produs produs)
        {
            try
            {
                store.Delete(produs.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Proprietati(int id)
        {
            var produs = store.GetById(id);
            return View(produs);
        }

        public ActionResult AdaugaProprietati()
        {
            var proprietati = proprietatiStore.GetAll();
            ViewData["proprietati"] = proprietati;
            return View(new ProprietateValoare());
        }

        [HttpPost]
        public ActionResult AdaugaProprietati(ProprietateValoare propVal)
        {
            try
            {
                var produs = store.GetById(propVal.ProdusId);
                produs.Proprietati.Add(propVal);
                store.Update(produs);
                //store.GetById(propVal.ProdusId).Proprietati.Add(propVal);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult AdaugaProprietateGenerala()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdaugaProprietateGenerala(Proprietate proprietate)
        {

            try
            {
                proprietatiStore.Create(proprietate);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(proprietate);
            }
        }
    }
}
