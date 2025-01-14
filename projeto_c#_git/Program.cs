// See https://aka.ms/new-console-template for more information
// Fazer um codigo que informa se o ano que estamo atualmente é 2025 e por quanto tempo é 2025

namespace projeto_git
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int opcao;
            Console.Clear();
            Console.WriteLine("----------------DeLorean 2025----------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine("| INSIRA UM NUMERO ABAIXO PARA SE INFORMAR  |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("| 1 - Informar se o ano atual é 2025        |");
            Console.WriteLine("| 2 - Creditos                              |");
            Console.WriteLine("| 0 - Sair                                  |");
            Console.WriteLine("|                                           |");
            opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
            switch (opcao)
            {
                case 1: Anometro(); break;
                case 2: Credito(); break;
                case 0: Sair(); break; 
                default: Menu(); break;
            }
        }

        static void Anometro()
        {
            DateTime hoje = DateTime.Now;
            int diasPassados = 0;
            
            if (hoje.Year == 2025)
            {
                for (int mes = 1; mes < hoje.Month; mes++)
                {
                    // Soma os dias dos meses anteriores
                    diasPassados += DateTime.DaysInMonth(2025, mes); 
                }
                // Adiciona os dias do mês atual
                diasPassados += hoje.Day;
                Console.Clear();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("|              ESTAMOS EM 2025!!!              |");
                Console.WriteLine($"|       estamos {diasPassados} dias em 2025.               |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("| precione qualquer tecla pra retornar ao menu |");
                Console.WriteLine("------------------------------------------------");
                Console.ReadKey();
                Menu();
            }
            else
            { 
                Console.WriteLine("ja num tamo mais :(");
            }
        }

        static void Credito()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|          thanks for testing my code!         |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("| done by: daniel machado nascimento           |");
            Console.WriteLine("| Email: machadonascimentodaniel@gmail.com     |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|  This code has been made so i can learn how  |");
            Console.WriteLine("|to use git. if u are seeing this i have Learnd|");
            Console.WriteLine("|how to use GitHub!                            |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|     Press any key to return to the menu.     |");
            Console.WriteLine("------------------------------------------------");
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("|      Goodbye, See you in the future!    |");
            Console.WriteLine("-------------------------------------------");
            Thread.Sleep(2500);
            Environment.Exit(0); 
        }
    }
   
}


