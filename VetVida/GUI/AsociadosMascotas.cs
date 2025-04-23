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
    public partial class AsociadosMascotas: Form
    {
        private IService<Mascota> serviceMascota;
        private IService<Propietario> servicePropietario;
        public AsociadosMascotas()
        {
            InitializeComponent();
            serviceMascota = new MascotaService();
            servicePropietario = new PropietarioService();
        }

        private void Gridasociado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarGridAsociado()
        {
            var listaMascota = serviceMascota.Consultar();
            Gridasociado.DataSource = listaMascota;
        }

        private void AsociadosMascotas_Load(object sender, EventArgs e)
        {
            CargarGridAsociado();
        }
    }
}
