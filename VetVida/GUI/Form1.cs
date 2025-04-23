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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void asaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form2());
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form3());
        }

        private void AbrirFormulario(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form4());
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form5());
        }
    }
}
