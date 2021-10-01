using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEncomienda
    {
        List<Encomienda> encomienda;
 
    public RepositorioEncomienda()
        {
            encomienda= new List<Encomienda>()
            {
                new Encomienda{id=1,descripcion="Roku Express, Reproductor multimedia de transmisión HD",peso= "1.1 Oz",tipo= "Accesorios de TV",presentacion= "N/A"},
                 
            };
        }
 
        public IEnumerable<Encomienda> GetAll()
        {
            return encomienda;
        }
 
        public Encomienda GetEncomiendaWithId(int id){
            return encomienda.SingleOrDefault(b => b.id == id);
        }

        public Encomienda Update(Encomienda newEncomienda){

            var encomiendas= encomienda.SingleOrDefault(b => b.id == newEncomienda.id);

            if(encomienda != null){
                encomiendas.descripcion = newEncomienda.descripcion;
                encomiendas.peso = newEncomienda.peso;
                encomiendas.tipo = newEncomienda.tipo;
                encomiendas.presentacion = newEncomienda.presentacion;
            }
        return encomiendas;
        }
    }
}
