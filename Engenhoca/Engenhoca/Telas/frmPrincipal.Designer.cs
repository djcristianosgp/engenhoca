namespace Engenhoca.Telas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.miLog = new System.Windows.Forms.ToolStripMenuItem();
            this.miPastas = new System.Windows.Forms.ToolStripMenuItem();
            this.miPastasImagens = new System.Windows.Forms.ToolStripMenuItem();
            this.miPastasLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.miPastasProjetos = new System.Windows.Forms.ToolStripMenuItem();
            this.muExecutar = new System.Windows.Forms.ToolStripMenuItem();
            this.miExecArquivoPAT = new System.Windows.Forms.ToolStripMenuItem();
            this.muBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.muJanelas = new System.Windows.Forms.ToolStripMenuItem();
            this.miCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.miVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.miHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstacao = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.miJanelaConfiguracao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muArquivo,
            this.muExecutar,
            this.muBackup,
            this.muJanelas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.muJanelas;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muArquivo
            // 
            this.muArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLog,
            this.miPastas});
            this.muArquivo.Image = ((System.Drawing.Image)(resources.GetObject("muArquivo.Image")));
            this.muArquivo.Name = "muArquivo";
            this.muArquivo.Size = new System.Drawing.Size(85, 23);
            this.muArquivo.Text = "Arquivo";
            // 
            // miLog
            // 
            this.miLog.Image = ((System.Drawing.Image)(resources.GetObject("miLog.Image")));
            this.miLog.Name = "miLog";
            this.miLog.Size = new System.Drawing.Size(117, 24);
            this.miLog.Text = "Log";
            this.miLog.Click += new System.EventHandler(this.miLog_Click);
            // 
            // miPastas
            // 
            this.miPastas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPastasImagens,
            this.miPastasLogs,
            this.miPastasProjetos});
            this.miPastas.Image = ((System.Drawing.Image)(resources.GetObject("miPastas.Image")));
            this.miPastas.Name = "miPastas";
            this.miPastas.Size = new System.Drawing.Size(117, 24);
            this.miPastas.Text = "Pastas";
            // 
            // miPastasImagens
            // 
            this.miPastasImagens.Image = ((System.Drawing.Image)(resources.GetObject("miPastasImagens.Image")));
            this.miPastasImagens.Name = "miPastasImagens";
            this.miPastasImagens.Size = new System.Drawing.Size(163, 24);
            this.miPastasImagens.Text = "Imagens";
            this.miPastasImagens.Click += new System.EventHandler(this.miPastasImagens_Click);
            // 
            // miPastasLogs
            // 
            this.miPastasLogs.Image = ((System.Drawing.Image)(resources.GetObject("miPastasLogs.Image")));
            this.miPastasLogs.Name = "miPastasLogs";
            this.miPastasLogs.Size = new System.Drawing.Size(163, 24);
            this.miPastasLogs.Text = "Logs";
            this.miPastasLogs.Click += new System.EventHandler(this.miPastasLogs_Click);
            // 
            // miPastasProjetos
            // 
            this.miPastasProjetos.Image = ((System.Drawing.Image)(resources.GetObject("miPastasProjetos.Image")));
            this.miPastasProjetos.Name = "miPastasProjetos";
            this.miPastasProjetos.Size = new System.Drawing.Size(163, 24);
            this.miPastasProjetos.Text = "Projetos (F12)";
            this.miPastasProjetos.Click += new System.EventHandler(this.miPastasProjetos_Click);
            // 
            // muExecutar
            // 
            this.muExecutar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExecArquivoPAT});
            this.muExecutar.Image = ((System.Drawing.Image)(resources.GetObject("muExecutar.Image")));
            this.muExecutar.Name = "muExecutar";
            this.muExecutar.Size = new System.Drawing.Size(88, 23);
            this.muExecutar.Text = "Executar";
            // 
            // miExecArquivoPAT
            // 
            this.miExecArquivoPAT.Image = ((System.Drawing.Image)(resources.GetObject("miExecArquivoPAT.Image")));
            this.miExecArquivoPAT.Name = "miExecArquivoPAT";
            this.miExecArquivoPAT.Size = new System.Drawing.Size(182, 24);
            this.miExecArquivoPAT.Text = "Arquivo .PAT (F2)";
            this.miExecArquivoPAT.Click += new System.EventHandler(this.miExecArquivoPAT_Click);
            // 
            // muBackup
            // 
            this.muBackup.Image = ((System.Drawing.Image)(resources.GetObject("muBackup.Image")));
            this.muBackup.Name = "muBackup";
            this.muBackup.Size = new System.Drawing.Size(81, 23);
            this.muBackup.Text = "Backup";
            this.muBackup.Click += new System.EventHandler(this.muBackup_Click);
            // 
            // muJanelas
            // 
            this.muJanelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCascata,
            this.miVertical,
            this.miHorizontal,
            this.miJanelaConfiguracao,
            this.toolStripSeparator1});
            this.muJanelas.Image = ((System.Drawing.Image)(resources.GetObject("muJanelas.Image")));
            this.muJanelas.Name = "muJanelas";
            this.muJanelas.Size = new System.Drawing.Size(80, 23);
            this.muJanelas.Text = "Janelas";
            // 
            // miCascata
            // 
            this.miCascata.Name = "miCascata";
            this.miCascata.Size = new System.Drawing.Size(180, 24);
            this.miCascata.Text = "Cascata";
            this.miCascata.Click += new System.EventHandler(this.miCascata_Click);
            // 
            // miVertical
            // 
            this.miVertical.Name = "miVertical";
            this.miVertical.Size = new System.Drawing.Size(180, 24);
            this.miVertical.Text = "Vertical";
            this.miVertical.Click += new System.EventHandler(this.miVertical_Click);
            // 
            // miHorizontal
            // 
            this.miHorizontal.Name = "miHorizontal";
            this.miHorizontal.Size = new System.Drawing.Size(180, 24);
            this.miHorizontal.Text = "Horizontal";
            this.miHorizontal.Click += new System.EventHandler(this.miHorizontal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVersao,
            this.lblEstacao,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVersao
            // 
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(118, 17);
            this.lblVersao.Text = "toolStripStatusLabel1";
            // 
            // lblEstacao
            // 
            this.lblEstacao.Name = "lblEstacao";
            this.lblEstacao.Size = new System.Drawing.Size(118, 17);
            this.lblEstacao.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.Image")));
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(217, 17);
            this.toolStripStatusLabel1.Text = "Desenvolvido por: Cristiano Grobério";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // miJanelaConfiguracao
            // 
            this.miJanelaConfiguracao.Name = "miJanelaConfiguracao";
            this.miJanelaConfiguracao.Size = new System.Drawing.Size(180, 24);
            this.miJanelaConfiguracao.Text = "Configuração";
            this.miJanelaConfiguracao.Click += new System.EventHandler(this.miJanelaConfiguracao_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engenhoca - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblVersao;
        private ToolStripStatusLabel lblEstacao;
        private ToolStripMenuItem muArquivo;
        private ToolStripMenuItem miLog;
        private ToolStripMenuItem muExecutar;
        private ToolStripMenuItem miExecArquivoPAT;
        private ToolStripMenuItem muBackup;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem miPastas;
        private ToolStripMenuItem miPastasImagens;
        private ToolStripMenuItem miPastasLogs;
        private ToolStripMenuItem miPastasProjetos;
        private ToolStripMenuItem muJanelas;
        private ToolStripMenuItem miCascata;
        private ToolStripMenuItem miVertical;
        private ToolStripMenuItem miHorizontal;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem miJanelaConfiguracao;
    }
}