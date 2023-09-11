static void PrintArray(int[,]arr)
{
    Console.WriteLine($"Dimensions: {arr.GetLength(0)}x{arr.GetLength(1)}");
    for (int i =0; i < arr.GetLength(0); i++)
    {
        for(int j =0;j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine("");
    }
}
static void PrintJaggedArray(int[][]arr)
{
    for(int i =0; i < arr.Length; i++)
    {
        for(int j = 0; j < arr[i].Length; j++)
        {
            Console.Write(arr[i][j]+" ");
        }
        Console.WriteLine();
    }  
}

// 2d array without size
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
Console.WriteLine("Hard Coded Array:");
PrintArray(numbers);
int[,] numbersDimension = new int[2, 2];
for(int i = 0; i < numbersDimension.GetLength(0); i++)
{
    for(int j = 0; j < numbersDimension.GetLength(1); j++)
    {
        Console.Write($"Enter element at position [{i}, {j}]: ");
        if (int.TryParse(Console.ReadLine(), out int inputValue))
        {
            Console.WriteLine(inputValue);
            numbersDimension[i, j] = inputValue;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            j--; // Retry the current column
        }
    }
}
Console.WriteLine("Input Array:");
PrintArray(numbersDimension);



// Jagged Arrays 
int [][] jaggedArray = new int[3][];
for(int i =0;i<jaggedArray.GetLength(0); i++)
{
    Console.WriteLine($"Number of column in row #{i+1} ");
    if(int.TryParse(Console.ReadLine(), out int input))
    {
        jaggedArray[i] = new int[input];
        for(int j = 0; j < input; j++)
        {
            jaggedArray[i][j] = new Random().Next();
        }
    }
}
Console.WriteLine("Jagged Array:");
PrintJaggedArray(jaggedArray);