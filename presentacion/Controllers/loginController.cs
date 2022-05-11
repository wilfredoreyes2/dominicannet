using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Capa_entidades;
using Capa_negocio;

namespace presentacion.Controllers
{

   
    public class loginController : Controller

    {
        negocio Neg = new negocio();

        // ACTION RESULT QUE ME PERMITE INICIAR SESION.

        public ActionResult login()
        {
            return View();
        }

        // METODO QUE ME REALIZA UN SERIE DE VERFIFICACIONES ANTES DE DAR PASO AL INICIO DE SESION.
        // TAMBIEN ME ENVIA LOS DATOS DE LA VISTA.

        [HttpPost]
        public ActionResult Login(usuarios usuario)
        {
            // VARIABLE USUARIO QUE ME RETORNA EL USUARIO.
            var user = Neg.Login(usuario);

            // CONDICIONAL QUE VERIFICA SI EL USUARIO ES NULO.
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.correo, false);

                // VARIABLE QUE ME GUARDA LOS DATOS DEL USUARIO.
                Session["usuario"] = user;

                //session para optener el id del usuario
                Session["id_usuario"] = user.ID;

                // SESSION QUE ME GUARDA EL NOMBRE DEL USUARIO

                Session["NombreU"] = user.nombre;

                // SESION QUE ME GUARDA EL ROL DEL USUARIO

                Session["ID_ROL"] = user.rol;


                // CONDICIONAL ANIDADA QUE ME VERIFICA EL TIPO DE USUARIO Y RETORNA A LA VISTA QUE LE CORRESPONDE.
                if (user.rol == 2)
                {
                    return RedirectToAction("MostrarProductos1", "usuario");

                }
                else if (user.rol == 1)
                {

                    return RedirectToAction("DashBoard", "Home");
                }

            }

            // CONDICIONAL QUE SIGINIFICA QUE SI LA BD DEVUELVE UN USUARIO NULO O LAS CREDENCIALES NO CONCUERDAN
            // ENTRE SI, PUES ME LANZARÁ UN MENSAJE DE ERROR EN LA PAGINA.

            else if (user == null)
            {
                // ESTE COMANDO ME PERMITE LIMPIAR LOS INPUTS DE LA PÁGINA
                ModelState.Clear();

                // MENSAJE DE ERROR
                ViewBag.Error = "Contraseña o Correo invalido";

            }

            return View();


        }
        public ActionResult REGISTRO()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [HttpPost]
        public ActionResult REGISTRO(usuarios user)
        {
            //validacion para no repeticion de correo

            var correo = Neg.Validar_correo(user.correo);


            //condicion para validar la no repeticion de correo
            if (correo == null)
            {

                // VALORES POR PREDETERMINADO AL INSERTAR LOS DATOS EN LA PAGINA DE REGISTRO.

                user.Estado = 1;
                user.rol = 2;
                user.telefono = 555555555;


                // METODO DE LA CAPA NEGOCIO QUE ME INSERTA LOS DATOS A LA BASE DE DATOS.


                Neg.Insertar(user);

                // ESTE COMANDO ME PERMITE LIMPIAR LOS INPUTS DE LA PÁGINA
                ModelState.Clear();


            }
            else
            {
                Neg.Insertar(user);
                // ESTE COMANDO ME PERMITE LIMPIAR LOS INPUTS DE LA PÁGINA
                ModelState.Clear();

                // MENSAJE DE ERROR
                ViewBag.Error = "Este correo ya esta en uso";

            }


            return View();
        }
        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            Session["usuario"] = null;
            return RedirectToAction("login", "login");

        }

    }
}