/*
using System;

class E57
{
    static void Main()
    {
        // Solicitar un número real al usuario
        Console.Write("Ingresa un número real: ");
        float numero =  Convert.ToSingle(Console.ReadLine()); // double.Parse(Console.ReadLine());

        // Inicializar la aproximación de la raíz cúbica
        float aproximacion = 0;

        // Definir el tamaño de incremento para tanteo
        flat incremento = 0.1f;

        // Realizar el tanteo
        while (Math.Pow(aproximacion, 3) < numero)
        {
            aproximacion += incremento;
        }

        // Aproximación de la raíz cúbica con una cifra decimal
        double raizCubicaAproximada = Math.Round(aproximacion, 1);

        // Imprimir el resultado
        Console.WriteLine($"La raíz cúbica aproximada de {numero} es {raizCubicaAproximada}");
    }
}
*/

using System;
class E57
{
    static void Main()
    {
        System.Console.WriteLine("introduce un número");
        float numero = Convert.ToInt32(Console.ReadLine());
        float resultado = 0;
        float i = 0.1f;

        while (resultado < numero)
        {
            i++;
            resultado = i * i * i;
        }


        if (resultado <= numero)
        {
            Console.WriteLine($"{i} * {i} = {numero} (exacta)");
        }
        else
        {
            i--;
            i = (i)Math.Round(i,1);
            System.Console.WriteLine($"{i} (aproximada)");
        }

    }
}