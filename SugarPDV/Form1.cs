using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SugarPDV
{
    public partial class Form1 : Form
    {
        private Carrinho carrinho;

        public Form1()
        {
            InitializeComponent();
            carrinho = new Carrinho();

            // Configurações de estilo
            this.BackColor = Color.LightGray; // Define a cor de fundo do formulário
            this.Font = new Font("Arial", 10, FontStyle.Regular); // Define a fonte padrão
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Define o tipo de borda do formulário
            

            // Configurações do Label
            lblTotal.Text = "Total: R$ 0,00"; // Define o texto do Label
            lblTotal.Font = new Font("Arial", 10, FontStyle.Bold); // Define a fonte do Label
            lblTotal.ForeColor = Color.Black; // Define a cor do texto do Label
            lblTitle.Text = "SugarPDV"; // Define o texto do Label
            lblTitle.Font = new Font("Arial", 20, FontStyle.Bold); // Define a fonte do Label
            lblTitle.ForeColor = Color.Green; // Define a cor do texto do Label

            // Configurações do TextBox IdProduto
            txtIdProduto.Font = new Font("Arial", 10, FontStyle.Regular); // Define a fonte do TextBox
            txtIdProduto.ForeColor = Color.Black; // Define a cor do texto do TextBox

            // Configurações do TextBox NomeProduto
            txtNomeProduto.Font = new Font("Arial", 10, FontStyle.Regular); // Define a fonte do TextBox
            txtNomeProduto.ForeColor = Color.Black; // Define a cor do texto do TextBox

            // Configurações do TextBox PrecoProduto
            txtPrecoProduto.Font = new Font("Arial", 10, FontStyle.Regular); // Define a fonte do TextBox
            txtPrecoProduto.ForeColor = Color.Black; // Define a cor do texto do TextBox

            // Configurações do Button AdicionarProduto
            btnAdicionarProduto.Text = "Adicionar Produto"; // Define o texto do Button
            btnAdicionarProduto.Font = new Font("Arial", 10, FontStyle.Bold); // Define a fonte do Button
            btnAdicionarProduto.ForeColor = Color.Black; // Define a cor do texto do Button
            btnAdicionarProduto.BackColor = Color.White; // Define a cor de fundo do Button
            btnAdicionarProduto.FlatStyle = FlatStyle.Flat; // Define o estilo do Button
            btnAdicionarProduto.FlatAppearance.BorderSize = 1; // Define a largura da borda do Button
            btnAdicionarProduto.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda do Button
            btnAdicionarProduto.FlatStyle = FlatStyle.Flat; //Define o estilo do Button
            btnAdicionarProduto.FlatAppearance.BorderSize = 1; // Define a largura da borda do Button
            btnAdicionarProduto.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda do Button

            // Configurações do Button FinalizarVenda
            btnFinalizarVenda.Text = "Finalizar Venda"; // Define o texto do Button
            btnFinalizarVenda.Font = new Font("Arial", 10, FontStyle.Bold); // Define a fonte do Button
            btnFinalizarVenda.ForeColor = Color.Black; // Define a cor do texto do Button
            btnFinalizarVenda.BackColor = Color.White; // Define a cor de fundo do Button
            btnFinalizarVenda.FlatStyle = FlatStyle.Flat; // Define o estilo do Button
            btnFinalizarVenda.FlatAppearance.BorderSize = 1; // Define a largura da borda do Button
            btnFinalizarVenda.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda do Button
            btnFinalizarVenda.FlatStyle = FlatStyle.Flat; //Define o estilo do Button
            btnFinalizarVenda.FlatAppearance.BorderSize = 1; // Define a largura da borda do Button
            btnFinalizarVenda.FlatAppearance.BorderColor = Color.Black; // Define a cor da borda do Button


            // Configurações do DataGridView
            dgvCarrinho.BackgroundColor = Color.White; // Define a cor de fundo do DataGridView
            dgvCarrinho.BorderStyle = BorderStyle.Fixed3D; // Define o estilo da borda do DataGridView
            dgvCarrinho.Font = new Font("Arial", 10, FontStyle.Regular); // Define a fonte padrão do DataGridView
            dgvCarrinho.ReadOnly = true; // Define o DataGridView como somente leitura
            dgvCarrinho.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Define o modo de seleção de linhas do DataGridView
            dgvCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Define o modo de ajuste automático das colunas do DataGridView
            dgvCarrinho.AllowUserToAddRows = false; // Define que o usuário não pode adicionar linhas manualmente
            dgvCarrinho.AllowUserToDeleteRows = false; // Define que o usuário não pode deletar linhas manualmente
            dgvCarrinho.AllowUserToResizeColumns = false; // Define que o usuário não pode redimensionar as colunas manualmente
            dgvCarrinho.AllowUserToResizeRows = false; // Define que o usuário não pode redimensionar as linhas manualmente
            dgvCarrinho.RowHeadersVisible = false; // Define que a coluna de cabeçalho de linhas não é visível
            dgvCarrinho.ColumnHeadersVisible = true; // Define que a linha de cabeçalho de colunas é visível
            dgvCarrinho.DataSource = carrinho.GetItens(); // Define a fonte de dados do DataGridView

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Implementar lógica de itens do menu, se necessário
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Implementar lógica para itens do menu, se necessário
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Implementar lógica para alterações no textbox, se necessário
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar componentes e lógica ao carregar o formulário, se necessário
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto
                {
                    Id = int.Parse(txtIdProduto.Text),
                    Nome = txtNomeProduto.Text,
                    Preco = decimal.Parse(txtPrecoProduto.Text)
                };

                carrinho.AdicionarProduto(produto);
                AtualizarCarrinho();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total da venda: R$ {carrinho.CalcularTotal()}", "Venda Finalizada");
            carrinho = new Carrinho();
            AtualizarCarrinho();
        }

        private void AtualizarCarrinho()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = carrinho.GetItens();
            lblTotal.Text = $"Total: R$ {carrinho.CalcularTotal()}";
        }

        private void LimparCampos()
        {
            txtIdProduto.Clear();
            txtNomeProduto.Clear();
            txtPrecoProduto.Clear();
        }

        private void btnAdicionarProduto_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    Produto produto = new Produto
                    {
                        Id = int.Parse(txtIdProduto.Text),
                        Nome = txtNomeProduto.Text,
                        Preco = decimal.Parse(txtPrecoProduto.Text)
                    };

                    carrinho.AdicionarProduto(produto);
                    AtualizarCarrinho();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
                }
            }
        }

        private void btnFinalizarVenda_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Total da venda: R$ {carrinho.CalcularTotal()}", "Venda Finalizada");
            carrinho = new Carrinho();
            AtualizarCarrinho();
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }

    public class Carrinho
    {
        private List<Produto> itens;

        public Carrinho()
        {
            itens = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            itens.Add(produto);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in itens)
            {
                total += item.Preco;
            }
            return total;
        }

        public List<Produto> GetItens()
        {
            return itens;
        }
    }
}
