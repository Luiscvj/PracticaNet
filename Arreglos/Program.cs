using System.Collections;

namespace Program;

class Program
{
   static void Main(string[] args)
    {//Un arreglo de enteros
       int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};//Le doy la ongitud por defecto
    /* 
    *Acceder a los numeros
     */
     //Un arreglo siempre va a ser mas rapido que una lista

     //Accedo a ellos por su posicion
     /* for (int i = 0; i <= numeros.Length; i++)
     {
        Console.WriteLine(numeros[i]);
     } */

     //Con Foreach() me ahorro la i y pued hacerlo mucho mas dinamico

     foreach(int numero in numeros)
     {
        Console.WriteLine(numero);
     }

    /* Un arreglo dinamico es en el cual yo le puedo modificar su tamaño de froma dinamica
    
    y lo decclaro ArrayList numeros = new ArrayList();
     */

    ArrayList  numeros2 = new ArrayList(){1,2,3,4,56};

    /* 
    *TAMBIEN PUEDO AÑADIRLE diferentes tipos de datos
     */
    ArrayList numeros3 = new ArrayList()
        {
            1,true,"",null
        };


    /* 
    una lista es una clase de coleccion List<int> enteros = new List<int>();Los parentesis para indicar que e sun objeto


   La clase list tiene metodos para insertar y demas
     */
   List<int> prueba = new List<int>();
   



   
     /* 
     ?COLAS
      */


      Queue lista = new Queue();
      Console.WriteLine("{0,5}{1,20}","Numero Ingresado","Numero de salida");
   /*    for(int i=0 ; i < 10 ;i++)
         {

          
        lista.Enqueue(i);
        
        Console.WriteLine("{0,5}{1,10}",i , lista.Dequeue());
      }  */
     
    
    }

}
