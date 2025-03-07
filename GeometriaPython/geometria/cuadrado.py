from geometria.geometria2d import Geometria2D

class Cuadrado(Geometria2D):
    def __init__(self, x, y, lado):
        self.coordenadaX = x
        self.coordenadaY = y
        self.lado = lado

    def calcular_area(self):
        return self.lado * self.lado

    def calcular_perimetro(self):
        return 4 * self.lado

    def get_coordenadaX(self):
        return self.coordenadaX

    def get_coordenadaY(self):
        return self.coordenadaY

    def get_lado(self):
        return self.lado
