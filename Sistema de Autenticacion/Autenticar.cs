using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Autenticacion
{
    public class Autenticar
    {

        public static List<Usuario> CargarInformacion()
        {
            //Listado auto generado de los registros, aqui puedes modificar lo que quieras para validar los usuarios
            Usuario usuario = new Usuario();
            usuario.ListadoUsuario.Add(new Usuario() { Nombre = "Shyriu Machuca", username = "40200000001", clave = "1234567", estado = 1, rol = "Supervisor", fecha_creacion = DateTime.Now });
            usuario.ListadoUsuario.Add(new Usuario() { Nombre = "Argenis Delator", username = "40200000002", clave = "1234567", estado = 1, rol = "Administrador", fecha_creacion = DateTime.Now });
            usuario.ListadoUsuario.Add(new Usuario() { Nombre = "Leonel Lider", username = "40200000003", clave = "1234567", estado = 0, rol = "Vendedor", fecha_creacion = DateTime.Now });
            return usuario.ListadoUsuario;
        }

        public string[] ValidarUsuario(string username, string clave)
        {
            //En este metodo validas si las credenciales que manda el usuario por pantalla estan en el listado que se genera en el metodo superior CargarInformacion
            string[] result = new string[2];
            //Cargamos aqui el listado de los registros
            var listado = CargarInformacion();

            //Aqui validamos el user name para ver si esta en caso de que no exista retornara el mensaje de else mas el estado que es 0 el cual indica que no esta validado.
            //Para un usuario estar validado debe ser 1
            var auth = listado.Find(x => x.username == username);

            if (auth != null)
            {
                if (auth.clave != clave)
                {
                    result[0] = "Contraseña Incorrecta";
                    result[1] = "0";
                }

                if (auth.estado != 1)
                {
                    result[0] = "El usuario " + auth.Nombre + " esta deshabilitado";
                    result[1] = "0";
                }

                if (auth.estado.Equals(1) && auth.clave.Equals(clave))
                {
                    result[0] = "Acaba de ingresar con el usuario " + auth.username + " y su rol es " + auth.rol;
                    result[1] = "1";
                }
            }
            else
            {
                result[0] = "Este usuario no existe";
                result[1] = "0";
            }

            return result;
        }
    }
}
