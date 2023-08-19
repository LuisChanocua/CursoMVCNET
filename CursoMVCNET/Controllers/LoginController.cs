using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CursoMVCNET.DTO;

namespace CursoMVCNET.Controllers
{
    public class LoginController : Controller
    {


        #region Vistas
        public ActionResult Index()
        {
            return View();
        }
        #endregion
        // GET: Login


        #region Metodos Inicio Sesion

        [HttpPost]
        public void iniciarsesion(DTO.Users users)
        {
            Console.WriteLine(users.user);
            Console.WriteLine(users.password);
        }

        #endregion
    }
}