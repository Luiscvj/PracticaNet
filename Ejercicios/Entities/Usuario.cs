namespace Entities;


public class Usuario
{
    public string ? Nombre { get; set; }
    public float ? Nota   {get;set;}  


    public Usuario(string _Nombre, float _Nota)
    {
        this.Nombre = _Nombre;
        this.Nota = _Nota;
    }
    public Usuario()
    {

    }
}