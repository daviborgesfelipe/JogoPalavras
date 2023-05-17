﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavras.WinApp.Dominio
{
    internal class JogoDePalavras
    {
        internal string[] palavras;
        internal string palavraAleatoria;
        internal int tentativas = 0;

        public AvaliacaoLetra[] Avaliar(string palavra)
        {
            tentativas++;

            AvaliacaoLetra[] avaliacoes = new AvaliacaoLetra[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == palavraAleatoria[i])
                    avaliacoes[i] = AvaliacaoLetra.Correta;

                else if (palavraAleatoria.Contains(palavra[i]))
                    avaliacoes[i] = AvaliacaoLetra.PosicaoIncorreta;
                else
                    avaliacoes[i] = AvaliacaoLetra.NaoExistente;
            }

            return avaliacoes;
        }

        public bool JogadorAcertou(string palavra)
        {
            return palavra == palavraAleatoria;
        }

        public bool JogadorPerdeu()
        {
            return tentativas == 5;
        }
        public void GeraUmaPalavraAleatoria()
        {
            string[] palavras =
            {
                "acido", "adiar", "impar", "algar", "amado", "amigo", "anexo", "anuir", "aonde", "apelo",
                "aquem", "argil", "arroz", "assar", "atras", "avido", "azeri", "babar", "bagre", "banho",
                "barco", "bicho", "bolor", "brasa", "brava", "brisa", "bruto", "bulir", "caixa", "cansa",
                "chato", "chave", "chefe", "choro", "chulo", "claro", "cobre", "corte", "curar", "deixo",
                "dizer", "dogma", "dores", "duque", "enfim", "estou", "exame", "falar", "fardo", "farto",
                "fatal", "feliz", "ficar", "fogue", "forca", "forno", "fraco", "fugir", "fundo", "furia",
                "gaita", "gasto", "geada", "gelar", "gosto", "grito", "gueto", "honra", "humor", "idade",
                "ideia", "idolo", "igual", "imune", "indio", "ingua", "irado", "isola", "janta", "jovem",
                "juizo", "largo", "laser", "leite", "lento", "lerdo", "levar", "lidar", "lindo", "lirio",
                "longe", "luzes", "magro", "maior", "malte", "mamar", "manto", "marca", "matar", "meigo",
                "meios", "melao", "mesmo", "metro", "mimos", "moeda", "moita", "molho", "morno", "morro",
                "motim", "muito", "mural", "naipe", "nasci", "natal", "naval", "ninar", "nivel", "nobre",
                "noite", "norte", "nuvem", "oeste", "ombro", "ordem", "orgao", "osseo", "ossos", "outro",
                "ouvir", "palma", "pardo", "passe", "patio", "peito", "pelos", "perdo", "peril", "perto",
                "pezar", "piano", "picar", "pilar", "pingo", "pione", "pista", "poder", "porem", "prado",
                "prato", "prazo", "preco", "prima", "primo", "pular", "quero", "quota", "raiva", "rampa",
                "rango", "reais", "reino", "rezar", "risco", "rocar", "rosto", "roubo", "russo", "saber",
                "sacar", "salto", "samba", "santo", "selar", "selos", "senso", "serao", "serra", "servo",
                "sexta", "sinal", "sobra", "sobre", "socio", "sorte", "subir", "sujei", "sujos", "talao",
                "talha", "tanga", "tarde", "tempo", "tenho", "terco", "terra", "tesao", "tocar", "lacre",
                "laico", "lamba", "lambo", "largo", "larva", "lasca", "laser", "laura", "lavra", "leigo",
                "leite", "leito", "leiva", "lenho", "lento", "leque", "lerdo", "lesao", "lesma", "levar",
                "libra", "limbo", "lindo", "lineo", "lirio", "lisar", "lista", "livro", "logar", "lombo",
                "lotes", "louca", "louco", "louro", "lugar", "luzes", "macio", "macom", "maior", "malha",
                "malte", "mamar", "mamae", "manto", "marco", "maria", "marra", "marta", "matar", "medir",
                "meigo", "meios", "melao", "menta", "menti", "mesmo", "metro", "miado", "midia", "mielo",
                "mielo", "milho", "mimos", "minar", "minha", "miolo", "mirar", "missa", "mitos", "moeda",
                "moido", "moita", "molde", "molho", "monar", "monja", "moral", "morar", "morda", "morfo",
                "morte", "mosca", "mosco", "motim", "motor", "mudar", "muito", "mular", "mulas", "mumia",
                "mural", "extra", "falar", "falta", "fardo", "farol", "farto", "fatal", "feixe", "festa",
                "feudo", "fezes", "fiapo", "fibra", "ficha", "fidel", "filao", "filho", "firma", "fisco",
                "fisga", "fluir", "forca", "forma", "forte", "fraco", "frade", "friso", "frito", "fugaz",
                "fugir", "fundo", "furor", "furto", "fuzil", "gabar", "gaita", "galho", "ganho", "garoa",
                "garra", "garro", "garvo", "gasto", "gaupe", "gazua", "geada", "gemer", "germe", "gigas",
                "girar", "gizar", "globo", "gosto", "graos", "graca", "grava", "grito", "grude", "haver",
                "haver", "hiato", "hidra", "hifen", "himel", "horas", "hotel", "humor", "ideal", "idolo",
                "igual", "ileso", "imune", "irado", "isola", "jarra", "jaula", "jegue", "jeito", "jogar",
                "jovem", "juiza", "juizo", "julho", "junho", "jurar", "justa"
            };
            this.palavras = palavras;
            Random random = new Random();
            this.palavraAleatoria = palavras[random.Next(0, palavras.Length)].ToUpper();
        }
    }
}
