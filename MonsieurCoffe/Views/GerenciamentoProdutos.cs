using MonsieurCoffe.Classes;
using System;
using System.Collections;
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
            ///////////////////////////////////////////////////////
            Classes.Categoria categoria = new Classes.Categoria();
            var r = categoria.ListarTudo();

            foreach (DataRow linha in r.Rows)
            {
                cbCategoriaCadas.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
                cbCategoriaEditar.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
            }

            ///////////////////////////////////////////////////////


            // atribuir tabela (resultadodo select) no DGV:
            dgvProdutos.DataSource = produto.ListarTudo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txbNomeProduto.Text != "") || (txbPreco.Text != ""))
            {
                //instanciar produto
                Classes.Produto produto = new Classes.Produto();
                //obter valores
                produto.Nome = txbNomeProduto.Text;
                produto.Preco = double.Parse(txbPreco.Text);

                string[] cat = cbCategoriaCadas.Text.Split('-');
                produto.Id_Categoria = int.Parse(cat[0]);

                produto.Id_RespCadastro = usuario.Id; //??????

                if (produto.Cadastrar() == true)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");

                    //limpar os campos
                    txbNomeProduto.Clear();
                    txbPreco.Clear();

                    //atualizar dgv
                    dgvProdutos.DataSource = produto.ListarTudo();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar Produtos");
                }
            }
            else
            {
                MessageBox.Show("Preencha os espaços vazios!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cbCategoriaEditar.Text != "")
            {
                //instanciar usuario
                Classes.Produto produto = new Classes.Produto();
                //obter valores dos campos
                produto.Id = IdSelecionado;
                produto.Nome = txbNomeEditar.Text;
                produto.Preco = double.Parse(txbPrecoEditar.Text);
                string[] cat = cbCategoriaEditar.Text.Split('-');
                produto.Id_Categoria = int.Parse(cat[0]);
                produto.Id_RespCadastro = usuario.Id;

                if (produto.Modificar() == true)
                {
                    MessageBox.Show("Produto modificado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // atualizar dgv
                    dgvProdutos.DataSource = produto.ListarTudo();

                    //limpar os campos
                    txbNomeProduto.Clear();
                    txbPreco.Clear();
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
            else
            {
                MessageBox.Show("Selecione uma categoria!", "Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Classes.Produto produto = new Classes.Produto();

            //ativar os groupbox editar e apagar
            gbEditar.Enabled = true;
            gbApagar.Enabled = true;

            //obter linha clicada
            int linhaSelecionada = dgvProdutos.CurrentCell.RowIndex;

            //armazenar os dados da linha clicada em linha (tipo um vetor)
            var linha = dgvProdutos.Rows[linhaSelecionada];

            txbNomeEditar.Text = linha.Cells[1].Value.ToString();
            txbPrecoEditar.Text = linha.Cells[2].Value.ToString();
            cbCategoriaEditar.Text = "";





            lblApagar.Text = linha.Cells[0].Value.ToString() + " - " +
                linha.Cells[1].Value.ToString();

            //Salvar o id na variavel global
            IdSelecionado = (int)linha.Cells[0].Value;
        }
        private void btnCatCriar_Click(object sender, EventArgs e)
        {
            //instanciar
            Classes.Categoria categoria = new Classes.Categoria();

            // guardar valores
            categoria.Nome = txbCatCriar.Text;

            if (categoria.Criar() == true)
            {
                MessageBox.Show("Categoria criada com sucesso!");

                var r = categoria.ListarTudo();
                cbCategoriaCadas.Items.Clear();
                cbCategoriaEditar.Items.Clear();

                foreach (DataRow linha in r.Rows)
                {

                    cbCategoriaCadas.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
                    cbCategoriaEditar.Items.Add(linha.ItemArray[0].ToString() + " - " + linha.ItemArray[1].ToString());
                }
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar categoria!");
            }
            }


    }
    }

