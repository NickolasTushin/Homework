Console.Clear();

Console.WriteLine("Введите первое число ");

 int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");

 int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
Console.WriteLine($"Число {x} больше числа {y}");
}
else if (x < y)
{
Console.WriteLine($"Число {y} больше числа {x} ");
}
else 
{
Console.WriteLine("Числа равны");
}