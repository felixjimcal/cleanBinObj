class Program
{
    static void Main()
    {
        string directorioPrincipal = @"C:\Users\felix\source\Repos"; // Reemplaza con la ruta de tu carpeta principal
        BuscarYEliminarCarpetas(directorioPrincipal, "bin");
        BuscarYEliminarCarpetas(directorioPrincipal, "obj");

        Console.WriteLine("Proceso completado. Presiona cualquier tecla para salir.");
        Console.ReadKey();
    }

    static void BuscarYEliminarCarpetas(string directorioRaiz, string nombreCarpeta)
    {
        string[] carpetasEncontradas = Directory.GetDirectories(directorioRaiz, nombreCarpeta, SearchOption.AllDirectories);

        foreach (var carpeta in carpetasEncontradas)
        {
            try
            {
                Directory.Delete(carpeta, true);
                Console.WriteLine($"Carpeta \"{nombreCarpeta}\" eliminada en: {carpeta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al intentar eliminar la carpeta \"{nombreCarpeta}\" en: {carpeta}");
                Console.WriteLine($"Mensaje de error: {ex.Message}");
            }
        }
    }
}
