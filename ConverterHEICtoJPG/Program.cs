using ImageMagick;
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduzca la ruta de la carpeta que desea recorrer sus fotos .HEIC");

        string rutaPrincipal = Console.ReadLine();

        // Buscar primero en la carpeta raíz
        string[] archivosRaiz = Directory.GetFiles(rutaPrincipal, "*.HEIC");
        foreach (string archivo in archivosRaiz)
        {      
            Console.WriteLine($"Archivo en raíz: {archivo}");
        }

        // Obtener todas las carpetas dentro de la ruta principal
        string[] carpetas = Directory.GetDirectories(rutaPrincipal);

        foreach (string carpeta in carpetas)
        {
            Console.WriteLine($"Carpeta: {carpeta}");

            // Obtener los archivos dentro de cada carpeta
            string[] archivos = Directory.GetFiles(carpeta, "*.HEIC");

            foreach (string archivo in archivos)
            {
                Console.WriteLine($"\tArchivo: {archivo}");
            }
        }

        Console.WriteLine("Recorrido completado.");
    }
}

    //public void ConvertidorIMG(string rutaIMG)
    //{
    //    // Cargar a input imagen

    //    using (MagickImage image = new MagickImage("image\\IMG_0011.HEIC"))
    //    {
    //        // Convertir formato

    //        image.Format = MagickFormat.Png;

    //        // Guardar imagen
    //        image.Write("image\\IMG_0011.png");
    //    }
    //}


