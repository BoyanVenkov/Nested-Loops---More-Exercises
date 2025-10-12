int man = int.Parse(Console.ReadLine());
int woman = int.Parse(Console.ReadLine());
int table = int.Parse(Console.ReadLine());
int combinations = 0;


for (int i = 1; i <= man; i++)
{
    for(int j = 1; j <= woman; j++)
    {
        if (combinations >= table)
        {
            return;
        }
        Console.Write($"({i} <-> {j}) ");
        combinations++;
    }
}