using PatronePrototypeCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPrototypeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de objetos
            CelularPrototype prototipoXiaomi = new XiaomiPrototype();
            CelularPrototype prototipoSamsung = new SamsungPrototype();
            CelularPrototype prototipoIPhone = new IPhonePrototype();

            //Creacion de instancia asignada que invoca al metodo de un objeto
            CelularPrototype Redmi9A = prototipoXiaomi.Clonar();
            Redmi9A.Modelo = "Redmi 9A";
            Redmi9A.Color = "negro";
            //Mostrar en pantalla el metodo VerCelular de dicha instancia asignada
            Console.WriteLine(Redmi9A.VerCelular());

            //Creacion de instancia asignada que invoca al metodo de un objeto
            CelularPrototype RedmiNote9 = prototipoXiaomi.Clonar();
            RedmiNote9.Modelo = "Redmi Note 9";
            RedmiNote9.Color = "blanco";
            //Mostrar en pantalla el metodo VerCelular de dicha instancia asignada
            Console.WriteLine(RedmiNote9.VerCelular());

            Console.WriteLine();

            //Creacion de instancia asignada que invoca al metodo de un objeto
            CelularPrototype S21 = prototipoSamsung.Clonar();
            S21.Modelo = "S 21";
            S21.Color = "negro";
            //Mostrar en pantalla el metodo VerCelular de dicha instancia asignada
            Console.WriteLine(S21.VerCelular());

            //Creacion de instancia asignada que invoca al metodo de un objeto
            CelularPrototype A21 = prototipoSamsung.Clonar();
            A21.Modelo = "A 21";
            A21.Color = "blanco";
            //Mostrar en pantalla el metodo VerCelular de dicha instancia asignada
            Console.WriteLine(A21.VerCelular());

            Console.WriteLine();

            //Creacion de instancia asignada que invoca al metodo de un objeto
            CelularPrototype ProMax13 = prototipoIPhone.Clonar();
            ProMax13.Modelo = "13 Pro Max";
            ProMax13.Color = "negro";
            //Mostrar en pantalla el metodo VerCelular de dicha instancia asignada
            Console.WriteLine(ProMax13.VerCelular());

            //Creacion de instancia asignada que invoca al metodo de un objeto
            CelularPrototype ProMax12 = prototipoIPhone.Clonar();
            //Asigacion de atributos
            ProMax12.Modelo = "12 Pro Max";
            ProMax12.Color = "blanco";
            //Mostrar en pantalla el metodo VerCelular de dicha instancia asignada 
            Console.WriteLine(ProMax12.VerCelular());

            Console.ReadKey();
        }
    }
}