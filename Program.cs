
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LISTA DE EXERCÍCIOS: ===");

            Console.WriteLine("+-----------------+");
            Console.WriteLine("| 1 - Lista 1     |");
            Console.WriteLine("| 2 - Lista 2     |");
            Console.WriteLine("| 3 - Lista 3     |");
            Console.WriteLine("| 4 - Lista 4     |");
            Console.WriteLine("| 5 - Lista 5     |");
            Console.WriteLine("| 6 - Lista Extra |");
            Console.WriteLine("+-----------------+");

            int menu = 0;
            try
            {
                menu = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
                menu = 0;
            }

            switch (menu)
            {
                // Lista 1
                case 1:
                    ExercicioUm.Call();
                    break;
                // Lista 2
                case 2:
                    ExercicioDois.Call();
                    break;
                // Lista 3
                case 3:
                    ExercicioTres.Call();
                    break;
                // Lista 4
                case 4:
                    ExercicioQuatro.Call();
                    break;
                // Lista 5
                case 5:
                    ExercicioCinco.Call();
                    break;
                // Lista Extra
                case 6:
                    ExercicioExtra.Call();
                    break;
                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }
    }
}