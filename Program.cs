using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(@"Выберите нужное вам действие:
1. Добавить ВАЗ;
2. Добавить БМВ;
3. Добавить МАЗ;

4. Показать ВАЗ;
5. Показать БМВ;
6. Показать МАЗ;
7. Показать весь список;

8. Удалить машину из списка;
9. Удалить все машины из списка;

10. Выход
");

                string choice = Console.ReadLine();
                Console.WriteLine("");
                switch (choice)
                {
                    case "1":
                        cars.AddVaz();
                        Console.WriteLine();
                        break;
                    case "2":
                        cars.AddBmw();
                        Console.WriteLine();
                        break;
                    case "3":
                        cars.AddMaz();
                        Console.WriteLine();
                        break;
                    case "4":
                        cars.ShowVaz();
                        Console.WriteLine();
                        break;
                    case "5":
                        cars.ShowBmw();
                        Console.WriteLine();
                        break;
                    case "6":
                        cars.ShowMaz();
                        Console.WriteLine();
                        break;
                        case "8":
                        Console.Write("Какую машину хотите удалить? (1 - ВАЗ, 2 - БМВ, 3 - МАЗ) - ");
                        string choice2 = Console.ReadLine();
                        switch (choice2)
                        {
                            case "1":
                                cars.DelVaz();
                                break;
                            case "2":
                                cars.DelBmw();
                                break;
                            case "3":
                                cars.DelMaz();
                                break;
                            default:
                                Console.WriteLine("Неверный выбор");
                                break;
                        }
                        break;
                    case "7":
                        if (cars.vazes.Count == 0 && cars.bmws.Count == 0 && cars.mazes.Count == 0)
                        {
                            Console.WriteLine("Список пуст");
                            break;
                        }
                        else
                        {
                            cars.ShowAll();
                        }    
                        Console.WriteLine();
                        break;
                    case "9":
                            cars.DelAll();
                        break;
                    case "10":
                        Console.WriteLine("Выход из программы");
                        flag = false;
                        return;
                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }
            }
        }
    }
}
