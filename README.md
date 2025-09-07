# 📸 HEIC to JPG Converter (C# + Magick.NET)

Un sencillo pero potente convertidor de imágenes **.HEIC a .JPG**, escrito en **C#** utilizando la librería [Magick.NET](https://github.com/dlemstra/Magick.NET).  


## ¿Por qué este proyecto?

Los iPhone y otros dispositivos modernos guardan las fotos en formato **HEIC** (High Efficiency Image Container).  
Aunque es eficiente en espacio, **no siempre es fácil de abrir en Windows, programas antiguos, ciertos navegadores, etc.**.

Este proyecto resuelve ese problema convirtiendo fotos `.HEIC` a `.JPG` de forma **rápida, sencilla y en masa**. 


## Características

- Conversión automática de **.HEIC → .JPG**.
- Procesa **carpetas completas** y sus subcarpetas (recursivo).
- Manejo básico de errores durante la conversión.
- Compatible con **Windows, Linux y macOS** (donde esté disponible Magick.NET).
- Salida configurable: define dónde se guardan las imágenes convertidas.


## Instalación

1. Clona este repositorio:

   ``git clone https://github.com/j-marthe/ConverterHEICtoJPG.git``
   ``cd ConverterHEICtoJPG``

2. Abre el proyecto en Visual Studio o VS Code.

3. Instala la dependencia principal desde NuGet, a través del siguiente comando:

    ``dotnet add package Magick.NET-Q8-AnyCPU``

## Uso

1. Ejecuta el programa desde la consola:

    ``dotnet run``


2. Se te pedirá:

    - Ruta de entrada → Carpeta con tus imágenes .HEIC.   
    (Por defecto los iPhone los guardan por fechas con año y mes (aaaamm__))

    - Ruta de salida → Carpeta donde se guardarán las imágenes .JPG.


## Ejemplo de ejecución:

Introduzca la ruta de la carpeta con fotos .HEIC:
C:\MisFotosHEIC

Introduzca la ruta de salida para las fotos .JPG:
C:\MisFotosConvertidas

[1] Convertido: C:\MisFotosHEIC\IMG_001.HEIC  
[2] Convertido: C:\MisFotosHEIC\IMG_002.HEIC  
Conversión completada.

## Dependencias

.NET 6.0+

Magick.NET
wrapper de ImageMagick para .NET.

## Ejemplo de resultado

Entrada: IMG_001.HEIC (iPhone).

Salida: IMG_001.jpg lista para abrir en cualquier software de edición o visor de imágenes.

## Mejoras futuras

A continuación se detalla las futuras mejoras:

- Opción de preservar la estructura de carpetas de origen.

- Ajustar la calidad de salida (compresión JPG).

- Añadir otros formatos de conversión.

- Crear una interfaz gráfica (GUI) para uso más sencillo.

- Procesamiento paralelo para mayor velocidad en lotes grandes.

## Autor

Proyecto desarrollado por Jesús Martínez Hernández
