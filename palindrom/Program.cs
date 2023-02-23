Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int x = number/10000;
int y = number%10;
if (x == y)
{
Console.WriteLine("Это палиндром");
}
else
{
Console.WriteLine("Не палиндром");
}