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

        private int? _idSelecionado = null;
        private void TelaAtualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = TelaAtualizar.Rows[e.RowIndex];

                string serie = comboBoxAtualizar.Text;

                switch (serie)
                {
                    case "Série A":
                        _idSelecionado = Convert.ToInt32(linha.Cells["idSerieA"].Value);
                        break;

                    case "Série B":
                        _idSelecionado = Convert.ToInt32(linha.Cells["idSerieB"].Value);
                        break;

                    case "Série C":
                        _idSelecionado = Convert.ToInt32(linha.Cells["idSerieC"].Value);
                        break;

                    case "Série D":
                        _idSelecionado = Convert.ToInt32(linha.Cells["idSerieD"].Value);
                        break;

                    default:
                        MessageBox.Show("Selecione alguma série para prosseguir!");
                        break;
                }

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

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            string serie = comboBoxAtualizar.Text;

            switch (serie)
            {
                case "Série A":
                    await atualizarSerieA();
                    break;

                case "Série B":
                    await atualizarSerieB();
                    break;

                case "Série C":
                    await atualizarSerieC();
                    break;

                case "Série D":
                    await atualizarSerieD();
                    break;

                default:
                    MessageBox.Show("Selecione alguma série para prosseguir!");
                    break;
            }
        }

        private async Task atualizarSerieA()
        {
            // 1) Garantir que temos um ID
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de editar.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Monta objeto com os campos (use os nomes esperados pela API)
            var clubeAtualizado = new
            {
                NomeClube = inpNome.Text.Trim(),
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            // 3) Validação mínima (exemplo)
            if (string.IsNullOrWhiteSpace(clubeAtualizado.NomeClube) ||
                !int.TryParse(inpPontos.Text, out _) ||
                !int.TryParse(inpJogos.Text, out _) ||
                !int.TryParse(inpSaldo.Text, out _) ||
                !int.TryParse(inpVitorias.Text, out _) ||
                !int.TryParse(inpDerrotas.Text, out _) ||
                !int.TryParse(inpEmpates.Text, out _) ||
                !int.TryParse(inpPosicao.Text, out _))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4) Confirmação opcional
            var respConf = MessageBox.Show("Confirma a alteração deste usuário?", "Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respConf != DialogResult.Yes) return;

            // 5) Envia PUT para /CadastroUsuario/<id>
            string apiPutUrl = $"{ApiRotasController.ConsultarSerieA}/{_idSelecionado}";
            string jsonBody = JsonConvert.SerializeObject(clubeAtualizado);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage resposta = await client.PutAsync(apiPutUrl, content);

            if (resposta.IsSuccessStatusCode)      // 200 ou 204
            {
                MessageBox.Show("Registro atualizado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6) Limpa seleção e recarrega grade
                _idSelecionado = null;

            }
            else
            {
                string detalhe = await resposta.Content.ReadAsStringAsync();
                MessageBox.Show($"Erro ao atualizar: {resposta.StatusCode}\n{detalhe}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task atualizarSerieB()
        {
            // 1) Garantir que temos um ID
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de editar.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Monta objeto com os campos (use os nomes esperados pela API)
            var clubeAtualizado = new
            {
                NomeClube = inpNome.Text.Trim(),
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            // 3) Validação mínima (exemplo)
            if (string.IsNullOrWhiteSpace(clubeAtualizado.NomeClube) ||
                !int.TryParse(inpPontos.Text, out _) ||
                !int.TryParse(inpJogos.Text, out _) ||
                !int.TryParse(inpSaldo.Text, out _) ||
                !int.TryParse(inpVitorias.Text, out _) ||
                !int.TryParse(inpDerrotas.Text, out _) ||
                !int.TryParse(inpEmpates.Text, out _) ||
                !int.TryParse(inpPosicao.Text, out _))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4) Confirmação opcional
            var respConf = MessageBox.Show("Confirma a alteração deste usuário?", "Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respConf != DialogResult.Yes) return;

            // 5) Envia PUT para /CadastroUsuario/<id>
            string apiPutUrl = $"{ApiRotasController.ConsultarSerieB}/{_idSelecionado}";
            string jsonBody = JsonConvert.SerializeObject(clubeAtualizado);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage resposta = await client.PutAsync(apiPutUrl, content);

            if (resposta.IsSuccessStatusCode)      // 200 ou 204
            {
                MessageBox.Show("Registro atualizado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6) Limpa seleção e recarrega grade
                _idSelecionado = null;

            }
            else
            {
                string detalhe = await resposta.Content.ReadAsStringAsync();
                MessageBox.Show($"Erro ao atualizar: {resposta.StatusCode}\n{detalhe}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task atualizarSerieC()
        {
            // 1) Garantir que temos um ID
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de editar.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Monta objeto com os campos (use os nomes esperados pela API)
            var clubeAtualizado = new
            {
                NomeClube = inpNome.Text.Trim(),
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            // 3) Validação mínima (exemplo)
            if (string.IsNullOrWhiteSpace(clubeAtualizado.NomeClube) ||
                !int.TryParse(inpPontos.Text, out _) ||
                !int.TryParse(inpJogos.Text, out _) ||
                !int.TryParse(inpSaldo.Text, out _) ||
                !int.TryParse(inpVitorias.Text, out _) ||
                !int.TryParse(inpDerrotas.Text, out _) ||
                !int.TryParse(inpEmpates.Text, out _) ||
                !int.TryParse(inpPosicao.Text, out _))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4) Confirmação opcional
            var respConf = MessageBox.Show("Confirma a alteração deste usuário?", "Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respConf != DialogResult.Yes) return;

            // 5) Envia PUT para /CadastroUsuario/<id>
            string apiPutUrl = $"{ApiRotasController.ConsultarSerieC}/{_idSelecionado}";
            string jsonBody = JsonConvert.SerializeObject(clubeAtualizado);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage resposta = await client.PutAsync(apiPutUrl, content);

            if (resposta.IsSuccessStatusCode)      // 200 ou 204
            {
                MessageBox.Show("Registro atualizado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6) Limpa seleção e recarrega grade
                _idSelecionado = null;

            }
            else
            {
                string detalhe = await resposta.Content.ReadAsStringAsync();
                MessageBox.Show($"Erro ao atualizar: {resposta.StatusCode}\n{detalhe}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task atualizarSerieD()
        {
            // 1) Garantir que temos um ID
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de editar.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Monta objeto com os campos (use os nomes esperados pela API)
            var clubeAtualizado = new
            {
                NomeClube = inpNome.Text.Trim(),
                PontosClube = int.Parse(inpPontos.Text),
                JogosClube = int.Parse(inpJogos.Text),
                SaldoGols = int.Parse(inpSaldo.Text),
                VitoriasClube = int.Parse(inpVitorias.Text),
                DerrotasClube = int.Parse(inpDerrotas.Text),
                EmpatesClube = int.Parse(inpEmpates.Text),
                PosicaoTabela = int.Parse(inpPosicao.Text)
            };

            // 3) Validação mínima (exemplo)
            if (string.IsNullOrWhiteSpace(clubeAtualizado.NomeClube) ||
                !int.TryParse(inpPontos.Text, out _) ||
                !int.TryParse(inpJogos.Text, out _) ||
                !int.TryParse(inpSaldo.Text, out _) ||
                !int.TryParse(inpVitorias.Text, out _) ||
                !int.TryParse(inpDerrotas.Text, out _) ||
                !int.TryParse(inpEmpates.Text, out _) ||
                !int.TryParse(inpPosicao.Text, out _))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4) Confirmação opcional
            var respConf = MessageBox.Show("Confirma a alteração deste usuário?", "Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respConf != DialogResult.Yes) return;

            // 5) Envia PUT para /CadastroUsuario/<id>
            string apiPutUrl = $"{ApiRotasController.ConsultarSerieD}/{_idSelecionado}";
            string jsonBody = JsonConvert.SerializeObject(clubeAtualizado);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage resposta = await client.PutAsync(apiPutUrl, content);

            if (resposta.IsSuccessStatusCode)      // 200 ou 204
            {
                MessageBox.Show("Registro atualizado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6) Limpa seleção e recarrega grade
                _idSelecionado = null;

            }
            else
            {
                string detalhe = await resposta.Content.ReadAsStringAsync();
                MessageBox.Show($"Erro ao atualizar: {resposta.StatusCode}\n{detalhe}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            string serie = comboBoxAtualizar.Text;

            switch (serie)
            {
                case "Série A":
                    await deletarSerieA();
                    break;

                case "Série B":
                    await deletarSerieB();
                    break;

                case "Série C":
                    await deletarSerieC();
                    break;

                case "Série D":
                    await deletarSerieD();
                    break;

                default:
                    MessageBox.Show("Selecione alguma série para prosseguir!");
                    break;
            }
        }

        private async Task deletarSerieA()
        {
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de excluir.",
                                "Nenhum item selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiDeleteUrl = $"{ApiRotasController.ConsultarSerieA}/{_idSelecionado}";

                    HttpResponseMessage resposta =
                        await client.DeleteAsync(apiDeleteUrl);

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro excluído com sucesso!");

                        _idSelecionado = null;
                    }
                    else
                    {
                        string detalhe = await resposta.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro ao excluir.\n{resposta.StatusCode}\n{detalhe}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task deletarSerieB()
        {
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de excluir.",
                                "Nenhum item selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiDeleteUrl = $"{ApiRotasController.ConsultarSerieB}/{_idSelecionado}";

                    HttpResponseMessage resposta =
                        await client.DeleteAsync(apiDeleteUrl);

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro excluído com sucesso!");

                        _idSelecionado = null;

                        await SerieB();
                    }
                    else
                    {
                        string detalhe = await resposta.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro ao excluir.\n{resposta.StatusCode}\n{detalhe}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task deletarSerieC()
        {
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de excluir.",
                                "Nenhum item selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiDeleteUrl = $"{ApiRotasController.ConsultarSerieC}/{_idSelecionado}";

                    HttpResponseMessage resposta =
                        await client.DeleteAsync(apiDeleteUrl);

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro excluído com sucesso!");

                        _idSelecionado = null;

                        await SerieC();
                    }
                    else
                    {
                        string detalhe = await resposta.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro ao excluir.\n{resposta.StatusCode}\n{detalhe}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async Task deletarSerieD()
        {
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de excluir.",
                                "Nenhum item selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            DialogResult resp = MessageBox.Show(
                "Deseja realmente excluir este registro?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp != DialogResult.Yes)
                return;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiDeleteUrl = $"{ApiRotasController.ConsultarSerieD}/{_idSelecionado}";

                    HttpResponseMessage resposta =
                        await client.DeleteAsync(apiDeleteUrl);

                    if (resposta.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Registro excluído com sucesso!");

                        _idSelecionado = null;

                        await SerieD();
                    }
                    else
                    {
                        string detalhe = await resposta.Content.ReadAsStringAsync();

                        MessageBox.Show($"Erro ao excluir.\n{resposta.StatusCode}\n{detalhe}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void inpRadioBtn_TextChanged(object sender, EventArgs e)
        {
            if (radioBtnNome.Checked)
            {
                await PesquisarPorNome(inpRadioBtn.Text);
            }
            else if (radioBtnPosicao.Checked)
            {
                await PesquisarPorPosicao(inpRadioBtn.Text);
            }
        }

        private async void radioBtnNome_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNome.Checked)
                await PesquisarPorNome(inpRadioBtn.Text);
        }

        private async void radioBtnPosicao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPosicao.Checked)
                await PesquisarPorPosicao(inpRadioBtn.Text);
        }
    }
}
