using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    internal class Moto : Vehículo,IEncendido,ICilindrada
    {
        public Moto(int ruedas, string marca, string modelo) : base(ruedas, marca, modelo)
        {
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("*********************Moto************************");
            Console.WriteLine($"Cant. de ruedas: {Ruedas} marca: {Marca} modelo: {Modelo}");         
        }

        public string Arranca()
        {
            return ("Este vehículo arranca con patada");
        }
    }
}
