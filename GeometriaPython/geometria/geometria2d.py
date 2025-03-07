from abc import ABC, abstractmethod

class Geometria2D(ABC):
    @abstractmethod
    def calcular_area(self):
        pass

    @abstractmethod
    def calcular_perimetro(self):
        pass
