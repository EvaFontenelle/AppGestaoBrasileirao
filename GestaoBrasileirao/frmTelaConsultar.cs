using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestaoBrasileirao
{
    public partial class frmTelaConsultar : Form
    {
        public frmTelaConsultar()
        {
            InitializeComponent();
        }

        private void frmTelaConsultar_Load(object sender, EventArgs e)
        {

        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            string serie = comboBoxConsultar.Text;

            switch (serie)
            {
                case "Série A":
                    await SerieA();
                    break;

                case "Série B":
                    await SerieB();
                    break;

                case "Série C":
                    await SerieC();
                    break;

                case "Série D":
                    await SerieD();
                    break;

                default:
                    MessageBox.Show("Selecione alguma série para prosseguir!");
                    break;
            }
        }

        private async Task SerieD()
        {
            throw new NotImplementedException();
        }

        private async Task SerieC()
        {
            throw new NotImplementedException();
        }

        private async Task SerieB()
        {
            throw new NotImplementedException();
        }

        private async Task SerieA()
        {
            throw new NotImplementedException();
        }
    }
}
