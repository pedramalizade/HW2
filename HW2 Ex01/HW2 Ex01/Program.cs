Console.Write("How many numbers do you wanna enter?: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write($"number {i + 1} :");
    array[i] = int.Parse(Console.ReadLine());
}

int min = array.Min();
int max = array.Max();
Console.WriteLine($"kochektarin ozve: {min}");
Console.WriteLine($"bozorgtarin ozve: {max}");

int[] reversedArray = new int[N];
for (int i = 0; i < N; i++)
{
    reversedArray[i] = array[N - i - 1];
}
Console.WriteLine($"arraye makos shode:");
Console.WriteLine(string.Join("", reversedArray));

int[] sortedArray = (int[])array.Clone();
Array.Sort(sortedArray);
Console.WriteLine("arraye moratab shode: ");
Console.WriteLine(string.Join("", sortedArray));

for (int i = 0; i < N; i++)
{
    bool isDuplicate = false;
    int count = 0;
    for (int j = 0; j < i; j++)
    {
        if (array[i] == array[j])
        {
            isDuplicate = true;
            break;
        }
    }
    if (!isDuplicate)
    {
        for (int j = 0; j < N; j++)
        {
            if (array[i] == array[j])
            {
                count++;
            }

        }
        if (count > 1)
        {
            Console.WriteLine($"meqdar: {array[i]}, \ntedad tekrar : {count}");
            Console.WriteLine("andis ha: ");
            for (int j = 0; j < N; j++)
            {
                if (array[j] == array[i])
                {
                    Console.WriteLine(j + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
Console.Write("How many numbers do you wanna enter?: ");
int m = int.Parse(Console.ReadLine());
int[] array2 = new int[m];
for (int i = 0; i < m; i++)
{
    Console.Write($"number {i + 1}: ");
    array2[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("same numbers: ");
bool CommonElements = false;
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (array[i] == array2[j])
        {
            Console.WriteLine(array[i]);
            CommonElements = true;
            break;
        }

    }
}


