Console.Write("Enter Reshte Aval: ");
string str1 = Console.ReadLine();

Console.Write("Enter Reshte Aval: ");
string str2 = Console.ReadLine();

int maxLength = 0;
int endIndex = 0;

int[,] table = new int[str1.Length + 1, str2.Length + 1];
for (int i = 1; i <= str1.Length; i++)
{
    for (int j = 1; j <= str2.Length; j++)
    {
        if (str1[i - 1] == str2[j - 1])
        {
            table[i, j] = table[i - 1, j - 1] + 1;
            if (table[i, j] > maxLength)
            {
                maxLength = table[i, j];
                endIndex = i;
            }
        }
        else
        {
            table[i, j] = 0;
        }
    }

}
string bozortarintol = str1.Substring(endIndex - maxLength, maxLength);
Console.WriteLine($"bozorg tarin zir reshte moshtarak : {bozortarintol}");