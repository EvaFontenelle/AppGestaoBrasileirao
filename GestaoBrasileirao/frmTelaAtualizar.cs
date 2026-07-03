using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestaoBrasileirao
{
    public partial class frmTelaAtualizar : Form
    {
        public frmTelaAtualizar()
        {
            InitializeComponent();
        }

        private async void comboBoxAtualizar_SelectedValueChanged(object sender, EventArgs e)
        {
            string serie = comboBoxAtualizar.Text;

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

        private async Task SerieA()
        {
            string apiUrl = ApiRotasController.ConsultarSerieA;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieAModel>>(jsonString);

                        TelaAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieB()
        {
            string apiUrl = ApiRotasController.ConsultarSerieB;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieBModel>>(jsonString);

                        TelaAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieC()
        {
            string apiUrl = ApiRotasController.ConsultarSerieC;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieCModel>>(jsonString);

                        TelaAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private async Task SerieD()
        {
            string apiUrl = ApiRotasController.ConsultarSerieD;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var dados = JsonConvert.DeserializeObject<List<ConsultarSerieDModel>>(jsonString);

                        TelaAtualizar.DataSource = dados;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao buscar dados da API: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar à API: " + ex.Message);
                }
            }
        }

        private void TelaAtualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = TelaAtualizar.Rows[e.RowIndex];

                inpNome.Text = linha.Cells["NomeClube"].Value?.ToString();
                inpPontos.Text = linha.Cells["PontosClube"].Value?.ToString();
                inpJogos.Text = linha.Cells["JogosClube"].Value?.ToString();
                inpSaldo.Text = linha.Cells["SaldoGols"].Value?.ToString();
                inpVitorias.Text = linha.Cells["VitoriasClube"].Value?.ToString();
                inpDerrotas.Text = linha.Cells["DerrotasClube"].Value?.ToString();
                inpEmpates.Text = linha.Cells["EmpatesClube"].Value?.ToString();
                inpPosicao.Text = linha.Cells["PosicaoTabela"].Value?.ToString();
            }
        }

        private async void btnInserir_Click(object sender, EventArgs e)
        {
            string serie = comboBoxAtualizar.Text;

            switch (serie)
            {
                case "Série A":
                    await inserirSerieA();
                    break;

                case "Série B":
                    await inserirSerieB();
                    break;

                case "Série C":
                    await inserirSerieC();
                    break;

                case "Série D":
                    await inserirSerieD();
                    break;

                default:
                    MessageBox.Show("Selecione alguma série para prosseguir!");
                    break;
            }
        }

        private async Task inserirSerieD()
        {
            ConsultarSerieDModel clube = new ConsultarSerieDModel
            {
                NomeClube = inpNome.Text,
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(clube);

                    var conteudo = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response =
                        await client.PostAsync(ApiRotasController.ConsultarSerieD, conteudo);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        await SerieD();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task inserirSerieC()
        {
            ConsultarSerieCModel clube = new ConsultarSerieCModel
            {
                NomeClube = inpNome.Text,
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(clube);

                    var conteudo = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response =
                        await client.PostAsync(ApiRotasController.ConsultarSerieC, conteudo);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        await SerieC();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task inserirSerieB()
        {
            ConsultarSerieBModel clube = new ConsultarSerieBModel
            {
                NomeClube = inpNome.Text,
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(clube);

                    var conteudo = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response =
                        await client.PostAsync(ApiRotasController.ConsultarSerieB, conteudo);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        await SerieB();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task inserirSerieA()
        {
            ConsultarSerieAModel clube = new ConsultarSerieAModel
            {
                NomeClube = inpNome.Text,
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var json = JsonConvert.SerializeObject(clube);

                    var conteudo = new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                    HttpResponseMessage response =
                        await client.PostAsync(ApiRotasController.ConsultarSerieA, conteudo);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro inserido com sucesso!");

                        await SerieA();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
