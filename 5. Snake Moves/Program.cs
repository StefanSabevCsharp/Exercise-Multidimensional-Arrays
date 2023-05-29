int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
char[,] matrix = new char[dimensions[0], dimensions[1]];
string word = Console.ReadLine();
int indexOfletter = 0;
for (int row = 0; row < matrix.GetLength(0); row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {

            matrix[row, col] = word[indexOfletter];
            indexOfletter++;
            if (indexOfletter == word.Length)
            {
                indexOfletter = 0;
            }

        }
    }
    else
    {
        for(int col = matrix.GetLength(0);col >= 0; col--)
        {
            matrix[row, col] = word[indexOfletter];
            indexOfletter++;
            if (indexOfletter == word.Length)
            {
                indexOfletter = 0;
            }
        }
    }
    
}
for (int row = 0;row < matrix.GetLength(0); row++)
{
    for (int col = 0;col < matrix.GetLength(1); col++)
    {
        Console.Write($"{matrix[row,col]}");
    }
    Console.WriteLine();
}