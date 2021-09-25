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
                new Usuario{id=1,nombre="Sebastian",apellido= "Burbano",dirreccion= "Carrera 27",telefono= "12345679875"},
                new Usuario{id=2,nombre="Camila",apellido= "Perez",dirreccion= "Calle 96",telefono= "12345678953"},
                new Usuario{id=3,nombre="Maria",apellido= "Goemz",dirreccion= "Avenida sur -14",telefono= "4567258745"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return Usuario;
        }
 
        public Usuario GetBusWithId(int id){
            return Usuario.SingleOrDefault(b => b.id == id);
        }
    }
}
