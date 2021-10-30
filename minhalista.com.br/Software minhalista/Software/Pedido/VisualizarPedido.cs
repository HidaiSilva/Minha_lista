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
    public partial class VisualizarPedido : Form
    {
        public string ID_pedido,data_entrada,horario_entrada,operadora,forma_pagamento,data_saida,horario_saida,status,ID_funcionario,ID_cliente;

        public VisualizarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VisualizarPedido_Load(object sender, EventArgs e)
        {
            label3.Text = "Identificação do pedido: " + ID_pedido + "\n" + "Data de entrada: " + data_entrada + "\n" + "Horario de entrada: " + horario_entrada + "\n" + "Operadora: " + operadora + "\n" + "Forma de pagamento: " + forma_pagamento + "\n" + "Data de saida: " + data_saida + "\n" + "Horario de saida: " + horario_saida + "\n" + "Status: " + status + "\n" + "Identificação do funcinario: " + ID_funcionario + "\n" + "Identificação do cliente: " + ID_cliente;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
      


    }
}
