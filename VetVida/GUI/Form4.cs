﻿using BLL;
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
    public partial class Form4 : Form
    {
        IService<Especie> serviceEspecie;
        IService<Raza> serviceRaza;
        public Form4()
        {
            InitializeComponent();
            serviceEspecie = new EspecieService();
            serviceRaza = new RazaService();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new ConsultaRaza();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CargarComboEspecies();
            CargarListaRazas();
        }

        void CargarListaRazas()
        {
            var listaRazas = serviceRaza.Consultar();
            lstRazas.DataSource = listaRazas;
            lstRazas.DisplayMember = "Nombre";
            //cbEspecies.ValueMember = "Id";
        }
        void CargarComboEspecies()
        {
            var listaEspecies = serviceEspecie.Consultar();
            cbEspecies.DataSource = listaEspecies;
            cbEspecies.DisplayMember = "Nombre";
            cbEspecies.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Raza raza = new Raza()
            {
                Id = int.Parse(txtId.Text), 
                Nombre = txtNombre.Text,
            };
            raza.AsignarEspecie(serviceEspecie.BuscarId((int)cbEspecies.SelectedValue));

            Guardar(raza);
            CargarListaRazas();
        }

        private void Guardar(Raza raza)
        {
            var mensaje = serviceRaza.Guardar(raza);
            MessageBox.Show(mensaje);

        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            btnGuardar.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }                                                                                                                                   
    }
}
