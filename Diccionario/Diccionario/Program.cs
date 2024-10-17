using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> diccionario = crearDiccionario();
        traducir(diccionario);
    }

    static Dictionary<string, string> crearDiccionario()
    {
        Dictionary<string, string> diccionario = new Dictionary<string, string>();
        Console.WriteLine("Ingrese 5 pares de palabras (ingles - español):");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Par {i + 1}: ");
            string entrada = Console.ReadLine();
            string[] palabras = entrada.Split(' ');

            if (palabras.Length == 2)
            {
                diccionario[palabras[0]] = palabras[1];
            }
            else
            {
                Console.WriteLine("Por favor, ingrese exactamente una palabra en ingles y su traducción en español.");
                i--;
            }
        }

        return diccionario;
    }

    static void traducir(Dictionary<string, string> diccionario)
    {
        Console.WriteLine("\nModo de traduccion. Ingrese palabras en ingles para traducir (escriba 'salir' para terminar):");

        while (true)
        {
            Console.Write("Palabra en ingles: ");
            string palabra = Console.ReadLine();

            if (palabra.ToLower() == "salir")
            {
                Console.WriteLine("Gracias por utilizar el diccionario. ¡Hasta luego!");
                break;
            }

            if (diccionario.TryGetValue(palabra, out string traduccion))
            {
                Console.WriteLine($"La traduccion de '{palabra}' es '{traduccion}'.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' no se encuentra en el diccionario.");
            }
        }
    }
}
