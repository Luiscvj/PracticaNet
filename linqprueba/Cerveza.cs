public class Cerveza
{
    public string Nombre { get; set; }
    public int  Alcohol { get; set; }
    public int Cantidad  {get; set;}
    public string Marca { get; set; }


     public Cerveza(string nombre, int Alochol,int Cantiad, string _Marca){
        this.Nombre = nombre;
        this.Alcohol = Alochol;
        this.Cantidad = Cantiad; 
        this.Marca = _Marca;

    } 

    public Cerveza()
    {
    }
}