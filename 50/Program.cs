/*
50. Depuración: Crea un programa que muestre ciertos 
valores de la función y = x^2 - 6x + 9 
(usando valores enteros para x, en el rango desde -10 a +10).
Añade un punto de interrupción en el momento en que calculas
el valor de "y". Comprueba en cada pasada los valores de "x^2"
y de "6x", además del valor de "y". Deberás entregar una captura
de pantalla (estática) del proceso de depuración.
*/ // Boris Garcés Vernier


// Ejemplo_02_07a.cs
// Modificación de una variable para depuración
// Introducción a C#, por Nacho Cabanes
using System;
class Depuracion
{
    static void Main()
    {
        int n = 5;
        n = n * 17;
        n = n - 1432;
        for (int x = 0; x < 5; x++)
            Console.Write("{0} ", x);
        for (int i = 1; i < n; i++)
            Console.Write("{0} ", i);
    }
}