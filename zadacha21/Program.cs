Console.Clear();

Console.WriteLine("Коородината x первой точки:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Коородината y первой точки:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Коородината z первой точки:");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Коородината x второй точки:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Коородината y второй точки:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Коородината z второй точки:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)));