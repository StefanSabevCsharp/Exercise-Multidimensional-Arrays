
int[] dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
string[,] matrix = new string[dimensions[0], dimensions[1]];

int count = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{
   

    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        if (matrix[row,col] == matrix[row,col + 1] &&
            matrix[row,col] == matrix[row + 1, col] &&
            matrix[row + 1,col] == matrix[row + 1,col + 1])
            
        {
            count++;
        }
    }
}
Console.WriteLine(count);