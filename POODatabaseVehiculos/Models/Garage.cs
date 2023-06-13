using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POODatabaseVehiculos.Models
{
    public class Garage<T>
    {
        private T[] datosElemento;
        public int i = 0;
       
        public Garage(T obj)
        {
            datosElemento[i] = obj;
            i++;                     //Este Constructor no lo termino de entender...........................................
        }
        //Añadir el elemento que se le pasa en el argumento a l'array 
        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }
        //Recoger el elemento seleccionado
        public T GetElement(int x)
        {
            return datosElemento[x];
        }
   
    }
}
