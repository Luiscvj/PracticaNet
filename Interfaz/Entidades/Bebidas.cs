namespace Entidades;


public class Bebida 
{
    public string Nombre { get; set; }
    public int Contenido { get; set; }


    public Bebida(int _Contenido, string _Nombre )
    {
        Contenido = _Contenido;
        Nombre = _Nombre;
    }

    public Bebida()
    {
    }
}