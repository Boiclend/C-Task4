// Написать программу, которая заполняет массив размерности n x n по диагонали


int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}


int[,] GetDoubleMassFromDiagonal(int rows, int columns) { // метод заполнения массива по диагонали
    int[,] arr = new int[rows, columns];
    int temp = 1;
        for (int i = 1 - rows; i <= rows - 1; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int k = j - i;
                if (k < 0 || k >= rows)
                    continue;
                    arr[j, k] = temp++;
                }
            }
    return arr;
}

void PrintArr(int[,] arr) { // метод печати массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ROWS = Zapros("введите количество строк");
int COLUMNS = Zapros("введите количество столбцов");
int[,] DiagonalArray = GetDoubleMassFromDiagonal(ROWS,COLUMNS);
PrintArr(DiagonalArray);