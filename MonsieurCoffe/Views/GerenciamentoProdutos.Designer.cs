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
            this.cbCategoriaCadas = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbPreco = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.lblIdCategoriaCadas = new System.Windows.Forms.Label();
            this.lblPrecoCadas = new System.Windows.Forms.Label();
            this.lblNomeCadas = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.cbCategoriaEditar = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbPrecoEditar = new System.Windows.Forms.TextBox();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblIdCategoriaEditar = new System.Windows.Forms.Label();
            this.lblPrecoEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.gbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.gbCategotria = new System.Windows.Forms.GroupBox();
            this.btnCatCriar = new System.Windows.Forms.Button();
            this.txbCatCriar = new System.Windows.Forms.TextBox();
            this.lblCatNomeCriar = new System.Windows.Forms.Label();
            this.gbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.gbEditar.SuspendLayout();
            this.gbApagar.SuspendLayout();
            this.gbCategotria.SuspendLayout();
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
            this.gbCadastro.Controls.Add(this.cbCategoriaCadas);
            this.gbCadastro.Controls.Add(this.btnCadastrar);
            this.gbCadastro.Controls.Add(this.txbPreco);
            this.gbCadastro.Controls.Add(this.txbNomeProduto);
            this.gbCadastro.Controls.Add(this.lblIdCategoriaCadas);
            this.gbCadastro.Controls.Add(this.lblPrecoCadas);
            this.gbCadastro.Controls.Add(this.lblNomeCadas);
            this.gbCadastro.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCadastro.Location = new System.Drawing.Point(746, 102);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(351, 169);
            this.gbCadastro.TabIndex = 12;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "CADASTRAR PRODUTO";
            // 
            // cbCategoriaCadas
            // 
            this.cbCategoriaCadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoriaCadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaCadas.FormattingEnabled = true;
            this.cbCategoriaCadas.Location = new System.Drawing.Point(114, 91);
            this.cbCategoriaCadas.Name = "cbCategoriaCadas";
            this.cbCategoriaCadas.Size = new System.Drawing.Size(230, 23);
            this.cbCategoriaCadas.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(9, 124);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(335, 33);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbPreco
            // 
            this.txbPreco.Location = new System.Drawing.Point(114, 62);
            this.txbPreco.Name = "txbPreco";
            this.txbPreco.Size = new System.Drawing.Size(230, 22);
            this.txbPreco.TabIndex = 4;
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Location = new System.Drawing.Point(114, 28);
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(230, 22);
            this.txbNomeProduto.TabIndex = 3;
            // 
            // lblIdCategoriaCadas
            // 
            this.lblIdCategoriaCadas.AutoSize = true;
            this.lblIdCategoriaCadas.Location = new System.Drawing.Point(25, 94);
            this.lblIdCategoriaCadas.Name = "lblIdCategoriaCadas";
            this.lblIdCategoriaCadas.Size = new System.Drawing.Size(83, 15);
            this.lblIdCategoriaCadas.TabIndex = 2;
            this.lblIdCategoriaCadas.Text = "Id Categoria:";
            // 
            // lblPrecoCadas
            // 
            this.lblPrecoCadas.AutoSize = true;
            this.lblPrecoCadas.Location = new System.Drawing.Point(67, 62);
            this.lblPrecoCadas.Name = "lblPrecoCadas";
            this.lblPrecoCadas.Size = new System.Drawing.Size(47, 15);
            this.lblPrecoCadas.TabIndex = 1;
            this.lblPrecoCadas.Text = "Preço: ";
            // 
            // lblNomeCadas
            // 
            this.lblNomeCadas.AutoSize = true;
            this.lblNomeCadas.Location = new System.Drawing.Point(63, 31);
            this.lblNomeCadas.Name = "lblNomeCadas";
            this.lblNomeCadas.Size = new System.Drawing.Size(44, 15);
            this.lblNomeCadas.TabIndex = 0;
            this.lblNomeCadas.Text = "Nome:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(30, 102);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(688, 419);
            this.dgvProdutos.TabIndex = 13;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.cbCategoriaEditar);
            this.gbEditar.Controls.Add(this.btnEditar);
            this.gbEditar.Controls.Add(this.txbPrecoEditar);
            this.gbEditar.Controls.Add(this.txbNomeEditar);
            this.gbEditar.Controls.Add(this.lblIdCategoriaEditar);
            this.gbEditar.Controls.Add(this.lblPrecoEditar);
            this.gbEditar.Controls.Add(this.lblNomeEditar);
            this.gbEditar.Enabled = false;
            this.gbEditar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEditar.Location = new System.Drawing.Point(746, 277);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(351, 169);
            this.gbEditar.TabIndex = 13;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "EDITAR PRODUTO";
            // 
            // cbCategoriaEditar
            // 
            this.cbCategoriaEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCategoriaEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaEditar.FormattingEnabled = true;
            this.cbCategoriaEditar.Location = new System.Drawing.Point(114, 95);
            this.cbCategoriaEditar.Name = "cbCategoriaEditar";
            this.cbCategoriaEditar.Size = new System.Drawing.Size(230, 23);
            this.cbCategoriaEditar.TabIndex = 16;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(9, 124);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(335, 33);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbPrecoEditar
            // 
            this.txbPrecoEditar.Location = new System.Drawing.Point(114, 62);
            this.txbPrecoEditar.Name = "txbPrecoEditar";
            this.txbPrecoEditar.Size = new System.Drawing.Size(230, 22);
            this.txbPrecoEditar.TabIndex = 4;
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(114, 28);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(230, 22);
            this.txbNomeEditar.TabIndex = 3;
            // 
            // lblIdCategoriaEditar
            // 
            this.lblIdCategoriaEditar.AutoSize = true;
            this.lblIdCategoriaEditar.Location = new System.Drawing.Point(25, 94);
            this.lblIdCategoriaEditar.Name = "lblIdCategoriaEditar";
            this.lblIdCategoriaEditar.Size = new System.Drawing.Size(83, 15);
            this.lblIdCategoriaEditar.TabIndex = 2;
            this.lblIdCategoriaEditar.Text = "Id Categoria:";
            // 
            // lblPrecoEditar
            // 
            this.lblPrecoEditar.AutoSize = true;
            this.lblPrecoEditar.Location = new System.Drawing.Point(67, 62);
            this.lblPrecoEditar.Name = "lblPrecoEditar";
            this.lblPrecoEditar.Size = new System.Drawing.Size(47, 15);
            this.lblPrecoEditar.TabIndex = 1;
            this.lblPrecoEditar.Text = "Preço: ";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(63, 31);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(44, 15);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome:";
            // 
            // gbApagar
            // 
            this.gbApagar.Controls.Add(this.btnApagar);
            this.gbApagar.Controls.Add(this.lblApagar);
            this.gbApagar.Enabled = false;
            this.gbApagar.ForeColor = System.Drawing.Color.Black;
            this.gbApagar.Location = new System.Drawing.Point(746, 454);
            this.gbApagar.Name = "gbApagar";
            this.gbApagar.Size = new System.Drawing.Size(351, 48);
            this.gbApagar.TabIndex = 14;
            this.gbApagar.TabStop = false;
            this.gbApagar.Text = "APAGAR";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.IndianRed;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApagar.Location = new System.Drawing.Point(240, 11);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(104, 31);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApagar.Location = new System.Drawing.Point(9, 21);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(207, 15);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o produto para apagar.";
            // 
            // gbCategotria
            // 
            this.gbCategotria.Controls.Add(this.lblCatNomeCriar);
            this.gbCategotria.Controls.Add(this.btnCatCriar);
            this.gbCategotria.Controls.Add(this.txbCatCriar);
            this.gbCategotria.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategotria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCategotria.Location = new System.Drawing.Point(414, 18);
            this.gbCategotria.Name = "gbCategotria";
            this.gbCategotria.Size = new System.Drawing.Size(330, 52);
            this.gbCategotria.TabIndex = 15;
            this.gbCategotria.TabStop = false;
            this.gbCategotria.Text = "CRIAR CATEGORIA";
            // 
            // btnCatCriar
            // 
            this.btnCatCriar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCatCriar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatCriar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatCriar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCatCriar.Location = new System.Drawing.Point(242, 19);
            this.btnCatCriar.Name = "btnCatCriar";
            this.btnCatCriar.Size = new System.Drawing.Size(79, 25);
            this.btnCatCriar.TabIndex = 16;
            this.btnCatCriar.Text = "CRIAR";
            this.btnCatCriar.UseVisualStyleBackColor = false;
            this.btnCatCriar.Click += new System.EventHandler(this.btnCatCriar_Click);
            // 
            // txbCatCriar
            // 
            this.txbCatCriar.Location = new System.Drawing.Point(56, 21);
            this.txbCatCriar.Name = "txbCatCriar";
            this.txbCatCriar.Size = new System.Drawing.Size(180, 22);
            this.txbCatCriar.TabIndex = 16;
            // 
            // lblCatNomeCriar
            // 
            this.lblCatNomeCriar.AutoSize = true;
            this.lblCatNomeCriar.Location = new System.Drawing.Point(6, 24);
            this.lblCatNomeCriar.Name = "lblCatNomeCriar";
            this.lblCatNomeCriar.Size = new System.Drawing.Size(44, 15);
            this.lblCatNomeCriar.TabIndex = 17;
            this.lblCatNomeCriar.Text = "Nome:";
            // 
            // GerenciamentoProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 533);
            this.Controls.Add(this.gbCategotria);
            this.Controls.Add(this.gbApagar);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "GerenciamentoProdutos";
            this.Text = "GerenciamentoProdutos";
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.gbApagar.ResumeLayout(false);
            this.gbApagar.PerformLayout();
            this.gbCategotria.ResumeLayout(false);
            this.gbCategotria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbPreco;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.Label lblIdCategoriaCadas;
        private System.Windows.Forms.Label lblPrecoCadas;
        private System.Windows.Forms.Label lblNomeCadas;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbPrecoEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblIdCategoriaEditar;
        private System.Windows.Forms.Label lblPrecoEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.GroupBox gbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.ComboBox cbCategoriaCadas;
        private System.Windows.Forms.ComboBox cbCategoriaEditar;
        private System.Windows.Forms.GroupBox gbCategotria;
        private System.Windows.Forms.Button btnCatCriar;
        private System.Windows.Forms.TextBox txbCatCriar;
        private System.Windows.Forms.Label lblCatNomeCriar;
    }
}