using Tyuiu.VormanAS.Sprint2.Task1.V16.Lib;

DataService ds = new DataService();

int a = 145;
int b = 716;
int c = 144;
int d = 137;

bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.Title = "Спринт #2 | Выполнил: Ворман А.С. | ИСПБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Логические операции                                               *");
Console.WriteLine("* Задание #2.1                                                            *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Ворман Анна Сергеевна | ИСПБ-26-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу из операций сравнений и логических операций          *");
Console.WriteLine("* а также арифметических выражений, которая вернет                        *");
Console.WriteLine("* логическую последовательность                                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"A = {a}");
Console.WriteLine($"B = {b}");
Console.WriteLine($"C = {c}");
Console.WriteLine($"D = {d}");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}