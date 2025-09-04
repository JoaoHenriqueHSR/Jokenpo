using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace GAME
{
    public partial class frmGame : Form
    {
        string cpuEscolha;
        int tempo;
        int ponto;
        RadioButton escolha;
        bool iniciar;
        public frmGame()
        {
            InitializeComponent();
            NovoJogo();
            lblStart.Visible = true;
            gpEscolhas.Enabled = false;
            iniciar=false;
        }

        private void NovoJogo()
        {
            this.BackColor = Color.White;
            ponto = 0;
            rbDefault.Checked = true;
            picEscolha.Image = null;
            tempo = 4;
            lbPonto.Text = ponto.ToString();
            timer1.Start();
        }

        private void Escolha()
        {
            Random random = new Random();
            switch (random.Next(0, 3))
            {
                case 0:
                    cpuEscolha = "Pedra";
                    break;
                case 1:
                    cpuEscolha = "Papel";
                    break;
                case 2:
                    cpuEscolha = "Tesoura";
                    break;
            }
            picEscolha.Image = Image.FromFile($"{cpuEscolha}.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iniciar)
            {
                tempo--;
                lbLegenda.Visible = true;
                lbLegenda.Text = tempo == 3 ? "JO" : tempo == 2 ? "KEN" : "PO!";

                if (tempo == 0)
                {
                    timer1.Stop();
                    Fim();
                }
            }

        }

        private void Fim()
        {
            Escolha();
            escolha = gpEscolhas.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (escolha.Text != "Default")
            {
                Embate();
            }
            else
            {
                GameOver();
            }
            Continuar();
        }

        private void Continuar()
        {
            this.BackColor = Color.White;
            timer1.Start();
            picEscolha.Image = null;
            rbDefault.Checked = true;
            tempo = 4;
        }

        private void Embate()
        {
            lbLegenda.Visible = false;

            if (escolha.Text == "Pedra"&&cpuEscolha=="Papel"||
                escolha.Text == "Papel"&&cpuEscolha=="Tesoura"||
                escolha.Text == "Tesoura"&&cpuEscolha=="Pedra")
            {
                GameOver();
            }else if (escolha.Text == cpuEscolha)
            {
                this.BackColor = Color.Gray;
                MessageBox.Show($"Escolheram {escolha.Text}", "Empate");
                Continuar();
            }
            else
            {
                this.BackColor = Color.Green;
                Vitoria();
            }
        }

        private void Vitoria()
        {
            MessageBox.Show($" {escolha.Text} ganha de {cpuEscolha}", "Vitoria");
            ponto++;
            lbPonto.Text=ponto.ToString();
            Continuar() ;
        }

        private void GameOver()
        {
            this.BackColor = Color.Red;
            lbLegenda.Visible = false;
            if (escolha.Text=="Default")
            {
                MessageBox.Show("Não escolheu!", "Perdeu");
            }
            else
            {
                MessageBox.Show($" {escolha.Text} perde para {cpuEscolha} ", "Perdeu");
            }
            NovoJogo();
        }

        private void frmGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            iniciar = true;
            lblStart.Visible = false;
            gpEscolhas.Enabled = true;
        }
    }
}
