
using System;

public class ExercicioUm 
{
    public static void Call() 
    {
        Console.WriteLine("=== EXERCÍCIOS - LISTA 1 ===");

        Console.WriteLine("+-------------------------------------------------------+");
        Console.WriteLine("| 1 - Calcule a Média                                   |");
        Console.WriteLine("| 2 - Calcule a Área                                    |");
        Console.WriteLine("| 3 - Calcule o Volume                                  |");
        Console.WriteLine("| 4 - Valor é maior que o dobro de outro valor          |");
        Console.WriteLine("| 5 - Cálculo de Bhaskara                               |");
        Console.WriteLine("| 6 - Velocidade Média                                  |");
        Console.WriteLine("| 7 - Percentual de Imposto                             |");
        Console.WriteLine("| 8 - Valor é par ou ímpar                              |");
        Console.WriteLine("| 9 - Comparar dois valores de String                   |");
        Console.WriteLine("| 10 - Valor double em string e convertido para inteiro |");
        Console.WriteLine("| 11 - Imposto de renda de um salário                   |");
        Console.WriteLine("| 12 - DESAFIO                                         |");
        Console.WriteLine("+-------------------------------------------------------+");

        int menu = 0;
        try 
        {
            menu =  int.Parse(Console.ReadLine());
        } 
        catch (Exception e) 
        {
            Console.Error.WriteLine(e.Message);
            menu = 0;
        }

        switch (menu) 
        {
            // 1) Crie um programa que calcule a média (`(nota1 + nota2 + nota3 / 3)`)
            case 1:
                Media();
                break;
            // 2) Crie um programa que calcule a área (`lado1 * lado2`)
            case 2:
                Console.WriteLine("Digite o primeiro lado: ");
                double lado1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo lado: ");
                double lado2 = Convert.ToDouble(Console.ReadLine());
                Area( lado1,  lado2);
                break;
            // 3) Crie um programa que calcule o volume (`largura * altura * profundidade`)
            case 3:
                Volume();
                break;
            // 4) Crie um programa que avalie se um valor é maior do que o dobro de outro valor
            case 4:
                ValorMaiorQueDobro();
                break;
            // 5) Crie um programa que calcule _bhaskara_
            case 5:
                Console.WriteLine("Digite o valor de A:");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de B:");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor de C:");
                int c = int.Parse(Console.ReadLine());

                double[] bhaskara = Bhaskara(a, b, c);

                Console.WriteLine($"Valor de X1: {bhaskara[0]}");
                Console.WriteLine($"Valor de X2: {bhaskara[1]}");
                Console.ReadLine();
                break;
            // 6) Crie um programa que calcule a velocidade média de uma viagem (`distancia (km) / tempo (h)`)
            case 6:
                MediaViagem();
                break;
            // 7) Crie um programa que calcule o percentual de imposto pago (`faturamento \ qtd imposto`)
            case 7:
                PercentualImposto();
                break;
            // 8) Crie um programa que teste se um valor é par ou ímpar
            case 8:
                ParOuImpar();
                break;
            // 9) Crie um programa que compare dois valores Strings
            case 9:
                CompareString();
                break;
            // 10) Crie um programa que tenha uma variável com ponto em String e converta seu valor para inteiro
            case 10:
                string valor = Console.ReadLine(); 
                ConvertString( valor);
                break;
            // 11) Crie um programa que receba o salário e diga o valor de imposto de renda conforme abaixo:
            // Base                     | Alíquota
            // ---------                | ------
            // Até 1.903,98             | Isento
            // De 1.903,99 até 2.826,65 | 7,5%
            case 11:
            Console.WriteLine("Digite o salário:");
            double salario = double.Parse(Console.ReadLine());
            String impostoRenda = PercentualImpostoSalario(salario);
            Console.WriteLine($"O valor do imposto de renda é de {impostoRenda}.");
        break;
        // DESAFIO - Crie um programa que teste se um número é primo
        case 12:
            TestePrimo();
            break;
        default:
            Console.WriteLine("Operação inválida");
            break;
        }
    }



    public static void Media()
    {
        Console.WriteLine("Digite a nota 1:");
        var nota1 = Console.ReadLine();
        if (nota1 == null)
        {
            throw new Exception("Valor inválido");
        }

        Console.WriteLine("Digite a nota 2:");
        var nota2 = Console.ReadLine();
        if (nota2 == null)
        {
            throw new Exception("Valor inválido");
        }

        Console.WriteLine("Digite a nota 3:");
        var nota3 = Console.ReadLine();
        if (nota3 == null)
        {
            throw new Exception("Valor inválido");
        }

        float media = (float.Parse(nota1) + float.Parse(nota2) + float.Parse(nota3)) / 3;
        Console.WriteLine($"A média é {media}");
    }

    public static double Area(double lado1, double lado2)
    {
        if (lado1 == null || lado2 == null)
        {
            throw new Exception("Os valores não podem ser nulos.");
        }
        return lado1 * lado2;
    }

    public static void Volume()
    {
        Console.WriteLine("Insira a largura: ");
        int largura = int.Parse(Console.ReadLine());
        if (largura == null)
        {
            throw new Exception("Largura não pode ser nula");
        }
        Console.WriteLine("Insira a altura: ");
        int altura = int.Parse(Console.ReadLine());
        if (altura == null)
        {
            throw new Exception("Altura não pode ser nula");
        }
        Console.WriteLine("Insira a profundidade: ");
        int profundidade = int.Parse(Console.ReadLine());
        if (profundidade == null)
        {
            throw new Exception("Profundidade não pode ser nula");
        }
        int volume = largura * altura * profundidade;
        Console.WriteLine("Volume = {0}", volume);
    }

    public static void ValorMaiorQueDobro()
    {
        Console.WriteLine("Digite o primeiro valor:");
        
        int? _base = Convert.ToInt32(Console.ReadLine());
        if(_base == null)
        {
            throw new Exception("Valor 1 não pode ser nullo");
        }
        
        Console.WriteLine("Digite o segundo valor:");
        
        int? verificar = Convert.ToInt32(Console.ReadLine());
        if(verificar == null)
        {
            throw new Exception("Valor 2 não pode ser nullo");
        }
        
        if(_base > (verificar * 2))
        {
            Console.WriteLine($"O primeiro valor {_base} é maior que o dobro do segundo valor {verificar}");
        }
        else
        {
            Console.WriteLine($"O primeiro valor {_base} não é maior que o dobro do segundo valor {verificar}");
        }
    }

    public static double[] Bhaskara(int a, int b, int c)
    {
        if (a == null || b == null || c == null)
        {
            throw new Exception("Um dos valores recebidos está nulo");
        }

        double delta = (b * b) - (4 * a * c);
        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        return new double[] { x1, x2 };
    }

    public static void MediaViagem()
    {
        
        Console.Write("Digite a distância em km: ");
        double distancia = double.Parse(Console.ReadLine());
        Console.Write("Digite o tempo em horas: ");
        double tempo = double.Parse(Console.ReadLine());

        if (distancia == 0 || tempo == 0)
            throw new Exception("Valor inválido!");
        
        double velocidadeMedia = distancia / tempo;

        Console.WriteLine($"A velocidade media da viagem foi de {velocidadeMedia}Km/h");
    }

    public static void PercentualImposto()
{
    Console.WriteLine("Digite o faturamento:");
    double faturamento = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a quantidade de imposto:");
    double qtdImposto = double.Parse(Console.ReadLine());

    if (faturamento == null || qtdImposto == null)
    {
        throw new Exception("Os valores informados são inválidos!");
    }

    double impostoPago =  (faturamento / qtdImposto);

    Console.WriteLine("O percentual de imposto pago é:" + impostoPago);
}

    public static void ParOuImpar()
{
    Console.WriteLine("Digite o número:");
    string numero = Console.ReadLine();

    if (string.IsNullOrEmpty(numero))
    {
        throw new Exception("Valor não informado!");
    }

    int numeroConvertido = int.Parse(numero);
    if (numeroConvertido % 2 == 0)
    {
        Console.WriteLine($"O número {numeroConvertido} é par.");
    }
    else
    {
        Console.WriteLine($"O número {numeroConvertido} é ímpar.");
    }
}

    public static void CompareString()
    {
        Console.WriteLine("Digite o primeiro valor:");
        string valor1 = Console.ReadLine();
        Console.WriteLine("Digite o segundo valor:");
        string valor2 = Console.ReadLine();

        if (valor1 == null || valor2 == null)
        {
            throw new Exception("Um dos valores não pode ser nulo");
        }

        if (valor1 == valor2)
        {
            Console.WriteLine("Os valores são iguais");
        }
        else
        {
            Console.WriteLine("Os valores são diferentes");
        }
    }

    public static void ConvertString(String valor)
    { 
        int valorInteiro; 
        if (String.IsNullOrEmpty(valor)) 
        { 
            throw new Exception("Valor nullo ou vazio não podem ser convertidos"); 
        } 
        else 
        { 
            valorInteiro = Convert.ToInt32(valor.Replace(".", "")); 
        } 
        
        Console.WriteLine(valorInteiro); 
    } 

    public static string PercentualImpostoSalario(double salario)
        {
            if (salario <= 1903.98)
            {
                return "Isento";
            }
            else if (salario > 1903.98 && salario <= 2826.65)
            {
                return "7,5%";
            }
            else if (salario > 2826.66 && salario <= 3751.05)
            {
                return "15%";
            }
            else if (salario > 3751.06 && salario <= 4664.68)
            {
                return "22,5%";
            }
            else
            {
                return "27,5%";
            }
        }

    public static void TestePrimo(){

        Console.Write("Entre com um número: ");
        int numero = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0){
                contador++;
            }
        }

        // Verifica se o número é primo
        if (contador == 2){
        Console.WriteLine("O número {0} é primo", numero);
        }

        Console.WriteLine("O número {0} não é primo", numero);
    }
}