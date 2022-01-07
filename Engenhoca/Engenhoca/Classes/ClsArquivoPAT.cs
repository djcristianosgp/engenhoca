namespace Engenhoca.Classes
{
    internal class ClsArquivoPAT
    {
        public static void FUEscreveArquivo(string sNomeArquivo, string sTexto)
        {
            try
            {
                StreamWriter swArquivo = new StreamWriter(ClsUteis.sPataProjetos + sNomeArquivo + ".PAT");
                swArquivo.WriteLine(sTexto);
                swArquivo.Close();
            }
            catch (Exception ex)
            {
                ClsLog.FU_Escreve_Log("FUEscreveArquivo", ex.Message);
            }
        }
    }
}
