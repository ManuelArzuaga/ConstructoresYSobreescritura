using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresYSobreescritura
{
    class Vehiculo
    {
        public string Marca { get; set; }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }

        public virtual void Conducir() //virtual indica que el metodo se puede sobreescribir en una clase derivada de la misma
        {
            //se va a modificar con la sobreescritura en la clase auto que hereda vehiculo
            Console.WriteLine("Conduciendo un vehiculo de marca " + Marca);
        }
    }
}
