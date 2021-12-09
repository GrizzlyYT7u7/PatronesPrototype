using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronePrototypeCore
{
    public abstract class CelularPrototype 
    {
        //Atrobutos
        protected string _color;
        protected string _modelo;
        public string Color { set => _color = value; }
        public string Modelo { set => _modelo = value; }

        //Metodo abstracto de tipo CelularPrototype
        public abstract CelularPrototype Clonar();

        //Metodo abstracto tipo string
        public abstract string VerCelular();
    }
}
