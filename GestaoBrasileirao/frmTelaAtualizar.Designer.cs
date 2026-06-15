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
            btnInserir = new Button();
            inpSerie = new TextBox();
            txtSerie = new Label();
            txtTitulo = new Label();
            btnAtualizar = new Button();
            btnApagar = new Button();
            imgFundo = new PictureBox();
            panelAtualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFundo).BeginInit();
            SuspendLayout();
            // 
            // panelAtualizar
            // 
            panelAtualizar.BackColor = Color.DarkBlue;
            panelAtualizar.Controls.Add(btnApagar);
            panelAtualizar.Controls.Add(btnAtualizar);
            panelAtualizar.Controls.Add(btnInserir);
            panelAtualizar.Controls.Add(inpSerie);
            panelAtualizar.Controls.Add(txtSerie);
            panelAtualizar.Controls.Add(txtTitulo);
            panelAtualizar.Location = new Point(-2, 0);
            panelAtualizar.Name = "panelAtualizar";
            panelAtualizar.Size = new Size(206, 450);
            panelAtualizar.TabIndex = 2;
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
            // inpSerie
            // 
            inpSerie.BorderStyle = BorderStyle.FixedSingle;
            inpSerie.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inpSerie.Location = new Point(24, 146);
            inpSerie.Name = "inpSerie";
            inpSerie.Size = new Size(151, 33);
            inpSerie.TabIndex = 4;
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
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.LightSeaGreen;
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
            // frmTelaAtualizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(imgFundo);
            Controls.Add(panelAtualizar);
            Name = "frmTelaAtualizar";
            Text = "frmTelaAtualizar";
            panelAtualizar.ResumeLayout(false);
            panelAtualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFundo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAtualizar;
        private Button btnInserir;
        private TextBox inpSerie;
        private Label txtSerie;
        private Label txtTitulo;
        private Button btnApagar;
        private Button btnAtualizar;
        private PictureBox imgFundo;
    }
}