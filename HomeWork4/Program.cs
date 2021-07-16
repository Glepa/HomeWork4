using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Операции с матрицами
            //int[,] matrix1 = CreateMatrix();
            //Console.WriteLine("Matrix1:");
            //Print(matrix1);
            //int[,] matrix2 = CreateMatrix();
            //Console.WriteLine("Matrix2:");
            //Print(matrix2);
            //Console.Write("\nВведите число на которое нужно умножить Matrix1:");
            //int num = int.Parse(Console.ReadLine());
            //int[,] matrixResult = Multi_Matrix_Num(matrix1, num);
            //Console.WriteLine("\nРезультат умножения матрицы на число, MatrixResult: \n");
            //Print(matrixResult);
            //Console.WriteLine("\nРезультат сложения Matrix1 и Matrix2, MatrixResult: \n");
            //matrixResult = MatrixAddition(matrix1, matrix2);
            //Print(matrixResult);
            //Console.WriteLine("\nРезультат вычитания Matrix1 и Matrix2, MatrixResult: \n");
            //matrixResult = DifferenceOfMatrix(matrix1, matrix2);
            //Print(matrixResult);
            //Console.WriteLine("\nРезультат умножения Matrix1 и Matrix2, MatrixResult: \n");
            //matrixResult = MultiMatrix(matrix1, matrix2);
            //Print(matrixResult);
            #endregion

            #region Работа со строками
            //Console.WriteLine("Напишите произвольную строку.");
            //string text = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Слово с минимальной длиной: ");
            //string str1 = MinWord(text);
            //Console.WriteLine($"\"{str1}\"");
            //Console.WriteLine();
            //List<string> str2 = MaxWord(text);
            //Console.Write("Слово с максимальной длиной: ");
            //foreach (var item in str2)
            //{
            //    Console.Write($"\"{item}\", ");
            //}
            //Console.WriteLine();
            #endregion

            #region Повторяющиеся символы
            //Console.WriteLine("Преобразование строки с повторяющимися символами:");
            //string _str = "ХХХХХХХХоооооОООООрррроооооооошшшшшаааааааааяяя пппппппппппппппппоооооооооооооооооггггггггггггггггггггггггооооооооооооооооооооооддддддддддддаааааааааааааа.";
            //Console.WriteLine($"Исходная строка:\n {_str}\n");
            //Console.WriteLine($"Преобразованная строка:\n {DelRepetChar(_str)}\n");
            #endregion

            #region Прогрессия
           
            Console.WriteLine(Progression());

            #endregion

            #region Функция Аккермана
            int m = 3;
            for (int n = 0; n < 20; n++)
            {
                Console.WriteLine($"Функция Аккермана А({m}, {n}) = {A(m, n)} ");
            }
            #endregion

        }
        static int [,] CreateMatrix()
        {
            Random rand = new Random();
            Console.WriteLine("Ведите размерность квадратной матрицы: ");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Ошибка!Матриц с отрицательным числом строк и столбцов не существует!");
                Console.Write("Повторите ввод: ");
                n = int.Parse(Console.ReadLine());
            }
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            return matrix;
        }
        static void Print(int [,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j],4}");
                }
                Console.WriteLine();
            }
        }
        static int[,] Multi_Matrix_Num(int [,] matrix,int num)
        {
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i, j] * num;
                }
            }
            return newMatrix;
        }
        static int[,] MatrixAddition(int[,] matrix1, int[,] matrix2)
        {
            int[,] newMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return newMatrix;
        }
        static int [,] DifferenceOfMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] newMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return newMatrix;
        }
        static int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] newMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    for (int k = 0; k <matrix1.GetLength(1) ; k++)
                    {
                        newMatrix[i, j]+= matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return newMatrix;
        }
        static string MinWord(string str)
        {
            char[] separator = { ',', '.', '?', '\"', '!', '-',' '};
            string [] result = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string minStr = str;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Length < minStr.Length && result[i].Length > 1)
                    minStr = result[i];
            }
            return minStr;
        }
        static List <string> MaxWord(string str)
        {
            char[] separator = { ',', '.', '?', '\"', '!', '-', ' ' };
            string[] result = str.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            string maxStr = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Length > maxStr.Length)
                    maxStr = result[i];
            }
        List<string> maxWord = new List<string>();
            maxWord.Add(maxStr);
            for (int j = 0; j < result.Length; j++)
            {
                if (result[j].Length == maxStr.Length && result[j].ToLower() != maxStr.ToLower())
                    maxWord.Add(result[j]);
            }
            return maxWord;
        }
        static string DelRepetChar(string str)
        {
            string result = str.First().ToString();
            char sim = str.First();
            foreach (var item in str)
            {
                if (char.ToLower(item) != char.ToLower(sim))

                {
                    result += item.ToString();
                    sim = item;
                }
            }
            return result;
        }

        static string Progression(params int[] num)
        {
            bool arifProg = true;
            bool geomProg = true;
            Console.WriteLine("Дана последовательность чисел:");
            foreach (var item in num) Console.Write($"{item,6}");
            Console.WriteLine();
            for (int i = 1; i < num.Length - 1; i++)
            {
                if (num[i] != (num[i - 1] + num[i + 1]) / 2)
                {
                    arifProg = false;
                    break;
                }
            }
            if (arifProg) return "Последовательность является арифметической прогрессией";
            for (int j = 1; j < num.Length-1; j++)
            {
                if(Math.Abs(num[j]) != Math.Sqrt(num[j - 1] * num[j + 1]))
                {
                    geomProg = false;
                    break;
                }
            }
            if (geomProg) return "Последовательность является геометрической прогрессией";
            return "Последовательность не является прогрессией";
        }
        static int A(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return A(m - 1, 1);
            else if (m > 0 && n > 0) return A(m - 1,A(m, n - 1));
            else return 0;
        }
    }
}
