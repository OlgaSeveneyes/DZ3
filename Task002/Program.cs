int x1, x2, y1, y2, z1, z2; 

try
{
    Console.Write("Введите x1: ");
    x1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите y1: ");
    y1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите z1: ");
    z1 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите x2: ");
    x2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите y2: ");
    y2 = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите z2: ");
    z2 = int.Parse(Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка ввода! Необходимо ввести число. {exc.Message}");
    return;

}

double length = Math.Sqrt (Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)); 
Console.WriteLine(length);