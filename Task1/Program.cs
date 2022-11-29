Console.Clear();

Console.WriteLine("Введите первое число ");

 int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");

 int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
Console.WriteLine("первое число больше");
}
else if (x < y)
{
Console.WriteLine("второе число больше");
}
else 
{
Console.WriteLine("Числа равны");
}