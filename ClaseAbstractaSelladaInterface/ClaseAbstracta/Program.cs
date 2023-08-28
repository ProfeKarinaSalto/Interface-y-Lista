using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            List<Auto> listAuto = new List<Auto>();

            Console.WriteLine("Cuántos autos desea ingresar?: ");
            int cantAutos = int.Parse(Console.ReadLine());

            for (int i=0; i<cantAutos; i++)
            {
                Console.WriteLine("Ingrese cant. de ruedas: ");
                int ruedas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Ingrese modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Ingrese cant. de puertas: ");
                int puertas = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Tiene cierre automático? True/False: ");
                bool cierreAutomatico = bool.Parse(Console.ReadLine());

                listAuto.Add(new Auto() { Ruedas = ruedas, Marca = marca, Modelo = modelo, Puertas = puertas, CierreAutomatico=cierreAutomatico });

            }
            
            foreach (Auto a in listAuto)
            {
                a.MostrarInformacion();
                a.MostrarLeyenda();
                Console.WriteLine(a.Arranca());
            }

            

            //Console.WriteLine("Indique la Marca del auto que desea encontrar: ");
            //string valor = Console.ReadLine();

            //Encuentra(valor,listAuto) ;

            listAuto.Sort((x, y) => (x.Modelo.CompareTo(y.Modelo)));

            foreach (Auto a in listAuto)
            {
                //a.MostrarLeyenda();
                a.MostrarInformacion();
            }

            Console.ReadKey();


        }

        static void Encuentra(string valorMarca, List<Auto> listAuto)
        {
            List<Auto> results = listAuto.FindAll(autito => autito.Marca==valorMarca);
            if (results.Count > 0)
            {
                foreach(Auto a in results)
                {
                    a.MostrarLeyenda();
                    a.MostrarInformacion();
                }
            }
            else
            {
                Console.WriteLine("No se encontró la marca.");
            }
            
        }
    }
}