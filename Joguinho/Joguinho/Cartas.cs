using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Joguinho
{
    internal class Cartas
    {
        public string Nome { get; set; }
        public int Inteligencia { get; set; }
        public int Força { get; set; }
        public int Habilidade { get; set; }
        public string CaminhoImagem { get; set; }
        public Image Imagem { get; set; }

        public Cartas(string nome, int inteligencia, int força, int habilidade, string caminhodaimagem)
        {
            Nome = nome;
            Inteligencia = inteligencia;
            Força = força;
            Habilidade = habilidade;
            CaminhoImagem = caminhodaimagem;
            Imagem = null;
        }
    }
}


