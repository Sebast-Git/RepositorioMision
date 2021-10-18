using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        
        private readonly AppContext _appContext = new AppContext(); 
 
 
        public IEnumerable<Servicio> GetAll()
        {
           return _appContext.Servicio.Include(u => u.origen)
                       .Include(u => u.destino).
                       Include(e => e.encomienda);
        }
 
        public Servicio GetServicioWithId(int id){
            return _appContext.Servicio.Find(id);
        }

        // public Servicio Create(int origen, int destino, string fecha, string hora, int encomienda)
        // {
        //     var addServicio = _appContext.Servicio.Add(newServicio);
        //     _appContext.SaveChanges();
        //     return addServicio.Entity;
        // }

        public Servicio Create(int origen, int destino, DateTime fecha, string hora, int encomienda)
        {
            var newServicio = new Servicio();
            newServicio.destino = _appContext.Usuario.Find(destino);
            newServicio.origen = _appContext.Usuario.Find(origen);  
            newServicio.encomienda = _appContext.Encomienda.Find(encomienda);         
            newServicio.fecha = fecha; //DateTime.Parse(fecha);
            newServicio.hora = hora;
            var addServicio = _appContext.Servicio.Add(newServicio);
            _appContext.SaveChanges();
            return addServicio.Entity;
        }

        public Servicio Update(int id, int origen, int destino, string fecha, string hora, int encomienda){
            var servicio = _appContext.Servicio.Find(id);
            if(servicio != null){
                servicio.origen = _appContext.Usuario.Find(origen);
                servicio.destino = _appContext.Usuario.Find(destino);
                servicio.encomienda = _appContext.Encomienda.Find(encomienda);

                servicio.fecha = fecha;
                servicio.hora = hora;
                
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return servicio;
        }


        public void Delete(int id)
        {
        var user = _appContext.Servicio.Find(id);
        if (user == null)
            return;
        _appContext.Servicio.Remove(user);
        _appContext.SaveChanges();
        }


    }

}