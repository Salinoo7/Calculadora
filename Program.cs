using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] argrs)
        {
            Calculadora calc = new Calculadora();
            string opcaoUsuario = EscolherOperacao();
            Console.WriteLine(opcaoUsuario);

            while (opcaoUsuario.ToUpper() != "X")
            {
                double num1;
                double num2;
                double resultado;

                Console.WriteLine("Digite o primeiro numero : ");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo numero : ");
                num2 = double.Parse(Console.ReadLine());

                switch (opcaoUsuario)
                {
                    case "1":
                        resultado = calc.Somar(num1, num2);
                        Console.WriteLine($"RESULTADO : {resultado}");
                        break;
                    case "2":
                        resultado = calc.Subtrair(num1, num2);
                        Console.WriteLine($"RESULTADO : {resultado}");
                        break;
                    case "3":
                        resultado = calc.Multiplicar(num1, num2);
                        Console.WriteLine($"RESULTADO : {resultado}");
                        break;
                    case "4":
                        resultado = calc.Dividir(num1, num2);
                        Console.WriteLine($"RESULTADO : {resultado}");
                        break;
                    default:
                        throw new ArgumentException();
                }

                opcaoUsuario = EscolherOperacao();
            }
        }

        private static string EscolherOperacao()
        {
            Console.WriteLine();
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("====================");
            Console.WriteLine("Qual operação deseja realizar? ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBITRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO ");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("X - SAIR");
            Console.WriteLine("====================");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
