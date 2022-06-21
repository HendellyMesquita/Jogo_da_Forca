using System;
using System.Windows.Forms;

namespace JogoDaForca.Ui
{
    public partial class FormJogoDaForca : Form
    {
        private string[] palavraSecreta;
        private string[] dicas;
        private string vetorverificavel;
        private string vetorHeroi = "heroi";
        private string vetorAnimal = "animal";
        private string tela;
        private string palavra;
        private int tentativas = 6;
        private int jogadas = 0;
        private int posPalavra;

        public FormJogoDaForca()
        {
            InitializeComponent();
            VerificaVetor(vetorverificavel);
        }

        private void VerificaVetor(string vetorverificavel)
        {

            if (vetorverificavel == vetorHeroi)
            {

                palavraSecreta = new string[10];
                dicas = new string[10];

                palavraSecreta[0] = "Doutor extranho";
                dicas[0] = "Magia";

                palavraSecreta[1] = "capita marvel";
                dicas[1] = "Muinto Poder";

                palavraSecreta[2] = "batiman";
                dicas[2] = "Dinheiro";

                palavraSecreta[3] = "aqua man";
                dicas[3] = "Peixes";

                palavraSecreta[4] = "homem aranha";
                dicas[4] = "Jovem";

                palavraSecreta[5] = "homem de ferro";
                dicas[5] = "Inteligente";

                palavraSecreta[6] = "wolverine";
                dicas[6] = "Super regeneração";

                palavraSecreta[7] = "deadpool";
                dicas[7] = "Imortal";

                palavraSecreta[8] = "professor xevier";
                dicas[8] = "Grande Mente";

                palavraSecreta[9] = "vespa";
                dicas[9] = "Pequena";
            }

            if (vetorverificavel == vetorAnimal)
            {
                palavraSecreta = new string[10];
                dicas = new string[10];

                palavraSecreta[0] = "Cachorro";
                dicas[0] = "Agitado";

                palavraSecreta[1] = "Gato";
                dicas[1] = "Domestico";

                palavraSecreta[2] = "Papagaio";
                dicas[2] = "Falastrão";

                palavraSecreta[3] = "Tilapia";
                dicas[3] = "Peixe";

                palavraSecreta[4] = "Ornitorrinco";
                dicas[4] = "Zoeira da Mae Natureza";

                palavraSecreta[5] = "Macaco";
                dicas[5] = "Parente Proximo";

                palavraSecreta[6] = "Avestruz";
                dicas[6] = "Ave";

                palavraSecreta[7] = "Pato";
                dicas[7] = "Mutiplas Abilidades";

                palavraSecreta[8] = "Onça Pintada";
                dicas[8] = "Grande Caçador";

                palavraSecreta[9] = "Chinchila";
                dicas[9] = "Roedor";
            }
        }

        private void ObterPalavraSecreta()
        {
            int letraposicao;
            string txt = " ";
            char espacamento = Convert.ToChar(" ");

            tela = "";
            Random pavalraRandom = new Random();
            posPalavra = pavalraRandom.Next(0, 10);
            palavra = palavraSecreta[posPalavra];
            for (int i = 0; i < palavra.Length; i++)
            {

                if (palavra[i] == espacamento)
                {
                    letraposicao = i;
                    txt += tbLetra.Text;
                    tela += txt;
                }
                else
                    tela = tela + "#";
            }

            TbPalavraSecreta.Text = tela;
            lbDica.Text = dicas[posPalavra];
            lbTentativas.Text = tentativas.ToString();
            lbJogadas.Text = tentativas.ToString();
            tbLetrasDigitadas.Clear();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (palavraSecreta != null)
            {
                pnJogo.Visible = true;

                btnAnimais.Enabled = false;
                btnHerois.Enabled = false;
                btnStart.Enabled = false;
                tentativas = 6;
                jogadas = 0;

                lbJogadas.Text = jogadas.ToString();
                lbTentativas.Text = tentativas.ToString();

                ObterPalavraSecreta();
                tbLetra.Focus();
                return;
            }
            MessageBox.Show("Selecione Um Tema");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                jogadas++;
                lbJogadas.Text = jogadas.ToString();
                tbLetrasDigitadas.Text += tbLetra.Text + ", ";
                bool letraExiste = false;
                string txt = "";
                char letra = Convert.ToChar(tbLetra.Text);
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        letraExiste = true;
                        txt += tbLetra.Text;
                    }
                    else
                    {
                        txt += tela[i];
                    }
                }
                tela = txt;
                TbPalavraSecreta.Text = tela;
                tbLetra.Clear();
                tbLetra.Focus();

                if (!letraExiste)
                {
                    tentativas--;
                    lbTentativas.Text = tentativas.ToString();
                    if (tentativas <= 0)
                    {
                        MessageBox.Show("Game Over");
                        btnAnimais.Enabled = true;
                        btnHerois.Enabled = true;
                        btnStart.Enabled = true;
                    }
                }
                if (!tela.Contains("#") && tentativas > 0)
                {
                    MessageBox.Show("You Win");
                    btnAnimais.Enabled = true;
                    btnHerois.Enabled = true;
                    btnStart.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Informa um valor valido");
                tbLetra.Focus();
            }
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            vetorverificavel = vetorAnimal;
            VerificaVetor(vetorverificavel);
        }

        private void btnHerois_Click(object sender, EventArgs e)
        {
            vetorverificavel = vetorHeroi;
            VerificaVetor(vetorverificavel);
        }
    }
}
