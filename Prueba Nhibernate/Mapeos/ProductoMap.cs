using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using Prueba_Nhibernate.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Nhibernate.Mapeos
{
    public class ProductoMap : ClassMapping<Producto>
    {
        public ProductoMap()
        {
            Id(x => x.Id, m => m.Generator(Generators.Identity));
            Property(x => x.Categoria);
            Property(x => x.Nombre);
            Property(x => x.Precio);
        }
    }
}
