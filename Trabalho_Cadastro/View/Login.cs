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
        int m;
        string textocaptcha = string.Empty;
        string validaImagem = string.Empty;
        const string sLetra = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        readonly string[] sFont = new string[] { "Courier New", "Impact", "Times New Roman", "Verdana", "Arial" };
        readonly Color[] cCor = new Color[] { Color.Aqua, Color.Black, Color.Blue, Color.Fuchsia, Color.Gray, Color.Green, Color.Lime, Color.Maroon, Color.Navy, Color.Olive, Color.Purple, Color.Red, Color.Silver, Color.Teal, Color.Yellow };

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.Compare(textocaptcha,txt_Informacao.Text.ToLower())==0)
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
            else
            {
                MessageBox.Show("Ops! Você errou, Digite novamente o Captcha");
                Captcha(pbImagem);
                txt_Informacao.Text = string.Empty;
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

        private void Login_Load(object sender, EventArgs e)
        {
            Captcha(pbImagem);
        }



        private void Captcha(PictureBox Imagem)
        {
            
            Random random = new Random();
            m = random.Next(10);
           
            switch (m)
            {
                case 0:
                    textocaptcha = "alcaph";
                    break;
                case 1:
                    textocaptcha = "atingian";
                    break;
                case 2:
                    textocaptcha = "boyes";
                    break;
                case 3:
                    textocaptcha = "comok";
                    break;
                case 4:
                    textocaptcha = "dessib";
                    break;
                case 5:
                    textocaptcha = "hibactor";
                    break;
                case 6:
                    textocaptcha = "mysome";
                    break;
                case 7:
                    textocaptcha = "pirse";
                    break;
                case 8:
                    textocaptcha = "quell";
                    break;
                case 9:
                    textocaptcha = "sural";
                    break;

            }
            Imagem.Image = imageList1.Images[m];
        }

    }
}

