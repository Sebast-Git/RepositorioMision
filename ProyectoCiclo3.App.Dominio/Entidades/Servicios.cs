using System;
namespace ProyectoCiclo3.App.Dominio{
    public class Servicio{
    public int id { get; set; }
    public Usuario origen { get; set; }
    public Usuario destino { get; set; }
    public string fecha { get; set; }
    public string hora { get; set; }
    public Encomienda encomienda { get; set; }
    //comentariopublic string codigo { get; set; }
    }

}