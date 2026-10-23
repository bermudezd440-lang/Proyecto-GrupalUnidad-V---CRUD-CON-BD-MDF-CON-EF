using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Proyecto_Grupal.Models;

//integrantes del grupo: //- Jonathan Mauricio Hernández Navidad
//CARNET: 260430 
// Rol de proyecto: Desarrollador de todo el proyecto

namespace Proyecto_Grupal
{
    public partial class Form1 : Form
    {
        private TiendaContext _context = new TiendaContext();
        private int _productoIdSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // CARGAR FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProductos();
        }

        // CARGAR CATEGORIAS
        private void CargarCategorias()
        {
            if (!_context.Categorias.Any())
            {
                _context.Categorias.AddRange(
                    new Categoria { Nombre = "Electronica" },
                    new Categoria { Nombre = "Ropa" }
                );

                _context.SaveChanges();
            }

            cmbCategorias.DataSource =
                _context.Categorias.ToList();

            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";
        }

        // CARGAR PRODUCTOS
        private void CargarProductos()
        {
            var productos = _context.Productos
                .Include(p => p.Categoria)
                .Select(p => new
                {
                    p.Id,
                    Producto = p.Nombre,
                    p.Precio,
                    Categoria = p.Categoria != null
                    ? p.Categoria.Nombre
    :               "Sin categoría",
                    p.CategoriaId
                })
                .ToList();

            dgvProductos.DataSource = productos;

            if (dgvProductos.Columns["CategoriaId"] != null)
            {
                dgvProductos.Columns["CategoriaId"].Visible = false;
            }
        }

        // LIMPIAR FORMULARIO
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPrecio.Clear();

            if (cmbCategorias.Items.Count > 0)
            {
                cmbCategorias.SelectedIndex = 0;
            }

            _productoIdSeleccionado = 0;
            btnGuardar.Text = "Guardar";
            dgvProductos.ClearSelection();
        }

        // GUARDAR Y ACTUALIZAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show(
                    "Ingrese un nombre y un precio valido."
                );
                return;
            }

            if (cmbCategorias.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoria.");
                return;
            }

            int categoriaId =
                Convert.ToInt32(cmbCategorias.SelectedValue);

            if (_productoIdSeleccionado == 0)
            {
                dgvProductos nuevoProducto = new dgvProductos
                {
                    Nombre = txtNombre.Text,
                    Precio = precio,
                    CategoriaId = categoriaId
                };

                _context.Productos.Add(nuevoProducto);
            }
            else
            {
                var productoExistente =
                    _context.Productos.Find(
                        _productoIdSeleccionado
                    );

                if (productoExistente != null)
                {
                    productoExistente.Nombre = txtNombre.Text;
                    productoExistente.Precio = precio;
                    productoExistente.CategoriaId = categoriaId;
                }
                else
                {
                    MessageBox.Show("No se encontro el producto.");
                    return;
                }
            }

            _context.SaveChanges();
            CargarProductos();
            LimpiarFormulario();

            MessageBox.Show("Operacion realizada con exito.");
        }

        // SELECCIONAR PRODUCTO PARA EDITAR
        private void dgvProductos_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            _productoIdSeleccionado =
                Convert.ToInt32(fila.Cells["Id"].Value);

            txtNombre.Text =
                fila.Cells["Producto"].Value.ToString();

            txtPrecio.Text =
                Convert.ToString(fila.Cells["Precio"].Value);

            cmbCategorias.SelectedValue =
                Convert.ToInt32(
                    fila.Cells["CategoriaId"].Value
                );

            btnGuardar.Text = "Actualizar";
        }

        // ELIMINAR PRODUCTO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_productoIdSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un producto para eliminar."
                );
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Esta seguro de eliminar este producto?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                var producto = _context.Productos.Find(
                    _productoIdSeleccionado
                );

                if (producto != null)
                {
                    _context.Productos.Remove(producto);
                    _context.SaveChanges();

                    CargarProductos();
                    LimpiarFormulario();

                    MessageBox.Show("Producto eliminado.");
                }
            }
        }

        // BOTON LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        
    }
}
