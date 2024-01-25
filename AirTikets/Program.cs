using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTikets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = { 6, 25, 15, 15, 17 };
            bool isOpen = true;


            while (isOpen)
            {
                Console.SetCursorPosition(0, 18);
                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($" В секторе {i + 1} свободно {sectors[i]} мест. ");

                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("регистрация рейса");
                Console.WriteLine("\n\n1 - забронировать места \n\n2 - выход из програмы.\n\n");
                Console.Write("Введите номер команды: ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int userSector, userPlaceAmount;
                        Console.Write(" В каком сектре вы хотите лететь? ");
                        userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (sectors.Length <= userSector || userSector < 0)
                        {
                            Console.WriteLine("Такого сектора не существует.");
                            break;
                        }
                        Console.Write("Сколько мест вы хотите забронировать? ");
                        userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                        if (userPlaceAmount < 0)
                        {
                            Console.WriteLine("Неверно количество мест.");
                            break;
                        }
                        if (sectors[userSector] < userPlaceAmount)
                        {
                            Console.WriteLine($"В секторе {userSector + 1} недостаточно мест."
                                + $"Остаток {sectors[userSector]} ");
                            break;
                        }
                        sectors[userSector] -= userPlaceAmount;
                        Console.WriteLine("бронирование успешно");
                        break;

                    case 2:
                        isOpen = false;
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("такой команды нет");
                       
                        break;
                }


                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
