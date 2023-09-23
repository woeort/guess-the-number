Random rand = new Random();
int i = rand.Next(2);
int count = 1;
Console.WriteLine("Отгадайте число от 0 до 30. У тебя всего лишь 5 попыток. Удачи!");
Console.WriteLine("Введите число:");
int k = Convert.ToInt32(Console.ReadLine());
while (count <= 5)
{
    if (i == k)
    {
        Console.WriteLine("Победа! Это было число " + k + "!");
        break;
    }
    else
    {
        count++;
        if (count == 5)
        {
            Console.WriteLine("Увы, вы не отгадали загаданное число. Это было число " + i + "!");
            break;
     
        }
        Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
        k = Convert.ToInt32(Console.ReadLine());

    }

}
Console.ReadLine();
