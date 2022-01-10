namespace Engenhoca.Telas
{
    partial class frmConfigJanela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigJanela));
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmQuantidadeJanela = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxModoAbertura = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidadeJanela)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(12, 12);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(146, 19);
            this.chkAtivo.TabIndex = 0;
            this.chkAtivo.Text = "Habilitar Configuração";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.chkAtivo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de Janelas:";
            // 
            // nmQuantidadeJanela
            // 
            this.nmQuantidadeJanela.Location = new System.Drawing.Point(12, 52);
            this.nmQuantidadeJanela.Name = "nmQuantidadeJanela";
            this.nmQuantidadeJanela.Size = new System.Drawing.Size(120, 23);
            this.nmQuantidadeJanela.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modo de Abertura:";
            // 
            // cbxModoAbertura
            // 
            this.cbxModoAbertura.BackColor = System.Drawing.Color.White;
            this.cbxModoAbertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModoAbertura.FormattingEnabled = true;
            this.cbxModoAbertura.Items.AddRange(new object[] {
            "NENHUM",
            "CASCATA",
            "VERTICAL",
            "HORIZONTAL"});
            this.cbxModoAbertura.Location = new System.Drawing.Point(12, 96);
            this.cbxModoAbertura.Name = "cbxModoAbertura";
            this.cbxModoAbertura.Size = new System.Drawing.Size(121, 23);
            this.cbxModoAbertura.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(183, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(115, 133);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmConfigJanela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(298, 133);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cbxModoAbertura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmQuantidadeJanela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkAtivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfigJanela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Janelas";
            this.Load += new System.EventHandler(this.frmConfigJanela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantidadeJanela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkAtivo;
        private Label label1;
        private NumericUpDown nmQuantidadeJanela;
        private Label label2;
        private ComboBox cbxModoAbertura;
        private Button btnSalvar;
    }
}