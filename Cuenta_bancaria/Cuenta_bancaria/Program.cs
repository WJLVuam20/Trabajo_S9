using System;

class Program
{
    static void Main()
    {
        double saldo = 0.0; 
        int opcion;

        do
        {
            Console.WriteLine("\n--- Menu de Opciones ---");
            Console.WriteLine("1. Consultar saldo");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Retirar dinero");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcio3n (1-4): ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    
                    Console.WriteLine($"Su saldo actual es: ${saldo:F2}");
                    break;

                case 2:
                   
                    Console.Write("Ingrese la cantidad a depositar: ");
                    double cantidadDeposito = double.Parse(Console.ReadLine());
                    if (cantidadDeposito > 0)
                    {
                        saldo += cantidadDeposito;
                        Console.WriteLine($"${cantidadDeposito:F2} han sido depositados. Su nuevo saldo es: ${saldo:F2}");
                    }
                    else
                    {
                        Console.WriteLine("La cantidad a depositar debe ser mayor que 0.");
                    }
                    break;

                case 3:
                    
                    Console.Write("Ingrese la cantidad a retirar: ");
                    double cantidadRetiro = double.Parse(Console.ReadLine());
                    if (cantidadRetiro > 0)
                    {
                        if (cantidadRetiro <= saldo)
                        {
                            saldo -= cantidadRetiro;
                            Console.WriteLine($"${cantidadRetiro:F2} han sido retirados. Su nuevo saldo es: ${saldo:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente para realizar el retiro.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("La cantidad a retirar debe ser mayor que 0.");
                    }
                    break;

                case 4:
                    
                    Console.WriteLine("Gracias por utilizar el sistema. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no valida. Por favor, seleccione una opcion entre 1 y 4.");
                    break;
            }
        } while (opcion != 4);
    }
}
