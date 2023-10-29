using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Paso 1: Crea una lista de tipo object
        List<object> myList = new List<object>();

        // Paso 2: Agrega valores a la lista
        myList.Add(7);
        myList.Add(28);
        myList.Add(-1);
        myList.Add(true);
        myList.Add("chair");

        // Paso 3: Recorre la lista y muestra todos los valores
        Console.WriteLine("Valores en la lista:");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        // Paso 4: Suma los valores de tipo int y muestra la suma
        int sum = 0;
        foreach (var item in myList)
        {
            if (item is int)
            {
                sum += (int)item;
            }
        }

        Console.WriteLine("Suma de valores enteros: " + sum);

        // Espera a que el usuario presione Enter antes de cerrar la aplicación
        Console.ReadLine();
    }
}
