using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prueba_Nhibernate;
using Prueba_Nhibernate.Dominio;
using NHibernate.Linq;
using System.Linq;
using Faker;

namespace Tests.Productos
{
    [TestClass]
    public class ModeloDatos
    {
        [TestMethod]
        public void ObtenerUnProductoRecienCreado()
        {
            var nuevoProducto = ConstruirUnNuevoProducto();

            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(nuevoProducto);
                session.Flush();

                var existeProductoRecienCreado = session.Query<Producto>()
                    .Any(x => x.Nombre == nuevoProducto.Nombre
                        && x.Categoria == nuevoProducto.Categoria
                        && x.Precio == nuevoProducto.Precio);

                Assert.IsTrue(existeProductoRecienCreado);
            }
        }

        [TestMethod]
        public void EliminarUnProductoRecienCreado()
        {
            var nuevoProducto = ConstruirUnNuevoProducto();

            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(nuevoProducto);
                session.Flush();

                var existeProductoRecienCreado = session.Query<Producto>()
                    .Any(x => x.Nombre == nuevoProducto.Nombre
                        && x.Categoria == nuevoProducto.Categoria
                        && x.Precio == nuevoProducto.Precio);

                Assert.IsTrue(existeProductoRecienCreado);

                session.Delete(nuevoProducto);
                session.Flush();

                existeProductoRecienCreado = session.Query<Producto>()
                    .Any(x => x.Nombre == nuevoProducto.Nombre
                        && x.Categoria == nuevoProducto.Categoria
                        && x.Precio == nuevoProducto.Precio);

                Assert.IsFalse(existeProductoRecienCreado);
            }
        }

        private Producto ConstruirUnNuevoProducto()
        {
            return new Producto()
            {
                Nombre = Name.First(),
                Categoria = Company.BS(),
                Precio = RandomNumber.Next(1000)
            };
        }
    }
}
