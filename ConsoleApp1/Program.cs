using System;

class Calculator
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("---CALCULADORA---");
            Console.WriteLine("Seleccione el tipo de cálculo:");
            Console.WriteLine("1. Entero ");
            Console.WriteLine("2. Decimal");

            int tipoCalculo = int.Parse(Console.ReadLine());

            double a, b, result;

            Console.WriteLine("Ingrese el primer número:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    result = Sumar(a, b, tipoCalculo);
                    Console.WriteLine("El resultado de la suma es: {0}", result);
                    break;
                case 2:
                    result = Restar(a, b, tipoCalculo);
                    Console.WriteLine("El resultado de la resta es: {0}", result);
                    break;
                case 3:
                    result = Multiplicacion(a, b, tipoCalculo);
                    Console.WriteLine("El resultado de la multiplicación es: {0}", result);
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    else
                    {
                        result = Division(a, b, tipoCalculo);
                        Console.WriteLine("El resultado de la división es: {0}", result);
                    }
                    break;
                case 5:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }

    static double Sumar(double a, double b, int tipoCalculo)
    {
        if (tipoCalculo == 1)
        {
            return Math.Floor(a + b);
        }
        else
        {
            return a + b;
        }
    }

    static double Restar(double a, double b, int tipoCalculo)
    {
        if (tipoCalculo == 1)
        {
            return Math.Floor(a - b);
        }
        else
        {
            return a - b;
        }
    }

    static double Multiplicacion(double a, double b, int tipoCalculo)
    {
        if (tipoCalculo == 1)
        {
            return Math.Floor(a * b);
        }
        else
        {
            return a * b;
        }
    }

    static double Division(double a, double b, int tipoCalculo)
    {
        if (tipoCalculo == 1)
        {
            return Math.Floor(a / b);
        }
        else
        {
            return a / b;
        }
    }
}
