using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls.Shapes;
using GeometriaCSharp.src; // Namespace de Cuadrado

namespace GeometriaCSharp
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();

        public class App : Application
        {
            public override void OnFrameworkInitializationCompleted()
            {
                base.OnFrameworkInitializationCompleted();

                // Crear instancia de Cuadrado con coordenadas dentro del Canvas
                Cuadrado miCuadrado = new Cuadrado(100, 100, 100);

                Console.WriteLine($"Dibujando cuadrado en X:{miCuadrado.CoordenadaX}, Y:{miCuadrado.CoordenadaY}, Lado:{miCuadrado.Lado}");

                // Crear un Canvas con fondo blanco
                var canvas = new Canvas
                {
                    Width = 400,
                    Height = 400,
                    Background = Brushes.White
                };

                // Crear el cuadrado como un Rectángulo
                var rectangulo = new Rectangle
                {
                    Width = miCuadrado.Lado,
                    Height = miCuadrado.Lado,
                    Fill = Brushes.Blue
                };

                // Aplicar coordenadas al rectángulo
                Canvas.SetLeft(rectangulo, miCuadrado.CoordenadaX);
                Canvas.SetTop(rectangulo, miCuadrado.CoordenadaY);

                // Agregar el rectángulo al canvas
                canvas.Children.Add(rectangulo);

                // Crear ventana y asignar el Canvas
                var window = new Window
                {
                    Title = "Dibujar Cuadrado",
                    Width = 400,
                    Height = 400,
                    Content = canvas
                };

                window.Show();
            }
        }
    }
}
