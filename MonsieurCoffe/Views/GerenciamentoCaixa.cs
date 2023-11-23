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
    public partial class GerenciamentoCaixa : Form
    {
        //variaveis globais
        Classes.Usuario usuario = new Classes.Usuario();

        public GerenciamentoCaixa(Classes.Usuario usuario)
            {
                InitializeComponent();
                this.usuario = usuario;
                this.Text = "Gerenciamento Caixa - " +
                    usuario.Nome_Completo.ToUpper();

            
            }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (nudComanda.Text != "0")
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda();
                ordem.IdFicha = int.Parse(nudComanda.Text);
                dgvCaixa.DataSource = ordem.BuscarFicha();
                // atualizar total
                var r =ordem.BuscarFicha();
                dgvCaixa.DataSource = r;
                lblValorTotal.Text = ("R$ ") + String.Format("{0:0.00}", r.Compute("SUM(Total_item)", "True"));

            }
            else
            {
                MessageBox.Show("Digite o número da ficha!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbPagamento_CheckedChanged(object sender, EventArgs e)
        {
            //ativar e desativar btn de acordo com o checked
            btnEncerrar.Enabled = chbPagamento.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show ("Tem certeza que deseja encerrar?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Classes.OrdemComanda ordem = new Classes.OrdemComanda ();
                ordem.IdFicha = int.Parse(nudComanda.Text);
                if (ordem.EncerrarFicha() == true)
                {
                    MessageBox.Show("Ficha encerrada", "Concluído!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar campos
                    nudComanda.Text = "0";
                    dgvCaixa.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Falha ao Encerrar Ficha!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
