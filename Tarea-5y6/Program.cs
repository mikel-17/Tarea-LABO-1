//4. Desarrollo y Actividades Ejercicio:
//Recursividad:
//1) Ejercicio 1: Escribe una función recursiva que imprima los números pares del 1 al 100.

using System;
using System.Numerics;

class Program
{
    static void PrintEvenNumbers(int start)
    {
        if (start <= 100)
        {
            if (start % 2 == 0)
                Console.WriteLine(start);
            PrintEvenNumbers(start + 1);
        }
    }

    static void Main()
    {
        PrintEvenNumbers(1);
    }
}

//2) Ejercicio 2: Escribe una función recursiva que imprima la suma de los números del 1 al n.

using System;

class Program
{
    static int Sum(int n)
    {
        if (n == 1)
            return 1;
        else
            return n + Sum(n - 1);
    }

    static void Main()
    {
        int n = 10; // Puedes cambiar el valor de n aquí
        Console.WriteLine($"La suma de los números del 1 al {n} es: {Sum(n)}");
    }
}


//3) Ejercicio 3: Escribe una función recursiva que imprima la pirámide de números del 1 al n.

using System;

class Program
{
    static void PrintPyramid(int current, int n)
    {
        if (current > n)
            return;


        for (int i = 0; i < n - current; i++)
            Console.Write(" ");


        for (int i = 1; i <= current; i++)
            Console.Write(i);


        for (int i = current - 1; i >= 1; i--)
            Console.Write(i);

        Console.WriteLine();
        PrintPyramid(current + 1, n);
    }

    static void Main()
    {
        int n = 5; // Puedes cambiar el valor de n aquí
        PrintPyramid(1, n);
    }
}

//4) Ejercicio 4: Escribe una función recursiva que imprima la pirámide de números invertidos del 1 al n.

using System;
using System.Collections.Generic;

class Program
{
    static List<List<double>> CreateMatrix(int rows, int cols, double value = 0.0)
    {
        if (rows == 0)
            return new List<List<double>>();

        List<List<double>> matrix = new List<List<double>>();

        for (int i = 0; i < rows; i++)
        {
            List<double> row = new List<double>();
            for (int j = 0; j < cols; j++)
            {
                row.Add(value);
            }
            matrix.Add(row);
        }

        return matrix;
    }

    static void Main(string[] args)
    {
        List<List<double>> matrix = CreateMatrix(3, 4, 1.5);

        foreach (var row in matrix)
        {
            foreach (var cell in row)
            {
                Console.Write(cell + " ");
            }
            Console.WriteLine();
        }
    }
}


//5) Ejercicio 2: Escribe una función recursiva que imprima la tabla de multiplicar del n.

using System;

class Program
{
    static void PrintMultiplicationTable(int n, int multiplier)
    {
        if (multiplier <= 10)
        {
            Console.WriteLine($"{n} x {multiplier} = {n * multiplier}");
            PrintMultiplicationTable(n, multiplier + 1);
        }
    }

    static void Main()
    {
        int n = 5; // Cambia el valor de n aquí
        PrintMultiplicationTable(n, 1);
    }
}


//Arreglos y Matrices:
//6) Crea una matriz de números reales.

//7) Crea una matriz de números complejos.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Complex[,] matriz = new Complex[2, 3];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = new Complex(i + 1, j + 2);
            }
        }


        Console.WriteLine(matriz[0, 0]);
    }
}

//8) Crea una matriz de matrices.

using System;

class Program
{
    static void Main()
    {

        int[][] matrizDeMatrices = new int[3][];


        matrizDeMatrices[0] = new int[] { 1, 2, 3 };
        matrizDeMatrices[1] = new int[] { 4, 5 };
        matrizDeMatrices[2] = new int[] { 6, 7, 8, 9 };


        Console.WriteLine("Matriz de matrices:");
        for (int i = 0; i < matrizDeMatrices.Length; i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < matrizDeMatrices[i].Length; j++)
            {
                Console.Write(matrizDeMatrices[i][j] + " ");
            }
            Console.WriteLine("]");
        }
    }
}

//9) Accede al elemento central de una matriz.

using System;
using System.Collections.Generic;

class Program
{
    static int GetCentralElement(List<List<int>> matrix)
    {
        if (matrix.Count == 1 && matrix[0].Count == 1)
        {
            return matrix[0][0];
        }
        else
        {
            int midRow = matrix.Count / 2;
            int midCol = matrix[0].Count / 2;


            int startRow = Math.Max(0, midRow - 1);
            int startCol = Math.Max(0, midCol - 1);
            int endRow = Math.Min(matrix.Count - 1, midRow + 1);
            int endCol = Math.Min(matrix[0].Count - 1, midCol + 1);

            List<List<int>> subMatrix = new List<List<int>>();
            for (int i = startRow; i <= endRow; i++)
            {
                List<int> subRow = new List<int>();
                for (int j = startCol; j <= endCol; j++)
                {
                    subRow.Add(matrix[i][j]);
                }
                subMatrix.Add(subRow);
            }
            return GetCentralElement(subMatrix);
        }
    }

    static void Main(string[] args)
    {
        List<List<int>> matrix = new List<List<int>>()
        {
            new List<int>() {1, 2, 3},
            new List<int>() {4, 5, 6},
            new List<int>() {7, 8, 9}
        };

        int centralElement = GetCentralElement(matrix);
        Console.WriteLine(centralElement); // Output: 5
    }
}


//10) Suma dos matrices de diferentes tamaños.

using System;

