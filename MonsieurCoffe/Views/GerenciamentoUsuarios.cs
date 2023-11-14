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
    public partial class GerenciamentoUsuarios : Form
    {
        public GerenciamentoUsuarios()
        {
            InitializeComponent();
            Classes.Usuario usuario = new Classes.Usuario();
            // atribuir tabela (resultadodo select) no DGV:
            dgvUsuarios.DataSource = usuario.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instanciar usuario
            Classes.Usuario usuario = new Classes.Usuario();
            //obter valores dos campos
            usuario.Nome_Completo = txbNomeCadas.Text;
            usuario.Email = txbmailCadas.Text;
            usuario.Senha = txbSenhasCadas.Text;

            if (usuario.Cadastrar() == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");

                //limpar os campos
                txbNomeCadas.Clear();
                txbmailCadas.Clear();
                txbSenhasCadas.Clear();

                //atualizar dgv
                dgvUsuarios.DataSource = usuario.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar usuário");
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ativar os groupbox editar e apagar
            gbEditar.Enabled = true;
            gbApagar.Enabled = true;

            //obter linha clicada
            int linhaSelecionada = dgvUsuarios.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvUsuarios.Rows[linhaSelecionada];

            txbNomeEditar.Text = linha.Cells[1].Value.ToString();
            txbEmailEditar.Text = linha.Cells[2].Value.ToString();


            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();
        }
    }
}
