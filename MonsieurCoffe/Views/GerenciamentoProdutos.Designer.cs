namespace MonsieurCoffe.Views
{
    partial class GerenciamentoProdutos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbSenhasCadas = new System.Windows.Forms.TextBox();
            this.txbmailCadas = new System.Windows.Forms.TextBox();
            this.txbNomeCadas = new System.Windows.Forms.TextBox();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(22, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(386, 44);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "Monsieur Coffe :: Produtos";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.btnCadastrar);
            this.gbCadastro.Controls.Add(this.txbSenhasCadas);
            this.gbCadastro.Controls.Add(this.txbmailCadas);
            this.gbCadastro.Controls.Add(this.txbNomeCadas);
            this.gbCadastro.Controls.Add(this.lblIdCategoria);
            this.gbCadastro.Controls.Add(this.lblPreco);
            this.gbCadastro.Controls.Add(this.lblNome);
            this.gbCadastro.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(243, 186);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(355, 160);
            this.gbCadastro.TabIndex = 12;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "CADASTRO";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 117);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(335, 33);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txbSenhasCadas
            // 
            this.txbSenhasCadas.Location = new System.Drawing.Point(114, 91);
            this.txbSenhasCadas.Name = "txbSenhasCadas";
            this.txbSenhasCadas.Size = new System.Drawing.Size(230, 22);
            this.txbSenhasCadas.TabIndex = 5;
            // 
            // txbmailCadas
            // 
            this.txbmailCadas.Location = new System.Drawing.Point(114, 62);
            this.txbmailCadas.Name = "txbmailCadas";
            this.txbmailCadas.Size = new System.Drawing.Size(230, 22);
            this.txbmailCadas.TabIndex = 4;
            // 
            // txbNomeCadas
            // 
            this.txbNomeCadas.Location = new System.Drawing.Point(114, 28);
            this.txbNomeCadas.Name = "txbNomeCadas";
            this.txbNomeCadas.Size = new System.Drawing.Size(230, 22);
            this.txbNomeCadas.TabIndex = 3;
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(25, 94);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(83, 15);
            this.lblIdCategoria.TabIndex = 2;
            this.lblIdCategoria.Text = "Id Categoria:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(67, 62);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(47, 15);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço: ";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(63, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 533);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "GerenciamentoProdutos";
            this.Text = "GerenciamentoProdutos";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbSenhasCadas;
        private System.Windows.Forms.TextBox txbmailCadas;
        private System.Windows.Forms.TextBox txbNomeCadas;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
    }
}