using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls.Shapes;
using GeometriaCSharp.src; // Asegúrate de que este namespace es correcto

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

                // Crear instancia de Cuadrado
                Cuadrado miCuadrado = new Cuadrado(50, 50, 100);
                Console.WriteLine($"Dibujando cuadrado en X:{miCuadrado.CoordenadaX}, Y:{miCuadrado.CoordenadaY}, Lado:{miCuadrado.Lado}");

                // Crear contenedor principal
                var stackPanel = new StackPanel
                {
                    Background = Brushes.White, // Fondo blanco para evitar transparencia
                    Width = 400,
                    Height = 400
                };

                // Crear un Canvas dentro del StackPanel
                var canvas = new Canvas();

                // Crear el cuadrado como un rectángulo
                var rectangulo = new Rectangle
                {
                    Width = miCuadrado.Lado,
                    Height = miCuadrado.Lado,
                    Fill = Brushes.Blue
                };

                // Aplicar coordenadas
                Canvas.SetLeft(rectangulo, miCuadrado.CoordenadaX);
                Canvas.SetTop(rectangulo, miCuadrado.CoordenadaY);

                // Agregar rectángulo al Canvas
                canvas.Children.Add(rectangulo);

                // Agregar Canvas al StackPanel
                stackPanel.Children.Add(canvas);

                // Crear ventana y asignar StackPanel
                var window = new Window
                {
                    Title = "Dibujar Cuadrado",
                    Width = 400,
                    Height = 400,
                    Content = stackPanel
                };

                window.Show();
            }
        }
    }
}
