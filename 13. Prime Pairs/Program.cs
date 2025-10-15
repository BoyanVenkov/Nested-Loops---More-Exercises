int firstStart = int.Parse(Console.ReadLine());
int secondStart = int.Parse(Console.ReadLine());
int firstDiff = int.Parse(Console.ReadLine());
int secondDiff = int.Parse(Console.ReadLine());

int firstEnd = firstStart + firstDiff;
int secondEnd = secondStart + secondDiff;

// Функция за проверка на просто число
bool IsPrime(int number)
{
    if (number < 2) return false;
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}

for (int first = firstStart; first <= firstEnd; first++)
{
    if (!IsPrime(first)) continue;

    for (int second = secondStart; second <= secondEnd; second++)
    {
        if (!IsPrime(second)) continue;

        Console.WriteLine($"{first}{second}");
    }
}