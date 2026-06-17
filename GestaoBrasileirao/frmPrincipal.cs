using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestaoBrasileirao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmTelaConsultar consultar = new frmTelaConsultar();
            this.Hide();
            consultar.ShowDialog();
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            frmTelaAtualizar atualizar = new frmTelaAtualizar();
            this.Hide();
            atualizar.ShowDialog();
            this.Close();
        }
    }
}
