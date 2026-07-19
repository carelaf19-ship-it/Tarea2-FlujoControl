using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el sueldo mensual del empleado: RD$ ");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        double sueldoAnual = sueldo * 12;
        double impuestoAnual = 0;

        if (sueldoAnual <= 416220)
        {
            Console.WriteLine("\n===== RESULTADO =====");
            Console.WriteLine($"Sueldo mensual: RD${sueldo:N2}");
            Console.WriteLine("ISR: N/A");
        }
        else if (sueldoAnual <= 624329)
        {
            impuestoAnual = (sueldoAnual - 416220) * 0.15;
        }
        else if (sueldoAnual <= 867123)
        {
            impuestoAnual = 31216 + ((sueldoAnual - 624329) * 0.20);
        }
        else
        {
            impuestoAnual = 79776 + ((sueldoAnual - 867123) * 0.25);
        }

        if (impuestoAnual > 0)
        {
            Console.WriteLine("\n===== RESULTADO =====");
            Console.WriteLine($"Sueldo mensual: RD${sueldo:N2}");
            Console.WriteLine($"ISR anual: RD${impuestoAnual:N2}");
            Console.WriteLine($"ISR mensual: RD${impuestoAnual / 12:N2}");
        }

        Console.ReadKey();
    }
}