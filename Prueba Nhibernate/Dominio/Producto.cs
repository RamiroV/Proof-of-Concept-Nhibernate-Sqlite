using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Nhibernate.Dominio
{
    public class Producto
    {
        public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual string Categoria { get; set; }
        public virtual double Precio { get; set; }

        public Producto() { }
    }
}
