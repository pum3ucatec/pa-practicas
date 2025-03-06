namespace GetStartedApp.src
{
    public class Cuadrado : Geometria2D
    {
        public int CoordenadaX { get; set; }
        public int CoordenadaY { get; set; }
        public int Lado { get; set; }

        public Cuadrado(int coordenadaX, int coordenadaY, int lado)
        {
            CoordenadaX = coordenadaX;
            CoordenadaY = coordenadaY;
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}