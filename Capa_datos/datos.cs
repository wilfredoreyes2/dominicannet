using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_entidades;

namespace Capa_datos
{

    public class datos
    {

        db_a86807_dominicannetEntities db = new db_a86807_dominicannetEntities();
        public void añadir_USUARIOS(usuarios user)
        {
            db.usuarios.Add(user);
            db.SaveChanges();
        }
        public usuarios login(usuarios ususario)
        {
            var oUser = (from d in db.usuarios
                         where d.correo == ususario.correo && d.contraseña == ususario.contraseña
                         select d).FirstOrDefault();



            return (oUser);

        }
        public usuarios validar_correo(String correo)
        {
            return (from user in db.usuarios
                    where user.correo == correo
                    select user).FirstOrDefault();
        }

        public List<proyectos> get_proyectos()
        {
            List<proyectos> lista;

            var productList = (from d in db.proyectos
                               where d.Estado == 1
                               select d).ToList();

            //lista = db.PRODUCTOS.ToList();
            lista = productList;

            return lista;
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public proyectos get_proyectosById(int id)
        {
            proyectos product = db.proyectos.Find(id);
            return product;
        }
        //METODO PARA EDITAR PRODUCTOS
        public void edit_proyectos(proyectos pro)
        {
            proyectos proEdit = get_proyectosById(pro.ID);
            proEdit.NOMBRE_PROYECTO      = pro.NOMBRE_PROYECTO;
            proEdit.descripcion  = pro.descripcion;
            proEdit.modelo_negocio    = pro.modelo_negocio;
            proEdit.invercion_necesaria = pro.invercion_necesaria;
            proEdit.Estado      = pro.Estado;
            proEdit.link_video   = pro.link_video;

            db.SaveChanges();
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisableproyectos(proyectos pro)
        {
            proyectos proDisable = get_proyectosById(pro.ID);
            proDisable.Estado = pro.Estado;

            db.SaveChanges();
        }
        //---------------------------------------------------

        // METODO QUE INSERTA O AGREGA NUEVOS USUARIOS
        public void añadir_proyectos(proyectos pro)
        {
            db.proyectos.Add(pro);
            db.SaveChanges();
        }






        //--------------------------- tabla empresas------------------------------
        public List<empresas> get_empresas()
        {
            List<empresas> lista;

            var productList = (from d in db.empresas
                               where d.Estado == 1
                               select d).ToList();

            //lista = db.PRODUCTOS.ToList();
            lista = productList;

            return lista;
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public empresas get_empresasById(int id)
        {
            empresas product = db.empresas.Find(id);
            return product;
        }
        //METODO PARA EDITAR PRODUCTOS
        public void edit_empresas(empresas pro)
        {
            empresas proEdit = get_empresasById(pro.ID);
            proEdit.nombre_empresa = pro.nombre_empresa;
            proEdit.descricion = pro.descricion;
            proEdit.modelo_negocio = pro.modelo_negocio;
            proEdit.invercion = pro.invercion;
            proEdit.Estado = pro.Estado;
            proEdit.porcentaje_participacion = pro.porcentaje_participacion;
            proEdit.id_usuario = pro.id_usuario;

            db.SaveChanges();
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisableempresas(empresas pro)
        {
            empresas proDisable = get_empresasById(pro.ID);
            proDisable.Estado = pro.Estado;

            db.SaveChanges();
        }
        //---------------------------------------------------

        // METODO QUE INSERTA O AGREGA NUEVOS USUARIOS
        public void añadir_empresas(empresas pro)
        {
            db.empresas.Add(pro);
            db.SaveChanges();
        }

        //------------------------------------------------ tabla usuarios-------------------------------------------------
        public List<usuarios> get_usuarios()
        {
            List<usuarios> lista;

            var productList = (from d in db.usuarios
                               where d.Estado == 1
                               select d).ToList();

            //lista = db.PRODUCTOS.ToList();
            lista = productList;

            return lista;
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public usuarios get_usuariosById(int id)
        {
            usuarios product = db.usuarios.Find(id);
            return product;
        }
        //METODO PARA EDITAR PRODUCTOS
        public void edit_usuarios(usuarios pro)
        {
            usuarios proEdit = get_usuariosById(pro.ID);
            proEdit.nombre = pro.nombre;
            proEdit.correo = pro.correo;
            proEdit.contraseña = pro.contraseña;
            proEdit.rol = pro.rol;
            proEdit.Estado = pro.Estado;
            proEdit.actividad = pro.actividad;
            proEdit.telefono = pro.telefono;
            proEdit.pagina_web = pro.pagina_web;
            proEdit.instagram = pro.instagram;

            db.SaveChanges();
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisableusuarios(usuarios pro)
        {
            usuarios proDisable = get_usuariosById(pro.ID);
            proDisable.Estado = pro.Estado;

            db.SaveChanges();
        }
        //---------------------------------------------------

        // METODO QUE INSERTA O AGREGA NUEVOS USUARIOS
        public void añadir_usuarios(usuarios pro)
        {
            db.usuarios.Add(pro);
            db.SaveChanges();
        }

        //--------------------------------------------- tabla vacantes empresas--------------------------------------
        public List<vacantes_empresas> get_vacantes_empresas()
        {
            List<vacantes_empresas> lista;

            var productList = (from d in db.vacantes_empresas
                               where d.Estado == 1
                               select d).ToList();

            //lista = db.PRODUCTOS.ToList();
            lista = productList;

            return lista;
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public vacantes_empresas get_vacantes_empresasById(int id)
        {
            vacantes_empresas product = db.vacantes_empresas.Find(id);
            return product;
        }
        //METODO PARA EDITAR PRODUCTOS
        public void edit_vacantes_empresas(vacantes_empresas pro)
        {
            vacantes_empresas proEdit = get_vacantes_empresasById(pro.ID);
            proEdit.vacante = pro.vacante;
            proEdit.descrpicion = pro.descrpicion;
            proEdit.puesto = pro.puesto;
            proEdit.horario = pro.horario;
            proEdit.Estado = pro.Estado;
            proEdit.salario = pro.salario;
            proEdit.ID_EMPRESA = pro.ID_EMPRESA;
            proEdit.Contacto = pro.Contacto;
           

            db.SaveChanges();
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisablevacantes_empresas(vacantes_empresas pro)
        {
            vacantes_empresas proDisable = get_vacantes_empresasById(pro.ID);
            proDisable.Estado = pro.Estado;

            db.SaveChanges();
        }
        //---------------------------------------------------

        // METODO QUE INSERTA O AGREGA NUEVOS USUARIOS
        public void añadir_vacantes_empresas(vacantes_empresas pro)
        {
            db.vacantes_empresas.Add(pro);
            db.SaveChanges();
        }
        //---------------------tabla reporte -------------------------------------
        public List<REPORTE> get_reportesProd()
        {
            var result = db.REPORTE.ToList();

            return result;
        }

        // ELIMINAR REPORTES

        public void ELIMINARREPORTES(int ID)
        {
            var query = (from r in db.REPORTE
                         where r.ID == ID
                         select r).ToList();


            db.REPORTE.RemoveRange(query);
            db.SaveChanges();
        }
        //---------------------------------------tabla proyecto usuario----------------------------------------------
        public void Añadirproyecto(proyectos Pro)
        {
            db.proyectos.Add(Pro);
            db.SaveChanges();
        }

        public List<proyectos> Listaproyecto()
        {
            var lista = (from d in db.proyectos
                         where (d.Estado == 1)
                         orderby d.ID ascending
                         select d).OrderByDescending(d => d.ID).Take(3).ToList();


            return lista;
        }

        public List<proyectos> detalles_proyecto(int ID)
        {


            var datos = (from d in db.proyectos
                         where (d.ID == ID)
                         select d).ToList();

            return datos;


        }
        public List<vacantes_empresas> Listavacantes()
        {
            var lista = (from d in db.vacantes_empresas
                         where (d.Estado == 1)
                         orderby d.ID ascending
                         select d).OrderByDescending(d => d.ID).Take(3).ToList();


            return lista;
        }
    }
}
