using Engenhoca.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenhoca.Telas
{
    public partial class frmConfigJanela : Form
    {
        public frmConfigJanela()
        {
            InitializeComponent();
        }

        private void frmConfigJanela_Load(object sender, EventArgs e)
        {
            cbxModoAbertura.SelectedIndex = 0;
            Inicializa();
        }

        private void Inicializa()
        {
            if (File.Exists(ClsUteis.sConfiJanela))
            {
                bool jbAtivo = false;
                int jiJanelas = 0;
                string jsModo = "NENHUM";
                StreamReader srArquivoConfig = new StreamReader(ClsUteis.sConfiJanela);
                String linha;
                // Lê linha por linha
                while ((linha = srArquivoConfig.ReadLine()) != null)
                {
                    if (linha.Split('=')[0].ToString() == "ATIVO") jbAtivo = Convert.ToBoolean(linha.Split('=')[1].ToString());
                    if (linha.Split('=')[0].ToString() == "JANELAS") jiJanelas = Convert.ToInt32(linha.Split('=')[1].ToString());
                    if (linha.Split('=')[0].ToString() == "MODO") jsModo = linha.Split('=')[1].ToString();
                }
                srArquivoConfig.Close();
                chkAtivo.Checked = jbAtivo;
                nmQuantidadeJanela.Value = jiJanelas;
                cbxModoAbertura.Text = jsModo;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sArquivo = new StreamWriter(ClsUteis.sConfiJanela);
                sArquivo.WriteLine("[CONFIGURAÇÕES JANELA]");
                sArquivo.WriteLine("ATIVO=" + chkAtivo.Checked);
                sArquivo.WriteLine("JANELAS=" + nmQuantidadeJanela.Value);
                sArquivo.WriteLine("MODO=" + cbxModoAbertura.SelectedItem.ToString());
                sArquivo.Close();
                MessageBox.Show("Configuração salva com sucesso!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAtivo.Checked)
            {
                nmQuantidadeJanela.Enabled = true;
                cbxModoAbertura.Enabled = true;
            }
            else
            {
                nmQuantidadeJanela.Enabled = false;
                cbxModoAbertura.Enabled = false;
            }
        }
    }
}
