namespace MonsieurCoffe.Views
{
    partial class GerenciamentoUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoUsuarios));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txbSenhasCadas = new System.Windows.Forms.TextBox();
            this.txbmailCadas = new System.Windows.Forms.TextBox();
            this.txbNomeCadas = new System.Windows.Forms.TextBox();
            this.lblSenhaCadas = new System.Windows.Forms.Label();
            this.lblEmailCadas = new System.Windows.Forms.Label();
            this.lblNomeCadas = new System.Windows.Forms.Label();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txbSenhaEditar = new System.Windows.Forms.TextBox();
            this.txbEmailEditar = new System.Windows.Forms.TextBox();
            this.txbNomeEditar = new System.Windows.Forms.TextBox();
            this.lblSenhasEditar = new System.Windows.Forms.Label();
            this.lblEmailEditar = new System.Windows.Forms.Label();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblApagar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbCadastro.SuspendLayout();
            this.gbEditar.SuspendLayout();
            this.gbApagar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 79);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(526, 391);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.btnCadastrar);
            this.gbCadastro.Controls.Add(this.txbSenhasCadas);
            this.gbCadastro.Controls.Add(this.txbmailCadas);
            this.gbCadastro.Controls.Add(this.txbNomeCadas);
            this.gbCadastro.Controls.Add(this.lblSenhaCadas);
            this.gbCadastro.Controls.Add(this.lblEmailCadas);
            this.gbCadastro.Controls.Add(this.lblNomeCadas);
            this.gbCadastro.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(544, 79);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(364, 160);
            this.gbCadastro.TabIndex = 1;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "CADASTRO";
            this.gbCadastro.Enter += new System.EventHandler(this.gbCadastro_Enter);
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
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            // lblSenhaCadas
            // 
            this.lblSenhaCadas.AutoSize = true;
            this.lblSenhaCadas.Location = new System.Drawing.Point(63, 91);
            this.lblSenhaCadas.Name = "lblSenhaCadas";
            this.lblSenhaCadas.Size = new System.Drawing.Size(45, 15);
            this.lblSenhaCadas.TabIndex = 2;
            this.lblSenhaCadas.Text = "Senha:";
            // 
            // lblEmailCadas
            // 
            this.lblEmailCadas.AutoSize = true;
            this.lblEmailCadas.Location = new System.Drawing.Point(67, 62);
            this.lblEmailCadas.Name = "lblEmailCadas";
            this.lblEmailCadas.Size = new System.Drawing.Size(41, 15);
            this.lblEmailCadas.TabIndex = 1;
            this.lblEmailCadas.Text = "Email:";
            // 
            // lblNomeCadas
            // 
            this.lblNomeCadas.AutoSize = true;
            this.lblNomeCadas.Location = new System.Drawing.Point(6, 35);
            this.lblNomeCadas.Name = "lblNomeCadas";
            this.lblNomeCadas.Size = new System.Drawing.Size(107, 15);
            this.lblNomeCadas.TabIndex = 0;
            this.lblNomeCadas.Text = "Nome Completo:";
            // 
            // gbEditar
            // 
            this.gbEditar.Controls.Add(this.btnEditar);
            this.gbEditar.Controls.Add(this.txbSenhaEditar);
            this.gbEditar.Controls.Add(this.txbEmailEditar);
            this.gbEditar.Controls.Add(this.txbNomeEditar);
            this.gbEditar.Controls.Add(this.lblSenhasEditar);
            this.gbEditar.Controls.Add(this.lblEmailEditar);
            this.gbEditar.Controls.Add(this.lblNomeEditar);
            this.gbEditar.Enabled = false;
            this.gbEditar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditar.Location = new System.Drawing.Point(544, 256);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Size = new System.Drawing.Size(364, 160);
            this.gbEditar.TabIndex = 7;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "EDITAR";
            this.gbEditar.Enter += new System.EventHandler(this.gbEditar_Enter);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Moccasin;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(9, 117);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(335, 33);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txbSenhaEditar
            // 
            this.txbSenhaEditar.Location = new System.Drawing.Point(114, 91);
            this.txbSenhaEditar.Name = "txbSenhaEditar";
            this.txbSenhaEditar.Size = new System.Drawing.Size(230, 22);
            this.txbSenhaEditar.TabIndex = 5;
            // 
            // txbEmailEditar
            // 
            this.txbEmailEditar.Location = new System.Drawing.Point(114, 62);
            this.txbEmailEditar.Name = "txbEmailEditar";
            this.txbEmailEditar.Size = new System.Drawing.Size(230, 22);
            this.txbEmailEditar.TabIndex = 4;
            // 
            // txbNomeEditar
            // 
            this.txbNomeEditar.Location = new System.Drawing.Point(114, 28);
            this.txbNomeEditar.Name = "txbNomeEditar";
            this.txbNomeEditar.Size = new System.Drawing.Size(230, 22);
            this.txbNomeEditar.TabIndex = 3;
            // 
            // lblSenhasEditar
            // 
            this.lblSenhasEditar.AutoSize = true;
            this.lblSenhasEditar.Location = new System.Drawing.Point(63, 94);
            this.lblSenhasEditar.Name = "lblSenhasEditar";
            this.lblSenhasEditar.Size = new System.Drawing.Size(45, 15);
            this.lblSenhasEditar.TabIndex = 2;
            this.lblSenhasEditar.Text = "Senha:";
            // 
            // lblEmailEditar
            // 
            this.lblEmailEditar.AutoSize = true;
            this.lblEmailEditar.Location = new System.Drawing.Point(67, 62);
            this.lblEmailEditar.Name = "lblEmailEditar";
            this.lblEmailEditar.Size = new System.Drawing.Size(41, 15);
            this.lblEmailEditar.TabIndex = 1;
            this.lblEmailEditar.Text = "Email:";
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Location = new System.Drawing.Point(6, 35);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(107, 15);
            this.lblNomeEditar.TabIndex = 0;
            this.lblNomeEditar.Text = "Nome Completo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(375, 44);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Monsieur Coffe :: Usuários";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // gbApagar
            // 
            this.gbApagar.Controls.Add(this.btnApagar);
            this.gbApagar.Controls.Add(this.lblApagar);
            this.gbApagar.Enabled = false;
            this.gbApagar.Location = new System.Drawing.Point(544, 422);
            this.gbApagar.Name = "gbApagar";
            this.gbApagar.Size = new System.Drawing.Size(364, 48);
            this.gbApagar.TabIndex = 9;
            this.gbApagar.TabStop = false;
            this.gbApagar.Text = "APAGAR";
            this.gbApagar.Enter += new System.EventHandler(this.gbApagar_Enter);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.IndianRed;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(254, 11);
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
            this.lblApagar.Size = new System.Drawing.Size(202, 15);
            this.lblApagar.TabIndex = 0;
            this.lblApagar.Text = "Selecione o usuário para apagar.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GerenciamentoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(916, 480);
            this.Controls.Add(this.gbApagar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbEditar);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciamentoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuarios";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.gbEditar.ResumeLayout(false);
            this.gbEditar.PerformLayout();
            this.gbApagar.ResumeLayout(false);
            this.gbApagar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txbSenhasCadas;
        private System.Windows.Forms.TextBox txbmailCadas;
        private System.Windows.Forms.TextBox txbNomeCadas;
        private System.Windows.Forms.Label lblSenhaCadas;
        private System.Windows.Forms.Label lblEmailCadas;
        private System.Windows.Forms.Label lblNomeCadas;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txbSenhaEditar;
        private System.Windows.Forms.TextBox txbEmailEditar;
        private System.Windows.Forms.TextBox txbNomeEditar;
        private System.Windows.Forms.Label lblSenhasEditar;
        private System.Windows.Forms.Label lblEmailEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}