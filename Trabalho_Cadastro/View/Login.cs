using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_Cadastro.Control;

namespace Trabalho_Cadastro.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar_Usuario c = new Cadastrar_Usuario();
            int i = c.VerificadordeUsuarioeSenha(mtxt_UsuarioLogin.Text, mtxt_SenhaLogin.Text);
            
            if (i == 0)
            {
                MessageBox.Show("Informe um nome de usuário ou senha corretos");
            }
            else
            {
                MessageBox.Show("Entrou!");
            }
        }







        private void mtxt_UsuarioLogin_Click(object sender, EventArgs e)
        {
            mtxt_UsuarioLogin.SelectionStart = mtxt_UsuarioLogin.Text.Length;
        }

        private void mtxt_SenhaLogin_Click(object sender, EventArgs e)
        {
            mtxt_SenhaLogin.SelectionStart = mtxt_SenhaLogin.Text.Length;
        }

        private void mtxt_SenhaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void mtxt_UsuarioLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }




        }


    }

