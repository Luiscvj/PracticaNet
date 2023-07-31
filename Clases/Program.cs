// See https://aka.ms/new-console-template for more information
namespace Clases;
using Models;
class Program
{
    static void Main(string[] args)
    {
        Bebida gaseosa = new Bebida("Cocacola", 900);

        //gaseosa.Beberse(45);
        //Console.WriteLine(gaseosa.Cantidad);
        Cerveza heineken = new Cerveza(123);

        Console.WriteLine(heineken.Cantidad);

    

        
    }
}