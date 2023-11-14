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
    static int n, n1, n2;
    static int t, t1, t2;
    static int y, y1, y2;
    static int c, c1, c2;
    //static List<Tortik> n = new List<Tortik>();         // листы для записывания тортов
    //static List<Tortik> t = new List<Tortik>();
    //static List<Tortik> y = new List<Tortik>();
    //static List<Tortik> c = new List<Tortik>();

    static Tortik napoleon = new Tortik();
    static Tortik teramisu = new Tortik();
    static Tortik yagodnuy = new Tortik();
    static Tortik cremoviy = new Tortik();

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

        napoleon.Name = "Наполеон";
        napoleon.Forma = "Квадратный";
        napoleon.Razmer = "Средний";
        napoleon.Taste = "Кремовый";
        napoleon.Glazur = "Нет";
        napoleon.Decor = "Нет";
        napoleon.Price = 1200;

        teramisu.Name = "Терамису";
        teramisu.Forma = "Прямоугольный";
        teramisu.Razmer = "Маленький";
        teramisu.Taste = "Шоколад";
        teramisu.Glazur = "Нет";
        teramisu.Decor = "Шоколадная посыпка";
        teramisu.Price = 1500;

        yagodnuy.Name = "Ягодный";
        yagodnuy.Forma = "Круг";
        yagodnuy.Razmer = "Большой";
        yagodnuy.Taste = "Ягоды";
        yagodnuy.Glazur = "Нет";
        yagodnuy.Decor = "Ягоды";
        yagodnuy.Price = 1000;

        cremoviy.Name = "Кремовый";
        cremoviy.Forma = "Круг";
        cremoviy.Razmer = "Большой";
        cremoviy.Taste = "Крем";
        cremoviy.Glazur = "Есть";
        cremoviy.Decor = "Шарики";
        cremoviy.Price = 700;

        //n.Add(napoleon);
        //t.Add(teramisu);
        //y.Add(yagodnuy);
        //c.Add(cremoviy);

        //t[1].выбрать из листа нужный элемент
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню: ");
            Console.WriteLine($"  {napoleon.Name}");
            Console.WriteLine($"  {teramisu.Name}");
            Console.WriteLine($"  {yagodnuy.Name}");
            Console.WriteLine($"  {cremoviy.Name}");
            Console.WriteLine("  Закончить покупку");

            int post = Menu.men(1, 5);

            if (post == 1)
            {
                Console.Clear();
                Console.WriteLine("Название: " + napoleon.Name);
                Console.WriteLine("Форма: " + napoleon.Forma);
                Console.WriteLine("Размер: " + napoleon.Razmer);
                Console.WriteLine("Вкус: " + napoleon.Taste);
                Console.WriteLine("Глазурь: " + napoleon.Glazur);
                Console.WriteLine("Декор: " + napoleon.Decor);
                Console.WriteLine("Цена: " + napoleon.Price);
                Console.Write("Ввелите количество: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                n = n + n1;
            }
            if (post == 2)
            {
                Console.Clear();
                Console.WriteLine("Название: " + teramisu.Name);
                Console.WriteLine("Форма: " + teramisu.Forma);
                Console.WriteLine("Размер: " + teramisu.Razmer);
                Console.WriteLine("Вкус: " + teramisu.Taste);
                Console.WriteLine("Глазурь: " + teramisu.Glazur);
                Console.WriteLine("Декор: " + teramisu.Decor);
                Console.WriteLine("Цена: " + teramisu.Price);
                Console.Write("Ввелите количество: ");
                t1 = Convert.ToInt32(Console.ReadLine());
                t = t + t1;
            }
            if (post == 3)
            {
                Console.Clear();
                Console.WriteLine("Название" + teramisu.Name);
                Console.WriteLine("Форма:" + yagodnuy.Forma);
                Console.WriteLine("Размер: " + yagodnuy.Razmer);
                Console.WriteLine("Вкус: " + yagodnuy.Taste);
                Console.WriteLine("Глазурь: " + yagodnuy.Glazur);
                Console.WriteLine("Декор: " + yagodnuy.Decor);
                Console.WriteLine("Цена: " + yagodnuy.Price);
                Console.Write("Ввелите количество: ");
                y1 = Convert.ToInt32(Console.ReadLine());
                y = y + y1;
            }
            if (post == 4)
            {
                Console.Clear();
                Console.WriteLine("Название: " + cremoviy.Name);
                Console.WriteLine("Форма: " + cremoviy.Forma);
                Console.WriteLine("Размер: " + cremoviy.Razmer);
                Console.WriteLine("Вкус: " + cremoviy.Taste);
                Console.WriteLine("Глазурь: " + cremoviy.Glazur);
                Console.WriteLine("Декор: " + cremoviy.Decor);
                Console.WriteLine("Цена: " + cremoviy.Price);
                Console.Write("Ввелите количество: ");
                c1 = Convert.ToInt32(Console.ReadLine());
                c = c + c1;
            }
            if (post == 5)
            {
                break;
            }
            Console.SetCursorPosition(0, 7);
        }

        Console.Clear();
        n2 = n * napoleon.Price;
        t2 = t * teramisu.Price;
        y2 = y * yagodnuy.Price;
        c2 = c * cremoviy.Price;
        int summa = n2 + t2 + y2 + c2;

        txt = $"Заказ от {DateTime.Now} \n  Заказ:\n  {napoleon.Name}: {n}\n  {teramisu.Name}: {t}\n  {yagodnuy.Name}: {y}\n  {cremoviy.Name}: {c}\n  Итоговая сумма: {summa}";                                                                                       //  МЕСТО ВВОДА ДАННЫХ В ФАЙЛ
        
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