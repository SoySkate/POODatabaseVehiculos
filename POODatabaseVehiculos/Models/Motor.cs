using POODatabaseVehiculos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODatabaseVehiculos.Models
{
    public class Motor
    {
        private Combustible tipoMotor;
        private double horsePowerHP;
        private double cilindrada;

        //una de las mil formas de hacer un constructorrr...
        public Motor(Combustible tipoMotor, double horsePowerHP, double cilindrada)
        {
            this.tipoMotor = tipoMotor;
            this.horsePowerHP = horsePowerHP;
            this.cilindrada = cilindrada;
        }

    }
}
