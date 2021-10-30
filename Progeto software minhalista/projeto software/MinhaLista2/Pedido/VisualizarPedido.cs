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
            label3.Text = ID_pedido + "\n" + data_entrada + "\n" + horario_entrada + "\n" + operadora + "\n" + forma_pagamento + "\n" + data_saida + "\n" + horario_saida + "\n" + status + "\n" + ID_funcionario + "\n" + ID_cliente;

        }
      


    }
}
