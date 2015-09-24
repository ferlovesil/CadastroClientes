namespace Trabalho_Cadastro.View
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_UsuarioLogin = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_SenhaLogin = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.Location = new System.Drawing.Point(164, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(37, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(139, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 94);
            this.panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 304);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 44);
            this.textBox3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Esqueceu a sua Senha? Clique Aqui!";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(136, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Digite o texto da imagem acima";
            // 
            // mtxt_UsuarioLogin
            // 
            this.mtxt_UsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.mtxt_UsuarioLogin.Location = new System.Drawing.Point(153, 34);
            this.mtxt_UsuarioLogin.Mask = "aaaaaaAAAAAAAAAAAAAAAAAAAAA";
            this.mtxt_UsuarioLogin.Name = "mtxt_UsuarioLogin";
            this.mtxt_UsuarioLogin.PromptChar = ' ';
            this.mtxt_UsuarioLogin.Size = new System.Drawing.Size(289, 38);
            this.mtxt_UsuarioLogin.TabIndex = 10;
            this.mtxt_UsuarioLogin.Click += new System.EventHandler(this.mtxt_UsuarioLogin_Click);
            this.mtxt_UsuarioLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_UsuarioLogin_KeyDown);
            // 
            // mtxt_SenhaLogin
            // 
            this.mtxt_SenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.mtxt_SenhaLogin.Location = new System.Drawing.Point(153, 96);
            this.mtxt_SenhaLogin.Mask = "aaaaaaAAAAAAAAAAAAAAAA";
            this.mtxt_SenhaLogin.Name = "mtxt_SenhaLogin";
            this.mtxt_SenhaLogin.PasswordChar = '*';
            this.mtxt_SenhaLogin.PromptChar = ' ';
            this.mtxt_SenhaLogin.Size = new System.Drawing.Size(289, 38);
            this.mtxt_SenhaLogin.TabIndex = 11;
            this.mtxt_SenhaLogin.Click += new System.EventHandler(this.mtxt_SenhaLogin_Click);
            this.mtxt_SenhaLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxt_SenhaLogin_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(476, 465);
            this.Controls.Add(this.mtxt_SenhaLogin);
            this.Controls.Add(this.mtxt_UsuarioLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_UsuarioLogin;
        private System.Windows.Forms.MaskedTextBox mtxt_SenhaLogin;


    }
}