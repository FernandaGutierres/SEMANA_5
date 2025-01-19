//Crear un programa que maneje N° cantidad de datos de tipo real en una lista. Una vez
//cargados los datos en lista, el programa debe calcular el promedio de todos los datos
//cargados. Posteriormente, el programa debe cargar los datos menores o igual al promedio en
//una segunda lista, y los mayores en una tercera lista. Al finalizar este proceso, el programa
//debe mostrar lo siguiente:
//a. Los datos cargados en la lista principal.
//b. El promedio.
//c. Los datos cuyo valor sea igual o menor al promedio de todos los datos.
//d. Los datos que sean mayores al promedio de todos los datos.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Paso 1: Solicitar la cantidad de datos
        Console.Write("Ingrese la cantidad de datos que desea cargar: ");
        int cantidad = int.Parse(Console.ReadLine());

        // Inicialización de la lista principal
        List<double> datos = new List<double>();

        // Paso 2: Cargar los datos en la lista principal
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el dato {i + 1}: ");
            double dato = double.Parse(Console.ReadLine());
            datos.Add(dato);
        }

        // Paso 3: Calcular el promedio
        double promedio = datos.Average();

        // Paso 4: Clasificar los datos en dos listas
        List<double> menoresOIguales = datos.Where(d => d <= promedio).ToList();
        List<double> mayores = datos.Where(d => d > promedio).ToList();

        // Paso 5: Mostrar los resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine($"a. Lista principal: {string.Join(", ", datos)}");
        Console.WriteLine($"b. Promedio: {promedio:F2}");
        Console.WriteLine($"c. Datos menores o iguales al promedio: {string.Join(", ", menoresOIguales)}");
        Console.WriteLine($"d. Datos mayores al promedio: {string.Join(", ", mayores)}");
    }
}
