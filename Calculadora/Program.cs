using System;
using System.ComponentModel.Design;

namespace Calculadora
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------||| CALCULADORA EM C# |||-------------------");
            Console.WriteLine("ESCOLHA ALGUMA OPERAÇÃO");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("5 - SAIR");
            Console.WriteLine("---------------------");
            

            if (short.TryParse(Console.ReadLine(), out short operador)) {
                switch (operador)
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

                    default:
                        Console.Clear();
                        Menu();
                        break;
                }

                
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("ERRO#0001: OPERAÇÃO INVALIDA");
                Console.WriteLine(" ");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                Console.ReadLine();
                Menu();
            }

        }


        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("PRIMEIRO VALOR: ");
            float num1;
            while(!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.Clear();
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO");
            }

            Console.WriteLine("SEGUNDO VALOR: ");
            float num2;
            while(!float.TryParse(Console.ReadLine(),out num2))
            {
                Console.Clear();
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO");
            }

            float resultado = num1 + num2;

            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da soma é = {resultado}");

            Console.ReadLine();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("PRIMEIRO VALOR: ");
            float num1;
            while(!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.Clear();
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO");
            }

            Console.WriteLine("SEGUNDO VALOR: ");
            float num2;
            while(!float.TryParse(Console.ReadLine(),out num2))
            {
                Console.Clear();
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO");
            }

            float resultado = num1 - num2;

            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da subtração é = {resultado}");

            Console.ReadLine();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("PRIMEIRO VALOR: ");
            float num1;
            while(!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.Clear();
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO");
            }
            
            Console.WriteLine("SEGUNDO VALOR: ");
            float num2;
            while (!float.TryParse(Console.ReadLine(),out num2))
            {
                Console.Clear();
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO");
            }
            float resultado = num1 / num2;

            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da divisão é = {resultado}");

            Console.ReadLine();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("PRIMEIRO VALOR: ");
            float num1;
            while (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO!");
            }

            Console.WriteLine("SEGUNDO VALOR: ");
            float num2;
            while (!float.TryParse(Console.ReadLine(),out num2))
            {
                Console.WriteLine("VALOR INVALIDO, DIGITE UM NUMERO!");
            }


            float resultado = num1 * num2;
            Console.WriteLine(" ");
            Console.WriteLine($"O resultado da multiplicação é = {resultado}");

            Console.ReadLine();
            Menu();
        }
    }
}
