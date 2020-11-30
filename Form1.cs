using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuxiliadorDeVenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
private void button1_Click(object sender, EventArgs e)
        {

            double ValorC = double.Parse(ValorCompra.Text);
            double ValorL = 0.1;
            double ValorV = ValorC + (ValorC * ValorL);

            MessageBox.Show("Voce devera vender esse produto a R$ " + ValorV);

        }
    }
}
