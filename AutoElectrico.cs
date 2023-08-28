using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientadoAObjetos
{
    public class AutoElectrico:Auto
    {
        private int voltaje;
        public AutoElectrico(string marca, string modeloCoche, int puertasCoche, bool cierreAutomaticoCoche, int voltaje):base(marca, modeloCoche,puertasCoche,cierreAutomaticoCoche) {
            this.voltaje=voltaje;

        }

        public int Voltaje { get => voltaje; set => voltaje = value; }

        public void infoAutoElectrico(){
            Console.WriteLine($"Utiliza voltaje: {voltaje} (V)");

        }
    }
}