//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class vacantes_empresas
    {
        public int ID { get; set; }
        public string vacante { get; set; }
        public string descrpicion { get; set; }
        public string puesto { get; set; }
        public string horario { get; set; }
        public Nullable<int> salario { get; set; }
        public Nullable<int> ID_EMPRESA { get; set; }
        public string Contacto { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual empresas empresas { get; set; }
    }
}
