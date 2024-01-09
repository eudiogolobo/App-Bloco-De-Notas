namespace EditorDeTexto
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            colarToolStripMenuItem = new ToolStripMenuItem();
            desfazerToolStripMenuItem = new ToolStripMenuItem();
            refazerToolStripMenuItem = new ToolStripMenuItem();
            formatarToolStripMenuItem1 = new ToolStripMenuItem();
            negritoToolStripMenuItem = new ToolStripMenuItem();
            itálicoToolStripMenuItem = new ToolStripMenuItem();
            sublinhadoToolStripMenuItem = new ToolStripMenuItem();
            alinhamentoToolStripMenuItem = new ToolStripMenuItem();
            centralizarToolStripMenuItem = new ToolStripMenuItem();
            esquerdaToolStripMenuItem = new ToolStripMenuItem();
            direitaToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnNovo = new ToolStripButton();
            btnAbrir = new ToolStripButton();
            btnSalvar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCopiar = new ToolStripButton();
            btnColar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnNegrito = new ToolStripButton();
            btnItalico = new ToolStripButton();
            btnSublinhado = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnEsquerda = new ToolStripButton();
            btnCentro = new ToolStripButton();
            btnDireita = new ToolStripButton();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, formatarToolStripMenuItem, formatarToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, abrirToolStripMenuItem, salvarToolStripMenuItem, toolStripMenuItem1, sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(180, 22);
            novoToolStripMenuItem.Text = "Novo";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(180, 22);
            abrirToolStripMenuItem.Text = "Abrir...";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(180, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // formatarToolStripMenuItem
            // 
            formatarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copiarToolStripMenuItem, colarToolStripMenuItem, desfazerToolStripMenuItem, refazerToolStripMenuItem });
            formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            formatarToolStripMenuItem.Size = new Size(49, 20);
            formatarToolStripMenuItem.Text = "Editar";
            formatarToolStripMenuItem.Click += formatarToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(118, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // colarToolStripMenuItem
            // 
            colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            colarToolStripMenuItem.Size = new Size(118, 22);
            colarToolStripMenuItem.Text = "Colar";
            colarToolStripMenuItem.Click += colarToolStripMenuItem_Click;
            // 
            // desfazerToolStripMenuItem
            // 
            desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            desfazerToolStripMenuItem.Size = new Size(118, 22);
            desfazerToolStripMenuItem.Text = "Desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            refazerToolStripMenuItem.Size = new Size(118, 22);
            refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem1
            // 
            formatarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { negritoToolStripMenuItem, itálicoToolStripMenuItem, sublinhadoToolStripMenuItem, alinhamentoToolStripMenuItem });
            formatarToolStripMenuItem1.Name = "formatarToolStripMenuItem1";
            formatarToolStripMenuItem1.Size = new Size(67, 20);
            formatarToolStripMenuItem1.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            negritoToolStripMenuItem.Size = new Size(143, 22);
            negritoToolStripMenuItem.Text = "Negrito";
            negritoToolStripMenuItem.Click += negritoToolStripMenuItem_Click;
            // 
            // itálicoToolStripMenuItem
            // 
            itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            itálicoToolStripMenuItem.Size = new Size(143, 22);
            itálicoToolStripMenuItem.Text = "Itálico";
            itálicoToolStripMenuItem.Click += itálicoToolStripMenuItem_Click;
            // 
            // sublinhadoToolStripMenuItem
            // 
            sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            sublinhadoToolStripMenuItem.Size = new Size(143, 22);
            sublinhadoToolStripMenuItem.Text = "Sublinhado";
            sublinhadoToolStripMenuItem.Click += sublinhadoToolStripMenuItem_Click;
            // 
            // alinhamentoToolStripMenuItem
            // 
            alinhamentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { centralizarToolStripMenuItem, esquerdaToolStripMenuItem, direitaToolStripMenuItem });
            alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            alinhamentoToolStripMenuItem.Size = new Size(143, 22);
            alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            centralizarToolStripMenuItem.Size = new Size(130, 22);
            centralizarToolStripMenuItem.Text = "Centralizar";
            centralizarToolStripMenuItem.Click += centralizarToolStripMenuItem_Click;
            // 
            // esquerdaToolStripMenuItem
            // 
            esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            esquerdaToolStripMenuItem.Size = new Size(130, 22);
            esquerdaToolStripMenuItem.Text = "Esquerda";
            esquerdaToolStripMenuItem.Click += esquerdaToolStripMenuItem_Click;
            // 
            // direitaToolStripMenuItem
            // 
            direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            direitaToolStripMenuItem.Size = new Size(130, 22);
            direitaToolStripMenuItem.Text = "Direita";
            direitaToolStripMenuItem.Click += direitaToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNovo, btnAbrir, btnSalvar, toolStripSeparator1, btnCopiar, btnColar, toolStripSeparator3, btnNegrito, btnItalico, btnSublinhado, toolStripSeparator2, btnEsquerda, btnCentro, btnDireita });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1264, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNovo
            // 
            btnNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNovo.Image = BlocoDeNotas.Properties.Resources.novo;
            btnNovo.ImageTransparentColor = Color.Magenta;
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(23, 22);
            btnNovo.Text = "Novo";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAbrir.Image = BlocoDeNotas.Properties.Resources.abrir;
            btnAbrir.ImageTransparentColor = Color.Magenta;
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(23, 22);
            btnAbrir.Text = "Abrir";
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSalvar.Image = BlocoDeNotas.Properties.Resources.save;
            btnSalvar.ImageTransparentColor = Color.Magenta;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(23, 22);
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnCopiar
            // 
            btnCopiar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCopiar.Image = BlocoDeNotas.Properties.Resources.copy;
            btnCopiar.ImageTransparentColor = Color.Magenta;
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(23, 22);
            btnCopiar.Text = "toolStripButton1";
            btnCopiar.ToolTipText = "Copiar";
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnColar
            // 
            btnColar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnColar.Image = BlocoDeNotas.Properties.Resources.colar;
            btnColar.ImageTransparentColor = Color.Magenta;
            btnColar.Name = "btnColar";
            btnColar.Size = new Size(23, 22);
            btnColar.Text = "toolStripButton1";
            btnColar.ToolTipText = "Colar";
            btnColar.Click += btnColar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnNegrito
            // 
            btnNegrito.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNegrito.Image = BlocoDeNotas.Properties.Resources.bold;
            btnNegrito.ImageTransparentColor = Color.Magenta;
            btnNegrito.Name = "btnNegrito";
            btnNegrito.Size = new Size(23, 22);
            btnNegrito.Text = "Negrito";
            btnNegrito.Click += btnNegrito_Click;
            // 
            // btnItalico
            // 
            btnItalico.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnItalico.Image = BlocoDeNotas.Properties.Resources.italic;
            btnItalico.ImageTransparentColor = Color.Magenta;
            btnItalico.Name = "btnItalico";
            btnItalico.Size = new Size(23, 22);
            btnItalico.Text = "Itálico";
            btnItalico.Click += btnItalico_Click;
            // 
            // btnSublinhado
            // 
            btnSublinhado.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSublinhado.Image = (Image)resources.GetObject("btnSublinhado.Image");
            btnSublinhado.ImageTransparentColor = Color.Magenta;
            btnSublinhado.Name = "btnSublinhado";
            btnSublinhado.Size = new Size(23, 22);
            btnSublinhado.Text = "Sublinhado";
            btnSublinhado.Click += btnSublinhado_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnEsquerda
            // 
            btnEsquerda.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEsquerda.Image = BlocoDeNotas.Properties.Resources.left;
            btnEsquerda.ImageTransparentColor = Color.Magenta;
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(23, 22);
            btnEsquerda.Text = "Esquerda";
            btnEsquerda.Click += btnEsquerda_Click;
            // 
            // btnCentro
            // 
            btnCentro.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCentro.Image = BlocoDeNotas.Properties.Resources.centro;
            btnCentro.ImageTransparentColor = Color.Magenta;
            btnCentro.Name = "btnCentro";
            btnCentro.Size = new Size(23, 22);
            btnCentro.Text = "Centralizar";
            btnCentro.Click += btnCentro_Click;
            // 
            // btnDireita
            // 
            btnDireita.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDireita.Image = BlocoDeNotas.Properties.Resources.right;
            btnDireita.ImageTransparentColor = Color.Magenta;
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(23, 22);
            btnDireita.Text = "Direita";
            btnDireita.Click += btnDireita_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.EnableAutoDragDrop = true;
            richTextBox1.Location = new Point(0, 49);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(1264, 632);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(richTextBox1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BLOCO DE NOTAS";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem salvarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem colarToolStripMenuItem;
        private ToolStripMenuItem desfazerToolStripMenuItem;
        private ToolStripMenuItem refazerToolStripMenuItem;
        private ToolStripMenuItem formatarToolStripMenuItem1;
        private ToolStripMenuItem negritoToolStripMenuItem;
        private ToolStripMenuItem itálicoToolStripMenuItem;
        private ToolStripMenuItem sublinhadoToolStripMenuItem;
        private ToolStripMenuItem alinhamentoToolStripMenuItem;
        private ToolStripMenuItem centralizarToolStripMenuItem;
        private ToolStripMenuItem esquerdaToolStripMenuItem;
        private ToolStripMenuItem direitaToolStripMenuItem;
        private ToolStripButton btnNovo;
        private ToolStripButton btnAbrir;
        private ToolStripButton btnSalvar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnCopiar;
        private ToolStripButton btnColar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnNegrito;
        private ToolStripButton btnItalico;
        private ToolStripButton btnSublinhado;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnEsquerda;
        private ToolStripButton btnCentro;
        private ToolStripButton btnDireita;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private RichTextBox richTextBox1;
    }
}
