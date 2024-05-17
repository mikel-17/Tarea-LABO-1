
//Clases: Objetos, atributos y métodos
//problema: 1

using System;

public class Arquitecto
{
    public string Codigo { get; set; }
    public string Nombres { get; set; }
    public string CondicionContrato { get; set; }
    public string Especialidad { get; set; }
    public string TipoActividad { get; set; }
    public string TipoAfiliacion { get; set; }
    public double SueldoBase { get; set; }
    public double Bonificacion { get; set; }
    public double Descuento { get; set; }
    public double SueldoBruto { get; set; }
    public double SueldoNeto { get; set; }

    public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
    {
        Codigo = codigo;
        Nombres = nombres;
        CondicionContrato = condicionContrato;
        Especialidad = especialidad;
        TipoActividad = tipoActividad;
        TipoAfiliacion = tipoAfiliacion;
        SueldoBase = CalcularSueldoBase();
        Bonificacion = CalcularBonificacion();
        SueldoBruto = SueldoBase + Bonificacion;
        Descuento = CalcularDescuento();
        SueldoNeto = SueldoBruto - Descuento;
    }

    private double CalcularSueldoBase()
    {
        double sueldoBase = 0;
        if (CondicionContrato == "Estable")
        {
            if (TipoActividad == "Supervisión de Obras")
            {
                sueldoBase = 4000;
            }
            else if (TipoActividad == "Supervisión de Vías")
            {
                sueldoBase = 6000;
            }
        }
        else if (CondicionContrato == "Contratado")
        {
            if (TipoActividad == "Supervisión de Obras")
            {
                sueldoBase = 2000;
            }
            else if (TipoActividad == "Supervisión de Vías")
            {
                sueldoBase = 4500;
            }
        }
        return sueldoBase;
    }

    private double CalcularBonificacion()
    {
        double porcentajeBonificacion = 0;
        if (Especialidad == "Estructuras")
        {
            porcentajeBonificacion = 0.16;
        }
        else if (Especialidad == "Recursos Hídricos")
        {
            porcentajeBonificacion = 0.18;
        }
        return SueldoBase * porcentajeBonificacion;
    }

    private double CalcularDescuento()
    {
        double porcentajeDescuento = TipoAfiliacion == "AFP" ? 0.15 : 0.08;
        return SueldoBruto * porcentajeDescuento;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Condición de Contrato: {CondicionContrato}");
        Console.WriteLine($"Especialidad: {Especialidad}");
        Console.WriteLine($"Tipo de Actividad: {TipoActividad}");
        Console.WriteLine($"Tipo de Afiliación: {TipoAfiliacion}");
        Console.WriteLine($"Sueldo Base: {SueldoBase}");
        Console.WriteLine($"Bonificación: {Bonificacion}");
        Console.WriteLine($"Descuento: {Descuento}");
        Console.WriteLine($"Sueldo Bruto: {SueldoBruto}");
        Console.WriteLine($"Sueldo Neto: {SueldoNeto}");
    }
}

// Ejemplo de uso
public class Program
{
    public static void Main()
    {
        Arquitecto arquitecto1 = new Arquitecto(
            "A001",
            "Juan Perez",
            "Estable",
            "Estructuras",
            "Supervisión de Obras",
            "AFP"
        );

        arquitecto1.MostrarInformacion();
    }
}


//problema: 2

using System;

public class Jefe
{
    public string Nombres { get; set; }
    public string DNI { get; set; }
    public string Cargo { get; set; }
    public string Area { get; set; }
    public int AniosAntiguedad { get; set; }
    public double SueldoBase { get; set; }
    public double Movilidad { get; set; }
    public double Bonificacion { get; set; }
    public double SueldoFinal { get; set; }

    public Jefe(string nombres, string dni, string cargo, string area, int aniosAntiguedad)
    {
        Nombres = nombres;
        DNI = dni;
        Cargo = cargo;
        Area = area;
        AniosAntiguedad = aniosAntiguedad;
        SueldoBase = CalcularSueldoBase();
        Movilidad = CalcularMovilidad();
        Bonificacion = CalcularBonificacion();
        SueldoFinal = CalcularSueldoFinal();
    }

    private double CalcularSueldoBase()
    {
        if (Cargo == "Gerente")
        {
            if (Area == "Contabilidad")
            {
                return 6000;
            }
            else if (Area == "Planificación")
            {
                return 7000;
            }
        }
        else if (Cargo == "Subgerente")
        {
            if (Area == "Contabilidad")
            {
                return 5000;
            }
            else if (Area == "Planificación")
            {
                return 6000;
            }
        }
        return 0;
    }

    private double CalcularMovilidad()
    {
        if (Cargo == "Gerente")
        {
            return 700;
        }
        else if (Cargo == "Subgerente")
        {
            return 400;
        }
        return 0;
    }

    private double CalcularBonificacion()
    {
        double porcentajeBonificacion = AniosAntiguedad <= 7 ? 0.05 : 0.04;
        return SueldoBase * porcentajeBonificacion;
    }

    private double CalcularSueldoFinal()
    {
        return SueldoBase + Bonificacion + Movilidad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"DNI: {DNI}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Área: {Area}");
        Console.WriteLine($"Años de Antigüedad: {AniosAntiguedad}");
        Console.WriteLine($"Sueldo Base: {SueldoBase}");
        Console.WriteLine($"Movilidad: {Movilidad}");
        Console.WriteLine($"Bonificación: {Bonificacion}");
        Console.WriteLine($"Sueldo Final: {SueldoFinal}");
    }
}

// Ejemplo de uso
public class Program
{
    public static void Main()
    {
        Jefe jefe1 = new Jefe(
            "Maria Lopez",
            "12345678",
            "Gerente",
            "Contabilidad",
            10
        );

        jefe1.MostrarInformacion();
    }
}

