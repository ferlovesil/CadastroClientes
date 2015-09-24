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
    }
}