using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoFinal
{
    internal class Exercicio03
    {
        static public void handlePhrase()
        {
            int resultMultiplication = 0;
            int resultDivision = 0;
            int restOfDivision = 0;
            List<int> chosenNumbers = new List<int>();


            try
            {
                Console.WriteLine("Digite uma frase: ");
                string phrase = Console.ReadLine();
                string[] wordsWithoutFormat = phrase.Split(' ');
                List<string> words = new List<string>();
                List<string> allUpper = new List<string>();
                List<string> firstUpper = new List<string>();
                List<string> allLower = new List<string>();
                List<string> firstLower = new List<string>();

                for (int i = 0; i < wordsWithoutFormat.Length; i++)
                {
                    if (wordsWithoutFormat[i].Length > 0)
                    {
                        words.Add(wordsWithoutFormat[i]);
                    }
                }

                for (int i = 0; i < words.Count; i++)
                {
                    int lowerNumber = 0;
                    int upperNumber = 0;
                    List<bool> lowerCases = new List<bool>();
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (char.IsLower(words[i][j]))
                        {
                            lowerCases.Add(true);
                            lowerNumber++;
                        }
                        else
                        {
                            lowerCases.Add(false);
                            upperNumber++;
                        }
                    }
                    if (lowerNumber == 0)
                    {
                        allUpper.Add(words[i]);
                    }
                    if (lowerNumber == words[i].Length)
                    {
                        allLower.Add(words[i]);
                    }
                    if (lowerNumber == words[i].Length - 1 && lowerCases[0] == false)
                    {
                        firstUpper.Add(words[i]);
                    }
                    if (lowerNumber == 1 && upperNumber == words[i].Length - 1)
                    {
                        firstLower.Add(words[i]);
                    }
                }

                Console.WriteLine($"Dentro da frase \"{phrase}\", temos:" +
                    $"\n NÚMERO DE PALAVRAS: {words.Count}" +
                    $"\n NÚMEROS DE PALAVRAS MAIÚSCULAS: {allUpper.Count} - [{string.Join(", ", allUpper)}]" +
                    $"\n NÚMEROS DE PALAVRAS MINÚSCULAS: {allLower.Count} - [{string.Join(", ", allLower)}]" +
                    $"\n NÚMEROS DE PALAVRAS SOMENTE COM A INICIAL MAIÚSCULAS: {firstUpper.Count} - [{string.Join(", ", firstUpper)}]" +
                    $"\n NÚMEROS DE PALAVRAS SOMENTE COM A INICIAL MINÚSCULA: {firstLower.Count} - [{string.Join(", ", firstLower)}]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Menu.View();

        }
    }
}

