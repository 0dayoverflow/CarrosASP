namespace carrosASP.Models
{
    public class Usuario
    {
        public String Nombre { get; set; }

        public string Correo { get; set; }

        public string Clave { get; set; }

        public string[] Roles { get; set; }
    }
}
