using System.Runtime.ConstrainedExecution;

namespace Program;

class Program
{
    private static void Main(string[] args)
    {
        List<int> numeros = new List<int>() {1,2,3,4,5,6,7,8};

        //Para saber si existe un numero

    /*     var numero = numeros.Where(X => X == 79).FirstOrDefault();
        Console.WriteLine(numero);

        var numeroOrdenado = numeros.OrderBy(n => n);
        foreach(var numeroO in numeroOrdenado)
        {
            Console.WriteLine(numeroO);
        } */


        //Sumatoria 

        var total = numeros.Sum(d => d);

       
        
        //Avergae
/* 
        var  promedio = numeros.Average(d => d);
        Console.WriteLine(promedio); */

        
     List<Cerveza> cervezas = new List<Cerveza>()
     {
        new Cerveza(){Nombre="Heineken", Alcohol = 9, Cantidad = 28 , Marca ="Minerva"},
        new Cerveza(){Nombre = "Costeña", Alcohol = 15, Cantidad =15, Marca = "Budweiser"}
     };


     var CervevezasOrdenadas = from d in cervezas
                              orderby d.Cantidad 
                              select new {d.Nombre,d.Marca};

        foreach(var c in CervevezasOrdenadas)
        {
            Console.WriteLine(c.Nombre+ "  " +c.Marca);
        }
    }
}