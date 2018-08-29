using System;

namespace listadia28
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTAO1
            Console.Write("\nQUESTÃO 1\n\n");
            int fsa;
            fsa = 1;
            while (fsa <= 40)
            {
                Console.Write(fsa);
                Console.Write("\t");
                fsa = fsa + 1;
            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();

            // QUESTAO2
            Console.Write("\nQUESTÃO 2\n\n");
            int x;
            int y;
            x = 2;
            y = 3;

            {
                Console.WriteLine("x =" + x);
                Console.WriteLine("o valor de x + x é " + (x + x));
                Console.WriteLine("x = ");
                Console.WriteLine((x + y) + " = " + (y + x));

            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();

            //QUESTAO3
            Console.Write("\nQUESTÃO 3\n\n");

            {
                Console.WriteLine("*\n**\n***\n****\n*****");

            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();

            //QUESTAO4
            Console.Write("\nQUESTÃO 4\n\n");

            {
                Console.Write("*");
                Console.Write("***");
                Console.WriteLine("*****");
                Console.Write("****");
                Console.WriteLine("**");

            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();

            //QUESTAO5
            Console.Write("\nQUESTÃO 5\n\n");

            {
                Console.WriteLine("Digite seu nome");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite seu sobrenome");
                var sobrenome = Console.ReadLine();

                Console.WriteLine("Digite sua matrícula");
                var matricula = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($" {matricula}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {nome} {sobrenome}");

                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();

            // QUESTAO6
            Console.Write("\nQUESTÃO 6\n\n");

            {
                Console.WriteLine("Digite um número");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite outro número");
                int num2 = int.Parse(Console.ReadLine());

                int resultado = 0;
                resultado = num1 + num2;
                Console.Write("\n Soma: {0}\n", resultado);
                resultado = 0;
                resultado = num1 - num2;
                Console.Write(" Subtração: {0}\n", resultado);
                resultado = 0;
                resultado = num1 * num2;
                Console.Write(" Multiplicação: {0}\n", resultado);
                resultado = 0;
                resultado = num1 / num2;
                Console.Write(" Divisão: {0}", resultado);
                resultado = 0;


            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();


            //QUESTAO7
            Console.Write("\nQUESTÃO 7\n\n");

            {
                Console.WriteLine("Digite o raio do círculo");
                int raio1 = int.Parse(Console.ReadLine());

                int diametro;
                double circunferencia, area;
                diametro = raio1 * 2;
                Console.Write("\n Diâmetro: {0}\n", diametro);
                circunferencia = raio1 * 2 * 3.14;
                Console.Write("\n Circunferência: {0}\n", circunferencia);
                area = 3.14 * raio1 * raio1;
                Console.Write("\n Área: {0}\n", area);


            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();

            //QUESTAO8
            Console.Write("\nQUESTÃO 8\n\n");

            {
                Console.WriteLine("Digite o primeiro número");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número");
                int num2 = int.Parse(Console.ReadLine());

                if (num1 % num2 == 0)
                {
                    Console.Write("\nO número {0} é múltiplo de {1}", num1, num2);
                }
                else
                {
                    Console.Write("\nO número {0} não é múltiplo de {1}", num1, num2);
                }



            }
            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();


            //QUESTAO9
            Console.Write("\nQUESTÃO 9\n\n");

            {
                int aux;

                Console.WriteLine("Digite um número de 5 dígitos ");
                int num = int.Parse(Console.ReadLine());

                aux = num / 10000;
                Console.Write(aux + "   ");

                aux = num / 1000;
                aux = aux % 10;
                Console.Write(aux + "   ");

                aux = num / 100;
                aux = aux % 10;
                Console.Write(aux + "   ");

                aux = num / 10;
                aux = aux % 10;
                Console.Write(aux + "   ");

                aux = num % 10;
                Console.Write(aux + "   ");
            }

            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();



            //QUESTÃO 10

            {
                Console.Write("Número\t\tQuadrado\tCubo\n");


                int num;
                num = 1;
                while (num <= 10)
                {
                    Console.Write(num + "\t\t");
                    Console.Write(num * num + "\t\t");
                    Console.Write(num * num * num + "\n");
                    num++;
                }

                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();
            }
        }







    }

}

