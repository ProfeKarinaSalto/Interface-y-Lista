using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    public abstract class Vehículo
    {
        private int ruedas;
        private string marca;
        private string modelo;

        public int Ruedas { get => ruedas; set => ruedas = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }

        public Vehículo()
        {

        }

        public Vehículo(int ruedas,string marca, string modelo)
        {
            this.ruedas = ruedas;
            this.marca = marca;
            this.modelo = modelo;
        }
        public abstract void MostrarInformacion();

        public void MostrarLeyenda()
        {
            Console.WriteLine("Esto es un vehículo");
        }
    }

}