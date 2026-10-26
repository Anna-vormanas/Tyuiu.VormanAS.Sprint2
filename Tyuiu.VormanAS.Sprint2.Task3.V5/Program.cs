using Tyuiu.VormanAS.Sprint2.Task3.V5.Lib;

DataService ds = new DataService();

double x;
double res;

Console.Title = "Спринт #2 | Выполнил: Ворман А. С. | ИСПБ-26-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #2                                                               *");
Console.WriteLine("* Тема: Вложенные операторы if-else                                       *");
Console.WriteLine("* Задание #2.3                                                            *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнил: Ворман Анна Сергеевна | ИСПБ-26-1                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
Console.WriteLine("* значение переменной X с клавиатуры.                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение переменной x = ");
x = Convert.ToDouble(Console.ReadLine());
res = ds.Calculate(x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Значение функции: " + res);

Console.ReadKey();
