namespace Trabalho_Cadastro.View
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_IrParaLogin = new System.Windows.Forms.Button();
            this.mtxt_Senha = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_Usuario = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_Nome = new System.Windows.Forms.MaskedTextBox();
            this.link_Regulamento = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_ConfirmacaoSenha = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.mtxt_ComparacaoSenha = new System.Windows.Forms.MaskedTextBox();
            this.txt_Mensagem = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_RespostaSecreta = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(365, 476);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(83, 43);
            this.btn_Voltar.TabIndex = 52;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_IrParaLogin
            // 
            this.btn_IrParaLogin.Location = new System.Drawing.Point(12, 476);
            this.btn_IrParaLogin.Name = "btn_IrParaLogin";
            this.btn_IrParaLogin.Size = new System.Drawing.Size(135, 43);
            this.btn_IrParaLogin.TabIndex = 51;
            this.btn_IrParaLogin.Text = "Já Possui uma Conta? Clique aqui para Logar-se";
            this.btn_IrParaLogin.UseVisualStyleBackColor = true;
            // 
            // mtxt_Senha
            // 
            this.mtxt_Senha.AsciiOnly = true;
            this.mtxt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_Senha.Location = new System.Drawing.Point(153, 113);
            this.mtxt_Senha.Mask = "aaaaaaAAAAAAAAAAAAAAA";
            this.mtxt_Senha.Name = "mtxt_Senha";
            this.mtxt_Senha.PasswordChar = '*';
            this.mtxt_Senha.PromptChar = ' ';
            this.mtxt_Senha.Size = new System.Drawing.Size(324, 38);
            this.mtxt_Senha.TabIndex = 49;
            this.mtxt_Senha.Click += new System.EventHandler(this.mtxt_Senha_Click);
            this.mtxt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_Senha_KeyDown);
            // 
            // mtxt_Usuario
            // 
            this.mtxt_Usuario.AsciiOnly = true;
            this.mtxt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_Usuario.Location = new System.Drawing.Point(153, 59);
            this.mtxt_Usuario.Mask = "aaaaaaAAAAAAAAAAAAAAA";
            this.mtxt_Usuario.Name = "mtxt_Usuario";
            this.mtxt_Usuario.PromptChar = ' ';
            this.mtxt_Usuario.Size = new System.Drawing.Size(324, 38);
            this.mtxt_Usuario.TabIndex = 48;
            this.mtxt_Usuario.Click += new System.EventHandler(this.mtxt_Usuario_Click);
            this.mtxt_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_Usuario_KeyDown);
            // 
            // mtxt_Nome
            // 
            this.mtxt_Nome.AsciiOnly = true;
            this.mtxt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_Nome.Location = new System.Drawing.Point(153, 6);
            this.mtxt_Nome.Mask = "???????????????????????????????????";
            this.mtxt_Nome.Name = "mtxt_Nome";
            this.mtxt_Nome.PromptChar = ' ';
            this.mtxt_Nome.Size = new System.Drawing.Size(324, 38);
            this.mtxt_Nome.TabIndex = 47;
            this.mtxt_Nome.Click += new System.EventHandler(this.mtxt_Nome_Click);
            // 
            // link_Regulamento
            // 
            this.link_Regulamento.AutoSize = true;
            this.link_Regulamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Regulamento.LinkColor = System.Drawing.Color.Gold;
            this.link_Regulamento.Location = new System.Drawing.Point(262, 363);
            this.link_Regulamento.Name = "link_Regulamento";
            this.link_Regulamento.Size = new System.Drawing.Size(92, 15);
            this.link_Regulamento.TabIndex = 46;
            this.link_Regulamento.TabStop = true;
            this.link_Regulamento.Text = "regulamento.";
            this.link_Regulamento.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Regulamento_LinkClicked);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(386, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "- você se compromete em respeitar sem exceção este regulamento.";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 23);
            this.label6.TabIndex = 44;
            this.label6.Text = "- você reconhece ter lido inteiramente o presente ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(28, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(386, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Clicando em \" Eu aceito \" abaixo:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(52, 438);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 42;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Não Aceito";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(52, 415);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 41;
            this.radioButton1.Text = "Eu Aceito";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbl_ConfirmacaoSenha
            // 
            this.lbl_ConfirmacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_ConfirmacaoSenha.Location = new System.Drawing.Point(28, 162);
            this.lbl_ConfirmacaoSenha.Name = "lbl_ConfirmacaoSenha";
            this.lbl_ConfirmacaoSenha.Size = new System.Drawing.Size(109, 53);
            this.lbl_ConfirmacaoSenha.TabIndex = 40;
            this.lbl_ConfirmacaoSenha.Text = "Repita a Senha:";
            this.lbl_ConfirmacaoSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_Senha.Location = new System.Drawing.Point(28, 109);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(109, 42);
            this.lbl_Senha.TabIndex = 39;
            this.lbl_Senha.Text = "Senha:";
            this.lbl_Senha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_Usuario.Location = new System.Drawing.Point(28, 55);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(109, 42);
            this.lbl_Usuario.TabIndex = 38;
            this.lbl_Usuario.Text = "Usuário:";
            this.lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lbl_Nome.Location = new System.Drawing.Point(23, 2);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(114, 47);
            this.lbl_Nome.TabIndex = 37;
            this.lbl_Nome.Text = "Nome:";
            this.lbl_Nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Enabled = false;
            this.btn_Cadastrar.Location = new System.Drawing.Point(153, 476);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(206, 43);
            this.btn_Cadastrar.TabIndex = 36;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // mtxt_ComparacaoSenha
            // 
            this.mtxt_ComparacaoSenha.AsciiOnly = true;
            this.mtxt_ComparacaoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_ComparacaoSenha.Location = new System.Drawing.Point(153, 167);
            this.mtxt_ComparacaoSenha.Mask = "aaaaaaAAAAAAAAAAAAAAA";
            this.mtxt_ComparacaoSenha.Name = "mtxt_ComparacaoSenha";
            this.mtxt_ComparacaoSenha.PasswordChar = '*';
            this.mtxt_ComparacaoSenha.PromptChar = ' ';
            this.mtxt_ComparacaoSenha.Size = new System.Drawing.Size(324, 38);
            this.mtxt_ComparacaoSenha.TabIndex = 53;
            this.mtxt_ComparacaoSenha.Click += new System.EventHandler(this.mtxt_ComparacaoSenha_Click);
            this.mtxt_ComparacaoSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_ComparacaoSenha_KeyDown);
            // 
            // txt_Mensagem
            // 
            this.txt_Mensagem.BackColor = System.Drawing.Color.SteelBlue;
            this.txt_Mensagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Mensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mensagem.ForeColor = System.Drawing.Color.Gold;
            this.txt_Mensagem.Location = new System.Drawing.Point(52, 525);
            this.txt_Mensagem.Multiline = true;
            this.txt_Mensagem.Name = "txt_Mensagem";
            this.txt_Mensagem.Size = new System.Drawing.Size(361, 50);
            this.txt_Mensagem.TabIndex = 54;
            this.txt_Mensagem.Text = "É necessário ler o regulamento, e clicar em \"Eu Aceito\" para se cadastrar!";
            this.txt_Mensagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Qual o nome do seu 1º animal de estimação?",
            "Qual é a sua comida favorita? ",
            "Qual é o nome de solteira da sua avó?",
            "Qual é o apelido do seu tio avô?"});
            this.comboBox1.Location = new System.Drawing.Point(142, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 28);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(5, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 78);
            this.label1.TabIndex = 56;
            this.label1.Text = "Pergunta de Segurança:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtxt_RespostaSecreta
            // 
            this.mtxt_RespostaSecreta.AsciiOnly = true;
            this.mtxt_RespostaSecreta.Enabled = false;
            this.mtxt_RespostaSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxt_RespostaSecreta.Location = new System.Drawing.Point(142, 295);
            this.mtxt_RespostaSecreta.Mask = "aaaaaaAAAAAAAAAAAAAAA";
            this.mtxt_RespostaSecreta.Name = "mtxt_RespostaSecreta";
            this.mtxt_RespostaSecreta.PromptChar = ' ';
            this.mtxt_RespostaSecreta.Size = new System.Drawing.Size(346, 38);
            this.mtxt_RespostaSecreta.TabIndex = 57;
            this.mtxt_RespostaSecreta.Click += new System.EventHandler(this.maskedTextBox1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(18, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 53);
            this.label2.TabIndex = 58;
            this.label2.Text = "Resposta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(489, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxt_RespostaSecreta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Mensagem);
            this.Controls.Add(this.mtxt_ComparacaoSenha);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_IrParaLogin);
            this.Controls.Add(this.mtxt_Senha);
            this.Controls.Add(this.mtxt_Usuario);
            this.Controls.Add(this.mtxt_Nome);
            this.Controls.Add(this.link_Regulamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lbl_ConfirmacaoSenha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Cadastrar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_IrParaLogin;
        private System.Windows.Forms.MaskedTextBox mtxt_Senha;
        private System.Windows.Forms.MaskedTextBox mtxt_Usuario;
        private System.Windows.Forms.MaskedTextBox mtxt_Nome;
        private System.Windows.Forms.LinkLabel link_Regulamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbl_ConfirmacaoSenha;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.MaskedTextBox mtxt_ComparacaoSenha;
        private System.Windows.Forms.TextBox txt_Mensagem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_RespostaSecreta;
        private System.Windows.Forms.Label label2;
    }
}