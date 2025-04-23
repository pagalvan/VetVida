using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace GUI
{
    public partial class Form2: Form
    {
        private IService<Propietario> servicePropietario;
        public Form2()
        {
            InitializeComponent();
            servicePropietario = new PropietarioService();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar(new Propietario(txtcc.Text, txtnombre.Text, txtapellido.Text, txttelef.Text));
        }

        private void Guardar(Propietario propietario)
        {
            // validar  nulos y demas
            var mensaje = servicePropietario.Guardar(propietario);
            MessageBox.Show(mensaje);
            //CargarListaEspecies();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtcc.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txttelef.Text = string.Empty;
            txtcc.Focus();
        }
    }
}
