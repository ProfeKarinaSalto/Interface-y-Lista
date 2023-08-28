using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientadoAObjetos
{
    public class Auto:Vehículo
    {
        //private int ruedas;
        //private string marca;
        //private string modelo;        
        private int puertas;
        private bool cierreAutomatico;

        public bool CierreAutomatico { get => cierreAutomatico; set => cierreAutomatico = value; }
        //public string Modelo { get => modelo; set => modelo = value; }
        //public string Marca { get => marca; set => marca = value; }

        /*public int Ruedas {
            get{
                return ruedas;
            }
            set{
                if(value!=4) ruedas=4;
                else ruedas=value;
            }
        }*/

        public int Puertas {
            get{
                return puertas;
            }
            set{
                if(value<3 || value>6) puertas=3;
                else puertas=value;
            }
        }

       
        public Auto(string marca, string modeloCoche, int puertasCoche, bool cierreAutomaticoCoche){
            ruedas=4;
            this.marca=marca;
            modelo=modeloCoche;
            puertas=puertasCoche;
            cierreAutomatico=cierreAutomaticoCoche;
        }




        public override void mostrarInformacion(){

            Console.WriteLine("*********************Auto************************");
            if (puertas<4){
                Console.WriteLine("Autos con 3 puertas: ");
                Console.WriteLine($"Cant. de ruedas: {ruedas} marca: {Marca} modelo: {Modelo} puertas: {puertas} cierre automático: {CierreAutomatico}");
            }
            else{
                Console.WriteLine("Autos con 5 puertas: ");
                Console.WriteLine($"Cant. de ruedas: {ruedas} marca: {Marca} modelo: {Modelo} puertas: {puertas} cierre automático: {CierreAutomatico}");

            }
            
        }

    }
}