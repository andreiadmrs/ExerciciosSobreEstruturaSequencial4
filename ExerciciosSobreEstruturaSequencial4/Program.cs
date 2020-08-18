using System;
using System.Globalization;

namespace ExerciciosSobreEstruturaSequencial4
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
 hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.*/

            Console.WriteLine("Digite abaixo seu número:");
           int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite abaixo a quantidade de horas trabalhadas:");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite abaixo o valor por hora:");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double salario = horas * valorPorHora;


            Console.WriteLine("Number "+numero+ "Salary is $" + salario.ToString("F2", CultureInfo.InvariantCulture)) ;

        }
    }
}
