using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OldLadyGame
{
    public partial class Form1 : Form
    {
        string estilo = "J"; //J - Modo Jogador/Jogador, C - Modo Jogador/CPU

        public Form1()
        {
            InitializeComponent();
            inicio();
        }

        #region Métodos

        /// <summary>
        /// Alterna o símbolo de entrada (De "X" para "O" e vice-versa)
        /// </summary>
        /// <returns>Símbolo a ser utilizado</returns>
        public string alternar()
        {
            if (button10.Text == "X")
            {
                button10.Text = "O";
            }
            else
            {
                button10.Text = "X";
            }

            return button10.Text;
        }

        /// <summary>
        /// Configura o jogo para ser iniciado corretamente
        /// </summary>
        public void inicio()
        {
            button1.Text = button2.Text = button3.Text =
            button4.Text = button5.Text = button6.Text =
            button7.Text = button8.Text = button9.Text = " ";
 
            btnJogadorJogador.Enabled = btnJogadorCPU.Enabled = true;

            habilitaBotoesJogo(false);
        }

        /// <summary>
        /// Com base nos valores informados, verifica se houve uma vitória
        /// </summary>
        /// <param name="casa1">Valor da primeira casa</param>
        /// <param name="casa2">Valor da segunda casa</param>
        /// <param name="casa3">Valor da terceira casa</param>
        public void verificarVitoria(string casa1, string casa2, string casa3)
        {
            if ((casa1 == casa2) && (casa2 == casa3) && (casa1 != " "))
            {
                MessageBox.Show("Jogo finalizado! Vencedor: " + casa1);
                inicio();
            }
        }

        /// <summary>
        /// Verifica as regras do jogo
        /// </summary>
        public void regras()
        {
            //Verificação de campeão
            verificarVitoria(button1.Text, button2.Text, button3.Text);
            verificarVitoria(button4.Text, button5.Text, button6.Text);
            verificarVitoria(button7.Text, button8.Text, button9.Text);
            verificarVitoria(button1.Text, button5.Text, button9.Text);
            verificarVitoria(button3.Text, button5.Text, button7.Text);

            if ((button1.Text != " ") && (button2.Text != " ") && (button3.Text != " ") &&
                (button4.Text != " ") && (button5.Text != " ") && (button6.Text != " ") &&
                (button7.Text != " ") && (button8.Text != " ") && (button9.Text != " "))
            {
                MessageBox.Show("Empate!");
                inicio();
            }
        }

        /// <summary>
        /// Retorna um número aleatório
        /// </summary>
        /// <param name="QtdMax">Limite para geração de números aleatórios</param>
        /// <returns>Número aleatório escolhido</returns>
        public int return_randomico(int QtdMax)
        {
            Random Sorteio = new Random();
            return (Sorteio.Next(1, QtdMax));
        }

        /// <summary>
        /// Habilita os botões de casas ou desabilita
        /// </summary>
        /// <param name="habilita">Parâmetro com valor para habilitar/desabilitar</param>
        public void habilitaBotoesJogo(bool habilita)
        {
            button1.Enabled = button2.Enabled = button3.Enabled =
            button4.Enabled = button5.Enabled = button6.Enabled =
            button7.Enabled = button8.Enabled = button9.Enabled = habilita;
        }

        #endregion

        #region Eventos de botões

        private void button1_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botao = ((Button)sender);
            botao.Text = alternar();
            botao.Enabled = false;
            regras();
        }

        private void btnJogadorJogador_Click(object sender, EventArgs e)
        {
            estilo = "J";
            btnJogadorCPU.Enabled = false;
            habilitaBotoesJogo(true);
        }

        private void btnJogadorCPU_Click(object sender, EventArgs e)
        {
            estilo = "C";
            btnJogadorJogador.Enabled = false;
            habilitaBotoesJogo(true);
        }

        #endregion
    }
}
