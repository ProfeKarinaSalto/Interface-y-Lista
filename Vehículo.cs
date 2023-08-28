using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientadoAObjetos
{
    public abstract class Vehículo
    {
        private int ruedas;
        private string marca;
        private string modelo;

        public int Ruedas { get => ruedas; set => ruedas = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public abstract void mostrarInformacion();
    }

}