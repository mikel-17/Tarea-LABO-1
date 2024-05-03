#1) Realiza la suma, resta, multiplicación y división de dos números ingresados por el usuario.
N1 = float(input('ingrse el primer número: '))
N2 = float(input('ingrese el segundo número: '))

Suma = N1 * N2
Resta = N1 + N2
Multiplicacion = N1 - N2

if N2 != 0:
    Division = N1 / N2
else:
    Division = "No se puede dividir por cero"


print('Suma:', Suma)
print("Resta: ", Resta)
print('Multiplicacion:', Multiplicacion)
print('Division:', Division)

#Verificación de Número Par o Impar:
#2) Solicita un número al usuario y determina si es par o impar.
Numero = int(input("Ingrese un numero: "))

if Numero % 2 == 0:
    print("Si el numero ", Numero, " es par: ")


else:
    print("Si el numero ", Numero, " es impar: ")



# Área de un Triángulo:
#3) Pide la base y la altura de un triángulo al usuario y calcula su área.
base = int(input("Ingrese la base del triangulo: "))
altura = int(input("Ingrese la altura del triangulo: "))

area = base * altura / 2

print("Area del triangulo es: ", area)

#Calculadora de Factorial:
#4) Crea una función que calcule la factorial de un número.
Num = int(input("Ingrese un numero: "))

fact = 1

for i in range(1, Num + 1):
    fact *= i


print("Factorial de ", Num, " es: ", fact)

#Número Primo:
#5) Verifica si un número ingresado por el usuario es primo o no.

numero = int(input("Ingrese un numero: "))

es_primo = True


if numero <= 1:
    es_primo = False
else:
    for i in range(2, numero):
        if numero % i == 0:
            es_primo = False
            break

if es_primo:
    print(f"{numero} es un numero primo.")
else:
    print(f"{numero} no es un numero primo.")

#Inversión de Cadena:
#6) Toma una cadena de texto y muestra su inversión.
cadena = input("Ingrese una cadena de texto: ")

cadena_invertida = cadena[::- 1]

print("La cadena invertida es:", cadena_invertida)

#Suma de Números Pares:
#7) Calcula la suma de los números pares en un rango especificado por el usuario.
num1 = int(input("Ingresar numero inicial: "))
num2 = int(input("Ingresar un numero final: "))

suma = 0
i = num1

while i <= num2:  
    if i % 2 == 0: 
        suma += i
    i += 1

print("La suma de los números pares en el rango especificado es:", suma)

#Lista de Cuadrados:
#8) Crea una lista de los cuadrados de los primeros 10 números naturales.
def genera_cuadrados(n):
    cuadrados = []


    for i in range(1, n + 1):  
        cuadrados.append(i * *2)


    return cuadrados

resultados = genera_cuadrados(10)

print("El cuadrado de la 10 primeros numeros: ", resultados)

#Contador de Vocales:
#9) Cuenta el número de vocales en una cadena de texto.
def contar_vocales(cadena):
  
    cadena = cadena.lower()


    vocales = "aeiou"


    contador = 0


    for caracter in cadena:


        if caracter in vocales:
contador += 1


    return contador

cadena = input("Ingrese una cadena de texto: ")

num_vocales = contar_vocales(cadena)

print("El número de vocales en la cadena es:", num_vocales)

#Números de la Serie Fibonacci:
#10) Genera los primeros 10 números de la serie Fibonacci.
fibonacci = [0, 1]

for i in range(2, 10):
    siguiente_numero = fibonacci[i - 1] + fibonacci[i - 2]
    fibonacci.append(siguiente_numero)

print("Los primeros 10 números de la serie de Fibonacci son:", fibonacci)

#Ordenamiento de Lista:
#11) Ordena una lista de números ingresados por el usuario de menor a mayor.
numeros = input("Ingrese una lista de numeros separados por espacios: ")

numeros = [float(numero) for numero in numeros.split()]

numeros_ordenados = sorted(numeros)

print("Lista de numeros ordenada de menor a mayor:", numeros_ordenados)

#Palíndromo:
#12) Verifica si una palabra ingresada por el usuario es un palíndromo.
palabra = input("Ingrese una palabra: ")

palabra = palabra.lower()

if palabra == palabra[::- 1]:
    print("La palabra ingresada es un palíndromo.")
else:
    print("La palabra ingresada no es un palíndromo.")

#Generador de Tablas de Multiplicar:
#13) Crea un programa que genere la tabla de multiplicar de un número ingresado por el usuario.
numero = int(input("Ingrese un numero para generar la tabla de multiplicar: "))

print(f"Tabla de multiplicar del {numero}:")

for i in range(1, 11):
    resultado = numero * i
    print(f"{numero} x {i} = {resultado}")

#Cálculo del Área de un Círculo:
#14) Pide el radio de un círculo al usuario y calcula su área.
radio = float(input("Ingrese el radio del ci­rculo: "))

area = 3.14159 * radio * *2

print("El Ã¡rea del cÃ­rculo con radio", radio, "es:", area)

#Suma de Dígitos:
#15) Toma un número entero y calcula la suma de sus dígitos.
numero = int(input("Ingrese un numero entero: "))

suma_digitos = 0

while numero > 0:
    suma_digitos += numero % 10
    numero //= 10 

print("La suma de los digitos del numero es:", suma_digitos)

