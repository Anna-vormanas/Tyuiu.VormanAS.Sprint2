using Tyuiu.VormanAS.Sprint2.Task6.V13.Lib;

DataService ds = new DataService();

int g, m, n;
string res;

Console.Title = "Спринт #2 | Выполнил: Ворман А. С. | ИСПБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Получение результата из switch                                    *");
Console.WriteLine("* Задание #2.6                                                            *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Ворман Анна Сергеевна | ИСПБ-26-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
Console.WriteLine("* оператора switch, вычисляет требуемое значение и возвращает результат.  *");
Console.WriteLine("* Дано: g (год), m (номер месяца), n (число). Определить дату следующего  *");
Console.WriteLine("* дня. Заданный год является високосным.                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение переменной g = ");
g = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение переменной m = ");
m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение переменной n = ");
n = Convert.ToInt32(Console.ReadLine());
res = ds.FindDateOfNextDay(g, m, n);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Дата следующего дня: " + res);

Console.ReadKey();
