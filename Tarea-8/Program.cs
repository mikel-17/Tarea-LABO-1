//1. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números
primos.
using System;
using System.Collections.Generic;

public class NumerosPrimos
{
    static bool EsPrimo(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    static HashSet<int> ObtenerNumerosPrimos(HashSet<int> numeros)
    {
        HashSet<int> primos = new HashSet<int>();
        foreach (int num in numeros)
        {
            if (EsPrimo(num))
            {
                primos.Add(num);
            }
        }
        return primos;
    }

    public static void Main(string[] args)
    {
        HashSet<int> conjuntoNumeros = new HashSet<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        HashSet<int> primos = ObtenerNumerosPrimos(conjuntoNumeros);
        Console.WriteLine("Números primos en el conjunto: " + string.Join(", ", primos));
    }
}

//2. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
comienzan con una letra determinada.

using System;
using System.Collections.Generic;

public class PalabrasQueComienzanConLetra
{
    static HashSet<string> PalabrasQueComienzanCon(HashSet<string> palabras, char letra)
    {
        HashSet<string> palabrasComienzanCon = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (!string.IsNullOrEmpty(palabra) && char.ToLower(palabra[0]) == char.ToLower(letra))
            {
                palabrasComienzanCon.Add(palabra);
            }
        }
        return palabrasComienzanCon;
    }

    public static void Main(string[] args)
    {
        HashSet<string> conjuntoPalabras = new HashSet<string>() { "apple", "banana", "pear", "orange", "grape" };
        char letraDeterminada = 'b';

        HashSet<string> palabrasComienzanCon = PalabrasQueComienzanCon(conjuntoPalabras, letraDeterminada);
        Console.WriteLine($"Palabras que comienzan con '{letraDeterminada}': {string.Join(", ", palabrasComienzanCon)}");
    }
}


//3. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
son divisibles por un número determinado.

using System;
using System.Collections.Generic;

public class NumerosDivisibles
{
    static HashSet<int> NumerosDivisiblesPor(HashSet<int> numeros, int divisor)
    {
        HashSet<int> divisibles = new HashSet<int>();
        foreach (int num in numeros)
        {
            if (num % divisor == 0)
            {
                divisibles.Add(num);
            }
        }
        return divisibles;
    }

    public static void Main(string[] args)
    {
        HashSet<int> conjuntoNumeros = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int divisor = 3;

        HashSet<int> numerosDivisibles = NumerosDivisiblesPor(conjuntoNumeros, divisor);
        Console.WriteLine($"Números divisibles por {divisor}: {string.Join(", ", numerosDivisibles)}");
    }
}


//4. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
están en ambos conjuntos.

using System;
using System.Collections.Generic;

public class NumerosComunes
{
    static HashSet<int> NumerosEnAmbosConjuntos(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> numerosComunes = new HashSet<int>(conjunto1);
        numerosComunes.IntersectWith(conjunto2);
        return numerosComunes;
    }

    public static void Main(string[] args)
    {
        HashSet<int> conjunto1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> conjunto2 = new HashSet<int>() { 3, 4, 5, 6, 7 };

        HashSet<int> numerosComunes = NumerosEnAmbosConjuntos(conjunto1, conjunto2);
        Console.WriteLine($"Números comunes en ambos conjuntos: {string.Join(", ", numerosComunes)}");
    }
}


//5. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
están en el primer conjunto pero no en el segundo.

using System;
using System.Collections.Generic;

public class NumerosEnPrimerConjuntoNoEnSegundo
{
    static HashSet<int> NumerosEnPrimerNoEnSegundo(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        HashSet<int> numerosEnPrimerNoEnSegundo = new HashSet<int>(conjunto1);
        numerosEnPrimerNoEnSegundo.ExceptWith(conjunto2);
        return numerosEnPrimerNoEnSegundo;
    }

    public static void Main(string[] args)
    {
        HashSet<int> conjunto1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> conjunto2 = new HashSet<int>() { 3, 4, 5, 6, 7 };

        HashSet<int> numerosEnPrimerNoEnSegundo = NumerosEnPrimerNoEnSegundo(conjunto1, conjunto2);
        Console.WriteLine($"Números en el primer conjunto pero no en el segundo: {string.Join(", ", numerosEnPrimerNoEnSegundo)}");
    }
}


