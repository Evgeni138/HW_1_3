int number = 121321;
int a = 0;
int num = number;
while (num > 0)
{
    num = num / 10;
    a++;
}
int[] arr = new int[a];

int position = 0;
while (position < a)
{
    arr[position] = number % 10;
    number = number / 10;
    position++;
}
int index = 0;
while (index < position)
{
    if (arr[index] == arr[position - 1])
    {
        index = index + 1;
        position = position - 1;
        if (index > position || index == position)
        {
            Console.WriteLine("Это число является полиндромом");
        }
    }
    else
    {
        Console.WriteLine("Это число не является полиндромом");
        break;
    }
}
