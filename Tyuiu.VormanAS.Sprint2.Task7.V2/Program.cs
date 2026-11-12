using Tyuiu.VormanAS.Sprint2.Task7.V2.Lib;

DataService ds = new DataService();

double x, y;
bool res;

Console.Title = "Спринт #2 | Выполнил: Ворман А. С. | ИСПБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #2.7                                                            *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Ворман Анна Сергеевна | ИСПБ-26-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с               *");
Console.WriteLine("* координатами X, Y в заштрихованной области.                             *");
Console.WriteLine("* Заштрихованная область: внутри единичной окружности x^2 + y^2 = 1       *");
Console.WriteLine("* и не выше прямой y = x / 2.                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение переменной x = ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение переменной y = ");
y = Convert.ToDouble(Console.ReadLine());
res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Точка в заштрихованной области: " + res);

Console.ReadKey();
