namespace Engenhoca.Telas
{
    partial class frmExecArquivoPAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExecArquivoPAT));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomeArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDemo = new System.Windows.Forms.RichTextBox();
            this.offSelectArquivo = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNomeArquivo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 140);
            this.panel1.TabIndex = 0;
            // 
            // txtNomeArquivo
            // 
            this.txtNomeArquivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeArquivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNomeArquivo.Location = new System.Drawing.Point(200, 21);
            this.txtNomeArquivo.Name = "txtNomeArquivo";
            this.txtNomeArquivo.Size = new System.Drawing.Size(380, 23);
            this.txtNomeArquivo.TabIndex = 2;
            this.txtNomeArquivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeArquivo_KeyDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Arquivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(580, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 140);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComprimento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLargura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimensões:";
            // 
            // txtComprimento
            // 
            this.txtComprimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtComprimento.Location = new System.Drawing.Point(3, 84);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(194, 23);
            this.txtComprimento.TabIndex = 1;
            this.txtComprimento.TextChanged += new System.EventHandler(this.txtComprimento_TextChanged);
            this.txtComprimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComprimento_KeyPress);
            this.txtComprimento.Leave += new System.EventHandler(this.txtComprimento_Leave);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comprimento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLargura
            // 
            this.txtLargura.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLargura.Location = new System.Drawing.Point(3, 40);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(194, 23);
            this.txtLargura.TabIndex = 0;
            this.txtLargura.TextChanged += new System.EventHandler(this.txtLargura_TextChanged);
            this.txtLargura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLargura_KeyPress);
            this.txtLargura.Leave += new System.EventHandler(this.txtLargura_Leave);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largura:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(671, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Demonstração:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDemo
            // 
            this.txtDemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDemo.Location = new System.Drawing.Point(0, 161);
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.ReadOnly = true;
            this.txtDemo.Size = new System.Drawing.Size(671, 185);
            this.txtDemo.TabIndex = 3;
            this.txtDemo.Text = "";
            // 
            // offSelectArquivo
            // 
            this.offSelectArquivo.Filter = "Arquivo PAT|*.pat";
            // 
            // frmExecArquivoPAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 346);
            this.Controls.Add(this.txtDemo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExecArquivoPAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arquivo PAT";
            this.Load += new System.EventHandler(this.frmExecArquivoPAT_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtNomeArquivo;
        private Label label1;
        private Button btnSalvar;
        private GroupBox groupBox1;
        private TextBox txtComprimento;
        private Label label3;
        private TextBox txtLargura;
        private Label label2;
        private Label label4;
        private RichTextBox txtDemo;
        private OpenFileDialog offSelectArquivo;
    }
}