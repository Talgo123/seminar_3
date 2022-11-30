// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


 int EnterPointCoordinate(string str)
{
    Console.WriteLine(str);
    double number1 = double.Parse(Console.ReadLine());
    return number1;
}

void FindDistance(double x1, double y1, double x2, double y2)
{
    double distance = Math.Sqrt (((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
    double roundedDistance = Math.Round(distance, 2); // округлил цифры после запятой
    Console.WriteLine($"Расстояние между двумя точками в 2D пространстве = {roundedDistance}");
}

double xA = EnterPointCoordinate("Введите x координату точки А");
double yA = EnterPointCoordinate("Введите y координату точки А");

double xB = EnterPointCoordinate("Введите x координату точки В");
double yB = EnterPointCoordinate("Введите y координату точки В");

FindDistance(xA, yA, xB, yB);
