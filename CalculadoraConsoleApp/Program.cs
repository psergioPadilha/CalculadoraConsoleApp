namespace CalculadoraConsoleApp
{
    //Teste
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Limpa o console toda vez que inicia um loop
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para Adição");
                Console.WriteLine("Digite 2 para Subtração");
                Console.WriteLine("Digite 3 para Multiplicação");
                Console.WriteLine("Digite 4 para Divisão");
                Console.WriteLine("Digite 'S' para Sair");

                String operacao = Console.ReadLine();

                if ((operacao == "S") || (operacao == "s"))
                {
                    Console.WriteLine("Você deseja mesmo sair do sistema 'CALCULADORA'?");
                    Console.WriteLine("Se sim digite 'S', se não digite 'N'!");
                    String sair = Console.ReadLine();
                    if ((sair == "S") || (sair == "s"))
                        break;
                }
                else if (operacao == "1")
                {
                    Console.WriteLine("Você optou por uma operação do tipo 'SOMA'!");
                    Console.WriteLine("Se desejar parar a soma digite 'P'!");
                    int cont = 0;
                    decimal numero = 0;
                    String somaString = null;
                    bool soma = true;

                    while (soma == true)
                    {
                        cont++;
                        Console.Write("Digite o " + cont + "º número: ");
                        numero = numero + Convert.ToDecimal(Console.ReadLine());
                        somaString = Console.ReadLine();
                        if ((somaString == "P") || (somaString == "p"))
                        {
                            Console.Write("O resultado da Soma dos " + cont + " números foi = " + numero.ToString("F") + ".");
                            soma = false;
                        }
                    }
                }
                else if (operacao == "2")
                {
                    Console.WriteLine("Você optou por uma operação do tipo 'SUBTRAÇÃO'!");
                    Console.WriteLine("Se desejar parar a subtração digite 'P'!");
                    int cont = 1;
                    decimal numero = 0;
                    decimal subtrai = 1;
                    String subtracaoString = null;
                    bool subtracao = true;

                    Console.Write("Digite o 1º número: ");
                    numero = Convert.ToDecimal(Console.ReadLine());
                    subtracaoString = Console.ReadLine();
                    if ((subtracaoString == "P") || (subtracaoString == "p"))
                    {
                        Console.Write("O resultado da 'SUBTRAÇÃO' dos " + cont + " números foi = " + numero.ToString("F") + ".");
                        subtracao = false;
                    }

                    while (subtracao == true)
                    {
                        cont++;
                        Console.Write("Digite o " + cont + "º número: ");
                        numero = numero - Convert.ToDecimal(Console.ReadLine());
                        subtracaoString = Console.ReadLine();
                        if ((subtracaoString == "P") || (subtracaoString == "p"))
                        {
                            Console.Write("O resultado da 'SUBTRAÇÃO' dos " + cont + " números foi = " + numero.ToString("F") + ".");
                            subtracao = false;
                        }
                    }
                }
                else if (operacao == "3")
                {
                    Console.WriteLine("Você optou por uma operação do tipo 'MULTIPLICAÇÃO'!");
                    Console.WriteLine("Se desejar parar a multiplicação digite 'P'!");
                    int cont = 0;
                    decimal numero = 1;
                    String multiplicacaoString = null;
                    bool multiplicacao = true;

                    while (multiplicacao == true)
                    {
                        cont++;
                        Console.Write("Digite o " + cont + "º número: ");
                        numero = numero * Convert.ToDecimal(Console.ReadLine());
                        multiplicacaoString = Console.ReadLine();
                        if ((multiplicacaoString == "P") || (multiplicacaoString == "p"))
                        {
                            Console.Write("O resultado da Soma dos " + cont + " números foi = " + numero.ToString("F") + ".");
                            multiplicacao = false;
                        }
                    }
                }
                else if (operacao == "4") 
                {
                    Console.WriteLine("Você optou por uma operação do tipo 'DIVISÃO'!");
                    Console.WriteLine("Se desejar parar a 'DIVISÃO' digite 'P'!");
                    int cont = 1;
                    decimal numero = 0;
                    decimal dividi = 1;
                    String divisaoString = null;
                    bool divisao = true;

                    Console.Write("Digite o 1º número: ");
                    numero = Convert.ToDecimal(Console.ReadLine());
                    divisaoString = Console.ReadLine();

                    if ((divisaoString == "P") || (divisaoString == "p"))
                    {
                        Console.Write("O resultado da 'DIVISÃO' dos " + cont + " números foi = " + numero.ToString("F") + ".");
                        divisao = false;
                    }

                    while (divisao == true)
                    {
                        cont++;
                        decimal aux = 0;
                        Console.Write("Digite o " + cont + "º número: ");
                        aux = Convert.ToDecimal(Console.ReadLine());
                        divisaoString = Console.ReadLine();

                        if (aux != 0)
                        {
                            numero = numero / aux;
                        }
                        if ((divisaoString == "P") || (divisaoString == "p"))
                        {
                            Console.Write("O resultado da 'DIVISÃO' dos " + cont + " números foi = " + numero.ToString("F") + ".");
                            divisao = false;
                        }
                    }
                }
                Console.ReadLine();
            }
        }
    }
}