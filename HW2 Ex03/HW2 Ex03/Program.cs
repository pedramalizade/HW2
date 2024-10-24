Console.Write("Enter Your number: ");
string input =  Console.ReadLine();
int count = 1;
foreach (char c in input)
{
    if (c == ' ')
    {
        count++;
    }
}
int[] numbers = new int[count];
int numberIndex = 0;
string currentNumber = "";

foreach (char c in input)
{
    if (c == ' ')
    {
        numbers[numberIndex++] = int.Parse(currentNumber);
        currentNumber = "";
    }
    else
    {
        currentNumber += c;
    }
}
if (currentNumber.Length > 0)
{
    numbers[numberIndex] = int.Parse(currentNumber);
}
Console.WriteLine("arraye aadad: ");
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
