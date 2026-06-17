namespace GestaoBrasileirao
{
    partial class frmPrincipal
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
            panelPrincipal = new Panel();
            btnAtualizar = new Button();
            btnConsultar = new Button();
            imgTelaPrincipal = new PictureBox();
            txtTitulo = new Label();
            ltxtSubTitulo = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTelaPrincipal).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.DarkBlue;
            panelPrincipal.Controls.Add(btnAtualizar);
            panelPrincipal.Controls.Add(btnConsultar);
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(195, 450);
            panelPrincipal.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Gold;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtualizar.ForeColor = Color.DarkBlue;
            btnAtualizar.Location = new Point(34, 205);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(115, 48);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Gold;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = Color.DarkBlue;
            btnConsultar.Location = new Point(34, 138);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 48);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // imgTelaPrincipal
            // 
            imgTelaPrincipal.Image = Properties.Resources.bandeiraBrasil;
            imgTelaPrincipal.Location = new Point(254, 94);
            imgTelaPrincipal.Name = "imgTelaPrincipal";
            imgTelaPrincipal.Size = new Size(494, 282);
            imgTelaPrincipal.SizeMode = PictureBoxSizeMode.StretchImage;
            imgTelaPrincipal.TabIndex = 1;
            imgTelaPrincipal.TabStop = false;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = Color.DarkBlue;
            txtTitulo.Location = new Point(298, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(405, 82);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "Sistema de controle de \r\n               times";
            // 
            // ltxtSubTitulo
            // 
            ltxtSubTitulo.AutoSize = true;
            ltxtSubTitulo.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ltxtSubTitulo.ForeColor = Color.DarkBlue;
            ltxtSubTitulo.Location = new Point(408, 396);
            ltxtSubTitulo.Name = "ltxtSubTitulo";
            ltxtSubTitulo.Size = new Size(192, 32);
            ltxtSubTitulo.TabIndex = 3;
            ltxtSubTitulo.Text = "Tela principal";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ltxtSubTitulo);
            Controls.Add(txtTitulo);
            Controls.Add(imgTelaPrincipal);
            Controls.Add(panelPrincipal);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgTelaPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelPrincipal;
        private PictureBox imgTelaPrincipal;
        private Label txtTitulo;
        private Button btnAtualizar;
        private Button btnConsultar;
        private Label ltxtSubTitulo;
    }
}