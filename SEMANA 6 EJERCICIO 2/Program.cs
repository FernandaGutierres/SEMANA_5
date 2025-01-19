//Crear un programa que maneje N° cantidad de datos de tipo entero en dos listas por el inicio.
//Debe existir un ciclo de carga para la primera lista y otro ciclo de carga para la segunda lista.
//Una vez cargados los datos en las listas, el programa debe comparar las dos listas para
//verificar si ambas listas son iguales en tamaño y contenido, es decir que si tienen la misma
//cantidad de datos y si los datos están cargados en el mismo orden. Una vez realizada, la
//verificación. El programa debe mostrar:
//a. Si las listas son iguales en tamaño y en contenido.
//b. Si las listas son iguales en tamaño pero no en contenido.
//c. No tienen el mismo tamaño ni contenido.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Paso 1: Inicializar las listas
        List<int> lista1 = new List<int>();
        List<int> lista2 = new List<int>();

        // Paso 2: Cargar datos en la primera lista
        Console.Write("Ingrese la cantidad de elementos para la primera lista: ");
        int cantidad1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los elementos de la primera lista:");
        for (int i = 0; i < cantidad1; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            lista1.Add(int.Parse(Console.ReadLine()));
        }

        // Paso 3: Cargar datos en la segunda lista
        Console.Write("Ingrese la cantidad de elementos para la segunda lista: ");
        int cantidad2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los elementos de la segunda lista:");
        for (int i = 0; i < cantidad2; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            lista2.Add(int.Parse(Console.ReadLine()));
        }

        // Paso 4: Verificar las listas
        if (lista1.Count == lista2.Count)
        {
            // Verificar si los contenidos son iguales
            bool contenidoIgual = true;
            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[i] != lista2[i])
                {
                    contenidoIgual = false;
                    break;
                }
            }

            // Mostrar resultados basados en la comparación de contenido
            if (contenidoIgual)
            {
                Console.WriteLine("\nResultado: Las listas son iguales en tamaño y contenido.");
            }
            else
            {
                Console.WriteLine("\nResultado: Las listas son iguales en tamaño pero no en contenido.");
            }
        }
        else
        {
            Console.WriteLine("\nResultado: Las listas no tienen el mismo tamaño ni contenido.");
        }
    }
}
