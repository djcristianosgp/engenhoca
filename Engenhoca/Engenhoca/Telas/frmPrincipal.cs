using Engenhoca.Classes;
using System.Diagnostics;
using System.Reflection;

namespace Engenhoca.Telas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                lblVersao.Text = "Versão: " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " | ";
                lblEstacao.Text = "Estação: " + ClsUteis.sEstacao + " | ";
                MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];
                if (ClsUteis.bImagemFundo)
                {
                    if (File.Exists(ClsUteis.sImagemFundo)) ctlMDI.BackgroundImage = Image.FromFile(ClsUteis.sImagemFundo);
                    else ctlMDI.BackgroundImage = this.BackgroundImage;
                }
                ctlMDI.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                ClsLog.FU_Escreve_Log("frmPrincipal_Load", ex.Message);
            }
        }

        private void miExecArquivoPAT_Click(object sender, EventArgs e)
        {
            frmExecArquivoPAT FormExecPAT = new frmExecArquivoPAT();
            FormExecPAT.MdiParent = this;
            FormExecPAT.Show();
        }

        private void miLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(ClsUteis.sArquivoLog))
            {
                frmLog FormTelaLog = new frmLog();
                FormTelaLog.sArquivoLog = ClsUteis.sArquivoLog;
                FormTelaLog.sArquivo = ClsUteis.sArquivoLog;
                FormTelaLog.MdiParent = this;
                FormTelaLog.Show();
            }
            else MessageBox.Show("Não existe log do sistema para esse mês!!!");
        }

        private void muBackup_Click(object sender, EventArgs e)
        {
            frmBackup FormBackup = new frmBackup();
            FormBackup.MdiParent = this;
            FormBackup.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://www.instagram.com/djcristianosgp/");
            }
            catch (Exception ex)
            {
                ClsLog.FU_Escreve_Log("toolStripStatusLabel1_Click", ex.Message);
            }
        }
    }
}
