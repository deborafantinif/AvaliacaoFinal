using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoFinal
{
    internal class Exercicio01
    {
        static public void handleNumbers()
        {
            List<int> chosenNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();
            List<int> positiveNumbers = new List<int>();
            List<int> negativeNumbers = new List<int>();

            try
            {
                Console.WriteLine("Digite 5 números inteiros a sua escolha");
                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{i + 1}º número: ");
                    do
                    {
                        if (int.TryParse(Console.ReadLine(), out int chosenNumber))
                        {
                            chosenNumbers.Add(chosenNumber);
                            break;
                        }
                        else
                        {
                            Console.Write($"Caracteres inseridos inválidos, digite {i + 1}° número corretamente: ");
                        }
                    } while (true);
                }

                for (int i = 0; i < chosenNumbers.Count; i++)
                {
                    if (chosenNumbers[i] % 2 == 0)
                    {
                        evenNumbers.Add(chosenNumbers[i]);
                    }
                    else
                    {
                        oddNumbers.Add(chosenNumbers[i]);
                    }
                    if (chosenNumbers[i] >= 0)
                    {
                        positiveNumbers.Add(chosenNumbers[i]);
                    }
                    else
                    {
                        negativeNumbers.Add(chosenNumbers[i]);
                    }
                }

                Console.WriteLine($"Entre os números escolhidos [{string.Join(", ", chosenNumbers)}], temos:" +
                    $"\n NÚMEROS PARES: {evenNumbers.Count} - [{string.Join(", ", evenNumbers)}]" +
                    $"\n NÚMEROS ÍMPARES: {oddNumbers.Count} - [{string.Join(", ", oddNumbers)}]" +
                    $"\n NÚMEROS POSITIVOS: {positiveNumbers.Count} - [{string.Join(", ", positiveNumbers)}]" +
                    $"\n NÚMEROS NEGATIVOS: {negativeNumbers.Count} - [{string.Join(", ", negativeNumbers)}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Menu.View();

        }
    }
}
