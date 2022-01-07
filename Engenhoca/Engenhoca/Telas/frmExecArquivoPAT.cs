using Engenhoca.Classes;

namespace Engenhoca.Telas
{
    public partial class frmExecArquivoPAT : Form
    {
        public frmExecArquivoPAT()
        {
            InitializeComponent();
        }

        string sModelo = ";%UNITS=MM \r\n" +
            "*Hachura {0}×{1} \r\n" +
            ";%TYPE=MODEL \r\n" +
            "0, 0,0, 0,{0} \r\n" +
            "90, 0,0, {0},{2}, {0},-{0}";

        private void txtLargura_TextChanged(object sender, EventArgs e)
        {
            MontaString();
        }

        private void txtComprimento_TextChanged(object sender, EventArgs e)
        {
            MontaString();
        }

        private void txtLargura_Leave(object sender, EventArgs e)
        {
            MontaString();
        }

        private void txtComprimento_Leave(object sender, EventArgs e)
        {
            MontaString();
        }

        public bool Valida()
        {
            bool bretorno = false;
            if (txtLargura.Text != string.Empty) bretorno = true;
            else bretorno = false;
            if (txtComprimento.Text != string.Empty) bretorno = true;
            else bretorno = false;            

            return bretorno;
        }
        public void MontaString()
        {
            if (Valida())
            {
                try
                {
                    txtDemo.Text = String.Format(sModelo, txtLargura.Text, txtComprimento.Text, CalculoCompimento(txtComprimento.Text));
                }
                catch (Exception ex)
                {
                    ClsLog.FU_Escreve_Log("MontaString", ex.Message);
                }
            }
        }

        private static string CalculoCompimento(string sComprimento)
        {
            int iComprimento= Convert.ToInt32(sComprimento);
            string sRetorno = "";
            sRetorno = (iComprimento / 2).ToString();
            return sRetorno;
        }

        private void frmExecArquivoPAT_Load(object sender, EventArgs e)
        {

        }

        private void Limpar()
        {
            txtComprimento.Clear();
            txtLargura.Clear();
            txtDemo.Clear();
            txtNomeArquivo.Clear();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(Valida() && txtNomeArquivo.Text != String.Empty)
            {
                MontaString();
                ClsArquivoPAT.FUEscreveArquivo(txtNomeArquivo.Text, txtDemo.Text);
                MessageBox.Show("Arquivo salvo com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpar();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos para continuar!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtLargura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtComprimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomeArquivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                offSelectArquivo.InitialDirectory = ClsUteis.sPataProjetos;
                if (offSelectArquivo.ShowDialog() == DialogResult.OK)
                {
                    txtNomeArquivo.Text = offSelectArquivo.SafeFileName.ToUpper().Replace(".PAT","");
                    txtDemo.Text = File.ReadAllText(offSelectArquivo.FileName);
                    var sArquivoLido = File.ReadAllLines(offSelectArquivo.FileName);
                    for(int iContador = 0; iContador< sArquivoLido.Count(); iContador++)
                    {
                        if(sArquivoLido[iContador].ToString().Contains("Hachura"))
                        {
                            string[] sSplint01 = sArquivoLido[iContador].ToString().Split(' ');
                            txtLargura.Text = sSplint01[1].Split('×')[0].ToString();
                            txtComprimento.Text = sSplint01[1].Split('×')[1].ToString();
                        }
                    }
                }
            }
        }
    }
}
