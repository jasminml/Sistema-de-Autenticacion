using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autenticacion
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string username { get; set; }
        public string clave { get; set; }
        public string rol { get; set; }
        public DateTime fecha_creacion { get; set; }
        public int estado { get; set; }
        public List<Usuario> ListadoUsuario { get; set; }

        public Usuario()
        {
            Nombre = string.Empty;
            username = string.Empty;
            clave = string.Empty;
            rol = string.Empty;
            fecha_creacion = DateTime.Now;
            estado = 0;
            ListadoUsuario = new List<Usuario>();
        }
    }
}
