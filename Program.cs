// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число");
int number = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Int32.Parse(Console.ReadLine());
Console.WriteLine("Выберите знак: +, -, *, :, /, %");
char sign = Convert.ToChar(Console.ReadLine());
switch (sign)
{
    case '+':
        Console.WriteLine(number + number2);
        break;
    case '-':
        Console.WriteLine(number - number2);
        break;
    case '*':
        Console.WriteLine(number * number2);
        break;
    case ':':
    case '/':
        Console.WriteLine((double)number / number2);
        break;
    case '%':
        Console.WriteLine(number % number2);
        break;
}