using GetStartedApp.src;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Controls.Shapes;
using System;

namespace GetStartedApp.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Crear una instancia de Cuadrado (por ejemplo, posición (50,50) y lado 100)
        Cuadrado miCuadrado = new Cuadrado(50, 50, 100);
        Console.WriteLine($"Dibujando cuadrado en X: {miCuadrado.CoordenadaX}, Y: {miCuadrado.CoordenadaY}, Lado: {miCuadrado.Lado}");

        // Crear un objeto Rectangle que representará el cuadrado
        var squareRect = new Rectangle
        {
            Width = miCuadrado.Lado,
            Height = miCuadrado.Lado,
            Fill = Brushes.Blue
        };

        // Posicionar el rectángulo en el Canvas
        Canvas.SetLeft(squareRect, miCuadrado.CoordenadaX);
        Canvas.SetTop(squareRect, miCuadrado.CoordenadaY);

        // Agregar el rectángulo al Canvas definido en el XAML
        DrawingCanvas.Children.Add(squareRect);
    }
}