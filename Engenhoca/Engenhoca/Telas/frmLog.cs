namespace Engenhoca.Telas
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }
        public string sArquivoLog = "";
        public string sArquivo = "";
        public bool bEdita = false;

        private void frmLog_Load(object sender, EventArgs e)
        {
            txtTexto.Dock = DockStyle.Fill;
            tiAtualiza.Interval = 60000;
            tiAtualiza.Start();
            this.Text = this.Text + " - " + sArquivo;
            LerArquivo();
            if (bEdita)
            {
                tiAtualiza.Stop();
                txtTexto.ReadOnly = false;
            }
        }

        public void LerArquivo()
        {
            try
            {
                string sTexto = File.ReadAllText(sArquivoLog);
                txtTexto.Text = sTexto.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tiAtualiza_Tick(object sender, EventArgs e)
        {
            LerArquivo();
        }
    }
}
