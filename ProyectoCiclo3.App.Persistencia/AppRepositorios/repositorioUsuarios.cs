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
                new Usuario{id=1,nombre="Sebastian",apellidos= "Burbano",direccion= "Carrera 27",telefono= "12345679875",ciudad= "Cali"},
                new Usuario{id=2,nombre="Camila",apellidos= "Perez",direccion= "Calle 96",telefono= "12345678953",ciudad= "Bogota"},
                new Usuario{id=3,nombre="Maria",apellidos= "Goemz",direccion= "Avenida sur -14",telefono= "4567258745",ciudad= "Manizales"}
 
            };
        }
 
        public IEnumerable<Usuario> GetAll()
        {
            return Usuario;
        }
 
        public Usuario GetUsuarioWithId(int id){
            return Usuario.SingleOrDefault(b => b.id == id);
        }

        public Usuario Create(Usuario newUsuario)
        {
           if(Usuario.Count > 0){
           newUsuario.id=Usuario.Max(r => r.id) +1; 
            }else{
               newUsuario.id = 1; 
            }
           Usuario.Add(newUsuario);
           return newUsuario;
        }

        public Usuario Update(Usuario newUsuario){

            var user= Usuario.SingleOrDefault(b => b.id == newUsuario.id);

            if(user != null){
                user.nombre = newUsuario.nombre;
                user.apellidos = newUsuario.apellidos;
                user.direccion = newUsuario.direccion;
                user.telefono = newUsuario.telefono;
                user.ciudad = newUsuario.ciudad;
            }
        return user;
        }

        public void Delete(int id)
        {
        var user= Usuario.SingleOrDefault(b => b.id == id);
        Usuario.Remove(user);
        return;
        }

    }

}
