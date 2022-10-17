using System;

namespace ProgramaBasico
{
    class AppProChefe
    {
        static int NumeroUsuario;
        static int numeroCerto;
        static int tentativas;
        static int dificuldade;
        static int pontuacaoInicial = 1000;
        static int pontuacaoAtual;


        static void Main(string[] args)
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

            dificuldade = int.Parse(Console.ReadLine());

            while (true)
            {
                if (dificuldade <= 0 || dificuldade > 3)
                {
                    Console.WriteLine("Digite uma dificuldade valida");
                    dificuldade = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            switch (dificuldade)
            {
                case 1:
                    tentativas = 21;
                    Console.WriteLine($"pronto, vc tem {tentativas} tentativas");
                    break;
                case 2:
                    tentativas = 11;
                    Console.WriteLine($"pronto, vc tem {tentativas} tentativas");
                    break;
                case 3:
                    tentativas = 6;
                    Console.WriteLine($"pronto, vc tem {tentativas} tentativas");
                    break;
            }
            Console.WriteLine("tente acertar meu numero agora");

            while (tentativas > 1)
            {
                NumeroUsuario = int.Parse(Console.ReadLine());

                if (NumeroUsuario == numeroCerto)
                {
                    Console.WriteLine("Acertou");
                    Console.WriteLine($"Voce fez {pontuacaoAtual} pontos");

                    break;
                }
                else if (NumeroUsuario > 100)
                {
                    Console.WriteLine($"lembrando que eu só vou pensar em um numero de 1 até 100 e vc tentou {NumeroUsuario}, tente novamente");
                    //NumeroUsuario = int.Parse(Console.ReadLine());
                    tentativas--;
                    continue;
                }
                pontuacaoAtual -= Math.Abs(numeroCerto - NumeroUsuario);

                if (NumeroUsuario > numeroCerto)
                {
                    Console.WriteLine("Voce não acertou, tente novamente");
                    Console.WriteLine($"O numero certo é menor do que {NumeroUsuario}");
                    //NumeroUsuario = int.Parse(Console.ReadLine());
                }
                else if (NumeroUsuario < numeroCerto)
                {
                    Console.WriteLine($"O numero certo é maior do que {NumeroUsuario}");
                    Console.WriteLine("Voce não acertou, tente novamente");
                    //NumeroUsuario = int.Parse(Console.ReadLine());
                }
                tentativas--;
                if (tentativas <= 1)
                {
                    Console.WriteLine("acabou as tentativas e infelizmente vc não acertou");
                    Console.WriteLine($"eu pensei no numero {numeroCerto}");
                }
            }
        }
    }
}
