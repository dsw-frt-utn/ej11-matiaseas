using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var casoList = new CasoList();

        var a1 = new Alumno(1, "Agustina Valverdi", 10.0);
        var a2 = new Alumno(2, "Esteban Quito", 6.7);
        var a3 = new Alumno(3, "Matias Autino", 8.33);
        casoList.Agregar(a1);
        casoList.Agregar(a2);
        casoList.Agregar(a3);

        Console.WriteLine("Listar por consola los alumnos");
        foreach (var a in casoList.GetAlumnos())
            Console.WriteLine(a);

        Console.WriteLine("\nBuscar por nombre un alumno que exista");
        var encontrado = casoList.BuscarPorNombre("Agustina Valverdi");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\nBuscar por nombre un alumno que no exista");
        var noEncontrado = casoList.BuscarPorNombre("Juan Rodríguez");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        casoList.Eliminar(a2);
        Console.WriteLine("\nEliminar un alumno y listar");
        foreach (var a in casoList.GetAlumnos())
            Console.WriteLine(a);

        casoList.EliminarEnPosicion(0);
        Console.WriteLine("\nEliminar el primer elemento y listar");
        foreach (var a in casoList.GetAlumnos())
            Console.WriteLine(a);
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var casoDic = new CasoDictionary();

        casoDic.Agregar(new Alumno(1, "Agustina Valverdi", 10.0));
        casoDic.Agregar(new Alumno(2, "Esteban Quito", 6.7));
        casoDic.Agregar(new Alumno(3, "Matias Autino", 8.33));

        Console.WriteLine("Listar por consola los alumnos");
        foreach (var par in casoDic.GetAlumnos())
            Console.WriteLine($"Clave: {par.Key} -> {par.Value}");

        Console.WriteLine("\nBuscar un alumno por clave que exista");
        var encontrado = casoDic.BuscarPorClave(20);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        Console.WriteLine("\nBuscar un alumno por clave que no exista");
        var noEncontrado = casoDic.BuscarPorClave(99);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        casoDic.Eliminar(10);
        Console.WriteLine("\nEliminar un alumno por clave y listar");
        foreach (var par in casoDic.GetAlumnos())
            Console.WriteLine($"Clave: {par.Key} -> {par.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var linq = new CasoLinq();

        Console.WriteLine("=== 1. Primer libro ===");
        var primero = linq.GetPrimero();
        Console.WriteLine($"{primero.Titulo} - {primero.Precio:C}");

        Console.WriteLine("\n=== 2. Último libro ===");
        var ultimo = linq.GetUltimo();
        Console.WriteLine($"{ultimo.Titulo} - {ultimo.Precio:C}");

        Console.WriteLine("\n=== 3. Suma de precios ===");
        Console.WriteLine(linq.GetTotalPrecios().ToString("C"));

        Console.WriteLine("\n=== 4. Promedio de precios ===");
        Console.WriteLine(linq.GetPromedioPrecios().ToString("C"));

        Console.WriteLine("\n=== 5. Libros con Id > 15 ===");
        foreach (var l in linq.GetListById())
            Console.WriteLine($"{l.Id} - {l.Titulo}");

        Console.WriteLine("\n=== 6. Título y precio en formato moneda ===");
        foreach (var s in linq.GetLibros())
            Console.WriteLine(s);

        Console.WriteLine("\n=== 7. Libro con mayor precio ===");
        var mayor = linq.GetMayorPrecio();
        Console.WriteLine($"{mayor.Titulo} - {mayor.Precio:C}");

        Console.WriteLine("\n=== 8. Libro con menor precio ===");
        var menor = linq.GetMenorPrecio();
        Console.WriteLine($"{menor.Titulo} - {menor.Precio:C}");

        Console.WriteLine("\n=== 9. Libros con precio mayor al promedio ===");
        foreach (var l in linq.GetMayorPromedio())
            Console.WriteLine($"{l.Titulo} - {l.Precio:C}");

        Console.WriteLine("\n=== 10. Libros ordenados por título (descendente) ===");
        foreach (var l in linq.GetOrdenadosPorTituloDesc())
            Console.WriteLine(l.Titulo);
    }
}
