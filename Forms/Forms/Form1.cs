using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    
    public partial class Form1 : Form
    {
        //variaveis
        private List<prenda> hohoho;

        //eventos
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            string n = tNome.Text;
            string p = tPeso.Text;                  
            string a = tAltura.Text;
            string c = tComprimento.Text;
            string l = tLargura.Text;
            string v = tValor.Text;

            Dims d = new Dims();
            d.altura = a;
            d.comprimento = c;
            d.largura = l;

            prenda ho = new prenda(d, n, p, v);
            hohoho.Add(ho);

            tNome.Text = "";
            tPeso.Text = "";
            tAltura.Text = "";
            tComprimento.Text = "";
            tLargura.Text = "";
            tValor.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hohoho = new List<prenda>();
        }
    }
}
