using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronePrototypeCore
{

    //Herencia de CelularPrototype
    public class XiaomiPrototype : CelularPrototype
    {

        //Metodo override que clona dicha clase
        public override CelularPrototype Clonar()
        {
            return (XiaomiPrototype)this.MemberwiseClone();
        }

        //Metodo tipo string para mostrar en pantalla
        public override string VerCelular()
        {
            return $"Xiaomi {_modelo} color {_color}";
        }
    }
}
