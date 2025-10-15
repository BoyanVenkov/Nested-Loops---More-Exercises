int input = int.Parse(Console.ReadLine());
int count = 0;
string password = " ";

for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        for (int k = 1; k <= 9; k++)
        {
            for (int l = 1; l <= 9; l++)
            {
                if (i < j && k > l && (i * j) + (k * l) == input)
                {
                    Console.Write($"{i}{j}{k}{l} ");
                    count++;
                    if (count == 4)
                    {
                        password = ($"{i}{j}{k}{l}");
                    }
                }
            }
        }
    }
}
if (count < 4)
{
    Console.WriteLine();
    Console.WriteLine("No!");
}
else
{
    Console.WriteLine();
    Console.WriteLine($"Password: {password}");
}
