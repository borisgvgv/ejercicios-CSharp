/*
39. Escribe un programa que le pida al usuario dos números a y b, 
así como un límite inferior y un límite superior, y muestre todos 
los números entre ambos límites (incluidos) que sean a la vez múltiplos 
de a y de b, como en este ejemplo:

Introduce un número: 2

Introduce otro número: 5

¿A partir de qué número buscamos? 10

¿Hasta qué número buscamos? 30

He encontrado los siguientes múltiplos comunes de ambos números: 10 20 30

*///Boris Garcés Vernier

using System;

class Ejercicio_37
{
    static void Main()
    {
        Console.WriteLine("Introduce un número");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce otro número");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int num1;
        int num2;

        if (numero1 > numero2)
        {
            num1 = numero2;
            num2 = numero1;
        }
        else
        {
            num1 = numero1;
            num2 = numero2;
        }

        
    }
}