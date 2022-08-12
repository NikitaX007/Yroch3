Console.WriteLine("Ведите координаты точки А: ");
Console.Write("Первая точка = ");
double x1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Вторая точка = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Третья точка = ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ведите координаты точки B: ");
Console.Write("Первая точка = ");
double x2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Вторая точка = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Третья точка = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x2), 2)
              + Math.Pow((y1 - y2), 2)
              + Math.Pow((z1 - z2), 2));

Console.WriteLine($"Расстояние между точками A и B = {result:F}");