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
    public partial class GerenciamentoProdutos : Form
    {
        //variaveis globais:
        Classes.Usuario usuario = new Classes.Usuario();
        int IdSelecionado = 0;

        public GerenciamentoProdutos(Classes.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            Classes.Produto produto = new Classes.Produto();
            // atribuir tabela (resultadodo select) no DGV:
            dgvProdutos.DataSource = produto.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //instanciar produto
            Classes.Produto produto = new Classes.Produto();
            //obter valores
            produto.Nome = txbNomeProduto.Text;
            produto.Preco = double.Parse(txbPreco.Text);
            produto.Id_Categoria = int.Parse(txbIdCategoriaCadastrar.Text);
            produto.Id_RespCadastro = usuario.Id; //??????

            if (produto.Cadastrar() == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");

                //limpar os campos
                txbNomeProduto.Clear();
                txbPreco.Clear();
                txbIdCategoriaCadastrar.Clear();

                //atualizar dgv
                dgvProdutos.DataSource = produto.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar Produtos");
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            //instanciar usuario
            Classes.Produto produto = new Classes.Produto();
            //obter valores dos campos
            produto.Id = IdSelecionado;
            produto.Nome = txbNomeEditar.Text;
            produto.Preco = double.Parse(txbPrecoEditar.Text);
            produto.Id_Categoria = int.Parse(txbIdCategoriaEditar.Text);
            produto.Id_RespCadastro = usuario.Id;

            if (produto.Modificar() == true)
            {
                MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // atualizar dgv
                dgvProdutos.DataSource = produto.ListarTudo();

                //limpar os campos
                txbNomeProduto.Clear();
                txbPreco.Clear();
                txbIdCategoriaCadastrar.Clear();
                lblApagar.Text = "Selecione um Produto para apagar:";

                //desabilitar group box edição e apagar
                gbEditar.Enabled = false;
                gbApagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Falha ao modificar Produto!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Classes.Produto produto = new Classes.Produto();
            produto.Id = IdSelecionado;

            //mostrar messagebox
            var r = MessageBox.Show("Tem certeza que deseja remover?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //apagar
                if (produto.Apagar() == true)
                {
                    MessageBox.Show("Produto Removido!", "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvProdutos.DataSource = produto.ListarTudo();

                    //limpar os campos
                    txbNomeProduto.Clear();
                    txbPreco.Clear();
                    txbIdCategoriaCadastrar.Clear();
                    lblApagar.Text = "Selecione um Produto para apagar:";

                    //desabilitar group box edição e apagar
                    gbEditar.Enabled = false;
                    gbApagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Falha ao remover Produto!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //aqui vai mostrar as info do banco de dados 

            //ativar os groupbox editar e apagar
            gbEditar.Enabled = true;
            gbApagar.Enabled = true;

            //obter linha clicada
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvProdutos.Rows[linhaSelecionada];

            txbNomeEditar.Text = linha.Cells[1].Value.ToString();
            txbPrecoEditar.Text = linha.Cells[2].Value.ToString();
            txbIdCategoriaEditar.Text = linha.Cells[3].Value.ToString();


            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            //Salvar o id na variavel global
            IdSelecionado = (int)linha.Cells[0].Value;
        }
    }
    }
