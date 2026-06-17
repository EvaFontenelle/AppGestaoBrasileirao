namespace GestaoBrasileirao
{
    partial class frmTelaConsultar
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
            panelConsultar = new Panel();
            btnConsultar = new Button();
            txtSerie = new Label();
            txtTitulo = new Label();
            imgTelaConsultar = new PictureBox();
            TelaConsulta = new DataGridView();
            comboBoxConsultar = new ComboBox();
            panelConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTelaConsultar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TelaConsulta).BeginInit();
            SuspendLayout();
            // 
            // panelConsultar
            // 
            panelConsultar.BackColor = Color.DarkBlue;
            panelConsultar.Controls.Add(comboBoxConsultar);
            panelConsultar.Controls.Add(btnConsultar);
            panelConsultar.Controls.Add(txtSerie);
            panelConsultar.Controls.Add(txtTitulo);
            panelConsultar.Location = new Point(-2, 1);
            panelConsultar.Name = "panelConsultar";
            panelConsultar.Size = new Size(197, 450);
            panelConsultar.TabIndex = 1;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.SpringGreen;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.DarkBlue;
            btnConsultar.Location = new Point(24, 222);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(151, 61);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // txtSerie
            // 
            txtSerie.AutoSize = true;
            txtSerie.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSerie.ForeColor = Color.White;
            txtSerie.Location = new Point(24, 146);
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
            txtTitulo.Location = new Point(12, 8);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(176, 74);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "Consultar \r\n    times";
            // 
            // imgTelaConsultar
            // 
            imgTelaConsultar.Image = Properties.Resources.jogador;
            imgTelaConsultar.Location = new Point(493, 1);
            imgTelaConsultar.Name = "imgTelaConsultar";
            imgTelaConsultar.Size = new Size(308, 450);
            imgTelaConsultar.SizeMode = PictureBoxSizeMode.StretchImage;
            imgTelaConsultar.TabIndex = 2;
            imgTelaConsultar.TabStop = false;
            // 
            // TelaConsulta
            // 
            TelaConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TelaConsulta.Location = new Point(218, 117);
            TelaConsulta.Name = "TelaConsulta";
            TelaConsulta.Size = new Size(477, 243);
            TelaConsulta.TabIndex = 3;
            // 
            // comboBoxConsultar
            // 
            comboBoxConsultar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxConsultar.FormattingEnabled = true;
            comboBoxConsultar.Location = new Point(24, 167);
            comboBoxConsultar.Name = "comboBoxConsultar";
            comboBoxConsultar.Size = new Size(151, 33);
            comboBoxConsultar.TabIndex = 6;
            // 
            // frmTelaConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(TelaConsulta);
            Controls.Add(imgTelaConsultar);
            Controls.Add(panelConsultar);
            Name = "frmTelaConsultar";
            Text = "frmTelaConsultar";
            Load += frmTelaConsultar_Load;
            panelConsultar.ResumeLayout(false);
            panelConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgTelaConsultar).EndInit();
            ((System.ComponentModel.ISupportInitialize)TelaConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsultar;
        private Label txtTitulo;
        private Label txtSerie;
        private Button btnConsultar;
        private PictureBox imgTelaConsultar;
        private DataGridView TelaConsulta;
        private ComboBox comboBoxConsultar;
    }
}