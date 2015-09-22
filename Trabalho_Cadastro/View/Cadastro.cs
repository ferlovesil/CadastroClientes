using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}


