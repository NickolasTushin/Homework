Console.Clear();

Console.WriteLine("Введите первое число ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > b && a > c) 
{
max = a;
    Console.WriteLine($"{a} максимальное число ");
}
if (b > a && b > c) 
{
max = b;
    Console.WriteLine($"{b} максимальное число ");
}

if (c > a && c > b) 
{
max = c;
    Console.WriteLine($"{c} максимальное число ");
}







else if (b > a && b > c)
{
b = max;
    Console.WriteLine($"{b} максимальное число ");
}
