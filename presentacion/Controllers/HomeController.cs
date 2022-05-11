using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capa_entidades;
using Capa_negocio;

namespace presentacion.Controllers
{
    public class HomeController : Controller
    {
        negocio Neg = new negocio();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            return View();
        }
        //tabla proyectos
        public ActionResult Tablaproyectos()
        {
            ViewBag.Message = "Your Table proyecto page.";

            return View(Neg.get_proyectos());

        }

        //ActionResults para agregar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Agregarproyecto()
        {
            ViewBag.Message = "Your Add Product page.";

            return View();
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        public ActionResult Agregarproyecto(proyectos pro)
        {
            ViewBag.Message = "Your Add Product page.";

            //Valida si el modelo es valido
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                //pro.Fecha_Registro = DateTime.Now;
                Neg.Insertarproyectos(pro);
                return RedirectToAction("Tablaproyectos");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar el Producto", ex);
                return View();
            }
        }

        //-------------------------------------------
        //ActionResults para editar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Editarproyecto(int id)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                return View(Neg.get_proyectosById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editarproyecto(proyectos pro)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                Neg.edit_proyectos(pro);

                return RedirectToAction("Tablaproyectos");
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        //-------------------------------------------

        //ActionResults para Deshabilitar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Deshabilitarproyecto(int id)
        {
            ViewBag.Message = "Your Disable Product page.";

            try
            {
                return View(Neg.get_proyectosById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        public ActionResult Deshabilitarproyecto(proyectos pro)
        {
            ViewBag.Message = "Your Disable Product page.";
            try
            {
                Neg.toDisableproyectos(pro);

                return RedirectToAction("Tablaproyectos");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //---------------------------------------tabla empresas-------------------------------------
        public ActionResult Tablaempresas()
        {
            ViewBag.Message = "Your Table proyecto page.";

            return View(Neg.get_empresas());

        }

        //ActionResults para agregar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Agregarempresas()
        {
            ViewBag.Message = "Your Add Product page.";

            return View();
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        public ActionResult Agregarempresas(empresas pro)
        {
            ViewBag.Message = "Your Add Product page.";

            //Valida si el modelo es valido
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                //pro.Fecha_Registro = DateTime.Now;
                Neg.Insertarempresas(pro);
                return RedirectToAction("Tablaempresas");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar el Producto", ex);
                return View();
            }
        }

        //-------------------------------------------
        //ActionResults para editar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Editarempresas(int id)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                return View(Neg.get_empresasById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editarempresas(empresas pro)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                Neg.edit_empresas(pro);

                return RedirectToAction("Tablaempresas");
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        //-------------------------------------------

        //ActionResults para Deshabilitar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Deshabilitarempresas(int id)
        {
            ViewBag.Message = "Your Disable Product page.";

            try
            {
                return View(Neg.get_empresasById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        public ActionResult Deshabilitarempresas(empresas pro)
        {
            ViewBag.Message = "Your Disable Product page.";
            try
            {
                Neg.toDisableempresas(pro);

                return RedirectToAction("Tablaempresas");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //--------------------------------------------------- tabla usuario----------------------------------------------
        public ActionResult Tablausuarios()
        {
            ViewBag.Message = "Your Table proyecto page.";

            return View(Neg.get_usuarios());

        }

        //ActionResults para agregar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Agregarusuarios()
        {
            ViewBag.Message = "Your Add Product page.";

            return View();
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        public ActionResult Agregarusuarios(usuarios pro)
        {
            ViewBag.Message = "Your Add Product page.";

            //Valida si el modelo es valido
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                //pro.Fecha_Registro = DateTime.Now;
                Neg.Insertarusuarios(pro);
                return RedirectToAction("Tablausuarios");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar el Producto", ex);
                return View();
            }
        }

        //-------------------------------------------
        //ActionResults para editar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Editarusuarios(int id)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                return View(Neg.get_usuariosById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editarusuarios(usuarios pro)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                Neg.edit_usuarios(pro);

                return RedirectToAction("Tablausuarios");
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        //-------------------------------------------

        //ActionResults para Deshabilitar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Deshabilitarusuarios(int id)
        {
            ViewBag.Message = "Your Disable Product page.";

            try
            {
                return View(Neg.get_usuariosById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        public ActionResult Deshabilitarusuarios(usuarios pro)
        {
            ViewBag.Message = "Your Disable Product page.";
            try
            {
                Neg.toDisableusuarios(pro);

                return RedirectToAction("Tablausuarios");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //------------------------------------tablaa vacantes-------------------------------------------

        public ActionResult Tablavacantes_empresas()
        {
            ViewBag.Message = "Your Table proyecto page.";

            return View(Neg.get_vacantes_empresas());

        }

        //ActionResults para agregar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Agregarvacantes_empresas()
        {
            ViewBag.Message = "Your Add Product page.";

            return View();
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        public ActionResult Agregarvacantes_empresas(vacantes_empresas pro)
        {
            ViewBag.Message = "Your Add Product page.";

            //Valida si el modelo es valido
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                //pro.Fecha_Registro = DateTime.Now;
                Neg.Insertarvacantes_empresas(pro);
                return RedirectToAction("Tablavacantes_empresas");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error al agregar el Producto", ex);
                return View();
            }
        }

        //-------------------------------------------
        //ActionResults para editar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Editarvacantes_empresas(int id)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                return View(Neg.get_vacantes_empresasById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editarvacantes_empresas(vacantes_empresas pro)
        {
            ViewBag.Message = "Your Edit Product page.";

            try
            {
                Neg.edit_vacantes_empresas(pro);

                return RedirectToAction("Tablavacantes_empresas");
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        //-------------------------------------------

        //ActionResults para Deshabilitar Productos------
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        [HttpGet]
        public ActionResult Deshabilitarvacantes_empresas(int id)
        {
            ViewBag.Message = "Your Disable Product page.";

            try
            {
                return View(Neg.get_vacantes_empresasById(id));
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // METODO QUE ALMACENA EL NUMERO DE ROL PARA VERIFICAR LA AUTENTICACION
        //[PermisosRol(1)]
        public ActionResult Deshabilitarvacantes_empresas(vacantes_empresas pro)
        {
            ViewBag.Message = "Your Disable Product page.";
            try
            {
                Neg.toDisablevacantes_empresas(pro);

                return RedirectToAction("Tablavacantes_empresas");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        //-------------------------tabla reporte --------------------
        public ActionResult TablaReporteView()
        {
            //int IDUser = (int)Session["id_usuario"];
            try
            {
                var reportes = Neg.get_reportesProd();

                return View(reportes);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //[PermisosRol(1)]

        public ActionResult EliminarReportes(int ID)
        {
            // METODO QUE ME ELIMINA LOS REPORES SEGUN EL ID

            Neg.EliminarR(ID);

            return RedirectToAction("TablaReporteView");
        }
    }
}