//6. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
están en el segundo conjunto pero no en el primero.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> conjunto1 = new HashSet<int>() { 1, 2, 3, 4 };
        HashSet<int> conjunto2 = new HashSet<int>() { 3, 4, 5, 6 };

        conjunto2.ExceptWith(conjunto1); // Elimina todos los elementos del conjunto2 que están en conjunto1

        Console.WriteLine("Números en el segundo conjunto pero no en el primero: " + string.Join(", ", conjunto2));
    }
}


//7. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
son anagramas.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<string> EncontrarAnagramas(HashSet<string> palabras)
    {
        var anagramasLookup = palabras.ToLookup(palabra => string.Concat(palabra.OrderBy(c => c)));

        var anagramas = new HashSet<string>();
        foreach (var grupo in anagramasLookup)
        {
            if (grupo.Count() > 1)
            {
                anagramas.UnionWith(grupo);
            }
        }

        return anagramas;
    }

    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string>() { "roma", "amor", "perro", "ropem", "maro" };

        HashSet<string> anagramas = EncontrarAnagramas(palabras);
        Console.WriteLine("Anagramas encontrados: " + string.Join(", ", anagramas));
    }
}

//8. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
son palíndromos.

using System;
using System.Collections.Generic;

class Program
{
    static HashSet<string> Palindromos(HashSet<string> palabras)
    {
        HashSet<string> palindromos = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }
        return palindromos;
    }

    static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;
        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }

    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string>() { "radar", "oso", "cívico", "perro", "ana" };

        HashSet<string> palindromos = Palindromos(palabras);
        Console.WriteLine("Palíndromos encontrados: " + string.Join(", ", palindromos));
    }
}

//9. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
tienen una longitud determinada.

using System;
using System.Collections.Generic;

public class PalabrasConLongitud
{
    static HashSet<string> PalabrasConLongitudDeterminada(HashSet<string> palabras, int longitud)
    {
        HashSet<string> palabrasConLongitud = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud)
            {
                palabrasConLongitud.Add(palabra);
            }
        }
        return palabrasConLongitud;
    }

    public static void Main(string[] args)
    {
        HashSet<string> conjuntoPalabras = new HashSet<string>() { "apple", "banana", "pear", "orange", "grape" };
        int longitudDeterminada = 5;

        HashSet<string> palabrasConLongitud = PalabrasConLongitudDeterminada(conjuntoPalabras, longitudDeterminada);
        Console.WriteLine($"Palabras con longitud {longitudDeterminada}: {string.Join(", ", palabrasConLongitud)}");
    }
}

//10. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
contienen una letra determinada.

using System;
using System.Collections.Generic;

public class PalabrasConLetra
{
    static HashSet<string> PalabrasConLetraDeterminada(HashSet<string> palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();
        foreach (string palabra in palabras)
        {
            if (palabra.Contains(char.ToLower(letra)) || palabra.Contains(char.ToUpper(letra)))
            {
                palabrasConLetra.Add(palabra);
            }
        }
        return palabrasConLetra;
    }

    public static void Main(string[] args)
    {
        HashSet<string> conjuntoPalabras = new HashSet<string>() { "apple", "banana", "pear", "orange", "grape" };
        char letraDeterminada = 'a';

        HashSet<string> palabrasConLetra = PalabrasConLetraDeterminada(conjuntoPalabras, letraDeterminada);
        Console.WriteLine($"Palabras que contienen la letra '{letraDeterminada}': {string.Join(", ", palabrasConLetra)}");
    }
}

//11. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están ordenados de menor a mayor.

using System;
using System.Collections.Generic;
using System.Linq;

public class OrdenarNumeros
{
    static HashSet<int> OrdenarDeMenorAMayor(HashSet<int> numeros)
    {
        var numerosOrdenados = numeros.OrderBy(num => num);
        return new HashSet<int>(numerosOrdenados);
    }

