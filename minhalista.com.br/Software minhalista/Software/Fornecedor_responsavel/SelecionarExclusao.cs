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
    public partial class SelecionarExclusao : Form
    {
        public string radio;
        public SelecionarExclusao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                
                radio = "er";
                Close();
                
            }
            else
            {
                
                radio = "erf";
                Close();
            }
            
        }
    }
}
