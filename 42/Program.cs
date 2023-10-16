/*
42. Muestra un triángulo creciente, formado por "almohadillas" (#), 
alineado a la derecha, con el tamaño indicado por el usuario, usando "for":

Tamaño? 5
    #
   ##
  ###
 ####
#####
*/ //Boris Garcés Vernier

using System;
class E42
{
    static void Main()
    {

        System.Console.WriteLine("Introduce un número");
        int numero = Convert.ToInt32(Console.ReadLine());
        int numeroIn = numero;

        for (int i = 1; i <= numero; i++)
        {

            for (int j = 1; j <= numeroIn - 1; j++)
            {
                System.Console.Write(" ");
            }
            for (int ii = numeroIn; ii < numero + 1; ii++)
            {
                System.Console.Write("#");
            }

            numeroIn--;
            System.Console.WriteLine();
        }

    }
}