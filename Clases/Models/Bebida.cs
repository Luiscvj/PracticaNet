using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clases.Models
{
    public class Bebida
    {     //GET SET Me permite serializar mi atributo, con estos metodos es que hago la configuracion tambien
        public string  Nombre  { get; set; }
        public int Cantidad {get; set; }

        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }
        public Bebida()
        {

        }
        public void Beberse (int bebido)
        {
            this.Cantidad -= bebido;

        }
    }
}