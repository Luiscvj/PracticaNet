using Interfaces;

namespace Entidades;

public class Vino :Bebida, IBebidaAlcoholica
{   
    public int Contenido {get;set;}
    public string Nombre    {get;set;}
    public int Alcohol { get; set; }

    public Vino(int contenido ,string _Nombre = "Vino"): base(contenido ,_Nombre)
    {

    }

    public void MaxRecomendado()
    {
        Console.WriteLine("Un buen vino tiene mas de 100 años");
    }
}