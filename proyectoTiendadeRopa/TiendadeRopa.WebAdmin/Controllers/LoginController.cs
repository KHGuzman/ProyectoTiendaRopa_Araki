using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TiendadeRopa.BL;

namespace TiendadeRopa.WebAdmin.Controllers
{
    public class LoginController : Controller
    {
        SeguridadBL _seguridadBL;

        public LoginController()
        {
            _seguridadBL = new SeguridadBL();

        }

        // GET: Login
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection data)
        {
            var nombreusuario = data["username"];
            var contrasena = data["password"];

            var usuarioValido = _seguridadBL
                .Autorizar(nombreusuario, contrasena);

            if (usuarioValido)
            {
                FormsAuthentication.SetAuthCookie(nombreusuario, true);
                return RedirectToAction("Index", "Home");
        }
            ModelState.AddModelError("", "Usuario o contraseña invalido");

            return View();
    }
   }
}