using Interfaces;

namespace Entidades;


public class Cerveza : Bebida,IBebidaAlcoholica
{
    public Cerveza(int _Contenido, string _Nombre) : base(_Contenido, _Nombre)
    {
        
    }


    public int Alcohol { get;set; }

    public void MaxRecomendado()
    {
        Console.WriteLine("EL maximo recomendado es 10ml");

    }
}