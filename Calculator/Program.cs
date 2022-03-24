using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha qual tipo de calculo deseja realizar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Digite a opção desejada:");

            short resultado = short.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1:
                    Soma();
                break;
                case 2:
                    Subtracao();
                break;
                case 3:
                    Multiplicacao();
                break;
                case 4:
                    Divisao();
                break;
                case 5:
                    System.Environment.Exit(0);
                break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Digite o primeiro numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da soma é: {num1 + num2}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da subtração é: {num1 - num2}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da multiplicação é: {num1 * num2}" );
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"O resultado da divisão é: {num1 / num2}");
            Console.ReadKey();
            Menu();
        }
        
        
    }
}