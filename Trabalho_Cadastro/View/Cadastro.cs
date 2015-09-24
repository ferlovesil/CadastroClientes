using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Trabalho_Cadastro.Control;

namespace Trabalho_Cadastro.View
{
    public partial class Cadastro : Form
    {
        public string caminho = "C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt";

        public Cadastro()
        {

            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_Cadastrar.Enabled = true;
            txt_Mensagem.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btn_Cadastrar.Enabled = false;
            txt_Mensagem.Visible = true;
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
            if ((mtxt_Nome.Text.Trim().Length != 0) && (mtxt_Senha.Text.Trim().Length != 0) && (mtxt_Usuario.Text.Trim().Length != 0) && (mtxt_ComparacaoSenha.Text.Trim().Length != 0))
            {
                if (mtxt_ComparacaoSenha.Text == mtxt_Senha.Text)
                {
                    mtxt_ComparacaoSenha.BackColor = Color.White;

                    if (File.Exists(caminho))
                    {
                        try
                        {
                            FileInfo informacoesdoarquivo = new FileInfo(caminho);
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

                                    int y = 0;
                                    StreamReader LeitordeArquivo;
                                    LeitordeArquivo = new StreamReader(caminho);
                                    string Linha;

                                    while ((Linha = LeitordeArquivo.ReadLine()) != null)
                                    {
                                        string Aux_Linha, Aux_Usuario, Aux_Nome, Aux_Senha;
                                        Aux_Linha = Linha;
                                        string[] Aux_Conjunto = Linha.Split('*');

                                        Aux_Nome = Aux_Conjunto[0];
                                        Aux_Usuario = Aux_Conjunto[1];
                                        Aux_Senha = Aux_Conjunto[2];

                                        if ((string.Compare(mtxt_Usuario.Text, Aux_Usuario) == 0) && (string.Compare(mtxt_Senha.Text, Aux_Senha) == 0))
                                        {
                                            y = 1;
                                            MessageBox.Show("Esse usuário já está cadastrado, por favor insira outro nome de usuário!");

                                        }
                                    }
                                    LeitordeArquivo.Close();
                                    if (y == 0)
                                    {
                                        try
                                        {


                                            using (StreamWriter sw = File.AppendText(caminho))
                                            {
                                                sw.Write(mtxt_Nome.Text + "*" + mtxt_Usuario.Text + "*" + mtxt_Senha.Text + "\r\n");
                                                mtxt_Nome.Text = "";
                                                mtxt_Senha.Text = "";
                                                mtxt_Usuario.Text = "";
                                                mtxt_ComparacaoSenha.Text = "";
                                            }
                                        }//fim segundo try
                                        catch (IOException)
                                        {
                                            MessageBox.Show("Não pode abrir o arquivo pois ja está sendo utilizado por outro programa");
                                        }
                                    }
                                    y = 0;
                                }
                            }
                        }//primeiro Try
                        catch (FileNotFoundException)
                        {
                            MessageBox.Show("Não foi possível encontrar o arquivo");
                        }
                        catch (FileLoadException)
                        {
                            MessageBox.Show("Não foi possível carregar o arquivo");
                        }
                        catch (FieldAccessException)
                        {
                            MessageBox.Show("Não foi possível acessar o arquivo");
                        }
                    }
                    else
                    {
                        Cadastrar_Usuario c = new Cadastrar_Usuario();
                        c.CriaArquivodeUsuarios(mtxt_Nome.Text, mtxt_Usuario.Text, mtxt_Senha.Text + "\r\n");
                        mtxt_Nome.Text = "";
                        mtxt_Senha.Text = "";
                        mtxt_Usuario.Text = "";
                        mtxt_ComparacaoSenha.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Por favor insira a mesma senha que digitou no campo Senha!");
                    mtxt_ComparacaoSenha.BackColor = Color.Red;
                    mtxt_ComparacaoSenha.Focus();
                    mtxt_ComparacaoSenha.Select();
                }
            }
            else
            {
                MessageBox.Show("Existem Campos vazios, por favor complete todos os campos!");
            }
        }


        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Cadastrar_Usuario l = new Cadastrar_Usuario();
            l.LeArquivodeUsuarios(mtxt_Usuario.Text, mtxt_Senha.Text);

        }
    }
}



