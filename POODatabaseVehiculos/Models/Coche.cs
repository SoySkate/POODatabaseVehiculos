using POODatabaseVehiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODatabaseVehiculos.Models
{
    class Coche:Vehiculo, ITerrestre
    {
        private int numRuedas;
        const bool cinturones = true;

        public Coche(int numRuedas, string modelo) : base(modelo)
        {
            this.numRuedas = numRuedas;
        }
        public int NumRuedas { get => numRuedas; set => numRuedas = value; }
        public bool Cinturones { get => cinturones;}
        public string Conducir()
        {
            return "BRUUUM HACE EL COCHEE XDD";
        }
    }
}
