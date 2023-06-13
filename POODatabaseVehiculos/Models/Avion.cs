using POODatabaseVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODatabaseVehiculos.Models
{
    class Avion:Vehiculo,IAereo
    {
        private int numRuedas;
        const bool cinturones = true;
        public Avion(int numRuedas, string modelo) : base(modelo)
        {
            this.numRuedas = numRuedas;
        }
        public int NumRuedas { get => numRuedas; set => numRuedas = value; }
        public bool Cinturones { get => cinturones; }
        public string Volar()
        {
            return "FIIIIIIIIIIAUU Volando a full xd";
        }
        public override void Seguridad()
        {
            Console.WriteLine("Los cinturones obligatorios al despegar y al aterrizar...");
        }
    }
}
