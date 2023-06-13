using POODatabaseVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODatabaseVehiculos.Models
{
    public class Yate : Vehiculo, IAcuatico
    {
        private int valoracion;//Yo que se pienso en una valoracion rollo como un hotel con las estrellas
        const bool cinturones = false;

        public Yate(int valoracion, string modelo):base(modelo)
        {
            this.valoracion = valoracion;
        }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public bool Cinturones { get => cinturones; }
        public override void Seguridad()
        {
            Console.WriteLine("Nada aqui sin cinturones bro xdd del chill");
        }
        public string Navegar()
        {
            return "Broww aqui navegando por el mar chillinnnnn'";
        }
    }
}
