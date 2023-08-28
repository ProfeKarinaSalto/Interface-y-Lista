namespace orientadoAObjetos{
internal class Program
{
    private static void Main(string[] args)
    {
                        
        Auto auto3=new Auto("Renault","2009",5,true);
        auto3.mostrarInformacion();

        Auto auto2=new Auto("VW","2020",2,true);
        AutoElectrico auto4=new AutoElectrico("Peugeot","202",2,false,220);
        auto4.mostrarInformacion();
        auto4.infoAutoElectrico();

        Console.ReadKey();


    }
}
}