using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public sealed class AutoElectrico:Auto
    {
        private int voltaje;
        public AutoElectrico(int ruedas, string marca, string modeloCoche, int puertasCoche, bool cierreAutomaticoCoche, int voltaje):base(ruedas, marca, modeloCoche,puertasCoche,cierreAutomaticoCoche) {
            this.voltaje=voltaje;

        }

        public int Voltaje { get => voltaje; set => voltaje = value; }

        public void InfoAutoElectrico(){
            Console.WriteLine($"Utiliza voltaje: {voltaje} (V)");

        }
    }
}