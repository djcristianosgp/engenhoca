using Engenhoca.Classes;
using System.Diagnostics;
using System.IO.Compression;

namespace Engenhoca.Telas
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblLocalBackup.Text = "Local do Backup: ==> " + ClsUteis.sPastaBackup;
            lblStatus.Text = "";
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            FU_ExecutaBanckup();
        }

        public void FU_ExecutaBanckup()
        {
            ThreadStart ts = new ThreadStart(ExecutaBackup);
            Thread t = new Thread(ts);
            t.IsBackground = true;
            t.Start();
        }

        private void ExecutaBackup()
        {
            try
            {
                if (Directory.Exists(ClsUteis.sPastaBackup))
                {
                    btnExecutar.Enabled = false;
                    pbStatus.Visible = true;

                    lblStatus.Text = "Preparando backup!";
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    lblStatus.Text = "Preparando Arquivos!";
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    lblStatus.Text = "Efetuando Backup!!";
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    lblStatus.Text = "Compactando Backup";
                    if (File.Exists(ClsUteis.sPastaBackup + ClsUteis.sArquivoBackup)) File.Delete(ClsUteis.sPastaBackup + ClsUteis.sArquivoBackup);
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    ZipFile.CreateFromDirectory(ClsUteis.sPastaPadrao, ClsUteis.sPastaBackup + ClsUteis.sArquivoBackup);
                    if (pbStatus.Maximum > pbStatus.Value) pbStatus.Value++;
                    lblStatus.Text = "Backup Concluído!!!";
                    pbStatus.Value = 0;
                }
                else
                {
                    MessageBox.Show("Não foi possivel encontrar a pasta destino de backup!!!\r\nVá até o 'Menu Arquivo, Configurações' e defina uma pasta de backup para continuar!!");
                }

                pbStatus.Value = 0;
                btnExecutar.Enabled = true;
            }
            catch (Exception ex)
            {
                ClsLog.FU_Escreve_Log("lblLocalBackup_MouseDoubleClick", ex.Message);
            }
        }

        private void lblLocalBackup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Process.Start(ClsUteis.sPastaBackup);
            }
            catch (Exception ex)
            {
                ClsLog.FU_Escreve_Log("lblLocalBackup_MouseDoubleClick", ex.Message);
            }
        }
    }
}
