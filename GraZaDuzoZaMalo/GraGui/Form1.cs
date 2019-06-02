using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;
namespace GraGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Gra g;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            NowaGra.Enabled = false;
        }

        
private void Losuj_Click(object sender, EventArgs e)
        {
            //Wczytaj zakres do losowania
            int a = int.Parse(textBoxod.Text);
            int b = int.Parse(textBoxdo.Text);
            //utworz gre
            g = new Gra(a, b);
            textBoxod.Enabled = false;
            textBoxdo.Enabled = false;
            Losuj.Visible = false;
            //Wyswietl kolejne elementy formularza


        }
    }
}
