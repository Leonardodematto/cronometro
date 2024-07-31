using System;
using System.Diagnostics;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Começo();
        }

        static void Começo()
        {
            Console.Clear();
            Console.WriteLine("CRONÔMETRO");
            Console.WriteLine("---------------------");

            Console.WriteLine("deseja que sua contagem regresiva seja CRESCENTE ou DECRESCENTE ?");
            Console.WriteLine("");
            Console.WriteLine("para CRESCENTE digite (1) para DECRESCENTE  digite  (2)");
            MenuDeEscolha();
        }

        static void MenuDeEscolha()
        {
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (escolha == 1)
            {

                Console.WriteLine("qual sera o valor inicial para iniciar a  contagem Crescente? ");
                int inicial = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("qual será o valor maximo para encerrar a contagem regressiva crescente ?");
                int maximo = Convert.ToInt32(Console.ReadLine());

                if (inicial > maximo)
                {
                    Console.WriteLine("nao digite um valor inicial mais alto que o maximo , para utilizar o cronometro crescente.");
                    Voltar();
                }


                while (inicial <= maximo)
                {

                    Console.WriteLine($"contagem regressiva:  {inicial}");
                    Thread.Sleep(1000);
                    inicial++;

                }
                Console.WriteLine("");
                Console.WriteLine("contagem regressiva finalizada....");
                Console.WriteLine("Cronômetro  finalizado");
                Voltar();
            }




            else if (escolha == 2)
            {
                Console.Clear();
                Console.WriteLine("qual sera o valor inicial para iniciar a  contagem Decrescente? ");
                int inicial1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("qual será o valor  para encerrar a contagem regressiva decrescente ?");
                int maximo1 = Convert.ToInt32(Console.ReadLine());


                if (inicial1 < maximo1)
                {

                    Console.WriteLine("nao digite um numero inicial maior  ao  valor para encerrar a contagem regressiva.");

                    Voltar();
                }

                while (inicial1 >= maximo1)
                {
                    Console.Clear();
                    Console.WriteLine($"contagem regressiva: {inicial1}");
                    Thread.Sleep(1000);
                    inicial1--;
                }
                Console.WriteLine("");
                Console.WriteLine("contagem regressiva finalizada....");
                Thread.Sleep(1000);

                Voltar();
            }
            else if (escolha == 3)
            {
                Console.WriteLine("cronômetro finalizado.");
                System.Environment.Exit(0);
            }
            else
            {

                Console.WriteLine("por favor escolha somente (1) para crescente,(2) decrescente ou (3) para encerrar. ");
                Console.WriteLine("");
                Console.WriteLine("cronômetro finalizado....");
                Console.WriteLine("-----------------------------------------------------");
                Voltar();
            }
        }

        static void Voltar()
        {
            Console.Clear();
            Console.WriteLine("deseja fazer novamente?");
            Console.WriteLine("");
            Console.WriteLine("para SIM  digite  (1) para NÃO  digite (2)");
            short voltar = short.Parse(Console.ReadLine());


            switch (voltar)
            {

                case 1: Começo(); break;
                case 2: Console.WriteLine("Cronômetro  finalizado"); System.Environment.Exit(0); break;
                default:
                    Console.WriteLine("escolha somente SIM(1) ou NÃO(2)");
                    Voltar(); break;
            }



        }





    }
}



