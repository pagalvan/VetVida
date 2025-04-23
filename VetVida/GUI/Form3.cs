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
    public partial class Form3 : Form
    {
        IService<Especie> serviceEspecie;
        IService<Raza> serviceRaza;
        IService<Propietario> servicePropietario;
        IService<Mascota> serviceMascota;
        public Form3()
        {
            InitializeComponent();
            serviceEspecie = new EspecieService();
            serviceRaza = new RazaService();
            servicePropietario = new PropietarioService();
            serviceMascota = new MascotaService();
            CargarComboEspecies();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnespecie_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.StartPosition = FormStartPosition.CenterParent;
            var result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                CargarComboEspecies(); // ¡Aquí se actualiza el combo cuando cierras!
            }
        }

        private void btnraza_Click(object sender, EventArgs e)
        {
            Form f = new Form4();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargarComboEspecies();
        }

        private void CargarComboEspecies()
        {
            var listaEspecies = serviceEspecie.Consultar();
            comboespecie.DataSource = listaEspecies;
            comboespecie.DisplayMember = "Nombre";
            comboespecie.ValueMember = "Id";
        }

        private void comboespecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboespecie.SelectedItem is Especie especieSeleccionada)
            {
                CargarRazasPorEspecie(especieSeleccionada.Id);
            }
        }

        private void CargarRazasPorEspecie(int id)
        {
            var razas = serviceRaza.Consultar()
                .Where(r => r.Especie != null && r.Especie.Id == id)
                .ToList();

            comboraza.DataSource = razas;
            comboraza.DisplayMember = "Nombre";
            comboraza.ValueMember = "Id";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string cedula = txtprop.Text;

            var propietarioService = new PropietarioService();
            var Propietario = propietarioService.ConsultarPorCedula(cedula);

            if (Propietario == null)
            {
                MessageBox.Show("Propietario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int edad;
            if (!int.TryParse(txtedad.Text, out edad))
            {
                MessageBox.Show("Edad inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear la mascota y asignarle el propietario
            var mascota = new Mascota
            {
                Nombre = txtnombre.Text,
                Edad = edad,
                Especie = (Especie)comboespecie.SelectedItem,
                Raza = (Raza)comboraza.SelectedItem,
                Propietario = Propietario
            };

            // Guardar la mascota
            var mensaje = serviceMascota.Guardar(mascota);
            MessageBox.Show(mensaje, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
