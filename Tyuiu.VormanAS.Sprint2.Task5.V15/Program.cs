using Tyuiu.VormanAS.Sprint2.Task5.V15.Lib;

DataService ds = new DataService();

int k;
string res;

Console.Title = "Спринт #2 | Выполнил: Ворман А. С. | ИСПБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Оператор switch                                                   *");
Console.WriteLine("* Задание #2.5                                                            *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнил: Ворман Анна Сергеевна | ИСПБ-26-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch и вычисляет      *");
Console.WriteLine("* требуемое значение и возвращает результат.                              *");
Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
Console.WriteLine("* (понедельником, вторником, ..., субботой или воскресеньем) является     *");
Console.WriteLine("* k-й день невисокосного года, в котором 1 января понедельник.            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение переменной k = ");
k = Convert.ToInt32(Console.ReadLine());
res = ds.FindDayName(k);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("День недели: " + res);

Console.ReadKey();
