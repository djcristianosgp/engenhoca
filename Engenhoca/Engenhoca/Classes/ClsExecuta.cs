using System.Diagnostics;

namespace Engenhoca.Classes
{
    internal class ClsExecuta
    {
        public static void FU_ExecutaCMD(string sComando)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo(sComando);
                info.UseShellExecute = true;
                Process.Start(info);
            }
            catch (Exception ex)
            {
                ClsLog.FU_Escreve_Log("FU_ExecutaCMD", ex.Message);
            }
        }
    }
}
