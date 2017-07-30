namespace Prueba_Nhibernate
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ListarProductos = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_CrearProducto = new System.Windows.Forms.Button();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Categoria = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_categoria = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.maskedTextBox_Precio = new System.Windows.Forms.MaskedTextBox();
            this.btn_BorrarTodosProductos = new System.Windows.Forms.Button();
            this.label_eliminarProdPorNombre = new System.Windows.Forms.Label();
            this.textBox_NombreProductoAEliminar = new System.Windows.Forms.TextBox();
            this.btn_EliminarProductoPorNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ListarProductos
            // 
            this.btn_ListarProductos.Location = new System.Drawing.Point(53, 230);
            this.btn_ListarProductos.Name = "btn_ListarProductos";
            this.btn_ListarProductos.Size = new System.Drawing.Size(157, 23);
            this.btn_ListarProductos.TabIndex = 0;
            this.btn_ListarProductos.Text = "Listar Productos";
            this.btn_ListarProductos.UseVisualStyleBackColor = true;
            this.btn_ListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 259);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(806, 172);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btn_CrearProducto
            // 
            this.btn_CrearProducto.Location = new System.Drawing.Point(245, 22);
            this.btn_CrearProducto.Name = "btn_CrearProducto";
            this.btn_CrearProducto.Size = new System.Drawing.Size(107, 22);
            this.btn_CrearProducto.TabIndex = 2;
            this.btn_CrearProducto.Text = "Crear Producto";
            this.btn_CrearProducto.UseVisualStyleBackColor = true;
            this.btn_CrearProducto.Click += new System.EventHandler(this.btn_CrearProducto_Click);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(110, 24);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 3;
            // 
            // textBox_Categoria
            // 
            this.textBox_Categoria.Location = new System.Drawing.Point(110, 60);
            this.textBox_Categoria.Name = "textBox_Categoria";
            this.textBox_Categoria.Size = new System.Drawing.Size(100, 20);
            this.textBox_Categoria.TabIndex = 4;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(50, 27);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(44, 13);
            this.label_nombre.TabIndex = 6;
            this.label_nombre.Text = "Nombre";
            // 
            // label_categoria
            // 
            this.label_categoria.AutoSize = true;
            this.label_categoria.Location = new System.Drawing.Point(50, 63);
            this.label_categoria.Name = "label_categoria";
            this.label_categoria.Size = new System.Drawing.Size(54, 13);
            this.label_categoria.TabIndex = 7;
            this.label_categoria.Text = "Categoría";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(50, 101);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(37, 13);
            this.label_precio.TabIndex = 8;
            this.label_precio.Text = "Precio";
            // 
            // maskedTextBox_Precio
            // 
            this.maskedTextBox_Precio.Location = new System.Drawing.Point(110, 98);
            this.maskedTextBox_Precio.Mask = "99999.99";
            this.maskedTextBox_Precio.Name = "maskedTextBox_Precio";
            this.maskedTextBox_Precio.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_Precio.TabIndex = 9;
            // 
            // btn_BorrarTodosProductos
            // 
            this.btn_BorrarTodosProductos.Location = new System.Drawing.Point(53, 450);
            this.btn_BorrarTodosProductos.Name = "btn_BorrarTodosProductos";
            this.btn_BorrarTodosProductos.Size = new System.Drawing.Size(157, 23);
            this.btn_BorrarTodosProductos.TabIndex = 10;
            this.btn_BorrarTodosProductos.Text = "Eliminar todos los productos";
            this.btn_BorrarTodosProductos.UseVisualStyleBackColor = true;
            this.btn_BorrarTodosProductos.Click += new System.EventHandler(this.btn_BorrarTodosProductos_Click);
            // 
            // label_eliminarProdPorNombre
            // 
            this.label_eliminarProdPorNombre.AutoSize = true;
            this.label_eliminarProdPorNombre.Location = new System.Drawing.Point(385, 101);
            this.label_eliminarProdPorNombre.Name = "label_eliminarProdPorNombre";
            this.label_eliminarProdPorNombre.Size = new System.Drawing.Size(139, 13);
            this.label_eliminarProdPorNombre.TabIndex = 11;
            this.label_eliminarProdPorNombre.Text = "Nombre producto a eliminar:";
            // 
            // textBox_NombreProductoAEliminar
            // 
            this.textBox_NombreProductoAEliminar.Location = new System.Drawing.Point(530, 98);
            this.textBox_NombreProductoAEliminar.Name = "textBox_NombreProductoAEliminar";
            this.textBox_NombreProductoAEliminar.Size = new System.Drawing.Size(100, 20);
            this.textBox_NombreProductoAEliminar.TabIndex = 12;
            // 
            // btn_EliminarProductoPorNombre
            // 
            this.btn_EliminarProductoPorNombre.Location = new System.Drawing.Point(659, 96);
            this.btn_EliminarProductoPorNombre.Name = "btn_EliminarProductoPorNombre";
            this.btn_EliminarProductoPorNombre.Size = new System.Drawing.Size(200, 23);
            this.btn_EliminarProductoPorNombre.TabIndex = 13;
            this.btn_EliminarProductoPorNombre.Text = "Eliminar Producto por nombre";
            this.btn_EliminarProductoPorNombre.UseVisualStyleBackColor = true;
            this.btn_EliminarProductoPorNombre.Click += new System.EventHandler(this.btn_EliminarProductoPorNombre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 514);
            this.Controls.Add(this.btn_EliminarProductoPorNombre);
            this.Controls.Add(this.textBox_NombreProductoAEliminar);
            this.Controls.Add(this.label_eliminarProdPorNombre);
            this.Controls.Add(this.btn_BorrarTodosProductos);
            this.Controls.Add(this.maskedTextBox_Precio);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_categoria);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.textBox_Categoria);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.btn_CrearProducto);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_ListarProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ListarProductos;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_CrearProducto;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Categoria;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_categoria;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Precio;
        private System.Windows.Forms.Button btn_BorrarTodosProductos;
        private System.Windows.Forms.Label label_eliminarProdPorNombre;
        private System.Windows.Forms.TextBox textBox_NombreProductoAEliminar;
        private System.Windows.Forms.Button btn_EliminarProductoPorNombre;
    }
}

