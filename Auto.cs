using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructoresYSobreescritura
{
    class Auto : Vehiculo
        //heredar permite usar las propiedades y metodos de la clase que se esta heredando,solo permite heredar de una sola clase
        //para heredar se pone :clase a heredar
        //la clase heredada tiene que tener el mismo nivel de accesivilidad que la clase que hereda
        //si la clase hereda tambien hereda el constructor principal, que esta en la clase padre
    {
        public string Modelo { get; set; }

        public Auto(string marca, string modelo) : base(marca) //para heredar el constructor de la clase padre se pone :base(parametro) siendo el parametro lo que recibe el constructor de la clase padre
                      //se pone el parametro que recibe el constructor de la clase padre en los parametros que recibe el constructor de la clase hijo
        {               //base le envia al constructor de la clase padre el parametro que necesita
            Modelo = modelo;
        }

        public override void Conducir() //se pone override porque va a sobreescribir un metodo virtual
        {
            //la sobreescritura modifica el metodo original que es heredado
            Console.WriteLine("Conduciendo un auto modelo " + Modelo  + " y Marca " + Marca); //marca es un parametro del padre(vehiculo) que esta heredando
        }
    }
}
