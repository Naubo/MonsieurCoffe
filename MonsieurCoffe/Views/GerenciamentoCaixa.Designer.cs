namespace MonsieurCoffe.Views
{
    partial class GerenciamentoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciamentoCaixa));
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.lblNComanda = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.nudComanda = new System.Windows.Forms.NumericUpDown();
            this.chbPagamento = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.AllowUserToAddRows = false;
            this.dgvCaixa.AllowUserToDeleteRows = false;
            this.dgvCaixa.AllowUserToResizeColumns = false;
            this.dgvCaixa.AllowUserToResizeRows = false;
            this.dgvCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(20, 113);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(588, 227);
            this.dgvCaixa.TabIndex = 0;
            // 
            // lblNComanda
            // 
            this.lblNComanda.AutoSize = true;
            this.lblNComanda.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNComanda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNComanda.Location = new System.Drawing.Point(17, 89);
            this.lblNComanda.Name = "lblNComanda";
            this.lblNComanda.Size = new System.Drawing.Size(101, 17);
            this.lblNComanda.TabIndex = 1;
            this.lblNComanda.Text = "N° Comanda:";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListar.Location = new System.Drawing.Point(277, 84);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(36, 26);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "🔎";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(12, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(335, 44);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Monsieur Coffe :: Caixa";
            // 
            // nudComanda
            // 
            this.nudComanda.Location = new System.Drawing.Point(126, 87);
            this.nudComanda.Name = "nudComanda";
            this.nudComanda.Size = new System.Drawing.Size(145, 20);
            this.nudComanda.TabIndex = 14;
            // 
            // chbPagamento
            // 
            this.chbPagamento.AutoSize = true;
            this.chbPagamento.Location = new System.Drawing.Point(344, 374);
            this.chbPagamento.Name = "chbPagamento";
            this.chbPagamento.Size = new System.Drawing.Size(129, 17);
            this.chbPagamento.TabIndex = 15;
            this.chbPagamento.Text = "Pagamento Recebido";
            this.chbPagamento.UseVisualStyleBackColor = true;
            this.chbPagamento.CheckedChanged += new System.EventHandler(this.chbPagamento_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(17, 353);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(50, 17);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Enabled = false;
            this.btnEncerrar.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEncerrar.Location = new System.Drawing.Point(479, 356);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(129, 48);
            this.btnEncerrar.TabIndex = 17;
            this.btnEncerrar.Text = "Encerrar Comanda";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorTotal.Location = new System.Drawing.Point(15, 376);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(62, 28);
            this.lblValorTotal.TabIndex = 18;
            this.lblValorTotal.Text = "0,00";
            // 
            // GerenciamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 422);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chbPagamento);
            this.Controls.Add(this.nudComanda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblNComanda);
            this.Controls.Add(this.dgvCaixa);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerenciamentoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudComanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.Label lblNComanda;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown nudComanda;
        private System.Windows.Forms.CheckBox chbPagamento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label lblValorTotal;
    }
}