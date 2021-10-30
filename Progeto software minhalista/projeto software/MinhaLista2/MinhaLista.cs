using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


 
namespace MinhaLista
{

    

    public partial class MinhaLista : Form
    {
        public MinhaLista()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto altprod = new Produto();
            altprod.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produto altprod = new Produto();
            altprod.ShowDialog();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             Produto altprod = new Produto();
            altprod.ShowDialog();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido ppend = new Pedido();
            ppend.ShowDialog();
        }

        private void históricoDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistóricoPedido histped = new HistóricoPedido();
            histped.ShowDialog();
        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Funcionario ausu = new Funcionario();
            ausu.ShowDialog();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Funcionario ausu = new Funcionario();
            ausu.ShowDialog();

        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Funcionario ausu = new Funcionario();
            ausu.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FornecedorResponsavel altforn = new FornecedorResponsavel();
            altforn.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedorResponsavel altforn = new FornecedorResponsavel();
            altforn.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedorResponsavel altforn = new FornecedorResponsavel();
            altforn.ShowDialog();
        }

        private void MinhaLista_Load(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto altprod = new Produto();
            altprod.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario ausu = new Funcionario();
            ausu.ShowDialog();
        }

        private void fornecedorResponsavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FornecedorResponsavel altforn = new FornecedorResponsavel();
            altforn.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCliente vcliente = new VerCliente();
            vcliente.ShowDialog();
        }
    }
}
