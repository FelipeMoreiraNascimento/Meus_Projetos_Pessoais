using System;

namespace Meus_Projetos_Pessoais
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSecreto, escolha = 0, chances = 0, nivel = 0, jogarNovamente = 0;
            Random numAleatorio = new Random();
            numeroSecreto = numAleatorio.Next(1, 99);

            AcharNumero.AcharNumeroSecreto(escolha, chances, nivel, numeroSecreto);

            Console.WriteLine("Deseja jogar novamente? [1]sim / [2]nao");
            jogarNovamente = int.Parse(Console.ReadLine());

            while (jogarNovamente == 1)
            {
                AcharNumero.AcharNumeroSecreto(escolha, chances, nivel, numeroSecreto);

                Console.WriteLine("Deseja jogar novamente? [1]sim / [2]nao");
                jogarNovamente = int.Parse(Console.ReadLine());
            }
        }
    }
}

public class AcharNumero
{
    public static void AcharNumeroSecreto(int escolha, int chances, int nivel, int numeroSecreto)
    {

        Console.WriteLine("**********Jogo da Adivinhacao**********");
        Console.WriteLine("=======================================");
        Console.WriteLine("Qual nivel deseja jogar? [1]facil / [2]medio / [3]dificil");
        nivel = int.Parse(Console.ReadLine());
        if (nivel == 1)
        {
            nivel = 10;
        }
        else if (nivel == 2)
        {
            nivel = 7;
        }
        else
        {
            nivel = 5;
        }
        Console.WriteLine("Voce tem " + nivel + " chances!!!");
        Console.Write("Adivinhe o numero secreto: ");
        escolha = int.Parse(Console.ReadLine());
        chances++;

        while (chances < nivel)
        {

            if (escolha > numeroSecreto)
            {
                Console.Write("O numero Secreto eh menor: ");
                escolha = int.Parse(Console.ReadLine());
            }
            else if (escolha < numeroSecreto)
            {
                Console.Write("O numero secreto eh maior: ");
                escolha = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Voce Adivinhou o numero secreto!!!! " + numeroSecreto);
                break;
            }
            chances++;
        }

        if (chances >= nivel)
        {
            Console.WriteLine("Voce perdeu!!! O numero secreto era: " + numeroSecreto);
        }
    }
}
