Console.WriteLine("Enter Your Sentence: ");
string input = Console.ReadLine();

int[] charCount = new int[300];
foreach (char c in input)
{
    charCount[c]++;
}
char mostFrequentChar = ' ';
int maxCount = 0;
for (int i = 0; i < charCount.Length; i++)
{
    if (charCount[i] > maxCount)
    {
        mostFrequentChar = (char)i;
        maxCount = charCount[i];
    }
}
Console.WriteLine($"portekrar tarin chractor: {mostFrequentChar}, ba {maxCount} bar tekrar ");
