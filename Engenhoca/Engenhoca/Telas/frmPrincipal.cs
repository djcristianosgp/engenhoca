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
                ClsExecuta.FU_ExecutaCMD("https://www.instagram.com/djcristianosgp");
            }
            catch (Exception ex)
            {
                ClsLog.FU_Escreve_Log("toolStripStatusLabel1_Click", ex.Message);
            }
        }

        private void miPastasImagens_Click(object sender, EventArgs e)
        {
            ClsExecuta.FU_ExecutaCMD(ClsUteis.sPastaImagens);
        }

        private void miPastasLogs_Click(object sender, EventArgs e)
        {
            ClsExecuta.FU_ExecutaCMD(ClsUteis.sPastaLog);
        }

        private void miPastasProjetos_Click(object sender, EventArgs e)
        {
            ClsExecuta.FU_ExecutaCMD(ClsUteis.sPataProjetos);
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) miExecArquivoPAT.PerformClick();
            if (e.KeyCode == Keys.F12) miPastasProjetos.PerformClick();
        }

        private void miCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void miVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void miHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
