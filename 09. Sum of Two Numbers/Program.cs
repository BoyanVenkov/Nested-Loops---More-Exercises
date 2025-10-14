int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());
int combinations = 0;
int successfulCombinations = 0;
for (int i = start; i <= end; i++)
{
    for (int j = start; j <= end; j ++)
    {
        combinations++;
        if (i + j == magicNumber && successfulCombinations == 0)
        {
            Console.WriteLine($"Combination N:{combinations} ({i} + {j} = {magicNumber})");
            successfulCombinations++;
        }
    }
}
if (successfulCombinations == 0)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
}