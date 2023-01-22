Console.WriteLine("Введите размерность прямоугольного массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,n];
int row = -1;
int maxSum = Int32.MinValue;
int currSum;

for (int i = 0; i < n; i++)
{
    currSum = 0;
    Console.WriteLine($"Вводите элементы строки {i+1}");
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
        currSum += array[i, j];
    }

    if (currSum >= maxSum)
    {
        maxSum = currSum;
        row = i;
    }
}

Console.WriteLine($"Максимальная сумма в строке {row+1}");