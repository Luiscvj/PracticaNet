// See https://aka.ms/new-console-template for more information
namespace Fundamentos;

class program
{
    static void Main(string[] args)
    {
        //Tipos de datos


        //pARA NUMEROS HAY 8

        /*
        ?ENTEROS
         *Un byte guarda valores 0 a 255 bytes
         !Su nemesis me permite meter negativos
         *Para este caso seria sbyte que va desde -127 a 128
         *int 4 bytes  alamacena mas datos permite negativos
         *unit Solo me permite positivos u "Unsigned"
         *long de 8 bytes 
         *ulong solo positivos 
         *short 2 bytes
         ?byte 1byte , short 2 byte, int 4byte , long8byte
        
         los  nativos puedo inicializar como objetos y tienen sus propios metodos

         para el caso de int es 0

         si quiero que no tenga nada le asigno un null
         */
        byte num1 =255;
        sbyte num2 = -125;
        short num5 = 1213;
        int num3 = -12399;
        uint num4 =2192;
        long num6 = 123124141;


    int num = new int();//su valor por defecto es 0
    char a = new char();//System.String[]
    
    Console.WriteLine(args);

        /* 
        ?FLOTANTES
        *float es un flotante con 4 bytes , tengo que definirle la f por que por defecto lo toma como double
        *double  8 bytes 
        *decimal son 16 bytes y debe colocarse la m al final
         */
        float num7 = 12.32f; 
        double num8 = 112.213;
        decimal num9 = 123.2321m;


        /* 
        ?CARACTERES
        *char permite unicamente dos bytes y solo permite representar con comillas simples
        
        datos compuestos
        *string  "dkdslñadk"
        *DateTime representa una clase y me permite obtener las fechas

        */




        /* 
        ?VAR

        *Es para decirle a c# que tome automaticamente el valor 
        *Una vez ya este definido  no se puede cambiar el tipo de dato y solo va a funcionar en metodos locales , no puede ser un atributo


         */

         var h = 12;
         var nombre = 121312;
         var verdad = true;



         /* 
         ?OBJECT 
         *E la base de todos los tipos de datos de c# .net
        *puedo declrar cualquier tipo de nombre
        *el object pierde las cualidades cuando le asigno algo pero lo puedo usar con var para llamarlos

          */

          object persona =
            new   {nombre = "Luis Carlos", edad = 12};

            var casa = new {tamanio= 12.3, nombre = "Casaaaaa"};

            Console.WriteLine(casa.tamanio);


    }
}