class Program
{
    static void Main()
    {
        int[,] matriz1 = { { 1, 2 }, { 3, 4 } };
        int[,] matriz2 = { { 5, 6, 7 }, { 8, 9, 10 } };

        int filas = Math.Min(matriz1.GetLength(0), matriz2.GetLength(0));
        int columnas = Math.Min(matriz1.GetLength(1), matriz2.GetLength(1));

        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        // Imprimir la matriz resultado
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(resultado[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

//11) Multiplica una matriz por un número.

using System;

class Program
{
    static void Main()
    {

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };


        int numero = 2;


        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] *= numero;
            }
        }


        Console.WriteLine("Matriz resultado:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

//12) Calcula la media de los elementos de una matriz.

using System;

class Program
{
    static void Main()
    {

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };


        int suma = 0;
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);


        foreach (int elemento in matriz)
        {
            suma += elemento;
        }


        double media = (double)suma / totalElementos;


        Console.WriteLine("La media de los elementos de la matriz es: " + media);
    }
}

//Ejercicio Matrices:
//Ejercicio 1:
//Crea una matriz de números aleatorios de tamaño 100x100.

using System;

class Program
{
    static void Main()
    {

        Random random = new Random();


        int[,] matriz = new int[100, 100];


        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                matriz[i, j] = random.Next(100);
            }
        }

        // Imprimir la matriz
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

//Ejercicio 2:
//Calcula la media, la mediana y la desviación estándar de los elementos de una matriz.

using System;

class Program
{
    static void Main()
    {

        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };


        double suma = 0;
        foreach (int elemento in matriz)
        {
            suma += elemento;
        }
        double media = suma / matriz.Length;


        int[] elementosOrdenados = new int[matriz.Length];
        int index = 0;
        foreach (int elemento in matriz)
        {
            elementosOrdenados[index++] = elemento;
        }
        Array.Sort(elementosOrdenados);
        double mediana;
        if (elementosOrdenados.Length % 2 == 0)
        {
            mediana = (elementosOrdenados[elementosOrdenados.Length / 2 - 1] + elementosOrdenados[elementosOrdenados.Length / 2]) / 2.0;
        }
        else
        {
            mediana = elementosOrdenados[elementosOrdenados.Length / 2];
        }


        double sumaCuadrados = 0;
        foreach (int elemento in matriz)
        {
            sumaCuadrados += Math.Pow(elemento - media, 2);
        }
        double desviacionEstandar = Math.Sqrt(sumaCuadrados / matriz.Length);


        Console.WriteLine("Media: " + media);
        Console.WriteLine("Mediana: " + mediana);
        Console.WriteLine("Desviación estándar: " + desviacionEstandar);
    }
}

//Ejercicio 3:
//Escribe una función que encuentre el elemento máximo de una matriz.

using System;

class Program
{
    static int FindMaxElement(int[,] matrix)
    {
        int max = int.MinValue;
        foreach (int element in matrix)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int maxElement = FindMaxElement(matrix);
        Console.WriteLine("El elemento máximo de la matriz es: " + maxElement);
    }
}

//Ejercicio 4:
//Escribe una función que encuentre la submatriz de mayor suma de una matriz.

using System;

class Program
{
    static int[,] FindMaxSubmatrixBruteForce(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int maxSum = int.MinValue;
        int[,] maxSubmatrix = new int[2, 2];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                for (int k = i; k < rows; k++)
                {
                    for (int l = j; l < cols; l++)
                    {
                        int currentSum = 0;
                        for (int m = i; m <= k; m++)
                        {
                            for (int n = j; n <= l; n++)
                            {
                                currentSum += matrix[m, n];
                            }
                        }
                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            maxSubmatrix[0, 0] = i;
                            maxSubmatrix[0, 1] = j;
                            maxSubmatrix[1, 0] = k;
                            maxSubmatrix[1, 1] = l;
                        }
                    }
                }
            }
        }

        return maxSubmatrix;
    }

    static void Main(string[] args)
    {
        int[,] matrix = {
            {1, 2, -1, -4, -20},
            {-8, -3, 4, 2, 1},
            {3, 8, 10, 1, 3},
            {-4, -1, 1, 7, -6}
        };

        int[,] maxSubmatrix = FindMaxSubmatrixBruteForce(matrix);
        Console.WriteLine("Submatriz de mayor suma encontrada:");
        Console.WriteLine($"Fila inicial: {maxSubmatrix[0, 0]}, Columna inicial: {maxSubmatrix[0, 1]}");
        Console.WriteLine($"Fila final: {maxSubmatrix[1, 0]}, Columna final: {maxSubmatrix[1, 1]}");
    }
}

//Ejercicio 5:
//Escribe una función que encuentre la matriz de covarianza de dos matrices.

using System;

class Program
{
    static double[,] Covariance(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] cov = new double[cols, cols];


        double[] mean1 = new double[cols];
        double[] mean2 = new double[cols];
        for (int j = 0; j < cols; j++)
        {
            double sum1 = 0, sum2 = 0;
            for (int i = 0; i < rows; i++)
            {
                sum1 += matrix1[i, j];
                sum2 += matrix2[i, j];
            }
            mean1[j] = sum1 / rows;
            mean2[j] = sum2 / rows;
        }


        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double sum = 0;
                for (int k = 0; k < rows; k++)
                {
                    sum += (matrix1[k, i] - mean1[i]) * (matrix2[k, j] - mean2[j]);
                }
                cov[i, j] = sum / (rows - 1); // Dividir por (n - 1) para obtener la covarianza sin sesgo
            }
        }

        return cov;
    }

    static void Main(string[] args)
    {
        double[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double[,] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        double[,] covariance = Covariance(matrix1, matrix2);

        Console.WriteLine("Matriz de Covarianza:");
        for (int i = 0; i < covariance.GetLength(0); i++)
        {
            for (int j = 0; j < covariance.GetLength(1); j++)
            {
                Console.Write(covariance[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}



