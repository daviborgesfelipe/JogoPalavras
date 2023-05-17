using JogoPalavras.WinApp.Dominio;
using static System.Net.Mime.MediaTypeNames;

namespace JogoPalavras.WinApp
{
    public partial class TelaJogoPalavrasForm : Form
    {
        JogoDePalavras jogoDePalavras;
        public PalavraUserControl LinhaAtual
        {
            get
            {
                return (PalavraUserControl)tableLinhas.Controls[jogoDePalavras.tentativas];
            }
        }
        public TelaJogoPalavrasForm()
        {
            jogoDePalavras = new JogoDePalavras();
            InitializeComponent();
            RegistrarEventos();
        }
        public void RegistrarEventos()
        {
            foreach (Button botao in tableLayoutPanelTeclado.Controls)
            {
                if (botao.Text == "btnEnter" ||
                    botao.Text == "btnReiniciar" ||
                    botao.Text == "btnApagar")
                    continue;

                botao.Click += DigitarLetra;
            }

            btnEnter.Click += AvaliarPalavra;

            btnNovoJogo.Click += GerarNovoJogo;
        }

        private void ReiniciarJogo(object? sender, EventArgs e)
        {
            jogoDePalavras = new JogoDePalavras();


            foreach (PalavraUserControl linha in tablePrincipal.Controls)
                linha.Limpar();
        }

        private void ApagarLetra(object? sender, EventArgs e)
        {
            LinhaAtual.Apagar();
        }

        private void DigitarLetra(object? sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender!;

            LinhaAtual.Digitar(botaoClicado.Text);
        }
        internal void GerarNovoJogo(object? sender, EventArgs e)
        {
            jogoDePalavras.GeraUmaPalavraAleatoria();
        }
        private void AvaliarPalavra(object? sender, EventArgs e)
        {
            PalavraUserControl linha = LinhaAtual;

            string palavraCompleta = linha.ToString();

            AvaliacaoLetra[] avaliacoes = jogoDePalavras.Avaliar(palavraCompleta);

            linha.ColorirLabels(avaliacoes);

        }
    }
}