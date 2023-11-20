from model_elements.poligon import Poligon
from model_elements.texture import Texture


class PoligonalModel:
    def __init__(self) -> None:
        self.poligons: list[Poligon] = [Poligon()]
        self.texture: list[Texture] = Texture