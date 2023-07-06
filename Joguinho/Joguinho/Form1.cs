using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Joguinho
{
    public partial class Form1 : Form
    {
        private List<Cartas> baralho; // Lista de cartas do baralho
        private Cartas cartaAtualJogador; // Carta atual em jogo
        private Cartas cartaAtualMaquina; // Carta atual em jogo
        private List<Cartas> cartasJogador; // Cartas do jogador
        private List<Cartas> cartasMaquina; // Cartas da máquina


        public Form1()
        {
            InitializeComponent();



            // Inicializa o baralho com algumas cartas
            baralho = new List<Cartas>();
           
            baralho.Add(new Cartas("Capitão-América", 60, 85, 90, @"C:\Users\Usuario\OneDrive\Documentos\Estudos\supertrunfo\Joguinho\imagens\cap.jpg"));
            baralho.Add(new Cartas("Homem de Ferro", 100, 85, 85, @"C:\Users\Usuario\OneDrive\Documentos\Estudos\supertrunfo\Joguinho\imagens\ironman.jpg"));
            baralho.Add(new Cartas("Thor", 60, 100, 100, @"C:\Users\Usuario\OneDrive\Documentos\Estudos\supertrunfo\Joguinho\imagens\thor.jpg"));
            baralho.Add(new Cartas("Hulk", 30, 100, 30, @"C:\Users\Usuario\OneDrive\Documentos\Estudos\supertrunfo\Joguinho\imagens\Hulk.jpg"));
            baralho.Add(new Cartas("Homem Aranha", 100, 70, 90, @"C:\Users\Usuario\OneDrive\Documentos\Estudos\supertrunfo\Joguinho\imagens\miranha.jpg"));
            baralho.Add(new Cartas("Thanos", 90, 100, 100, @"C:\Users\Usuario\OneDrive\Documentos\Estudos\supertrunfo\Joguinho\imagens\thanos.jpg"));

            // Inicia o jogo
            IniciarJogo();
            pictureBoxJogador.Image = null;
            pictureBoxMaquina.Image = null;

            btnSortear.Click += BtnSortear_Click;
            //btnComparar.Click += BtnComparar_Click;
        }


        private void IniciarJogo()
        {



            EmbaralharBaralho();


            // Sortear três cartas para o jogador
            cartasJogador = new List<Cartas>();
            for (int i = 0; i < 3; i++)
            {
                Cartas carta = baralho[0];
                cartasJogador.Add(carta);
                baralho.RemoveAt(0);
            }

            // Sortear três cartas para a máquina
            cartasMaquina = new List<Cartas>();
            for (int i = 0; i < 3; i++)
            {
                Cartas carta = baralho[0];
                cartasMaquina.Add(carta);
                baralho.RemoveAt(0);
            }

            // Atualizar a carta atual do jogador com a primeira carta sorteada
            cartaAtualJogador = cartasJogador[0];
            cartaAtualMaquina = cartasMaquina[0];
            AtualizarCartaAtual();

            QuantidadeCartasMinhas.Text += cartasJogador.Count;
            QuantidadeCartasOponente.Text += cartasMaquina.Count;
        }

        public void EmbaralharBaralho()
        {
            Random random = new Random();//será usada para gerar números aleatórios.

            int n = baralho.Count;//Obtém o número total de cartas no baralho e atribui esse valor à variável n.
            while (n > 1)//O objetivo é percorrer todas as cartas do baralho para embaralhá-las.
            {
                n--;//decrementa o valor de n a cada iteração 
                int k = random.Next(n + 1);//sendo k um num aleatorio
                Cartas carta = baralho[k];
                baralho[k] = baralho[n];
                baralho[n] = carta;
            }

            int index1 = random.Next(baralho.Count);
            int index2;

            // Sorteia o segundo personagem (tendo como parametro ser diferente do primeiro)
            do
            {
                index2 = random.Next(baralho.Count);
            } while (index2 == index1);

            Cartas personagem1 = baralho[index1];
            Cartas personagem2 = baralho[index2];



        }

        public void AtualizarCartaAtual()
        {

            // Dimensiona e faz aparecer as cartas certinhas

            pictureBoxJogador.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxJogador.Width = 200;
            pictureBoxJogador.Height = 150;




            pictureBoxMaquina.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMaquina.Width = 200;
            pictureBoxMaquina.Height = 150;


            //verifica o caminho da imagem
            pictureBoxJogador.Image = Image.FromFile(cartasJogador[0].CaminhoImagem);
            pictureBoxMaquina.Image = Image.FromFile(cartasMaquina[0].CaminhoImagem);


            //atualiza os atributos
            label1.Text = $"Inteligência: {cartaAtualJogador.Inteligencia}";
            label2.Text = $"Força: {cartaAtualJogador.Força}";
            label3.Text = $"Habilidade: {cartaAtualJogador.Habilidade}";
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {

            if (cartasJogador.Count > 0 && cartasMaquina.Count > 0)//Verifica se as listas contém pelo menos uma carta. 
            {
                //cartasJogador.RemoveAt(0);
                //cartasMaquina.RemoveAt(0);
                //Verificação importante para evitar erros caso não haja mais cartas para sortear.
                if (cartasJogador.Count > 0 && cartasMaquina.Count > 0)
                {
                    cartaAtualJogador = cartasJogador[0];
                    cartaAtualMaquina = cartasMaquina[0];

                    AtualizarCartaAtual();
                }
                else
                {
                    MessageBox.Show("Fim do jogo!");
                }
            }
        }

        private int ObterAtributoSelecionado()
        {
            if (radioButton1.Checked)
            {
                return 1;
            }
            else if (radioButton2.Checked)
            {
                return 2;
            }
            else if (radioButton3.Checked)
            {
                return 3;
            }

            // Caso nenhum atributo esteja selecionado, retornar o valor padrão 1(fallback)
            return 1;
        }

        private int ObterValorAtributo(Cartas carta, int atributoSelecionado)
        {
            switch (atributoSelecionado)
            {
                case 1:
                    return carta.Inteligencia;
                case 2:
                    return carta.Força;
                case 3:
                    return carta.Habilidade;
                default:
                    return 0;
            }
        }


        private void BtnComparar_Click(object sender, EventArgs e)
        {

            int atributoSelecionado = ObterAtributoSelecionado();
            int valorJogador = ObterValorAtributo(cartaAtualJogador, atributoSelecionado);
            int valorMaquina = ObterValorAtributo(cartaAtualMaquina, atributoSelecionado);




            // Verificar quem venceu a comparação
            if (valorJogador > valorMaquina)
            {
                MessageBox.Show("Você venceu!");
                // Adiciona a carta da máquina à lista de cartas do jogador
                cartasJogador.Add(cartaAtualMaquina);

                // Remove a carta da máquina da lista de cartas da máquina
                cartasMaquina.Remove(cartaAtualMaquina);

                QuantidadeCartasMinhas.Text = "Minhas cartas: " + cartasJogador.Count.ToString();
                QuantidadeCartasOponente.Text = "Cartas do oponente: " + cartasMaquina.Count.ToString();


            }
            else if (valorJogador < valorMaquina)
            {
                MessageBox.Show("Você perdeu!");
                cartasMaquina.Add(cartaAtualJogador);
                cartasJogador.Remove(cartaAtualJogador);
                QuantidadeCartasMinhas.Text = "Minhas cartas: " + cartasJogador.Count.ToString();
                QuantidadeCartasOponente.Text = "Cartas do oponente: " + cartasMaquina.Count.ToString();

            }
            else
            {
                MessageBox.Show("Empate!");
                cartasJogador.Remove(cartaAtualJogador);
                cartasJogador.Add(cartaAtualJogador);

                cartasMaquina.Remove(cartaAtualMaquina);
                cartasMaquina.Add(cartaAtualMaquina);
                QuantidadeCartasMinhas.Text = "Minhas cartas: " + cartasJogador.Count.ToString();
                QuantidadeCartasOponente.Text = "Cartas do oponente: " + cartasMaquina.Count.ToString();
               
            }

            // Verificar se algum jogador venceu o jogo
            if (cartasJogador.Count == 6 || cartasMaquina.Count == 6)
            {
                string mensagem = cartasJogador.Count == 6 ? "Você venceu o jogo!" : "Você perdeu o jogo!";
                MessageBox.Show(mensagem);
                
                Close();
            }
            else
            {
                cartaAtualJogador = cartasJogador[0];
                cartaAtualMaquina = cartasMaquina[0];
                AtualizarCartaAtual();
                //LimparSelecaoAtributo();

            }

        }

        /*private void LimparSelecaoAtributo()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }*/

        
        }
    }






