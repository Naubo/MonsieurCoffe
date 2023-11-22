using MonsieurCoffe.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsieurCoffe.Views
{
    public partial class Comandas : Form
    {

        //variaveis globais
        Classes.Usuario usuario = new Classes.Usuario();


        public Comandas(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.Text = "Gerenciamento Comandas - " +
                usuario.Nome_Completo.ToUpper();

            // atribuir tabela (resultadodo select) no DGV:
            Classes.Produto produto = new Classes.Produto();
            dgvComandas.DataSource = produto.ListarTudo();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            grbLançamento.Enabled = true;
            grbInfo.Enabled = false;
        }

        private void dgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int LinhaSelecionada = dgvComandas.CurrentCell.RowIndex;
            var linha = dgvComandas.Rows[LinhaSelecionada];

            txbCodProdutoInfo.Text = linha.Cells[0].Value.ToString();
            txbProdutoLanca.Text = linha.Cells[1].Value.ToString();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            //mostrar messagebox
            var r = MessageBox.Show("Tem certeza que deseja Lançar?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(txbComandaInfo.Text);
                ordem.IdProduto = int.Parse(txbCodProdutoInfo.Text);
                ordem.Quantidade = int.Parse(txbQuantidade.Text);
                ordem.IdResponsavel = usuario.Id;

                //efetuar cadastro
                if (ordem.NovoLancamento() == true) 
                {
                    MessageBox.Show("Lançamento efetuado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao lançar!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
            MessageBox.Show("Falha ao lançar!", "ERROR",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
