
double EnterPointCoordinate(string str)
{
    Console.WriteLine(str);
    double number1 = double.Parse(Console.ReadLine());
    return number1;
}

void FindDistance(double numx1, double numy2, double numx3, double numy4)
{
    double distance = Math.Sqrt ((numx3 - numx1) * (numx3 - numx1) + (numy4 - numy2) * (numy4 - numy2));
    double roundedDistance = Math.Round(distance, 2);
    Console.WriteLine($"Расстояние между двумя точками в 2D пространстве = {roundedDistance}");
}

double xA = EnterPointCoordinate("Введите x координату точки А");
double yA = EnterPointCoordinate("Введите y координату точки А");
double xB = EnterPointCoordinate("Введите x координату точки В");
double yB = EnterPointCoordinate("Введите y координату точки В");

FindDistance(xA, xB, yA, yB);
