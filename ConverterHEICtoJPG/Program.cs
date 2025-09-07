using ImageMagick;
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca la ruta de la carpeta que desea recorrer sus fotos .HEIC:");
        string rutaEntrada = Console.ReadLine();

        Console.WriteLine("Introduzca la ruta de salida para las fotos .JPG:");
        string rutaSalida = Console.ReadLine();

        if (!Directory.Exists(rutaSalida))
            Directory.CreateDirectory(rutaSalida);

        string[] archivos = Directory.GetFiles(rutaEntrada, "*.HEIC", SearchOption.AllDirectories);

        int contador = 1;

        foreach (string archivo in archivos)
        {
            string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);

            try
            {
                ConvertidorIMG(archivo, rutaSalida, nombreArchivo);
                Console.WriteLine($"[{contador}] Convertido: {archivo}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en {archivo}: {e.Message}");
            }

            contador++;
        }

        Console.WriteLine("Conversión completada.");
    }

    public static void ConvertidorIMG(string archivoEntrada, string rutaSalida, string nombreArchivo)
    {
        // Cargar a input imagen

        using (MagickImage image = new MagickImage(archivoEntrada))
        {
            // Convertir formato

            image.Format = MagickFormat.Jpg;

            string rutaFinal = Path.Combine(rutaSalida, nombreArchivo + ".jpg");

            // Guardar imagen
            image.Write(rutaFinal);
        }
    }
}




