namespace GestaoBrasileirao
{
    partial class frmTelaAtualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelAtualizar = new Panel();
            comboBoxAtualizar = new ComboBox();
            btnApagar = new Button();
            btnAtualizar = new Button();
            btnInserir = new Button();
            txtSerie = new Label();
            txtTitulo = new Label();
            imgFundo = new PictureBox();
            inpNome = new TextBox();
            inpPontos = new TextBox();
            inpJogos = new TextBox();
            inpSaldo = new TextBox();
            inpVitorias = new TextBox();
            inpDerrotas = new TextBox();
            inpEmpates = new TextBox();
            inpPosicao = new TextBox();
            lblNome = new Label();
            lblPontos = new Label();
            lblJogos = new Label();
            lblSaldo = new Label();
            lblVitorias = new Label();
            lblEmpates = new Label();
            lblPosicao = new Label();
            lblDerrotas = new Label();
            radioBtnNome = new RadioButton();
            panelTelaAtualizar = new Panel();
            inpRadioBtn = new TextBox();
            radioBtnPosicao = new RadioButton();
            TelaAtualizar = new DataGridView();
            panelAtualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFundo).BeginInit();
            panelTelaAtualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TelaAtualizar).BeginInit();
            SuspendLayout();
            // 
            // panelAtualizar
            // 
            panelAtualizar.BackColor = Color.DarkBlue;
            panelAtualizar.Controls.Add(comboBoxAtualizar);
            panelAtualizar.Controls.Add(btnApagar);
            panelAtualizar.Controls.Add(btnAtualizar);
            panelAtualizar.Controls.Add(btnInserir);
            panelAtualizar.Controls.Add(txtSerie);
            panelAtualizar.Controls.Add(txtTitulo);
            panelAtualizar.Location = new Point(-2, 0);
            panelAtualizar.Name = "panelAtualizar";
            panelAtualizar.Size = new Size(206, 450);
            panelAtualizar.TabIndex = 2;
            // 
            // comboBoxAtualizar
            // 
            comboBoxAtualizar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAtualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAtualizar.FormattingEnabled = true;
            comboBoxAtualizar.Items.AddRange(new object[] { "", "Série A", "Série B", "Série C", "Série D" });
            comboBoxAtualizar.Location = new Point(24, 146);
            comboBoxAtualizar.Name = "comboBoxAtualizar";
            comboBoxAtualizar.Size = new Size(151, 33);
            comboBoxAtualizar.TabIndex = 7;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.Red;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagar.ForeColor = Color.DarkBlue;
            btnApagar.Location = new Point(24, 322);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(151, 52);
            btnApagar.TabIndex = 6;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Turquoise;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.DarkBlue;
            btnAtualizar.Location = new Point(24, 264);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(151, 52);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.SpringGreen;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInserir.ForeColor = Color.DarkBlue;
            btnInserir.Location = new Point(24, 206);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(151, 52);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // txtSerie
            // 
            txtSerie.AutoSize = true;
            txtSerie.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSerie.ForeColor = Color.White;
            txtSerie.Location = new Point(24, 125);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(50, 18);
            txtSerie.TabIndex = 3;
            txtSerie.Text = "Série:";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = Color.White;
            txtTitulo.Location = new Point(20, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(155, 74);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "Atualizar\r\n   times";
            // 
            // imgFundo
            // 
            imgFundo.Image = Properties.Resources.escudoCBF;
            imgFundo.Location = new Point(204, 0);
            imgFundo.Name = "imgFundo";
            imgFundo.Size = new Size(910, 512);
            imgFundo.SizeMode = PictureBoxSizeMode.AutoSize;
            imgFundo.TabIndex = 3;
            imgFundo.TabStop = false;
            // 
            // inpNome
            // 
            inpNome.Font = new Font("Segoe UI", 14F);
            inpNome.Location = new Point(237, 31);
            inpNome.Name = "inpNome";
            inpNome.Size = new Size(243, 32);
            inpNome.TabIndex = 4;
            // 
            // inpPontos
            // 
            inpPontos.Font = new Font("Segoe UI", 14F);
            inpPontos.Location = new Point(520, 31);
            inpPontos.Name = "inpPontos";
            inpPontos.Size = new Size(243, 32);
            inpPontos.TabIndex = 5;
            // 
            // inpJogos
            // 
            inpJogos.Font = new Font("Segoe UI", 14F);
            inpJogos.Location = new Point(237, 98);
            inpJogos.Name = "inpJogos";
            inpJogos.Size = new Size(243, 32);
            inpJogos.TabIndex = 6;
            // 
            // inpSaldo
            // 
            inpSaldo.Font = new Font("Segoe UI", 14F);
            inpSaldo.Location = new Point(520, 98);
            inpSaldo.Name = "inpSaldo";
            inpSaldo.Size = new Size(243, 32);
            inpSaldo.TabIndex = 7;
            // 
            // inpVitorias
            // 
            inpVitorias.Font = new Font("Segoe UI", 14F);
            inpVitorias.Location = new Point(237, 168);
            inpVitorias.Name = "inpVitorias";
            inpVitorias.Size = new Size(243, 32);
            inpVitorias.TabIndex = 8;
            // 
            // inpDerrotas
            // 
            inpDerrotas.Font = new Font("Segoe UI", 14F);
            inpDerrotas.Location = new Point(520, 168);
            inpDerrotas.Name = "inpDerrotas";
            inpDerrotas.Size = new Size(243, 32);
            inpDerrotas.TabIndex = 9;
            // 
            // inpEmpates
            // 
            inpEmpates.Font = new Font("Segoe UI", 14F);
            inpEmpates.Location = new Point(237, 232);
            inpEmpates.Name = "inpEmpates";
            inpEmpates.Size = new Size(243, 32);
            inpEmpates.TabIndex = 10;
            // 
            // inpPosicao
            // 
            inpPosicao.Font = new Font("Segoe UI", 14F);
            inpPosicao.Location = new Point(520, 232);
            inpPosicao.Name = "inpPosicao";
            inpPosicao.Size = new Size(243, 32);
            inpPosicao.TabIndex = 11;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.SteelBlue;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(237, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(114, 19);
            lblNome.TabIndex = 12;
            lblNome.Text = "Nome do time";
            // 
            // lblPontos
            // 
            lblPontos.AutoSize = true;
            lblPontos.BackColor = Color.SteelBlue;
            lblPontos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPontos.ForeColor = Color.White;
            lblPontos.Location = new Point(520, 9);
            lblPontos.Name = "lblPontos";
            lblPontos.Size = new Size(124, 19);
            lblPontos.TabIndex = 13;
            lblPontos.Text = "Pontos do time";
            // 
            // lblJogos
            // 
            lblJogos.AutoSize = true;
            lblJogos.BackColor = Color.SteelBlue;
            lblJogos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJogos.ForeColor = Color.White;
            lblJogos.Location = new Point(237, 76);
            lblJogos.Name = "lblJogos";
            lblJogos.Size = new Size(117, 19);
            lblJogos.TabIndex = 14;
            lblJogos.Text = "Jogos do time";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.SteelBlue;
            lblSaldo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.ForeColor = Color.White;
            lblSaldo.Location = new Point(520, 76);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(173, 19);
            lblSaldo.TabIndex = 15;
            lblSaldo.Text = "Saldo de gols do time";
            // 
            // lblVitorias
            // 
            lblVitorias.AutoSize = true;
            lblVitorias.BackColor = Color.SteelBlue;
            lblVitorias.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitorias.ForeColor = Color.White;
            lblVitorias.Location = new Point(237, 146);
            lblVitorias.Name = "lblVitorias";
            lblVitorias.Size = new Size(127, 19);
            lblVitorias.TabIndex = 16;
            lblVitorias.Text = "Vitórias do time";
            // 
            // lblEmpates
            // 
            lblEmpates.AutoSize = true;
            lblEmpates.BackColor = Color.SteelBlue;
            lblEmpates.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpates.ForeColor = Color.White;
            lblEmpates.Location = new Point(237, 210);
            lblEmpates.Name = "lblEmpates";
            lblEmpates.Size = new Size(136, 19);
            lblEmpates.TabIndex = 17;
            lblEmpates.Text = "Empates do time";
            // 
            // lblPosicao
            // 
            lblPosicao.AutoSize = true;
            lblPosicao.BackColor = Color.SteelBlue;
            lblPosicao.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosicao.ForeColor = Color.White;
            lblPosicao.Location = new Point(520, 210);
            lblPosicao.Name = "lblPosicao";
            lblPosicao.Size = new Size(131, 19);
            lblPosicao.TabIndex = 18;
            lblPosicao.Text = "Posição do time";
            // 
            // lblDerrotas
            // 
            lblDerrotas.AutoSize = true;
            lblDerrotas.BackColor = Color.SteelBlue;
            lblDerrotas.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDerrotas.ForeColor = Color.White;
            lblDerrotas.Location = new Point(520, 146);
            lblDerrotas.Name = "lblDerrotas";
            lblDerrotas.Size = new Size(135, 19);
            lblDerrotas.TabIndex = 19;
            lblDerrotas.Text = "Derrotas do time";
            // 
            // radioBtnNome
            // 
            radioBtnNome.AutoSize = true;
            radioBtnNome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnNome.Location = new Point(18, 55);
            radioBtnNome.Name = "radioBtnNome";
            radioBtnNome.Size = new Size(132, 23);
            radioBtnNome.TabIndex = 21;
            radioBtnNome.TabStop = true;
            radioBtnNome.Text = "Nome do time";
            radioBtnNome.UseVisualStyleBackColor = true;
            // 
            // panelTelaAtualizar
            // 
            panelTelaAtualizar.BackColor = Color.White;
            panelTelaAtualizar.Controls.Add(inpRadioBtn);
            panelTelaAtualizar.Controls.Add(radioBtnPosicao);
            panelTelaAtualizar.Controls.Add(radioBtnNome);
            panelTelaAtualizar.Location = new Point(204, 360);
            panelTelaAtualizar.Name = "panelTelaAtualizar";
            panelTelaAtualizar.Size = new Size(599, 90);
            panelTelaAtualizar.TabIndex = 22;
            // 
            // inpRadioBtn
            // 
            inpRadioBtn.BackColor = Color.Silver;
            inpRadioBtn.Font = new Font("Segoe UI", 14F);
            inpRadioBtn.Location = new Point(331, 46);
            inpRadioBtn.Name = "inpRadioBtn";
            inpRadioBtn.Size = new Size(243, 32);
            inpRadioBtn.TabIndex = 23;
            // 
            // radioBtnPosicao
            // 
            radioBtnPosicao.AutoSize = true;
            radioBtnPosicao.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnPosicao.Location = new Point(176, 55);
            radioBtnPosicao.Name = "radioBtnPosicao";
            radioBtnPosicao.Size = new Size(89, 23);
            radioBtnPosicao.TabIndex = 22;
            radioBtnPosicao.TabStop = true;
            radioBtnPosicao.Text = "Posição";
            radioBtnPosicao.UseVisualStyleBackColor = true;
            // 
            // TelaAtualizar
            // 
            TelaAtualizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TelaAtualizar.Location = new Point(237, 270);
            TelaAtualizar.Name = "TelaAtualizar";
            TelaAtualizar.Size = new Size(526, 130);
            TelaAtualizar.TabIndex = 23;
            // 
            // frmTelaAtualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TelaAtualizar);
            Controls.Add(panelTelaAtualizar);
            Controls.Add(lblDerrotas);
            Controls.Add(lblPosicao);
            Controls.Add(lblEmpates);
            Controls.Add(lblVitorias);
            Controls.Add(lblSaldo);
            Controls.Add(lblJogos);
            Controls.Add(lblPontos);
            Controls.Add(lblNome);
            Controls.Add(inpPosicao);
            Controls.Add(inpEmpates);
            Controls.Add(inpDerrotas);
            Controls.Add(inpVitorias);
            Controls.Add(inpSaldo);
            Controls.Add(inpJogos);
            Controls.Add(inpPontos);
            Controls.Add(inpNome);
            Controls.Add(imgFundo);
            Controls.Add(panelAtualizar);
            Name = "frmTelaAtualizar";
            Text = "frmTelaAtualizar";
            panelAtualizar.ResumeLayout(false);
            panelAtualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFundo).EndInit();
            panelTelaAtualizar.ResumeLayout(false);
            panelTelaAtualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TelaAtualizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAtualizar;
        private Button btnInserir;
        private Label txtSerie;
        private Label txtTitulo;
        private Button btnApagar;
        private Button btnAtualizar;
        private PictureBox imgFundo;
        private ComboBox comboBoxAtualizar;
        private TextBox inpNome;
        private TextBox inpPontos;
        private TextBox inpJogos;
        private TextBox inpSaldo;
        private TextBox inpVitorias;
        private TextBox inpDerrotas;
        private TextBox inpEmpates;
        private TextBox inpPosicao;
        private Label lblNome;
        private Label lblPontos;
        private Label lblJogos;
        private Label lblSaldo;
        private Label lblVitorias;
        private Label lblEmpates;
        private Label lblPosicao;
        private Label lblDerrotas;
        private RadioButton radioBtnNome;
        private Panel panelTelaAtualizar;
        private RadioButton radioBtnPosicao;
        private TextBox inpRadioBtn;
        private DataGridView TelaAtualizar;
    }
}