using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Capa_entidades;
using Capa_negocio;

namespace presentacion.Controllers
{
    public class usuarioController : Controller
    {
        negocio Neg = new negocio();
        public ActionResult AgregarProducto1()
        {
           

            if (Session["proyecto"] != null)
            {
                var Pro = (proyectos)Session["proyecto"];
                TempData["Foto"] = Pro.imagen;
               

                return View(Pro);
            }
            else
            {

                return View();


            }

        }


        // ********************************************************************************************* //
        // ********************************************************************************************* //


        // NUMERO DE ROL PARA LA AUTENTICACION DEL FILTRO.
        //[PermisosRol(2)]
        [HttpPost]
        public ActionResult AgregarProducto1(proyectos Pro, string Opcion)
        {
            if (Opcion == "NA")
            {
                // CONFIRMACION DE LA ACCION.
                TempData["Confirmacion3"] = "Content";

                // OBTENCION DE ARCHIVO DE LA WEB
                HttpPostedFileBase FileB = Request.Files[0];

                WebImage imagen = new WebImage(FileB.InputStream);

                // OBTENIENDO LOS BYTES DE LA IMAGEN PARA ALMACENARLOS EN LA BD
                Pro.imagen = imagen.GetBytes();

                // ALMACENAR PRODUCTOS DE FORMA TEMPORAL EN UNA SESSION
                Session["proyecto"] = Pro;

                // RETORNAR A LA VISTA CORRESPONDIENTE.
                return RedirectToAction("AgregarProducto1", "usuario");
            }
            else if (Opcion == "Si")
            {

                // DATOS

                var Prod = (proyectos)Session["proyecto"];


                // CONFIRMACION DE PETICION

                TempData["ConfirmacionPr"] = "Content";

                // VALORES PREDETERMINADOS

                Prod.id_usuario = (int)Session["id_usuario"];
                //Prod.Fecha_Registro = DateTime.Today;
                Prod.Estado = 1;

                // METODO QUE ME INSERTA LOS DATOS EN LA TABLA PRODUCTOS.

                Neg.Insertarproyecto(Prod);

                // LIMPIAR SESSION
                Session["proyecto"] = "";

                // RETORNAR A LA VISTA CORRESPONDIENTE.
                return RedirectToAction("MostrarProductos1", "usuario");
            }
            return View();

        }
        public ActionResult MostrarProductos1()
        {

            return View(Neg.Listaproyecto());
        }
        public ActionResult PDetalles()
        {

            return View();
        }
        [HttpPost]
        public ActionResult PDetalles(int ID_proyecto = 3)
        {
            // USUARIO ESTATICO
            //int IDUser = (int)Session["id_usuario"];

            //Session para conocer el id del producto al reportar

            Session["Id_Producto"] = ID_proyecto;

            //// CONDICIONAL DE LA VARIABLE PRODUCTO, CONDICION QUE ASIGNA EL VALOR DE LA VARIABLE SESSION.
            //if (ID_proyecto <= 0)
            //{
            //    ID_proyecto = (int)Session["IDP"];
            //}

            //// VALIDACIONES QUE DEVUELVEN UN VALOR DE LA BD.
            //var ValidacionProductos = Neg.ValidacionUsuarioProp(IDUser, ID_Producto);
            //var ValidacionProductosCarrito = Neg.ValidacionCarritoUsuario(IDUser, ID_Producto);

            //// SI EL CONTADOR MARCA QUE ES MAYOR A CERO.
            //if (ValidacionProductos.Count() > 0)
            //{
            //    // VIEWBAG QUE ME ALMACENA LOS DATOS DE LAS VARIABLES DE VALIDACION.
            //    ViewBag.UsuarioPropietario = ValidacionProductos;
            //}

            //// SI EL CONTADOR MARCA QUE ES MAYOR A CERO.
            //else if (ValidacionProductosCarrito.Count() > 0)
            //{
            //    // VIEWBAG QUE ME ALMACENA LOS DATOS DE LAS VARIABLES DE VALIDACION.
            //    ViewBag.ProductoCarrito = ValidacionProductosCarrito;
            //}


            // VARIABLE QUE ME RETORNA EL PRODUCTO SEGUN EL ID.
            var detalles = Neg.detalles_proyecto(ID_proyecto );

            return View(detalles);
        }

        public ActionResult Mostrarvacantes1()
        {

            return View(Neg.Listavacantes());
        }


    }
}