import tkinter as tk
from geometria.cuadrado import Cuadrado

def main():
    # Crear una instancia del Cuadrado en (50, 50) con lado 100
    cuadrado = Cuadrado(50, 50, 100)
    
    # Crear la ventana principal
    root = tk.Tk()
    root.title("Dibujar Cuadrado")
    
    # Crear un Canvas de 400x400 con fondo blanco
    canvas = tk.Canvas(root, width=400, height=400, bg="white")
    canvas.pack()
    
    # Obtener las coordenadas y el lado del cuadrado
    x = cuadrado.get_coordenadaX()
    y = cuadrado.get_coordenadaY()
    lado = cuadrado.get_lado()
    
    # Dibujar el cuadrado: create_rectangle(x1, y1, x2, y2, ...)
    canvas.create_rectangle(x, y, x + lado, y + lado, fill="blue")
    
    # Ejecutar el loop de la aplicación
    root.mainloop()

if __name__ == "__main__":
    main()
