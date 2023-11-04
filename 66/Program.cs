/*
66. Crea un menú como el siguiente. El usuario deberá escoger la opción 0, 1 o 2, 
y después se le mostrará la opción que ha escogido, usando "switch" y datos de tipo "byte":

1. Ver datos existentes
2. Añadir un nuevo dato
3. Buscar
0. Salir
1
Ha escogido la opción "1": "Ver datos existentes"

*/

using System;

class E66
{


    static void Main()
    {

        Console.WriteLine(
            "Escoje una de estas opciones\n" +
            "1.Ver datos existentes\n" +
            "2.Añadir un nuevo dato\n" +
            "3.Buscar\n" +
            "0.Salir"
        );
        byte opción = Convert.ToByte(Console.ReadLine());

        switch (opción)
        {
            case 0:
                System.Console.WriteLine("Ha escogido la opción 0:  salir");
                break;
            case 1:
                System.Console.WriteLine("Ha escogido la opción 1: Ver datos existentes");
                break;
            case 2:
                System.Console.WriteLine("Ha escogido la opción 2: Añadir un nuevo dato");
                break;
            case 3:
                System.Console.WriteLine("Ha escogido la opción 3: Buscar");
                break;
        }

    }
}