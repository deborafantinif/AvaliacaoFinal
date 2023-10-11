using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoFinal
{
    internal class Exercicio02
    {
        static public void Calculator()
        {
            int resultMultiplication = 0;
            int resultDivision = 0;
            int restOfDivision = 0;
            List<int> chosenNumbers = new List<int>();


            try
            {
                Console.WriteLine("Digite 2 números inteiros para ser realizada a operação de multiplicação e divisão");
                for (int i = 0; i < 2; i++)
                {
                    Console.Write($"{i + 1}º número: ");
                    do
                    {
                        if (int.TryParse(Console.ReadLine(), out int chosenNumber))
                        {
                            chosenNumbers.Add(chosenNumber);
                            if (i == 0)
                            {
                                restOfDivision = chosenNumber;
                            }
                            break;
                        }
                        else
                        {
                            Console.Write($"Caracteres inseridos inválidos, digite {i + 1}° número corretamente: ");
                        }
                    } while (true);
                }

                // MULTIPLICAÇÃO
                for (int i = 0; i < chosenNumbers[1]; i++)
                {
                    resultMultiplication += chosenNumbers[0];
                }

                //DIVISÃO
                while (true)
                {
                    restOfDivision = restOfDivision - chosenNumbers[1];      
                    if (restOfDivision >= 0)
                    {
                        resultDivision++;
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine($"Entre os números escolhidos [{string.Join(", ", chosenNumbers)}], temos os resultados:" +
                    $"\n MULTIPLICAÇÃO: {resultMultiplication}" +
                    $"\n DIVISÃO: {resultDivision}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Menu.View();

        }
    }
}
