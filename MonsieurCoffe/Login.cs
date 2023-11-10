using MonsieurCoffe.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsieurCoffe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //instanciar usuario:
            Classes.Usuario usuario= new Classes.Usuario();
            usuario.Email = txbEmail.Text;
            usuario.Senha = txbSenha.Text;
             // obter o resultado do SELECT no banco:
            var resultado = usuario.Logar();

            MessageBox.Show(resultado.Rows.Count.ToString());

            if (resultado.Rows.Count == 1)
            {
                usuario.Nome_Completo = resultado.Rows[0]["nome_completo"].ToString ();
                usuario.Id = (int)resultado.Rows[0]["id"];
                MessageBox.Show(usuario.Nome_Completo);

                //abrir janela menu
                MenuPrincipal janela = new MenuPrincipal();
                janela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ou senha inválidos", "Erro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                txbEmail.Clear();
                txbSenha.Clear();
            }

        }
    }
}
