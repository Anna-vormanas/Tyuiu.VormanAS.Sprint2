using Tyuiu.VormanAS.Sprint2.Task4.V20.Lib;

DataService ds = new DataService();

double x, y;
double res;

Console.Title = "Спринт #2 | Выполнил: Ворман А. С. | ИСПБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if-else                                       *");
Console.WriteLine("* Задание #2.4                                                            *");
Console.WriteLine("* Вариант #20                                                             *");
Console.WriteLine("* Выполнил: Ворман Анна Сергеевна | ИСПБ-26-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
Console.WriteLine("* переменных x, y с клавиатуры.                                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение переменной x = ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение переменной y = ");
y = Convert.ToDouble(Console.ReadLine());
res = ds.Calculate(x, y);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции: " + res);

Console.ReadKey();
