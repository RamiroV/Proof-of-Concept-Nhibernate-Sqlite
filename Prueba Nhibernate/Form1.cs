using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Linq;
using Prueba_Nhibernate.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Nhibernate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //TODO: Se puede hacer un Repositorio Genérico para todas las clases persistibles
        //Listar, Eliminar, Crear, etc.
        //Es un patrón que se suele usar, pero no está tan bueno cuando las queries no son las básicas.


        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            var nuevoProducto = new Producto()
            {
                Nombre = textBox_Nombre.Text,
                Categoria = textBox_Categoria.Text,
                Precio = double.Parse(maskedTextBox_Precio.Text)
            };

            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(nuevoProducto);
                transaction.Commit();
            }

            ListarProductos();
        }

        private void btn_BorrarTodosProductos_Click(object sender, EventArgs e)
        {
            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                foreach (var prod in session.Query<Producto>())
                    session.Delete(prod);

                transaction.Commit();
            }

            ListarProductos();
        }

        private void btn_EliminarProductoPorNombre_Click(object sender, EventArgs e)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var productosAEliminar = session.Query<Producto>().Where(x => x.Nombre == textBox_NombreProductoAEliminar.Text);

                using (var transaction = session.BeginTransaction())
                {
                    foreach (var prod in productosAEliminar)
                        session.Delete(prod);

                    transaction.Commit();
                }
            }

            ListarProductos();
        }

        private void ListarProductos()
        {
            richTextBox1.Clear();

            using (var session = NHibernateHelper.OpenSession())
            {
                foreach (var prod in session.Query<Producto>())
                {
                    richTextBox1.Text = richTextBox1.Text + "Id: " + prod.Id + "\nNombre: " + prod.Nombre
                    + "\nCategoria: " + prod.Categoria + "\nPrecio: " + prod.Precio + "\n"
                    + "-------------------------------------------------------------------\n";
                }
            }
        }
    }
}
