using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoProva
{
    class BingoBusiness
    {
        public int B { get; set; } // 1 a 15

        public int I { get; set; } // 16 a 30

        public int N { get; set; } // 31 a 45

        public int G { get; set; } // 46 a 60

        public int O { get; set; } // 61 a 75

        public BingoBusiness() { }

        public List<BingoBusiness> GenerateBingoCard()
        {
            // Cada linha vai representar uma coluna da cartela
            /* Precisei usar uma matriz como ponte da lógica pois achei mais viável fazer uma classe que poderia
               ligar com o dataGridView. Uma segunda lógica seria criar arrays das colunas, mas para esse tipo seria
               mais viável para web, pois é mais facil manipular esses tipos de dados numa tag <table> com js, por exemplo,
               do que no datagridview
             */
            List<List<int>> numbers = new List<List<int>>();

            // A cartela
            List<BingoBusiness> bingoCard = new List<BingoBusiness>();

            // Para cada linha/letra da cartela, repete 5 vezes
            for (int i = 0; i < 5; i++)
            {
                // Responsável pela função de geração do número aleatorio
                Random random = new Random();

                // Criando a lista que vai conter 5 valores de uma letra para uma cartela
                List<int> line = new List<int>();

                // Responsável por repetir as 5 vezes de cada letra
                for (int j = 0; j < 5; j++)
                {   
                    // Variáveis que vão pegar o intervalo das letras
                    int de = 1 + (i * 15);
                    int ate = ((1 + i) * 15) + 1; // () + 1 para incluir os números extremos

                    // Gera um número aleatorio
                    int number = random.Next(de, ate);

                    // Resolvendo a questão de duplicidade
                    while (ExistNumber(number, line))
                    {
                        number = random.Next(de, ate);
                    }

                    // Adiciona o número na lista
                    line.Add(number);
                }

                // Adiciona a linha com os 5 valores diferentes da letra dentro da matriz
                numbers.Add(line);
            }

            // Ordenando cada lista dentro da matriz
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i].Sort();
            }

            // Percorre cada vetor de letras da matriz
            for (int i = 0; i < numbers.Count; i++)
            {
                // Criando o objeto BingoBusiness qeu vai representar uma linha da cartela
                BingoBusiness line = new BingoBusiness();
                
                // Vai 'travar' numa coluna e vai percorrrer todas as linhas dela
                for (int j = 0; j < numbers[i].Count; j++)
                {
                    switch (j)
                    {
                        case 0:
                            line.B = numbers[j][i];
                            break;
                        case 1:
                            line.I = numbers[j][i];
                            break;
                        case 2:
                            line.N = numbers[j][i];
                            break;
                        case 3:
                            line.G = numbers[j][i];
                            break;
                        case 4:
                            line.O = numbers[j][i];
                            break;
                    }
                }

                // Adicionando a linha na cartela
                bingoCard.Add(line);
            }

            // Retornando a cartela
            return bingoCard;
        }

        // Verifica se o número existe na lista passada como argumento
        private bool ExistNumber(int number, List<int> line)
        {
            return (line.Contains(number)) ? true  : false;
        }
    }
}
