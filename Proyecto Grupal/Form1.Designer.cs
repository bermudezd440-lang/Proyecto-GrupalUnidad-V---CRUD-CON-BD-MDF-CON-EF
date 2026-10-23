namespace Proyecto_Grupal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            Nombre = new Label();
            Precio = new Label();
            Categoria = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            cmbCategorias = new ComboBox();
            textNombre = new TextBox();
            dgvProductos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(57, 468);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(234, 468);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(433, 468);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(613, 468);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(66, 290);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(78, 25);
            Nombre.TabIndex = 5;
            Nombre.Text = "Nombre";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(75, 342);
            Precio.Name = "Precio";
            Precio.Size = new Size(60, 25);
            Precio.TabIndex = 6;
            Precio.Text = "Precio";
            // 
            // Categoria
            // 
            Categoria.AutoSize = true;
            Categoria.Location = new Point(66, 399);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(88, 25);
            Categoria.TabIndex = 7;
            Categoria.Text = "Categoria";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 290);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(326, 31);
            txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(165, 342);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(326, 31);
            txtPrecio.TabIndex = 9;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(164, 396);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(326, 33);
            cmbCategorias.TabIndex = 11;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(164, 291);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(327, 31);
            textNombre.TabIndex = 13;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvProductos.Location = new Point(66, 26);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(668, 196);
            dgvProductos.TabIndex = 12;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 571);
            Controls.Add(textNombre);
            Controls.Add(dgvProductos);
            Controls.Add(cmbCategorias);
            Controls.Add(txtPrecio);
            Controls.Add(Categoria);
            Controls.Add(Precio);
            Controls.Add(Nombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label Nombre;
        private Label Precio;
        private Label Categoria;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private ComboBox cmbCategorias;
        private TextBox textNombre;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
