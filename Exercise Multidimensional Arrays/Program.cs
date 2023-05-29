int dimensions = int.Parse(Console.ReadLine());

int[,] matrix = new int[dimensions,dimensions];

for (int row = 0; row < dimensions; row++)
{
    int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < dimensions; col++)
    {
        matrix[row,col] = numbers[col];
    }
}

int primaryDiagonalSum = 0;
int secondaryDiagonalSum  = 0;

for (int row = 0 ;row < dimensions; row++)
{
        primaryDiagonalSum += matrix[row,row];
    secondaryDiagonalSum += matrix[row, dimensions -1 - row];
}
Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));