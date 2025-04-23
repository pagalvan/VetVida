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
    public partial class Form5 : Form
    {
        private IService<Especie> serviceEspecie;
        public Form5()
        {
            InitializeComponent();
            serviceEspecie = new EspecieService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar(new Especie(int.Parse(txtId.Text), txtNombre.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void Guardar(Especie especie)
        {
            // validar  nulos y demas
            var mensaje = serviceEspecie.Guardar(especie);
            MessageBox.Show(mensaje);
            CargarListaEspecies();
        }

        private void CargarListaEspecies()
        {
            lstEspecies.DataSource = serviceEspecie.Consultar();
            lstEspecies.DisplayMember = "Nombre";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CargarListaEspecies();
        }

        private void Buscar(int id)
        {
            var especieBuscada = serviceEspecie.BuscarId(id);
            VerEspecie(especieBuscada);
        }

        private void VerEspecie(Especie especie)
        {
            if (especie == null)
            {
                return;
            }
            txtId.Text = especie.Id.ToString();
            txtNombre.Text = especie.Nombre;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar(int.Parse(txtId.Text));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtId.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            AbrirConsulta();
        }

        private void AbrirConsulta()
        {
            Form f = new ConsultaEspecies();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.AliceBlue;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.Gray;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var especieBuscada = serviceEspecie.BuscarId(int.Parse(txtId.Text));
                if (especieBuscada != null)
                {
                    VerEspecie(especieBuscada);
                }
                else
                {
                    txtNombre.Text = "";
                }

            }
            catch (Exception)
            {
                Nuevo();
            }

        }

        private void btnconsultar_Click_1(object sender, EventArgs e)
        {
            Form f = new ConsultaEspecies();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }
    }
}
