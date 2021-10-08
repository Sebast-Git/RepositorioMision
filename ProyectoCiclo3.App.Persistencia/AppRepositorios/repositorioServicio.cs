using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioServicio
    {
        
        private readonly AppContext _appContext = new AppContext(); 
 
 
        public IEnumerable<Servicio> GetAll()
        {
            return _appContext.Servicio;
        }
 
        public Servicio GetServicioWithId(int id){
            return _appContext.Servicio.Find(id);
        }

        public Servicio Create(Servicio newServicio)
        {
            var addServicio = _appContext.Servicio.Add(newServicio);
            _appContext.SaveChanges();
            return addServicio.Entity;
        }

        public Servicio Update(Servicio newServicio){
            var service = _appContext.Servicio.Find(newServicio.id);
            if(service != null){
                service.origen = newServicio.origen;
                service.destino = newServicio.destino;
                service.fecha = newServicio.fecha;
                service.hora = newServicio.hora;
                service.encomienda = newServicio.encomienda;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return service;
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