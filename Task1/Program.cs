Console.Clear();

Console.WriteLine("Введите первое число ");

int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число ");

int b = int.Parse(Console.ReadLine());

if (a > b)
{
Console.WriteLine("первое число больше");
}
else if (a < b)
{
Console.WriteLine("второе число больше");
}
else 
{
Console.WriteLine("Числа равны");
}