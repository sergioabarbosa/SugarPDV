namespace SugarPDV
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.NovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Arquivo,
            this.Cadastro,
            this.Vendas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Arquivo
            // 
            this.Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sair});
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Arquivo.Text = "Arquivo";
            this.Arquivo.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Sair
            // 
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(93, 22);
            this.Sair.Text = "Sair";
            // 
            // Cadastro
            // 
            this.Cadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Produtos,
            this.Clientes});
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(66, 20);
            this.Cadastro.Text = "Cadastro";
            // 
            // Produtos
            // 
            this.Produtos.Name = "Produtos";
            this.Produtos.Size = new System.Drawing.Size(122, 22);
            this.Produtos.Text = "Produtos";
            // 
            // Clientes
            // 
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(122, 22);
            this.Clientes.Text = "Clientes";
            // 
            // Vendas
            // 
            this.Vendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovaVenda});
            this.Vendas.Name = "Vendas";
            this.Vendas.Size = new System.Drawing.Size(56, 20);
            this.Vendas.Text = "Vendas";
            // 
            // NovaVenda
            // 
            this.NovaVenda.Name = "NovaVenda";
            this.NovaVenda.Size = new System.Drawing.Size(137, 22);
            this.NovaVenda.Text = "Nova Venda";
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(178, 312);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.Size = new System.Drawing.Size(405, 180);
            this.dgvCarrinho.TabIndex = 1;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(178, 263);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(158, 23);
            this.btnAdicionarProduto.TabIndex = 2;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click_1);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(427, 152);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(156, 20);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(427, 113);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(156, 20);
            this.txtIdProduto.TabIndex = 4;
            this.txtIdProduto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(427, 186);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(156, 20);
            this.txtPrecoProduto.TabIndex = 5;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Location = new System.Drawing.Point(175, 116);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(73, 13);
            this.lblIdProduto.TabIndex = 6;
            this.lblIdProduto.Text = "ID do Produto";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(175, 155);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.lblNomeProduto.TabIndex = 7;
            this.lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Location = new System.Drawing.Point(175, 193);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(90, 13);
            this.lblPrecoProduto.TabIndex = 8;
            this.lblPrecoProduto.Text = "Preço do Produto";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(424, 495);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: R$ 0,00";
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(410, 263);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(173, 23);
            this.btnFinalizarVenda.TabIndex = 10;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(367, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Sugar PDV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnFinalizarVenda);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecoProduto);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ToolStripMenuItem Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Cadastro;
        private System.Windows.Forms.ToolStripMenuItem Vendas;
        private System.Windows.Forms.ToolStripMenuItem Sair;
        private System.Windows.Forms.ToolStripMenuItem Produtos;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem NovaVenda;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.Label lblTitle;
    }
}

