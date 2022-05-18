using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos;
using Capa_entidades;
namespace Capa_negocio
{
    public class negocio
    {
        datos Dt = new datos();
        public usuarios Login(usuarios usuario)
        {
            return Dt.login(usuario);

        }
        public void Insertar(usuarios user)
        {
            Dt.añadir_USUARIOS(user);
        }
        public usuarios Validar_correo(String correo)
        {
            return Dt.validar_correo(correo);
        }

        public List<proyectos> get_proyectos()
        {
            return Dt.get_proyectos();
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public proyectos get_proyectosById(int id)
        {
            return Dt.get_proyectosById(id);
        }

        //METODO PARA EDITAR UN USUARIO
        public void edit_proyectos(proyectos pro)
        {
            Dt.edit_proyectos(pro);
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisableproyectos(proyectos pro)
        {
            Dt.toDisableproyectos(pro);
        }

        // METODO QUE ME INSERTA UN USUARIO A LA BD.
        public void Insertarproyectos(proyectos pro)
        {
            Dt.añadir_proyectos(pro);
        }































        //---------------tabla empresa---------------------------------
        public List<empresas> get_empresas()
        {
            return Dt.get_empresas();
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public empresas get_empresasById(int id)
        {
            return Dt.get_empresasById(id);
        }

        //METODO PARA EDITAR UN USUARIO
        public void edit_empresas(empresas pro)
        {
            Dt.edit_empresas(pro);
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisableempresas(empresas pro)
        {
            Dt.toDisableempresas(pro);
        }

        // METODO QUE ME INSERTA UN USUARIO A LA BD.
        public void Insertarempresas(empresas pro)
        {
            Dt.añadir_empresas(pro);
        }

        //---------------------------------tabala usuarios------------------------------------------
        public List<usuarios> get_usuarios()
        {
            return Dt.get_usuarios();
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public usuarios get_usuariosById(int id)
        {
            return Dt.get_usuariosById(id);
        }

        //METODO PARA EDITAR UN USUARIO
        public void edit_usuarios(usuarios pro)
        {
            Dt.edit_usuarios(pro);
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisableusuarios(usuarios pro)
        {
            Dt.toDisableusuarios(pro);
        }

        // METODO QUE ME INSERTA UN USUARIO A LA BD.
        public void Insertarusuarios(usuarios pro)
        {
            Dt.añadir_usuarios(pro);
        }

        //------------------------------------vacantes empresas-----------------------------------------
        public List<vacantes_empresas> get_vacantes_empresas()
        {
            return Dt.get_vacantes_empresas();
        }

        //METODO PARA OBTENER A UN PRODUCTO POR SU ID
        public vacantes_empresas get_vacantes_empresasById(int id)
        {
            return Dt.get_vacantes_empresasById(id);
        }

        //METODO PARA EDITAR UN USUARIO
        public void edit_vacantes_empresas(vacantes_empresas pro)
        {
            Dt.edit_vacantes_empresas(pro);
        }

        //METODO PARA DESHABILITAR USUARIOS
        public void toDisablevacantes_empresas(vacantes_empresas pro)
        {
            Dt.toDisablevacantes_empresas(pro);
        }

        // METODO QUE ME INSERTA UN USUARIO A LA BD.
        public void Insertarvacantes_empresas(vacantes_empresas pro)
        {
            Dt.añadir_vacantes_empresas(pro);
        }
        //------------------------tabla reporte-----------------------------
        public List<REPORTE> get_reportesProd()
        {
            var result = Dt.get_reportesProd();

            return result;
        }

        // ELIMINAR REPORTES

        public void EliminarR(int ID)
        {
            Dt.ELIMINARREPORTES(ID);
        }

        //-------------------------------------tabla proyecto usuario------------------------------------------------------------
        public void Insertarproyecto(proyectos pro)
        {
            Dt.Añadirproyecto(pro);
        }

        public List<proyectos> Listaproyecto()
        {
            return Dt.Listaproyecto();
        }

        public List<proyectos> detalles_proyecto(int ID)
        {
            return Dt.detalles_proyecto(ID);
        }

        public List<vacantes_empresas> Listavacantes()
        {
            return Dt.Listavacantes();
        }

        public void Insertarofertantes(ofertantes pro)
        {
            Dt.Añadirofertantes(pro);
        }

        public List<proyectos> Listadoproyectos(int ID)
        {
            return Dt.Listadoproyectos(ID);
        }

        public List<ofertantes> Listadoofertantes(int ID)
        {
            return Dt.Listadoofertantes(ID);
        }
        public List<usuarios> infousuarios(int ID)
        {
            return Dt.infousuarios(ID);
        }

    }
}