    public static void Main(string[] args)
    {
        HashSet<int> conjuntoNumeros = new HashSet<int>() { 5, 2, 8, 1, 9, 3, 6 };

        HashSet<int> numerosOrdenados = OrdenarDeMenorAMayor(conjuntoNumeros);
        Console.WriteLine("Números ordenados de menor a mayor: " + string.Join(", ", numerosOrdenados));
    }
}


//12. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están ordenados de mayor a menor.

using System;
using System.Collections.Generic;
using System.Linq;

public class OrdenarNumeros
{
    static HashSet<int> OrdenarDeMayorAMenor(HashSet<int> numeros)
    {
        var numerosOrdenados = numeros.OrderByDescending(num => num);
        return new HashSet<int>(numerosOrdenados);
    }

    public static void Main(string[] args)
    {
        HashSet<int> conjuntoNumeros = new HashSet<int>() { 5, 2, 8, 1, 9, 3, 6 };

        HashSet<int> numerosOrdenados = OrdenarDeMayorAMenor(conjuntoNumeros);
        Console.WriteLine("Números ordenados de mayor a menor: " + string.Join(", ", numerosOrdenados));
    }
}


//13. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están duplicados.

using System;
using System.Collections.Generic;
using System.Linq;

public class NumerosDuplicados
{
    static HashSet<int> EncontrarNumerosDuplicados(HashSet<int> numeros)
    {
        var contadorNumeros = new Dictionary<int, int>();
        foreach (var numero in numeros)
        {
            if (contadorNumeros.ContainsKey(numero))
            {
                contadorNumeros[numero]++;
            }
            else
            {
                contadorNumeros[numero] = 1;
            }
        }

        var duplicados = contadorNumeros.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key);
        return new HashSet<int>(duplicados);
    }

    public static void Main(string[] args)
    {
        HashSet<int> conjuntoNumeros = new HashSet<int>() { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 9, 1 };

        HashSet<int> numerosDuplicados = EncontrarNumerosDuplicados(conjuntoNumeros);
        Console.WriteLine("Números duplicados: " + string.Join(", ", numerosDuplicados));
    }
}



//14. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
no están duplicados.

using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosNoDuplicados(HashSet<int> numeros)
    {
        HashSet<int> numerosNoDuplicados = new HashSet<int>();
        HashSet<int> numerosVistos = new HashSet<int>();

        foreach (int num in numeros)
        {
            if (!numerosVistos.Add(num)) // Si no se puede añadir, es un duplicado
            {
                numerosNoDuplicados.Remove(num);
            }
            else
            {
                numerosNoDuplicados.Add(num);
            }
        }

        return numerosNoDuplicados;
    }

    static void Main(string[] args)
    {
        HashSet<int> numeros = new HashSet<int>() { 1, 2, 3, 2, 4, 3, 5 };

        HashSet<int> numerosNoDuplicados = NumerosNoDuplicados(numeros);
        Console.WriteLine("Números no duplicados: " + string.Join(", ", numerosNoDuplicados));
    }
}

//15. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
son primos y están ordenados de menor a mayor.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        if (numero <= 3)
            return true;

        if (numero % 2 == 0 || numero % 3 == 0)
            return false;

        for (int i = 5; i * i <= numero; i += 6)
        {
            if (numero % i == 0 || numero % (i + 2) == 0)
                return false;
        }

        return true;
    }

    static HashSet<int> NumerosPrimosOrdenados(HashSet<int> numeros)
    {
        List<int> primosOrdenados = numeros.Where(EsPrimo).OrderBy(num => num).ToList();
        return new HashSet<int>(primosOrdenados);
    }

    static void Main(string[] args)
    {
        HashSet<int> numeros = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        HashSet<int> primosOrdenados = NumerosPrimosOrdenados(numeros);
        Console.WriteLine("Números primos ordenados: " + string.Join(", ", primosOrdenados));
    }
}

