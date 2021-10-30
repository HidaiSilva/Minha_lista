using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace acessoBD_incluir
{
    public partial class Form5 : Form
    {
  
        private string criterio = "";
        public string sqlString = "";

        public Form5()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            criterio = txtNome.Text.ToString();
            if (criterio != "")
            {
                sqlString = "SELECT * FROM Clientes Where nome LIKE '" + criterio + "%'";
                this.Close();
            }
            else
            {
                MessageBox.Show("Informe o nome a procurar com pelo menos um caractere.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
