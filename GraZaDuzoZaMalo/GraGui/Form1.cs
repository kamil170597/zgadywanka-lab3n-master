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
           
           
            

            string test = textBoxod.Text;
            string test2 = textBoxdo.Text;

            if(string.IsNullOrEmpty(test) || string.IsNullOrEmpty(test2))
            {
                MessageBox.Show("Zakres musi zostać podany poprawnie");
            }else
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
                Sprawdzanie_Box.Visible = true;
                Poddanie.Visible = true;

            }
           
           
          
           
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Poddanie_Click(object sender, EventArgs e)
        {

            string message = "Przegrałeś czy chcesz zagrać jeszcze raz ?";
            string title = "PRZEGRANA";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                NowaGra.Enabled = true;
                textBoxdo.Clear();
                textBoxod.Clear();
                PodanaLiczba.Clear();
                textBoxod.Enabled = true;
                textBoxdo.Enabled = true;
                groupBox1.Visible = false;
                Losuj.Visible = true;
                Sprawdzanie_Box.Visible = false;
                //Application.Restart();
            }


        }

        private void Sprawdz_Click_Click(object sender, EventArgs e)
        {
            komunikat.Visible = true;

            string test3 = PodanaLiczba.Text;
            if (string.IsNullOrEmpty(test3))
            {
                MessageBox.Show("Musisz podać swoją propozycję");
            }
            else
            {
                int c = int.Parse(PodanaLiczba.Text);
                if (Convert.ToString(g.Ocena(c)) == "ZaMalo")
                    komunikat.Text = "Za Mało";
                else if (Convert.ToString(g.Ocena(c)) == "ZaDuzo")
                    komunikat.Text = "Za Dużo";
                else
                {
                    string message = $"Wygrałes czy chcesz zagrać jeszcze raz ? \n Ilość Ruchów: {Convert.ToString(g.LicznikRuchow - 1)}";
                    string title = "WYGRANA";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        NowaGra.Enabled = true;
                        textBoxdo.Clear();
                        textBoxod.Clear();
                        PodanaLiczba.Clear();
                        textBoxod.Enabled = true;
                        textBoxdo.Enabled = true;
                        groupBox1.Visible = false;
                        Losuj.Visible = true;
                        Sprawdzanie_Box.Visible = false;
                        //Application.Restart();
                    }
                }
            }
        }

        private void Sprawdzanie_Box_Enter(object sender, EventArgs e)
        {

        }
    }
}
