using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Trabalho_Cadastro.View;

namespace Trabalho_Cadastro.Control
{
    class Cadastrar_Usuario
    {

        public string caminho = "C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt";


        public void CriaArquivodeUsuarios(string Nome, string Usuario, string Senha)
        {
            StreamWriter CriadordeArquivo;
            CriadordeArquivo = new StreamWriter(caminho);
            CriadordeArquivo.WriteLine(Nome.Trim() + "*" + Usuario.Trim() + "*" + Senha.Trim());
            CriadordeArquivo.Close();
        }

        public int VerificadordeUsuarioeSenha(string Usuario, string Senha)
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

                    if ((string.Compare(Usuario,Aux_Usuario)==0)&&(string.Compare(Senha,Aux_Senha)==0))
                    {
                        i = 1;

                    }

            }
            LeitordeArquivo.Close();
            return i;
           
        }
    }
}