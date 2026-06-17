namespace GestaoBrasileirao
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnSair = new Button();
            btnEntrar = new Button();
            txtTitulo = new Label();
            Rodape = new Panel();
            imgBrasileirao2026 = new PictureBox();
            Rodape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBrasileirao2026).BeginInit();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatAppearance.BorderColor = Color.Black;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(509, 30);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(115, 48);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 192, 0);
            btnEntrar.FlatAppearance.BorderColor = Color.Black;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(650, 30);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(115, 48);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.MiddleRight;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitulo.ForeColor = Color.DarkBlue;
            txtTitulo.Location = new Point(493, 89);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(295, 168);
            txtTitulo.TabIndex = 2;
            txtTitulo.Text = "Sistema de\r\n controle de\r\n           times";
            // 
            // Rodape
            // 
            Rodape.BackColor = Color.DarkBlue;
            Rodape.Controls.Add(btnEntrar);
            Rodape.Controls.Add(btnSair);
            Rodape.Location = new Point(1, 343);
            Rodape.Name = "Rodape";
            Rodape.Size = new Size(799, 109);
            Rodape.TabIndex = 3;
            // 
            // imgBrasileirao2026
            // 
            imgBrasileirao2026.BackColor = Color.Transparent;
            imgBrasileirao2026.Image = (Image)resources.GetObject("imgBrasileirao2026.Image");
            imgBrasileirao2026.Location = new Point(47, 60);
            imgBrasileirao2026.Name = "imgBrasileirao2026";
            imgBrasileirao2026.Size = new Size(361, 351);
            imgBrasileirao2026.SizeMode = PictureBoxSizeMode.Zoom;
            imgBrasileirao2026.TabIndex = 0;
            imgBrasileirao2026.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(imgBrasileirao2026);
            Controls.Add(Rodape);
            Controls.Add(txtTitulo);
            Name = "frmLogin";
            Text = "frmLogin";
            Rodape.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgBrasileirao2026).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private Button btnEntrar;
        private Label txtTitulo;
        private Panel Rodape;
        private PictureBox imgBrasileirao2026;
    }
}
