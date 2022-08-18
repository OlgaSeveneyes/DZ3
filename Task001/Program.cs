Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();
int numI;
int num1;
int num2;
int num4;
int num5;

if (int.TryParse(num, out numI))
{
    if (numI < 10000)
    {
        Console.WriteLine("Ошибка ввода! Введите пятизначное число: ");  
    }
    else if (numI > 99999)
    {
        Console.WriteLine("Ошибка ввода! Введите пятизначное число: ");
    }
    else
    {
        num5 = numI % 10;
        num1 = numI / 10000;
        
        if (num1 == num5)
        {
            num4 = (numI % 100) / 10;
            num2 = (numI % 10000) / 1000; 
                   
            if (num2 == num4)
            {
                Console.WriteLine("Да");  
            }
            else 
            {
                Console.WriteLine("Нет");   
            }
        }
        else
        {
         Console.WriteLine("Нет");   
        }
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
} 

