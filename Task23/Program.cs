int num, a = 1;
Console.WriteLine("Введите число");
num = Convert.ToInt32(Console.ReadLine());
while (a < num + 1)
{
    Console.WriteLine(a*a*a);
    a++;
}