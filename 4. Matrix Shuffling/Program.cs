int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();
string[,] matrix = new string[dimensions[0], dimensions[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = input[col];
    }
}

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "END")
{
    if (command[0] != "swap")
    {
        Console.WriteLine("Invalid input!");

        command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        continue;
    }
    string action = command[0];
    int firstIndex = int.Parse(command[1]);
    int secondIndex = int.Parse(command[2]);
    int firstIndexToSwap = int.Parse(command[3]);
    int secondIndexToSwap = int.Parse(command[4]);
    if (isValid(firstIndex, secondIndex, firstIndexToSwap, secondIndexToSwap, matrix, action))
    {
        string current = matrix[firstIndex, secondIndex];
        matrix[firstIndex, secondIndex] = matrix[firstIndexToSwap, secondIndexToSwap];
        matrix[firstIndexToSwap, secondIndexToSwap] = current;
        PrintMatrix(matrix);
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }


    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}


bool isValid(int firstIndex, int secondIndex, int firstIndexToSwap, int secondIndexToSwap, string[,] matrix, string command)
{
    return firstIndex >= 0 && firstIndex < matrix.GetLength(0) && secondIndex >= 0 && secondIndex < matrix.GetLength(1) && firstIndexToSwap >= 0 && firstIndexToSwap < matrix.GetLength(0) && secondIndexToSwap >= 0 && secondIndexToSwap < matrix.GetLength(1) && command == "swap";
    
}

static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }
}