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

        public ActionResult BubbleSort_Nombre()
        {

            try
            {
                for (int i = 0; i < Singleton.Instance.ClientesList.Count; i++)
                {


                    for (int j = i + 1; j < Singleton.Instance.ClientesList.Count; j++)
                    {
                        var aux = new Models.Clientes ();
                        Char Iniciali = Convert.ToChar(Singleton.Instance.ClientesList[i].Nombre.Substring(0, 1));  //Inicial del nombre comparado
                        Char Inicialj = Convert.ToChar(Singleton.Instance.ClientesList[j].Nombre.Substring(0, 1));  //Inicial del nombre a comparar


                        if (Iniciali > Inicialj)
                        {
                            aux = Singleton.Instance.ClientesList[i];
                            Singleton.Instance.ClientesList[i] = Singleton.Instance.ClientesList[j];
                            Singleton.Instance.ClientesList[j] = aux;
                        }
                    }
                }
                //BubbleSort(Singleton._instance.MestrosList);
                return RedirectToAction(nameof(Index)); ;
            }
            catch
            {
                return View();
            }
            
        }

        public ActionResult BubbleSort_Apellidos()
        {

            try
            {
                for (int i = 0; i < Singleton.Instance.ClientesList.Count; i++)
                {


                    for (int j = i + 1; j < Singleton.Instance.ClientesList.Count; j++)
                    {
                        var aux = new Models.Clientes();
                        Char Iniciali = Convert.ToChar(Singleton.Instance.ClientesList[i].Apellido.Substring(0, 1));  //Inicial del nombre comparado
                        Char Inicialj = Convert.ToChar(Singleton.Instance.ClientesList[j].Apellido.Substring(0, 1));  //Inicial del nombre a comparar


                        if (Iniciali > Inicialj)
                        {
                            aux = Singleton.Instance.ClientesList[i];
                            Singleton.Instance.ClientesList[i] = Singleton.Instance.ClientesList[j];
                            Singleton.Instance.ClientesList[j] = aux;
                        }
                    }
                }
                //BubbleSort(Singleton._instance.MestrosList);
                return RedirectToAction(nameof(Index)); ;
            }
            catch
            {
                return View();
            }

        }
        public ActionResult Index()
        {
            
            return View(Singleton.Instance.ClientesList);
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
