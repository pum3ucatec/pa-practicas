package geometria;

import javax.swing.JPanel;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Color;
import java.awt.Dimension;

public class DrawingPanel extends JPanel {
    // La figura a dibujar; en este ejemplo, un cuadrado.
    private Geometria2D figura;
    
    // Constructor que recibe una figura (puede ser un Cuadrado u otra que extienda Geometria2D).
    public DrawingPanel(Geometria2D figura) {
        this.figura = figura;
        setPreferredSize(new Dimension(400, 400));
        setBackground(Color.WHITE);
    }
    
    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g;
        
        // Si la figura es un Cuadrado, la dibujamos.
        // Puedes ampliar esta lógica para otras figuras.
        if (figura instanceof Cuadrado) {
            Cuadrado cuadrado = (Cuadrado) figura;
            g2.setColor(Color.BLUE);
            // Dibujar el cuadrado en las coordenadas y con el lado definidos
            g2.fillRect(cuadrado.getCoordenadaX(), cuadrado.getCoordenadaY(), cuadrado.getLado(), cuadrado.getLado());
        }
    }
}
