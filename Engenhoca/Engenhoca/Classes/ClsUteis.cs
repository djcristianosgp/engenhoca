namespace Engenhoca.Classes
{
    internal class ClsUteis
    {
        public static string sPastaPadrao = @"C:\Engenhoca\";
        public static string sPastaLog = sPastaPadrao + @"Log\";
        public static string sPastaImagens = sPastaPadrao + @"Imagens\";
        public static string sPataProjetos = sPastaPadrao + @"Projetos\";
        public static string sPastaBackup = @"c:\Backup\";

        public static List<string> lListaPasta = new List<string>()
        {
            sPastaPadrao,
            sPastaLog,
            sPataProjetos,
            sPastaImagens,
            sPastaBackup
        };

        public static string sArquivoLog = sPastaLog + "Engenhoca" + DateTime.Now.ToString("yyyyMM") + ".Log";
        public static string sArquivoBackup = "Engenhoca_Backup_" + DateTime.Now.ToString("ddd") + ".zip";
        public static string sConfiJanela = sPastaPadrao + "ConfigJanela.dll";

        public static List<string> lListaArquivos = new List<string>()
        {
            sArquivoLog
        };

        //Static
        public static string sExecucao = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string sEstacao = Environment.MachineName.ToUpper();
        public static bool bImagemFundo = true;
        public static string sImagemFundo = sPastaImagens + "fundo.png";
        //Pasta
        public void VerificaPastas()
        {
            var vPastas = lListaPasta;
            for (int iContador = 0; iContador < vPastas.Count; iContador++)
            {
                if (vPastas[iContador] != String.Empty)
                {
                    if (!Directory.Exists(vPastas[iContador])) Directory.CreateDirectory(vPastas[iContador]);
                }
            }
        }

        //Arquivos
        public void VerificaArquivos()
        {
            var vArquivos = lListaArquivos;
            for (int iContador = 0; iContador < vArquivos.Count; iContador++)
            {
                if (vArquivos[iContador] != String.Empty)
                {
                    if (!File.Exists(vArquivos[iContador])) File.Create(vArquivos[iContador]);
                }
            }
        }

        public void Atalho()
        {
            if (!sExecucao.Contains(@"Engenhoca\bin"))
            {
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Engenhoca.lnk"))
                {
                    try
                    {
                        byte[] Executavel = Properties.Resources.Engenhoca;
                        FileStream ArquivoTMP = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Engenhoca.lnk", FileMode.Create);
                        ArquivoTMP.Write(Executavel, 0, Executavel.Length);
                        ArquivoTMP.Close();
                    }
                    catch (Exception ex)
                    {
                        ClsLog.FU_Escreve_Log("Atalho", ex.Message);
                    }
                }
            }
        }
    }
}
