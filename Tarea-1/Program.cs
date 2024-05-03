//Operaciones Básicas:
//1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        double N1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double N2 = Convert.ToDouble(Console.ReadLine());

        double Suma = N1 * N2;
        double Resta = N1 + N2;
        double Multiplicacion = N1 - N2;
        object Division;

        if (N2 != 0)
        {
            Division = N1 / N2;
        }
        else
        {
            Division = "No se puede dividir por cero";
        }

        Console.WriteLine("Suma: " + Suma);
        Console.WriteLine("Resta: " + Resta);
        Console.WriteLine("Multiplicacion: " + Multiplicacion);
        Console.WriteLine("Division: " + Division);
    }
}


//Verificación de Número Par o Impar:
//2) Solicita un número al usuario y determina si es par o impar.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        int fact = 1;

        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }

        Console.WriteLine($"El factorial de {num} es: {fact}");
    }
}

//Área de un Triángulo:
//3) Pide la base y la altura de un triángulo al usuario y calcula su área.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la base del triángulo: ");
        int baseTriangulo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la altura del triángulo: ");
        int alturaTriangulo = int.Parse(Console.ReadLine());

        double area = (baseTriangulo * alturaTriangulo) / 2.0;

        Console.WriteLine("El área del triángulo es: " + area);
    }
}


//Calculadora de Factorial:
//4) Crea una función que calcule la factorial de un número.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int num = int.Parse(Console.ReadLine());

        int fact = 1;

        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }

        Console.WriteLine($"El factorial de {num} es: {fact}");
    }
}

//Número Primo:
//5) Verifica si un número ingresado por el usuario es primo o no.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        bool esPrimo = true;

        if (numero <= 1)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
        {
            Console.WriteLine($"{numero} es un número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} no es un número primo.");
        }
    }
}


//Inversión de Cadena:
//6) Toma una cadena de texto y muestra su inversión.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una cadena de texto: ");
        string cadena = Console.ReadLine();

        char[] caracteres = cadena.ToCharArray();
        Array.Reverse(caracteres);

        string cadenaInvertida = new string(caracteres);

        Console.WriteLine("La cadena invertida es: " + cadenaInvertida);
    }
}


//Suma de Números Pares:
//7) Calcula la suma de los números pares en un rango especificado por el usuario.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresar numero inicial: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresar un numero final: ");
        int num2 = int.Parse(Console.ReadLine());

        int suma = 0;
        int i = num1;

        while (i <= num2)
        {
            if (i % 2 == 0)
            {
                suma += i;
            }
            i++;
        }

        Console.WriteLine("La suma de los números pares en el rango especificado es: " + suma);
    }
}


//Lista de Cuadrados:
//8) Crea una lista de los cuadrados de los primeros 10 números naturales.


using System;
using System.Collections.Generic;

class Program
{
    static List<int> GeneraCuadrados(int n)
    {
        List<int> cuadrados = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            cuadrados.Add(i * i);
        }

        return cuadrados;
    }

    static void Main(string[] args)
    {
        List<int> resultados = GeneraCuadrados(10);

        Console.Write("El cuadrado de los primeros 10 números: ");
        foreach (int resultado in resultados)
        {
            Console.Write(resultado + " ");
        }
        Console.WriteLine();
    }
}


//Contador de Vocales:
//9) Cuenta el número de vocales en una cadena de texto.


using System;

class Program
{
    static int ContarVocales(string cadena)
    {
        cadena = cadena.ToLower();

        string vocales = "aeiou";

        int contador = 0;

        foreach (char caracter in cadena)
        {
            if (vocales.Contains(caracter))
            {
                contador++;
            }
        }

        return contador;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese una cadena de texto: ");
        string cadena = Console.ReadLine();

        int numVocales = ContarVocales(cadena);

        Console.WriteLine("El número de vocales en la cadena es: " + numVocales);
    }
}


//Números de la Serie Fibonacci:
//10) Genera los primeros 10 números de la serie Fibonacci.


using System;

class Program
{
    static void Main(string[] args)
    {
        int[] fibonacci = new int[] { 0, 1 };

        for (int i = 2; i < 10; i++)
        {
            int siguienteNumero = fibonacci[i - 1] + fibonacci[i - 2];
            Array.Resize(ref fibonacci, fibonacci.Length + 1);
            fibonacci[i] = siguienteNumero;
        }

        Console.Write("Los primeros 10 números de la serie de Fibonacci son: ");
        foreach (int num in fibonacci)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


//Ordenamiento de Lista:
//11) Ordena una lista de números ingresados por el usuario de menor a mayor.


using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una lista de números separados por espacios: ");
        string input = Console.ReadLine();

        double[] numeros = input.Split(' ').Select(double.Parse).ToArray();

        Array.Sort(numeros);

        Console.WriteLine("Lista de números ordenada de menor a mayor: " + string.Join(" ", numeros));
    }
}



//Palíndromo:
//12) Verifica si una palabra ingresada por el usuario es un palíndromo.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        bool esPalindromo = true;

        for (int i = 0; i < palabra.Length / 2; i++)
        {
            if (palabra[i] != palabra[palabra.Length - i - 1])
            {
                esPalindromo = false;
                break;
            }
        }

        if (esPalindromo)
        {
            Console.WriteLine("La palabra ingresada es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra ingresada no es un palíndromo.");
        }
    }
}


//Generador de Tablas de Multiplicar:
//13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número para generar la tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {numero}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}


//Cálculo del Área de un Círculo:
//14) Pide el radio de un círculo al usuario y calcula su área.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());

        double area = Math.PI * Math.Pow(radio, 2);

        Console.WriteLine($"El área del círculo con radio {radio} es: {area}");
    }
}


//15) Toma un número entero y calcula la suma de sus dígitos.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        int sumaDigitos = 0;

        while (numero > 0)
        {
            sumaDigitos += numero % 10;
            numero /= 10;
        }

        Console.WriteLine("La suma de los dígitos del número es: " + sumaDigitos);
    }
}
