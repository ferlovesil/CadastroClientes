using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Cadastro.Control
{
    class VerificadorUsuarioeSenha
    {
        public string caminho = "C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt";
        private int resultado = 0;

        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public VerificadorUsuarioeSenha(string Usuario)
        {

            int i = 0;
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

                if ((string.Compare(Usuario, Aux_Usuario) == 0))
                {
                    i = 1;
                }

            }
            LeitordeArquivo.Close();
            resultado = i;
            i = 0;
        }

        public VerificadorUsuarioeSenha(string Usuario, string Senha)
        {
            
            int i = 0;
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

                if ((string.Compare(Usuario, Aux_Usuario) == 0) && (string.Compare(Senha, Aux_Senha) == 0))
                {
                    i = 1;
                    
                }

            }
            LeitordeArquivo.Close();
            resultado = i;
            i = 0;
        }



        public VerificadorUsuarioeSenha(string Usuario, string Senha, string PerguntaSecreta)
        {

            int i = 0;
            StreamReader LeitordeArquivo;
            LeitordeArquivo = new StreamReader(caminho);
            string Linha;

            while ((Linha = LeitordeArquivo.ReadLine()) != null)
            {
                string Aux_Linha, Aux_Usuario, Aux_Nome, Aux_Senha, Aux_PerguntaSecreta;
                Aux_Linha = Linha;
                string[] Aux_Conjunto = Linha.Split('*');

                Aux_Nome = Aux_Conjunto[0];
                Aux_Usuario = Aux_Conjunto[1];
                Aux_Senha = Aux_Conjunto[2];
                Aux_PerguntaSecreta = Aux_Conjunto[3];

                if ((string.Compare(Usuario, Aux_Usuario) == 0) && (string.Compare(Senha, Aux_Senha) == 0)&& (string.Compare(PerguntaSecreta,Aux_PerguntaSecreta)==0))
                {
                    i = 1;

                }

            }
            LeitordeArquivo.Close();
            resultado = i;
            i = 0;
        }


        }



    }


