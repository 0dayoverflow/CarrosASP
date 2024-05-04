using carrosASP.Models;
using Humanizer;
using System.Security.Cryptography.X509Certificates;


namespace carrosASP.Data
{
    public class Da_Logica //aqui se va a hacer la conexion a la base de datos para validar el usuario
    {

        public List<Usuario> ListaUsuario() {

            return new List<Usuario> {

                //falta hacer que el entity lo consulte y lo devualv  com usn alista

                new Usuario {Nombre = "jose", Correo = "admin@mail.com", Clave="123", Roles= new string[]{"Administrador" } },
                new Usuario {Nombre = "Maria", Correo = "user@mail.com", Clave="123", Roles= new string[]{"Usuario" } },
                new Usuario {Nombre = "Pepe", Correo = "admi@mail.com", Clave="123", Roles= new string[]{"Administrador" } },
                new Usuario {Nombre = "julian", Correo = "user@mail.com", Clave="123", Roles= new string[]{"usuario" } }




            };//Devuelve todos los usuarios registrados en la base de datos





        }
        public Usuario ValidarUsuario(string _correo, string _clave)
        {
            return ListaUsuario().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
        }//Devuelve un usuario si el correo y la clave son correctos



    }
}
