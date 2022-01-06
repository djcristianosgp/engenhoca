using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Engenhoca.Classes
{
    internal class ClsArquivoPAT
    {
        public static void FUEscreveArquivo(int iLargura, int iAltura, string sNomeArquivo, string sNome)
        {
            StreamWriter swArquivo = new StreamWriter(sNomeArquivo+".PAT");
            swArquivo.WriteLine(";%UNITS=MM ");
            swArquivo.WriteLine("*"+sNome + " " + iLargura);
            swArquivo.WriteLine(";%TYPE=MODEL ");
            swArquivo.WriteLine("0, 0,0, 0,");
        }

        private string CalculoLargura(int ilargura)
        {
            string sRetorno = "";
            sRetorno = (ilargura / 2).ToString();
            return sRetorno;
        }
    }
}
