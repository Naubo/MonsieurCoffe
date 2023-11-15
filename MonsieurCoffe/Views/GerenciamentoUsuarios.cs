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
        //Atributos globais
            int IdSelecionado = 0;
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

            //Salvar o id na variavel global
            IdSelecionado = (int)linha.Cells[0].Value;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

            Classes.Usuario usuario = new Classes.Usuario();
            usuario.Id = IdSelecionado;

            //mostrar messagebox
            var r = MessageBox.Show("Tem certeza que deseja remover?","ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //apagar
                if (usuario.Apagar() == true)
                {
                    MessageBox.Show("Usuário Removido!", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvUsuarios.DataSource = usuario.ListarTudo();

                    //limpar campos de edicao
                    txbEmailEditar.Clear();
                    txbNomeEditar.Clear();
                    txbSenhaEditar.Clear();
                    lblApagar.Text = "Selecione um usuário para apagar:";

                    //desabilitar group box edição e apagar
                    gbEditar.Enabled = false;
                    gbApagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover usuário!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //instanciar usuario
            Classes.Usuario usuario = new Classes.Usuario();
            //obter valores dos campos
            usuario.Id = IdSelecionado;
            usuario.Nome_Completo = txbNomeEditar.Text;
            usuario.Email = txbEmailEditar.Text;
            usuario.Senha = txbSenhaEditar.Text;

            if (usuario.Modificar() == true)
            {
                MessageBox.Show("Usuário modificado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // atualizar dgv
                dgvUsuarios.DataSource = usuario.ListarTudo();

                //limpar campos de edicao
                txbEmailEditar.Clear();
                txbNomeEditar.Clear();
                txbSenhaEditar.Clear();
                lblApagar.Text = "Selecione um usuário para apagar:";

                //desabilitar group box edição e apagar
                gbEditar.Enabled = false;
                gbApagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar usuário!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gbEditar_Enter(object sender, EventArgs e)
        {

        }

        private void gbCadastro_Enter(object sender, EventArgs e)
        {

        }

        private void gbApagar_Enter(object sender, EventArgs e)
        {

        }
    }
}
