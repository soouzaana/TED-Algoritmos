using System.Drawing;

namespace ProjetoTED;

class Program
{
    static double saldoConta = 1000;   
    static void Main(string[] args)
    {
        bool mostrarMenu = true;

        do
        {
            Console.Clear();
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|       PROJETO TED N1       |");
            Console.WriteLine("+----------------------------+");
            Console.WriteLine("1. CALCULADORA DE MÉDIA PONDERADA");
            Console.WriteLine("2. CLASSIFICADOR DE IMC");
            Console.WriteLine("3. CALCULADORA SIMPLES");
            Console.WriteLine("4. GERADOR DE TABUADA PERSONALIZADA");
            Console.WriteLine("5. SOMADOR COM CONDIÇÃO DE PARADA");
            Console.WriteLine("6. SISTEMA COM VALIDAÇÃO DE SENHA");
            Console.WriteLine("7. CONVERSOR DE TEMPERATURAS UNIVERSAL");
            Console.WriteLine("8. MINI SIMULADOR DE CAIXA ELETRÔNICO");
            Console.WriteLine("0. Sair");
            Console.Write("\nEscolha uma opção -> ");

            string opcao = Console.ReadKey(true).KeyChar.ToString();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Console.Write("============= CALCULADORA DE MÉDIA PONDERADA =============");

                    Console.Write("\nQual é seu nome? ");
                    string nome = Console.ReadLine();

                    Console.Write("\nDigite a nota 1: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nDigite a nota 2: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nDigite a nota 3: ");
                    double n3 = Convert.ToDouble(Console.ReadLine());

                    CalcularMedia(nome, n1, n2, n3, 0);

                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("============= CLASSIFICADOR DE IMC =============");

                    Console.Write("\nDigite seu peso (em kg): ");
                    double peso = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nDigite sua altura (em metros): ");
                    double altura = Convert.ToDouble(Console.ReadLine());

                    ClassificarIMC(peso, altura, 0);

                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("============= CALCULADORA SIMPLES =============");

                    Console.Write("\nDigite um número inteiro: ");
                    double int1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nDigite outro número inteiro: ");
                    double int2 = Convert.ToDouble(Console.ReadLine());

                    bool calculadoraMenu = true;
                    while (calculadoraMenu)
                    {

                        Console.Clear();
                        Console.WriteLine("O que você gostaria de fazer com esses números?");
                        Console.WriteLine("1. Somar");
                        Console.WriteLine("2. Subtrair");
                        Console.WriteLine("3. Multiplicar");
                        Console.WriteLine("4. Dividir");
                        Console.WriteLine("0. Sair");
                        Console.Write("\nEscolha uma opção:  ");
                        int opcaoCalculadora = int.Parse(Console.ReadLine());

                        switch (opcaoCalculadora)
                        {
                            case 1:
                                Console.WriteLine($"\nResultado da soma: {int1 + int2}");
                                Console.Write("\nPressione qualquer tecla para escolher outra operação: ");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine($"\nResultado da subtração: {int1 - int2}");
                                Console.Write("\nPressione qualquer tecla para escolher outra operação: ");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine($"\nResultado da multiplicação: {int1 * int2}");
                                Console.Write("\nPressione qualquer tecla para escolher outra operação: ");
                                Console.ReadKey();
                                break;
                            case 4:
                                if (int2 != 0)
                                {
                                    Console.WriteLine($"\nResultado da divisão: {int1 / int2}");
                                }
                                else
                                {
                                    Console.WriteLine("\nErro: Divisão por zero não é permitida.");
                                }
                                Console.Write("\nPressione qualquer tecla para escolher outra operação: ");
                                Console.ReadKey();
                                break;
                            case 0:
                                calculadoraMenu = false;
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente. ");
                                Console.ReadKey();
                                break;
                        }
                    }

                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Console.Write("============= GERADOR DE TABUADA PERSONALIZADA =============");

                    Console.Write("\nDigite um número inteiro: ");
                    int inteiro = int.Parse(Console.ReadLine());

                    GerarTabuada(inteiro);

                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Console.Write("============= SOMADOR COM CONDIÇÃO DE PARADA =============");

                    int soma = 0;
                    int contador = 0;
                    int numero;
                    do
                    {
                        Console.Write("\nDigite um número inteiro: ");
                        numero = int.Parse(Console.ReadLine());

                        if(numero > 0)
                        {
                            soma += numero;
                        }
                        contador++;
                    } while (numero > 0);

                    Console.WriteLine($"Total da soma: {soma}");

                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "6":
                    Console.Clear();
                    Console.Write("============= SISTEMA COM VALIDAÇÃO DE SENHA =============");

                    string senha;
                    string senhaCorreta = "Csharp123";

                    do
                    {
                        Console.Write("\nDigite a senha de acesso: ");
                        senha = Console.ReadLine();

                        if (senha != senhaCorreta)
                        {
                            Console.WriteLine("Senha incorreta!");
                        }

                    } while (senha != senhaCorreta);

                    Console.WriteLine("Acesso permitido!");
                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "7":
                    Console.Clear();
                    Console.Write("============= CONVERSOR DE TEMPERATURAS UNIVERSAL =============");                                      

                    bool temperaturaMenu = true;
                    while (temperaturaMenu)
                    {

                        Console.Clear();
                        Console.WriteLine("1. Converter Celcius para Fahrenheit");
                        Console.WriteLine("2. Converter Fahrenheit para Celsius");
                        Console.WriteLine("0. Sair");
                        Console.Write("\nEscolha uma opção:  ");
                        int opcaoTemperatura = int.Parse(Console.ReadLine());

                        Console.Clear();
                        Console.Write("\nDigite uma temperatura: ");
                        double temperatura = Convert.ToDouble(Console.ReadLine());

                        switch (opcaoTemperatura)
                        {
                            case 1:
                                double f = ConverterCelsiusParaFahrenheit(temperatura);
                                Console.WriteLine($"\n{temperatura}°C é igual a {f}°F.");
                                Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                                Console.ReadKey();
                                break;

                            case 2:
                                double c = ConverterFahrenheitParaCelsius(temperatura);
                                Console.WriteLine($"\n{temperatura}°F é igual a {c}°C.");
                                Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                                Console.ReadKey();
                                break;
                            case 0:
                                temperaturaMenu = false;
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente. ");
                                Console.ReadKey();
                                break;
                        }
                    }
                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "8":
                    Console.Clear();
                    Console.Write("============= MINI SIMULADOR DE CAIXA ELETRÔNICO =============");

                    bool caixaMenu = true;
                    while (caixaMenu)
                    {

                        Console.Clear();
                        Console.WriteLine("O que você gostaria de fazer?");
                        Console.WriteLine("1. Depositar");
                        Console.WriteLine("2. Sacar");
                        Console.WriteLine("3. Ver Saldo");
                        Console.WriteLine("0. Sair");
                        Console.Write("\nEscolha uma opção:  ");
                        int opcaoCaixa = int.Parse(Console.ReadLine());

                        switch (opcaoCaixa)
                        {
                            case 1:
                                Console.Write("Digite o valor a ser depositado: ");
                                double valorDeposito = Convert.ToDouble(Console.ReadLine());
                                Depositar(valorDeposito);

                                Console.Write("\nPressione qualquer tecla para escolher outra operação: ");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Write("Digite o valor a ser sacado: ");
                                double valorSaque = Convert.ToDouble(Console.ReadLine());
                                Sacar(valorSaque);
                                Console.Write("\nPressione qualquer tecla para escolher outra operação: ");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.WriteLine($"Saldo atual: R${saldoConta}");
                                Console.Write("\nPressione qualquer tecla para escolher outra operação: ");
                                Console.ReadKey();
                                break;                            
                            case 0:
                                caixaMenu = false;
                                break;
                            default:
                                Console.WriteLine("\nOpção inválida! Pressione qualquer tecla para tentar novamente. ");
                                Console.ReadKey();
                                break;
                        }
                    }

                    Console.Write("\nPressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                case "0":
                    Console.Clear();
                    Console.Write("Você optou por sair. Pressione qualquer tecla para continuar. ");
                    Console.ReadKey();
                    mostrarMenu = false;
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.Write("Opção inválida! Pressione qualquer tecla para continuar. ");
                    Console.ReadKey();
                    Console.ResetColor();
                    break;
            }
        } while (mostrarMenu);
    }

    static void CalcularMedia(string nome, double n1, double n2, double n3, double media)
    {
        media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
        Console.WriteLine($"Olá, {nome}! Sua média nesta disciplina é: {media}.");
    }

    static void ClassificarIMC(double peso, double altura, double imc)
    {
        imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é: {imc}.");
        if (imc < 18.5)
        {
            Console.WriteLine("Classificação: Abaixo do peso.");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Classificação: Peso normal.");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Classificação: Sobrepeso.");
        }
        else
        {
            Console.WriteLine("Classificação: Obesidade.");
        }
    }

    static void GerarTabuada(int inteiro)
    {
        Console.WriteLine($"\nTabuada do {inteiro}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{inteiro} x {i} = {inteiro * i}");
        }
    }

    static double ConverterCelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double ConverterFahrenheitParaCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static void Depositar(double valorDeposito)
    {
        saldoConta += valorDeposito;
        Console.WriteLine($"Depósito de R${valorDeposito} realizado! Saldo atual: R${saldoConta}");
    }

    static void Sacar(double valorSaque)
    {
        if (valorSaque <= saldoConta)
        {
            saldoConta -= valorSaque;
            Console.WriteLine($"Saque de R${valorSaque} realizado! Saldo atual: R${saldoConta}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

}
        