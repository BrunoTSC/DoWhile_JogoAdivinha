using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile_JogoAdivinha
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //JOGO DE ADIVINHAÇÃO! :)
            int numeroSecreto = 9; // número secreto
            int chute; // chute do usuário
            int tentativasRestantes = 3; // limite de tentativas

            do
            {
                Console.WriteLine($"Adivinhe o número secreto (entre 1 e 10). Tentativas restantes: {tentativasRestantes}");

                string entrada = Console.ReadLine();

                // Tenta converter a entrada para inteiro:
                bool conversaoBemSucedida = int.TryParse(entrada, out chute);

                if (!conversaoBemSucedida)
                {
                    Console.WriteLine("Entrada inválida! Por favor, digite um número inteiro.");
                    continue; // volta para o início do laço sem gastar tentativa
                }

                tentativasRestantes--;

                if (chute == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você adivinhou o número secreto: " + numeroSecreto);
                    Console.ReadKey();
                    return; // encerra o programa ao acertar
                }
                else
                {
                    Console.WriteLine("Você errou! Tente novamente.");
                }

            }
            while (tentativasRestantes > 0);

            Console.WriteLine($"Você perdeu! O número secreto era: {numeroSecreto}");
            Console.ReadKey();

            //Adicionei tentativasRestantes iniciando em 3.

            //Diminui tentativasRestantes a cada tentativa(tentativasRestantes--).

            //Verifico se acertou dentro do do para sair imediatamente se o chute estiver correto.

            //A condição do while agora só repete enquanto tentativasRestantes > 0.

            //Se acabar as tentativas e o jogador não acertar, exibe “Você perdeu!”.

            //Usei int.TryParse() em vez de int.Parse() para converter a entrada de forma segura.

            //Quando a conversão falha, o programa exibe “Entrada inválida!” e não desconta a tentativa(graças ao continue).

            //Se o chute for incorreto, informa que o jogador errou antes de repetir.
        }

    }
}