//16. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
son palíndromos y están ordenadas de menor a mayor.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
                return false;
        }
        return true;
    }

    static HashSet<string> PalindromosOrdenados(HashSet<string> palabras)
    {
        List<string> palindromosOrdenados = palabras.Where(EsPalindromo).OrderBy(palabra => palabra).ToList();
        return new HashSet<string>(palindromosOrdenados);
    }

    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string>() { "ana", "civic", "radar", "level", "hello", "world" };

        HashSet<string> palindromosOrdenados = PalindromosOrdenados(palabras);
        Console.WriteLine("Palíndromos ordenados: " + string.Join(", ", palindromosOrdenados));
    }
}

//17. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
tienen una longitud determinada y están ordenadas de menor a mayor.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<string> PalabrasConLongitudOrdenadas(HashSet<string> palabras, int longitud)
    {
        List<string> palabrasFiltradas = new List<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud)
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        palabrasFiltradas.Sort();
        return new HashSet<string>(palabrasFiltradas);
    }

    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string>() { "apple", "banana", "pear", "orange", "grape" };
        int longitudDeterminada = 5;

        HashSet<string> palabrasFiltradasOrdenadas = PalabrasConLongitudOrdenadas(palabras, longitudDeterminada);
        Console.WriteLine($"Palabras de longitud {longitudDeterminada} ordenadas: {string.Join(", ", palabrasFiltradasOrdenadas)}");
    }
}

//18. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
contienen una letra determinada y están ordenadas de mayor a menor.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static HashSet<string> PalabrasConLetraOrdenadas(HashSet<string> palabras, char letra)
    {
        List<string> palabrasFiltradas = new List<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        palabrasFiltradas.Sort((a, b) => string.Compare(b, a)); // Ordenar de mayor a menor
        return new HashSet<string>(palabrasFiltradas);
    }

    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string>() { "apple", "banana", "pear", "orange", "grape" };
        char letraDeterminada = 'a';

        HashSet<string> palabrasFiltradasOrdenadas = PalabrasConLetraOrdenadas(palabras, letraDeterminada);
        Console.WriteLine($"Palabras con la letra '{letraDeterminada}' ordenadas: {string.Join(", ", palabrasFiltradasOrdenadas)}");
    }
}

//19. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
están ordenados de menor a mayor y que no están duplicados.

using System;
using System.Collections.Generic;

class Program
{
    static HashSet<int> NumerosOrdenadosNoDuplicados(HashSet<int> numeros)
    {
        // Ordenar los números y eliminar duplicados utilizando un HashSet auxiliar
        List<int> numerosOrdenados = new List<int>();
        HashSet<int> numerosVistos = new HashSet<int>();

        foreach (int num in numeros)
        {
            if (numerosVistos.Add(num))
            {
                numerosOrdenados.Add(num);
            }
        }

        numerosOrdenados.Sort();
        return new HashSet<int>(numerosOrdenados);
    }

    static void Main(string[] args)
    {
        HashSet<int> numeros = new HashSet<int>() { 5, 3, 2, 5, 7, 2, 9, 3 };

        HashSet<int> numerosOrdenadosNoDuplicados = NumerosOrdenadosNoDuplicados(numeros);
        Console.WriteLine("Números ordenados y no duplicados: " + string.Join(", ", numerosOrdenadosNoDuplicados));
    }
}

//20. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
son palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
                return false;
        }
        return true;
    }

    static HashSet<string> PalindromosLongitudOrdenados(HashSet<string> palabras, int longitud)
    {
        List<string> palindromosFiltrados = new List<string>();

        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra) && palabra.Length == longitud)
            {
                palindromosFiltrados.Add(palabra);
            }
        }

        palindromosFiltrados.Sort();
        return new HashSet<string>(palindromosFiltrados);
    }

    static void Main(string[] args)
    {
        HashSet<string> palabras = new HashSet<string>() { "level", "radar", "apple", "civic", "banana" };
        int longitudDeterminada = 5;

        HashSet<string> palindromosLongitudOrdenados = PalindromosLongitudOrdenados(palabras, longitudDeterminada);
        Console.WriteLine($"Palíndromos de longitud {longitudDeterminada} ordenados: {string.Join(", ", palindromosLongitudOrdenados)}");
    }
}

