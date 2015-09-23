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




        public void CriaArquivodeUsuarios(string Nome, string Usuario, string Senha)
        {
            StreamWriter CriadordeArquivo;
            CriadordeArquivo = new StreamWriter("C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt");
            CriadordeArquivo.WriteLine(Nome.Trim() + "*" + Usuario.Trim() + "*" + Senha.Trim());
            CriadordeArquivo.Close();
        }

        //public void LeArquivodeUsuarios()
        //{
        //    StreamReader LeitordeArquivo;
        //    LeitordeArquivo = new StreamReader("C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios.txt");
        //    string Linha;

        //    while ((Linha = LeitordeArquivo.ReadLine()) != null)
        //    {
        //        string Aux_Linha, Aux_Usuario, Aux_Nome, Aux_Senha;
        //        Aux_Linha = Linha;
        //        string[] Aux_Conjunto = Linha.Split('*');
        //        if (Aux_Conjunto.Length == 2)
        //        {

        //            Aux_Nome = Aux_Conjunto[0];
        //            Aux_Usuario = Aux_Conjunto[1];
        //            Aux_Senha = Aux_Conjunto[2];

        //            StreamWriter CriadordeArquivo;
        //            CriadordeArquivo = new StreamWriter("C:\\Users\\Lucas\\Desktop\\PC\\PUC\\SEGUNDO SEMESTRE\\Presenciais\\LC\\Trabalho_Cadastro\\Trabalho_Cadastro\\data\\arquivodeusuarios2.txt");
        //            CriadordeArquivo.WriteLine(Aux_Conjunto[2]);
        //            CriadordeArquivo.Close();
    }
}

