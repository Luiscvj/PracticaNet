using Entidades;
using Interfaces;

namespace Program;
class Program
{
    private static void Main(string[] args)
    {
        Vino bebidaAlcoholica  = new Vino(100);
        MostrarRecomendado(bebidaAlcoholica);
    }


    static void MostrarRecomendado(IBebidaAlcoholica bebida)
    {
        bebida.MaxRecomendado();
    }
}