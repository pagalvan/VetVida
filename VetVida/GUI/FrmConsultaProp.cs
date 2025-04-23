using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmConsultaProp : Form
    {
        private IService<Propietario> servicePropietario;
        public FrmConsultaProp()
        {
            InitializeComponent();
            servicePropietario = new PropietarioService();
        }

        private void FrmConsultaProp_Load(object sender, EventArgs e)
        {
            CargarListaprop();
        }

        private void CargarListaprop()
        {
            lsprop.DataSource = servicePropietario.Consultar();
            lsprop.DisplayMember = "Nombres";
        }

        private void lsprop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsprop.SelectedItem is Propietario seleccionado)
            {
                txtcc.Text = seleccionado.Cedula;
                txtnombre.Text = seleccionado.Nombres;
                txtapellido.Text = seleccionado.Apellidos;
                txttelef.Text = seleccionado.Telefono;
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (lsprop.SelectedItem is Propietario seleccionado)
            {
                // Imprime el ID para depuración
                Console.WriteLine($"ID del propietario seleccionado: {seleccionado.Id}");

                // Asegúrate de mantener el mismo ID
                Propietario propietarioModificado = new Propietario
                {
                    Id = seleccionado.Id,  // Esto es crucial
                    Cedula = txtcc.Text,
                    Nombres = txtnombre.Text,
                    Apellidos = txtapellido.Text,
                    Telefono = txttelef.Text
                };

                // Imprime el ID del propietario modificado para verificar
                Console.WriteLine($"ID del propietario modificado: {propietarioModificado.Id}");

                var mensaje = servicePropietario.Modificar(propietarioModificado);
                MessageBox.Show(mensaje);

                CargarListaprop();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un propietario para modificar.");
            }
        }

        private void limpiar()
        {
            txtcc.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txttelef.Text = string.Empty;
            txtcc.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lsprop.SelectedItem is Propietario seleccionado)
            {
                // Confirmar eliminación
                DialogResult resultado = MessageBox.Show(
                    $"¿Está seguro que desea eliminar al propietario {seleccionado.NombreCompleto()}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar al servicio para eliminar
                    var mensaje = servicePropietario.Eliminar(seleccionado.Id);
                    MessageBox.Show(mensaje);

                    // Limpiar los campos después de eliminar
                    limpiar();

                    // Actualizar la lista después de eliminar
                    CargarListaprop();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un propietario para eliminar.");
            }
        }
    }
}

