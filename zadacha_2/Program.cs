// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

int DataNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}


void FindCoordinates(int number)
{
    if (number == 1) Console.WriteLine("x и y положительные");
    if (number == 2) Console.WriteLine("x отрицательный, а y положительный");
    if (number == 3) Console.WriteLine("x и y отрицательные");
    if (number == 4) Console.WriteLine("x положительный, а y отрицательный");
}

int num = DataNumber("Введите номер части n = ");
if (num> 5 || num < 0) Console.WriteLine("Номер числа от 1 до 4!");
FindCoordinates(num);
