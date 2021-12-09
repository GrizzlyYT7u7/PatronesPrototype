using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatronePrototypeCore
{
    //Herencia de CelularPrototype
    public class IPhonePrototype : CelularPrototype
    {
        //Metodo override que clona dicha clase
        public override CelularPrototype Clonar()
        {
            return (IPhonePrototype)this.MemberwiseClone();
        }

        //Metodo tipo string para mostrar en pantalla
        public override string VerCelular()
        {
            return $"IPhone {_modelo} color {_color}";
        }
    }
}
