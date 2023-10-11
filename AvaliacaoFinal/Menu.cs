using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoFinal
{
    internal class Menu
    {
        static public void View()
        {
            Console.WriteLine("--------Escolha a opção desejada----------" +
                "\n 1 - Verificação de números" +
                "\n 2 - Calculadora" +
                "\n 3 - Verificação de frase" +
                "\n 4 - Sair");

            int option;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int chosenNumber) && chosenNumber >= 1 && chosenNumber <= 4)
                {
                    option = chosenNumber;
                    break;
                }
                else
                {
                    Console.Write("Caracteres inseridos inválidos, digite um número de 1 a 4: ");
                }
            } while (true);

            switch (option)
            {
                case 1:
                    Exercicio01.handleNumbers();
                    break;

                case 2:
                    Exercicio02.Calculator();
                    break;

                case 3:
                    Exercicio03.handlePhrase();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção errada");
                    break;
            }
        }
    }
}
