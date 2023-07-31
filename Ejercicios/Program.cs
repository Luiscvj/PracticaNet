// See https://aka.ms/new-console-template for more information
namespace Program;

using System.Globalization;
using Entities;
class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = new List<Usuario>();
        
          
        bool op = false;
        do{ 
             
            Console.WriteLine("Ingrese el nombre del usuario ");
            string ? nombre = Console.ReadLine() ;
            Console.WriteLine("Ingrese la nota del usuario");
            //double  nota = Convert.ToDouble(Console.ReadLine());
            float  nota = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture.NumberFormat);
            Usuario usuario = new Usuario(nombre,nota);
            
            usuarios.Add(usuario);
            Console.Clear();

            while(op == false)
            {
            Console.WriteLine("Desea seguir agregando estudiantes:\n1)S para Si\n2)Enter para no");
             var letra = Console.ReadKey().Key;
            if(letra == ConsoleKey.Enter)
            {
                op = true;
            }else if(letra == ConsoleKey.S)
            {
                   break; 
            }
            }


            
        }while(op == false);

    var us =  usuarios.OrderByDescending(x => x.Nota).ToList();
    Console.WriteLine("{0,5}{1,10}","Nota","Nombre");
    foreach(Usuario u  in us)
    {
         Console.WriteLine("{0,5}{1,10}",u.Nota,u.Nombre);
    }
     


    }
}