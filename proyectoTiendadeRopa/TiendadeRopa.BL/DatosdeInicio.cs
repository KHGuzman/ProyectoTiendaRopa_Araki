using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendadeRopa.BL
{
    public class DatosdeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "Ana Mejia";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("20182000909");

            nuevoUsuario.Nombre = "Estefany Bobadilla";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("20182001740");

            nuevoUsuario.Nombre = "Grissel Ortiz";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("20162030899");

            nuevoUsuario.Nombre = "Jerry Valle";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("20182001940");

            nuevoUsuario.Nombre = "Keren Hernandez";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("20182001734");

            contexto.Usuarios.Add(nuevoUsuario);

            base.Seed(contexto);
        }
    }
}
