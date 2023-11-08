// добавить дату, и добавить её в файл (нужно узнать нужно ли это) (Data now) (можно взять из ежедневника)    ^<>^
// добавить начало и конец на ентер и ескейп     ^<>^
//    добавить проверку наличия файла история заказов, если он есть то дополнить новый заказ, если нет, то создать заново  (возможно не делать добавление срезу ту а сделать его позже, в стрелочном мненю выбора (сначала просто создать файл, а потом с трелочном меню начать его дополнять))  (СДЕЛАНО ТОЛЬКО ОТЧАСТИ ТАК КАК ЗАПИСЬ В ФАЙЛ УЖЕ СОЗДАЁТСЯ ИЛИ ИСПОЛЬЗУЕТСЯ)   ^<>^ 

//  ДОБАВИТЬ ЗАПИСЬ В КОНЕЦ ФАЙЛА, А ТО ОН БУДЕТ ПЕРЕЗАПИСЫВАТЬСЯ

//    добавить стрелочное меню из календыря, желательно адаптировать его в классы    ^<>^
//    добавить критерии тортов из одной из работ в классе (пицаа)
//    сохранить в массив развые позиции заказа, а потом сложить их
//    добавить при завершении заказа добавление в файл сумму заказа (возможно его состав(тогда придётся добавить в массив к стоимости позиций и их название, либо создать новый))   (массивы наверное сделать сверху)

//    добавление создания нового заказа   ^<>^
//  если да то сделать перенос в стрелочное меню и обнулить массив со стоимостью (составом прошлого заказа)   ^<>^
//  если нет то завершить заказ  ^<>^
// int post = Menu.men(1, 5);

using System;
using Cl1;
using Cl2;

class Calculator
{
    static DateTime now = DateTime.Now;            // ${DateTime.Now}  (Для вывода)
    static string userName = Environment.UserName;      // Определение имени усройства
    static string txt;                                  // переменная для записи в файл данных

    static void Main()
    {
        Console.WriteLine("Добро пожаловать. Нажмите на Enter клавишу для запуска.\n");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
            {
                break;
            }
        }
        Console.Clear();

        Tortik 

        txt = $"{DateTime.Now}";                                                                                       //  МЕСТО ВВОДА ДАННЫХ В ФАЙЛ
        
        Console.WriteLine(txt);            // удалить позже или заменить

        string path = $"C:\\Users\\{userName}\\Desktop\\История заказов.txt";
        if (File.Exists(path))
        {
            ZapisON();
        }
        else
        {
            ZapisOFF();
        }

        Noviy();
    }

    static void ZapisOFF()                                                                                             // БЛОК ЗАПИСИ В ФАЙЛ
    {
        File.WriteAllText($"C:\\Users\\{userName}\\Desktop\\История заказов.txt", txt);
    }

    static void ZapisON()                                                                                             // БЛОК ЗАПИСИ В КОНЕЦ ФАЙЛА
    {
        File.AppendAllText($"C:\\Users\\{userName}\\Desktop\\История заказов.txt", $"\n{txt}");
    }

    static void Exit()                                                                        // БЛОК ВЫХОДА
    {
        Console.WriteLine("Завершение работы нажмите Escape.");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
            else
            {
                Console.Clear();
                Main();
            }
        }
    }

    static void Noviy()                                                                        // БЛОК ВЫБОРА НОВОГО ЗАКАЗА (ВОЗМОЖНО ПРИДЁТСЯ ПЕРЕНЕСТИ В MAIN)
    {
        Console.WriteLine("Если хотите создать новый заказ нажмите Enter, если нет то нажмите Escape.");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                return;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Main();
            }
        }
    }
}