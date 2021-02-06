using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio0.Models.Data;

namespace Laboratorio0.Controllers
{
    public class ClientesController : Controller
    {
        
        // GET: Clientes
        public ActionResult Index()
        {
            return View(Singleton.Instance.ClientesList);
        }

        // GET: Clientes/NameSort
        public ActionResult NameSort(string Nombre)
        {
            var Primeraletra = Singleton.Instance.ClientesList.Find(x => x.Nombre == Nombre);
            return View(Primeraletra);


        }
        // POST: StudentsController/Namesort
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Namesort(String Nombre, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

               

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        
        public ActionResult Create(IFormCollection collection)
        {           
            try
            {
                var NewCliente = new Models.Clientes
                {
                    
                    Nombre = collection["Nombre"],
                   Apellido= collection["Apellido"],
                    Telefono= Convert.ToInt32(collection["Telefono"]),
                    Descripcion = collection["Descripcion"],
                    


                };
                Singleton.Instance.ClientesList.Add(NewCliente);
                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }                   
        }




        // GET: Clientes/Edit/5
      /*  public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clientes/Edit/5
      /*  [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
      */
        // GET: Clientes/Delete/5
      /*  public ActionResult Delete(int id)
        {
            return View();
        }*/

        // POST: Clientes/Delete/5
       /* [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
