package geometria;

import javax.swing.JFrame;
import javax.swing.SwingUtilities;

public class Main {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            // Crear una instancia de Cuadrado en la posición (50, 50) con un lado de 100.
            Cuadrado cuadrado = new Cuadrado(50, 50, 100);
            
            // Crear el JFrame.
            JFrame frame = new JFrame("Proyecto Geometría - Dibujar Cuadrado");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            
            // Crear el panel de dibujo y agregarlo al frame.
            DrawingPanel panel = new DrawingPanel(cuadrado);
            frame.getContentPane().add(panel);
            
            // Empaquetar la ventana y centrarla.
            frame.pack();
            frame.setLocationRelativeTo(null);
            frame.setVisible(true);
        });
    }
}
