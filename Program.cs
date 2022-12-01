/*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
para ser responsável pelos cálculos.*/

using ExercStaticMethods;
using System.Globalization;

Console.Write("Qual a cotação do dólar? ");
double cotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double value = ConversorDeMoeda.Converter(cotation,money);

Console.WriteLine("Valor a ser pago em reais: = " + value.ToString("F2", CultureInfo.InvariantCulture));

