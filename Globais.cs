using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;

        // Estrutura para criar um caminho relativo no BD
        // O caminho relativo de "System.Environment.CurrentDirectory" leva até a pasta
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeDatabase = "bd_escola.db";
        public static string caminhoDatabase = caminho + "\\bd\\" + nomeDatabase;
    }
}
