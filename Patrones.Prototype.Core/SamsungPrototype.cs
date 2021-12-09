using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronePrototypeCore
{

    //Herencia de CelularPrototype
    public class SamsungPrototype : CelularPrototype
    {
        //Metodo override que clona dicha clase
        public override CelularPrototype Clonar()
        {
            return (SamsungPrototype)this.MemberwiseClone();
        }

        //Metodo tipo string para mostrar en pantalla
        public override string VerCelular()
        {
            return $"Samsung {_modelo} color {_color}";
        }
    }
}
