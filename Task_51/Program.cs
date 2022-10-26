Console.Clear();


int[,] CreateMatrix(int rows, int colums, int min, int max) // метод создания двухмерного массива со случайными числами
{
    int[,] matrix = new int[rows, colums];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(1) - размер длинны матрицы по строкам (rows)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(0) - размер длинны матрицы по столбцам (colums)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matr) // создаем метод
{
    for (int i = 0; i < matr.GetLength(0); i++) // где matrix - название матрицы, а .GetLength(0) - количество строк в данной матрице (0)
    {
        System.Console.Write(("["));
        for (int j = 0; j < matr.GetLength(1); j++) // где где matrix - название матрицы, а .GetLength(1) - количество строк в данной матрице (1)
        {
            if (j < matr.GetLength(1) - 1) System.Console.Write($"{matr[i, j],4}, "); // выводим данные из определенного столбца (i) и строки (j).
                                                                                      // i берется из первого цикла, j из подцикла
            else System.Console.Write($"{matr[i, j],4}");
        }
        System.Console.WriteLine(("]"));
    }
}


int SumDigonalElement(int[,] matr)
{
    int sumMembers = 0;
        for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(1) - размер длинны матрицы по строкам (rows)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(0) - размер длинны матрицы по столбцам (colums)
        {
            if (i  == j ) sumMembers = sumMembers+matr[i,j];
        
        }
    }
    return sumMembers;
}


int[,] matrix = CreateMatrix(5, 5, 1, 10); // вводим размер матрицы данных
PrintMatrix(matrix); // выводим сгенерированную матрицу
System.Console.WriteLine(); // переход на новую строку
int sumDigonalElement = SumDigonalElement(matrix);
System.Console.WriteLine($"{sumDigonalElement}")
System.Console.WriteLine(); // переход на новую строку


