using System;
using System.IO;
using System.Windows.Forms;
using Trabalho_Cadastro.Control;

namespace Trabalho_Cadastro.View
{
    public partial class Cadastro : Form
    {

        public Cadastro()
        {

            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_Cadastrar.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btn_Cadastrar.Enabled = false;
        }

        private void link_Regulamento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Regulamento regulamento = new Regulamento();
            regulamento.Show();
            radioButton1.Enabled = true;

        }

        private void mtxt_Nome_Click(object sender, EventArgs e)
        {
            mtxt_Nome.SelectionStart = mtxt_Nome.Text.Length;
        }

        private void mtxt_Usuario_Click(object sender, EventArgs e)
        {
            mtxt_Usuario.SelectionStart = mtxt_Usuario.Text.Length;
        }

        private void mtxt_Senha_Click(object sender, EventArgs e)
        {
            mtxt_Senha.SelectionStart = mtxt_Senha.Text.Length;
        }

        private void mtxt_ComparacaoSenha_Click(object sender, EventArgs e)
        {
            mtxt_ComparacaoSenha.SelectionStart = mtxt_ComparacaoSenha.Text.Length;
        }

        private void mtxt_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void mtxt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void mtxt_ComparacaoSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }


        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            if ("a" != null)
            {
                if (File.Exists("C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt"))
                {
                    FileInfo informacoesdoarquivo = new FileInfo("C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt");
                    {
                        if (informacoesdoarquivo.Length <= 0)
                        {
                            Cadastrar_Usuario c = new Cadastrar_Usuario();
                            c.CriaArquivodeUsuarios(mtxt_Nome.Text, mtxt_Usuario.Text, mtxt_Senha.Text);
                            mtxt_Nome.Text = "";
                            mtxt_Senha.Text = "";
                            mtxt_Usuario.Text = "";
                            mtxt_ComparacaoSenha.Text = "";
                        }
                        else
                        {
                            using (StreamWriter sw = File.AppendText("C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt"))
                            {
                                sw.Write("\r\n" + "Nome" + mtxt_Nome.Text + "Usuario" + mtxt_Usuario.Text +"*"+ "Senha" + mtxt_Senha.Text);
                                mtxt_Nome.Text = "";
                                mtxt_Senha.Text = "";
                                mtxt_Usuario.Text = "";
                                mtxt_ComparacaoSenha.Text = "";
                            }
                        }
                    }
                }
                else
                {
                    Cadastrar_Usuario c = new Cadastrar_Usuario();
                    c.CriaArquivodeUsuarios(mtxt_Nome.Text, mtxt_Usuario.Text, mtxt_Senha.Text);
                    mtxt_Nome.Text = "";
                    mtxt_Senha.Text = "";
                    mtxt_Usuario.Text = "";
                    mtxt_ComparacaoSenha.Text = "";

                }
            }
        }
    }
}



