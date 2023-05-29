int rows = int.Parse(Console.ReadLine());
int[][] jagged = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse).ToArray();

    jagged[row] = new int[numbers.Length];

    for (int col = 0; col < numbers.Length; col++)
    {
        jagged[row][col] = numbers[col];
    }
}

for (int row = 0; row < rows - 1; row++)
{
    if (jagged[row].Length == jagged[row + 1].Length)
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] *= 2;
            jagged[row + 1][col] *= 2;
        }
    }
    else
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            jagged[row][col] /= 2;
        }

        for (int col = 0; col < jagged[row + 1].Length; col++)
        {
            jagged[row + 1][col] /= 2;
        }
    }
}

//for (int row = 0; row < rows; row++)
//{
//    for (int col = 0; col < jagged[row].Length; col++)
//    {
//        Console.Write($"{jagged[row][col]} ");
//    }
//    Console.WriteLine();
//}

while (true)
{
    string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "End")
    {
        break;
    }

    string[] commandArgs = command;
    string action = commandArgs[0];
    int row = int.Parse(commandArgs[1]);
    int column = int.Parse(commandArgs[2]);
    int value = int.Parse(commandArgs[3]);

    if (IsValidIndex(row, column, jagged))
    {
        if (action == "Add")
        {
            jagged[row][column] += value;
        }
        else if (action == "Subtract")
        {
            jagged[row][column] -= value;
        }
    }
}

PrintJaggedArray(jagged);

static bool IsValidIndex(int row, int column, int[][] jagged)
{
    return row >= 0 && row < jagged.Length && column >= 0 && column < jagged[row].Length;
}

static void PrintJaggedArray(int[][] jagged)
{
    for (int row = 0; row < jagged.Length; row++)
    {
        for (int col = 0; col < jagged[row].Length; col++)
        {
            Console.Write(jagged[row][col] + " ");
        }
        Console.WriteLine();
    }
}