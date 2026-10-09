Console.WriteLine("SISTEMA DE LLENADO DE TANQUE");
Console.WriteLine();

// Crear un objeto de la clase Tanque
Tanque tanque1 = new Tanque();

// Capturar los datos del tanque
Console.Write("Ingrese la capacidad maxima del tanque (L): ");
tanque1.CapacidadMaxima = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el volumen inicial del tanque (L): ");
tanque1.VolumenActual = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el volumen agregado por ciclo (L): ");
tanque1.VolumenPorCiclo = Convert.ToDouble(Console.ReadLine());

// Validar los datos ingresados
if (tanque1.CapacidadMaxima <= 0 ||
    tanque1.VolumenActual < 0 ||
    tanque1.VolumenActual > tanque1.CapacidadMaxima ||
    tanque1.VolumenPorCiclo <= 0)
{
    Console.WriteLine();
    Console.WriteLine("Error: los valores ingresados no son validos.");
}
else
{
    // Simular el llenado del tanque
    Console.WriteLine();
    Console.WriteLine("INICIANDO LLENADO DEL TANQUE");
    Console.WriteLine();

    tanque1.SimularLlenado();
}


// Definicion de la clase
class Tanque
{
    // Propiedades
    public double CapacidadMaxima { get; set; }

    public double VolumenActual { get; set; }

    public double VolumenPorCiclo { get; set; }


    // Metodo para calcular el porcentaje de llenado
    public double CalcularPorcentaje()
    {
        double porcentaje;

        porcentaje = (VolumenActual / CapacidadMaxima) * 100;

        return porcentaje;
    }


    // Metodo para simular el llenado del tanque
    public void SimularLlenado()
    {
        int ciclo = 0;

        while (VolumenActual < CapacidadMaxima)
        {
            ciclo++;

            VolumenActual = VolumenActual + VolumenPorCiclo;

            // Evitar superar la capacidad maxima
            if (VolumenActual > CapacidadMaxima)
            {
                VolumenActual = CapacidadMaxima;
            }

            // Calcular el porcentaje de llenado
            double porcentaje = CalcularPorcentaje();

            // Mostrar los resultados del ciclo
            Console.WriteLine($"Ciclo: {ciclo}");
            Console.WriteLine($"Volumen actual: {VolumenActual:F2} L");
            Console.WriteLine($"Porcentaje de llenado: {porcentaje:F2} %");
            Console.WriteLine();
        }

        Console.WriteLine("El tanque esta lleno.");
        Console.WriteLine($"Volumen final: {VolumenActual:F2} L");
    }
}