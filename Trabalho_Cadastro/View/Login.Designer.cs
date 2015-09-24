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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Informacao = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxt_UsuarioLogin = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_SenhaLogin = new System.Windows.Forms.MaskedTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
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
            // txt_Informacao
            // 
            this.txt_Informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.txt_Informacao.Location = new System.Drawing.Point(127, 304);
            this.txt_Informacao.Multiline = true;
            this.txt_Informacao.Name = "txt_Informacao";
            this.txt_Informacao.Size = new System.Drawing.Size(226, 44);
            this.txt_Informacao.TabIndex = 6;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alcaph.jpg");
            this.imageList1.Images.SetKeyName(1, "atingian.jpg");
            this.imageList1.Images.SetKeyName(2, "boyes.jpg");
            this.imageList1.Images.SetKeyName(3, "comok.jpg");
            this.imageList1.Images.SetKeyName(4, "dessib.jpg");
            this.imageList1.Images.SetKeyName(5, "hibactor.jpg");
            this.imageList1.Images.SetKeyName(6, "mysome.jpg");
            this.imageList1.Images.SetKeyName(7, "pirse.jpg");
            this.imageList1.Images.SetKeyName(8, "quell.jpg");
            this.imageList1.Images.SetKeyName(9, "sural.jpg");
            // 
            // pbImagem
            // 
            this.pbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagem.Location = new System.Drawing.Point(164, 159);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(225, 84);
            this.pbImagem.TabIndex = 12;
            this.pbImagem.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(476, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.mtxt_SenhaLogin);
            this.Controls.Add(this.mtxt_UsuarioLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_Informacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Informacao;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxt_UsuarioLogin;
        private System.Windows.Forms.MaskedTextBox mtxt_SenhaLogin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label label4;


    }
}