int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

for (int i = 2; i <= num1; i += 2)
{
    for (int j = 2; j <= num2; j++)
    {
        if (j == 2 || j == 3 || j == 5 || j == 7)
        {
            for (int k = 2; k <= num3; k += 2)
            {
                Console.WriteLine($"{i} {j} {k}");
            }
        }
    }
}