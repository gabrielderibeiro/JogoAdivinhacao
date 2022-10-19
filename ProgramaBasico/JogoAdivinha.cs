using System;

class AppProChefe
{
    static int NumeroUsuario;
    static int numeroCerto;
    static int tentativas;
    static int dificuldade;
    static int pontuacaoInicial = 1000;
    static int pontuacaoAtual;
    static bool dificuldadeCerta = false;
    static bool jogarNovamente = true;
    static void Main(string[] args)
    {
        while (jogarNovamente)
        {
            pontuacaoAtual = pontuacaoInicial;
            Random numeroAleatorio = new Random();
            numeroCerto = numeroAleatorio.Next(1, 101);
            Console.WriteLine(numeroCerto);

            Console.WriteLine("==============   Olá   ==============");
            Console.WriteLine("Eu escolhi um numero de 1 até 100");
            Console.WriteLine("Antes de começarmos escolha uma dificuldade");
            Console.WriteLine(" (1) é facil e vc tem 20 tentativas");
            Console.WriteLine(" (2) é dificil e vc tem 10 tentativas");
            Console.WriteLine(" (3) é dificil e vc tem 5 tentativas");

            while (!dificuldadeCerta)
            {
                Console.WriteLine("Escolha a dificuldade");
                dificuldadeCerta = int.TryParse(Console.ReadLine(), out dificuldade);

                if (dificuldade < 1 || dificuldade > 3)
                {
                    dificuldadeCerta = false;
                }
            }

            switch (dificuldade)
            {
                case 1:
                    tentativas = 20;
                    Console.WriteLine($"boa escolha, vc tem 20 tentativas \n");
                    break;
                case 2:
                    tentativas = 10;
                    Console.WriteLine($"Vc tem 10 tentativas \n");
                    break;
                case 3:
                    tentativas = 5;
                    Console.WriteLine($"Uma pessoa Ousada, vc tem apenas 5 tentativas \n");
                    break;
            }

            Console.WriteLine("Se digitar um valor inválido perde uma tentativa");
            Console.WriteLine("tente acertar meu numero agora!!!");

            while (tentativas >= 1)
            {
                bool testar = int.TryParse(Console.ReadLine(), out NumeroUsuario);

                if (NumeroUsuario == numeroCerto)
                {
                    Console.WriteLine("Acertou");
                    Console.WriteLine($"Voce fez {pontuacaoAtual} pontos");

                    break;
                }
                else if (NumeroUsuario > 100 || NumeroUsuario < 1)
                {
                    Console.WriteLine($"lembrando que eu só vou pensar em um numero de 1 até 100 e vc tentou um valor inválido, perdeu essa tentativa");
                    tentativas--;
                    continue;
                }

                pontuacaoAtual -= Math.Abs(numeroCerto - NumeroUsuario);

                if (tentativas <= 1)
                {
                    Console.WriteLine("acabou as tentativas e infelizmente vc não acertou");
                    Console.WriteLine($"eu pensei no numero {numeroCerto}");
                    break;
                }
                else if (NumeroUsuario > numeroCerto)
                {
                    Console.WriteLine("Voce não acertou, tente novamente");
                    Console.WriteLine($"O numero é menor do que {NumeroUsuario}");
                }
                else if (NumeroUsuario < numeroCerto)
                {
                    Console.WriteLine($"O numero é maior do que {NumeroUsuario}");
                    Console.WriteLine("Voce não acertou, tente novamente");
                }

                tentativas--;

            }

            Console.WriteLine("Gostaria de jogarNovamente novamente?");
            Console.WriteLine("Digite (1) para sim e (2) para não");

            jogarNovamente = int.TryParse(Console.ReadLine(), out int valor);

            if (valor == 2)
            {
                jogarNovamente = false;
                Console.Clear();
                Console.WriteLine("Obrigado por jogar!!!");
            }
        }
    }
}

