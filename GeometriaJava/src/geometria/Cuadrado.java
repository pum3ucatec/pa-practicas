package geometria;

public class Cuadrado extends Geometria2D {
    private int coordenadaX;
    private int coordenadaY;
    private int lado;
    
    public Cuadrado(int x, int y, int lado) {
        this.coordenadaX = x;
        this.coordenadaY = y;
        this.lado = lado;
    }
    
    @Override
    public double calcularArea() {
        return lado * lado;
    }
    
    @Override
    public double calcularPerimetro() {
        return 4 * lado;
    }
    
    public int getCoordenadaX() {
        return coordenadaX;
    }
    
    public int getCoordenadaY() {
        return coordenadaY;
    }
    
    public int getLado() {
        return lado;
    }
}
