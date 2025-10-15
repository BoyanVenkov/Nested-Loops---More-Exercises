double days = double.Parse(Console.ReadLine());
double hours = double.Parse(Console.ReadLine());
double dayPrice = 0;
double totalPrice = 0;

for (int i = 1; i <= days; i++)
{
    for (int j = 1; j <= hours; j++)
    {
        if (i % 2 == 0 && j % 2 != 0)
        {
            dayPrice += 2.50;
            totalPrice += 2.50;
        }
        else if (i % 2 != 0 && j % 2 == 0)
        {
            dayPrice += 1.25;
            totalPrice += 1.25;
        }
        else
        {
            dayPrice += 1;
            totalPrice += 1;
        }
    }
    Console.WriteLine($"Day: {i} - {dayPrice:f2} leva");
    dayPrice = 0;
}
Console.WriteLine($"Total: {totalPrice:f2} leva");

