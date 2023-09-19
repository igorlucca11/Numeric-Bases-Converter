using System.Linq.Expressions;
using Calculator.bases;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Converter De Qual base numerica?");
            Console.WriteLine("1 - Hexadecimal");
            Console.WriteLine("2 - Decimal");
            Console.WriteLine("3 - Octal");
            Console.WriteLine("4 - Quaternary");
            Console.WriteLine("5 - Binary");
            var option1 = Int32.Parse(Console.ReadLine());
            var n = "";
            var input = "";
            Console.WriteLine("Para qual base numerica?");
            Console.WriteLine("1 - Hexadecimal");
            Console.WriteLine("2 - Decimal");
            Console.WriteLine("3 - Octal");
            Console.WriteLine("4 - Quaternary");
            Console.WriteLine("5 - Binary");
            var option2 = Int32.Parse(Console.ReadLine());
            var result = "";
            Console.WriteLine("Digite o numero");
            input = Console.ReadLine();
            switch (option1)
            {
                case 1:
                    n = Hexadecimal.FromHex(input);
                    break;
                case 2:
                    n = input;
                    break;
                case 3:
                    ;
                    n = Octal.From(input);
                    break;
                case 4:
                    ;
                    n = Quaternary.From(input);
                    break;
                case 5:
                    ;
                    n = Binary.From(input);
                    break;
                default:
                    Console.WriteLine("Opçào Invalida");
                    break;
            }
            switch (option2)
            {
                case 1:
                    result = Hexadecimal.ToHex(n);
                    break;
                case 2:
                    result = n;
                    break;
                case 3:
                    result = Octal.To(n);
                    break;
                case 4:
                    result = Quaternary.To(n);
                    break;
                case 5:
                    result = Binary.To(n);
                    break;
                default:
                    Console.WriteLine("Opçào Invalida");
                    break;
            }
            Console.WriteLine("Resultado: " + result);
            Console.WriteLine("Deseja Continuar?");
            Console.WriteLine("1 - Sim / 2 - Não");
            var option3 = Console.ReadLine();
            if (Int32.Parse(option3) == 1)
            {
                Program.Main();
            }
        }
    }
}