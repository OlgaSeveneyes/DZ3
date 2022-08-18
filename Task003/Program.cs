Console.Write("Введите число: ");
string? num = Console.ReadLine();
int numI;
int k = 1;

if (int.TryParse(num, out numI))
{
    while (k <= numI)
    {
        double cube = Math.Pow(k,3);
        Console.WriteLine(cube);
        k++;  
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
} 