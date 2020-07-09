namespace GameCubeBackupManager
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarListaDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrincipalExit = new System.Windows.Forms.ToolStripMenuItem();
            this.capasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizarEBaixarCapasSomente3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizarEBaixarCapastodasAsCapasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrincipalConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.capasToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ferramentasToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(1328, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStripPrincipal";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarListaToolStripMenuItem,
            this.exportarListaDeJogosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmiPrincipalExit});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // atualizarListaToolStripMenuItem
            // 
            this.atualizarListaToolStripMenuItem.Name = "atualizarListaToolStripMenuItem";
            this.atualizarListaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.atualizarListaToolStripMenuItem.Text = "Atualizar lista";
            // 
            // exportarListaDeJogosToolStripMenuItem
            // 
            this.exportarListaDeJogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarParaCSVToolStripMenuItem,
            this.exportarParaTXTToolStripMenuItem});
            this.exportarListaDeJogosToolStripMenuItem.Name = "exportarListaDeJogosToolStripMenuItem";
            this.exportarListaDeJogosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exportarListaDeJogosToolStripMenuItem.Text = "Exportar lista de jogos";
            // 
            // exportarParaCSVToolStripMenuItem
            // 
            this.exportarParaCSVToolStripMenuItem.Name = "exportarParaCSVToolStripMenuItem";
            this.exportarParaCSVToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exportarParaCSVToolStripMenuItem.Text = "Exportar para CSV";
            // 
            // exportarParaTXTToolStripMenuItem
            // 
            this.exportarParaTXTToolStripMenuItem.Name = "exportarParaTXTToolStripMenuItem";
            this.exportarParaTXTToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exportarParaTXTToolStripMenuItem.Text = "Exportar para TXT";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmiPrincipalExit
            // 
            this.tsmiPrincipalExit.Name = "tsmiPrincipalExit";
            this.tsmiPrincipalExit.Size = new System.Drawing.Size(190, 22);
            this.tsmiPrincipalExit.Text = "Sair";
            this.tsmiPrincipalExit.Click += new System.EventHandler(this.tsmiPrincipalExit_Click);
            // 
            // capasToolStripMenuItem
            // 
            this.capasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sincronizarEBaixarCapasSomente3DToolStripMenuItem,
            this.sincronizarEBaixarCapastodasAsCapasToolStripMenuItem});
            this.capasToolStripMenuItem.Name = "capasToolStripMenuItem";
            this.capasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.capasToolStripMenuItem.Text = "Capas";
            // 
            // sincronizarEBaixarCapasSomente3DToolStripMenuItem
            // 
            this.sincronizarEBaixarCapasSomente3DToolStripMenuItem.Name = "sincronizarEBaixarCapasSomente3DToolStripMenuItem";
            this.sincronizarEBaixarCapasSomente3DToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.sincronizarEBaixarCapasSomente3DToolStripMenuItem.Text = "Sincronizar e baixar capas (somente Disco e 3D)";
            // 
            // sincronizarEBaixarCapastodasAsCapasToolStripMenuItem
            // 
            this.sincronizarEBaixarCapastodasAsCapasToolStripMenuItem.Name = "sincronizarEBaixarCapastodasAsCapasToolStripMenuItem";
            this.sincronizarEBaixarCapastodasAsCapasToolStripMenuItem.Size = new System.Drawing.Size(324, 22);
            this.sincronizarEBaixarCapastodasAsCapasToolStripMenuItem.Text = "Sincronizar e baixar capas (todas as capas)";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPrincipalConfig});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // tsmiPrincipalConfig
            // 
            this.tsmiPrincipalConfig.Name = "tsmiPrincipalConfig";
            this.tsmiPrincipalConfig.Size = new System.Drawing.Size(180, 22);
            this.tsmiPrincipalConfig.Text = "Configurações...";
            this.tsmiPrincipalConfig.Click += new System.EventHandler(this.tsmiConfig_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 542);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BoxArt";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1328, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(218, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 533);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(757, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Disco";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1090, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informações Adicionais";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1090, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Downloads";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1090, 447);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Base de Dados";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1090, 447);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Log";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 404);
            this.dataGridView1.TabIndex = 1;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 594);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripPrincipal);
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameCube Backup Manager";
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarListaDeJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarParaTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrincipalExit;
        private System.Windows.Forms.ToolStripMenuItem capasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sincronizarEBaixarCapasSomente3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sincronizarEBaixarCapastodasAsCapasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrincipalConfig;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

