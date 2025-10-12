char letterOne = char.Parse(Console.ReadLine());
char letterTwo = char.Parse(Console.ReadLine());
char exception = char.Parse(Console.ReadLine());
int combination = 0;
string output = string.Empty;
for(char i = letterOne; i <= letterTwo; i++)
{
    for (char j = letterOne; j <= letterTwo; j++)
    {
        for (char k = letterOne; k <= letterTwo; k++)
        {
            if (i != exception && j != exception && k != exception)
            {
                output += ($"{i}{j}{k} ");
                combination++;
            }
        }
    }
}
Console.WriteLine($"{output}{combination}");