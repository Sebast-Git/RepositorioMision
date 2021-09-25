using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario
    {
        List<Usuario> Usuario;
 
    public RepositorioUsuario()
        {
            Usuario= new List<Usuario>()
            {
                new Usuario{id=1,nombre="Sebastian",apellidos= "Burbano",direccion= "Carrera 27",telefono= "12345679875"},
                new Usuario{id=2,nombre="Camila",apellidos= "Perez",direccion= "Calle 96",telefono= "12345678953"},
                new Usuario{id=3,nombre="Maria",apellidos= "Goemz",direccion= "Avenida sur -14",telefono= "4567258745"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return Usuario;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return Usuario.SingleOrDefault(b => b.id == id);
        }
    }
}
