Console.Write("Give Me Your Number: ");
int amount = int.Parse(Console.ReadLine());

int[] coins = { 50, 20, 10, 5, 1 };
int[] coinCount = new int[coins.Length];

for (int i = 0; i < coins.Length; i++)
{
    coinCount[i] = amount / coins[i];
    amount %= coins[i];
}

Console.WriteLine("kamtarin coins estefade shode: ");
for (int i = 0; i < coins.Length; i++)
{
    if (coinCount[i] > 0)
    {
        Console.WriteLine($"{coins[i]} Tomani : {coinCount[i]} adad");
    }
}