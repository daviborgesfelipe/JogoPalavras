using JogoPalavras.WinApp.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JogoPalavras.WinApp.TelaJogoPalavrasForm;

namespace JogoPalavras.WinApp
{
    public partial class PalavraUserControl : UserControl
    {
        private int indiceAtual = 0;
        public bool EstaPreenchida
        {
            get { return indiceAtual == 5; }
        }
        public PalavraUserControl()
        {
            InitializeComponent();
        }


        public void Digitar(string letra)
        {
            if (EstaPreenchida)
                return;

            List<Label> controles = teladaColunas.Controls.Cast<Label>().Reverse().ToList();

            controles[indiceAtual].Text = letra;

            indiceAtual++;
        }

        public override string ToString()
        {
            string palavraCompleta = "";

            foreach (Label label in teladaColunas.Controls.Cast<Label>().Reverse())
                palavraCompleta += label.Text;

            return palavraCompleta;
        }

        public void ColorirLabels(AvaliacaoLetra[] avaliacoes)
        {
            List<Label> controles = teladaColunas.Controls.Cast<Label>().Reverse().ToList();

            for (int i = 0; i < avaliacoes.Length; i++)
            {
                Label labelSelecionado = controles[i];

                switch (avaliacoes[i])
                {
                    case AvaliacaoLetra.Correta:
                        labelSelecionado.BackColor = Color.LawnGreen;
                        break;

                    case AvaliacaoLetra.PosicaoIncorreta:
                        labelSelecionado.BackColor = Color.Goldenrod;
                        break;

                    case AvaliacaoLetra.NaoExistente:
                        labelSelecionado.BackColor = SystemColors.WindowFrame;
                        break;
                }
            }
        }

        public void Apagar()
        {
            if (indiceAtual <= 0)
                return;

            indiceAtual--;

            Label labelSelecionada = teladaColunas.Controls.Cast<Label>().Reverse().ToList()[indiceAtual];

            labelSelecionada.Text = "";
        }

        internal void Limpar()
        {
            indiceAtual = 0;

            foreach (Label label in teladaColunas.Controls)
            {
                label.Text = "";
                label.BackColor = SystemColors.GrayText;
            }

        }
    }
}
