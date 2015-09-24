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
                   
            StreamReader LeitordeArquivo;
            LeitordeArquivo = new StreamReader("C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt");
            string Linha;
            int i = 0;

            while ((Linha = LeitordeArquivo.ReadLine()) != null)
            {
                string Aux_Linha, Aux_Usuario, Aux_Nome, Aux_Senha;
                Aux_Linha = Linha;
                string[] Aux_Conjunto = Linha.Split('*');
                
                    Aux_Nome = Aux_Conjunto[0];
                    Aux_Usuario = Aux_Conjunto[1];
                    Aux_Senha = Aux_Conjunto[2];

                    if ((string.Compare(mtxt_UsuarioLogin.Text,Aux_Usuario)==0)&&(string.Compare(mtxt_SenhaLogin.Text,Aux_Senha)==0))
                    {

                        i = 1;
                    }

            }
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

