using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1) Criar uma rotina de entrada que aceite somente um
            ////valor positivo.

            //int num = 0;

            //while (num <= 0)
            //{
            //    Console.Write("Digite um valor positivo: ");
            //    num = int.Parse(Console.ReadLine());
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Valor positivo: {0}", num);
            //Console.ReadKey();

            //// 2) Entrar com 2 (dois) valores via teclado, onde o segundo
            //// deverá ser maior que o primeiro.Caso contrário solicitar
            //// novamente apenas o segundo valor. 

            //int A = 0, B = 0;

            //Console.Write("Valor de A: ");
            //A = int.Parse(Console.ReadLine());

            //while (B < A)
            //{
            //    Console.Write("Valor de B: ");
            //    B = int.Parse(Console.ReadLine());
            //}
            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.Write("Valor de A: {0}, Valor de B: {1}", A, B);
            //Console.ReadKey();

            ////3) Entrar via teclado com o sexo de determinado usuário,
            ////aceitar somente “F” ou “M” como respostas válidas.

            //char S = ' ';
            //string Sex = "";

            //while (S != 'F' && S != 'M')
            //{
            //    Console.Write("Digite seu sexo: [F]eminino ou [M]asculino: ");
            //    S = Char.ToUpper(Console.ReadLine()[0]);
            //}
            //switch (S)
            //{
            //    case 'M':
            //        Sex = "Masculino";
            //        break;
            //    case 'F':
            //        Sex = "Feminino";
            //        break;
            //}

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(Sex);

            //Console.ReadKey();

            //// 4) Exibir a tabuada do número 5(cinco) no intervalo de
            //// um a dez.

            //int num = 5, total = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    total = i * num;
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("{0} x {1} = {2}", i, num, total);
            //}

            //Console.ReadKey();

            //// 5) Entrar via teclado com um valor qualquer. Travar a
            //// digitação, no sentido de aceitar somente valores
            //// positivos. Após a digitação, exibir a tabuada do valor
            //// solicitado, no intervalo de um a dez.

            //int num = 0, total = 0;

            //while (num <= 0)
            //{
            //    Console.Write("Digite um valor positivo: ");
            //    num = int.Parse(Console.ReadLine());
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    total = i * num;
            //    Console.WriteLine("{0} x {1} = {2}", num, i, total);
            //}

            //Console.ReadKey();

            //// 6) Entrar via teclado com um valor (X) qualquer. Travar a
            //// digitação, no sentido de aceitar somente valores
            //// positivos. Solicitar o intervalo que o programa que
            //// deverá calcular a tabuada do valor digitado, sendo
            //// que o segundo valor (B), deverá ser maior que o
            //// primeiro (A), caso contrário, digitar novamente
            //// somente o segundo. Após a validação dos dados,
            //// exibir a tabuada do valor digitado, no intervalo
            //// decrescente, ou seja, a tabuada de X no intervalo de
            //// B para A.

            //int X = 0, A = 0, B = 0, total = 0;

            //while (X <= 0)
            //{
            //    Console.Write("Fazer tabuada do: ");
            //    X = int.Parse(Console.ReadLine());
            //}

            //while (A <= 0)
            //{
            //    Console.Write("De: ");
            //    A = int.Parse(Console.ReadLine());
            //}

            //while (B <= A)
            //{
            //    Console.Write("Até: ");
            //    B = int.Parse(Console.ReadLine());
            //}

            //for (int i = B; i >= A; i--)
            //{
            //    total = X * i;
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("{0} x {1} = {2}", X, i, total);
            //    B--;
            //}

            //Console.ReadKey();

            //// 7) Exibir a tabuada dos valores de um a vinte, no intervalo
            //// de um a dez. Entre as tabuadas, solicitar que o usuário
            //// pressione uma tecla.

            //int tabuada = 1, total = 0;

            //for (int j = 1; j <= 20; j++)
            //{
            //    Console.Clear();
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        total = tabuada * i;
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("{0} x {1} = {2}", tabuada, i, total);
            //    }
            //    tabuada++;
            //    Console.WriteLine("Pressione uma tecla");
            //    Console.ReadKey();
            //}

            //Console.ReadKey();

            //// 8) Exibir a soma dos números inteiros positivos do intervalo
            //// de um a cem. 

            //int A = 1, B = 100, total = 0;

            //for (int i = A; i <= B; i++)
            //{
            //    total += A;
            //    A++;
            //};
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("A soma dos números inteiro de 1 até 100 = {0}", total);

            //Console.ReadKey();

            //// 9) Descreva um programa que receba via teclado 10
            //// (dez) valores e que, ao final, exiba o maior e menor
            //// deles.

            //int num = 0, maxNum = 0, minNum = 0;

            //Console.Write("1- Digite um número: ");
            //num = int.Parse(Console.ReadLine());
            //maxNum = num;
            //minNum = num;

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.Write("{0}- Digite um número: ", i + 1);
            //    num = int.Parse(Console.ReadLine());
            //    if (num < minNum)
            //    {
            //        minNum = num;
            //    }
            //    if (num > maxNum)
            //    {
            //        maxNum = num;
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("O número mínimo é {0} e o número máximo é {1}", minNum, maxNum);

            //Console.ReadKey();

            ////10) Exibir os 30(trinta) primeiros valores da série de
            ////Fibonacci.A série: 0, 1, 1, 2, 3, 5, 8, ... 

            //int a = 0, b = 1, c = 0;
            //for (int i = 3; i <= 30; i++)
            //{
            //    c = a + b;
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("{0}+{1}={2}", a, b, c);
            //    a = b;
            //    b = c;
            //}

            //Console.ReadKey();
        }

    }

}