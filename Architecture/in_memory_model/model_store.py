from abc import ABC, abstractmethod
from ast import List
from model_elements.scene import Scene
from model_elements.camera import Camera
from model_elements.flash import Flash
from in_memory_model import IModelChangeObserver, IModelChanger
from model_elements.poligonal_model import PoligonalModel
   
class ModelStore(IModelChanger):
    def __init__(self, changeObservers: list[IModelChangeObserver]) -> None:
        self._changeObservers = changeObservers
        self.models: list[PoligonalModel] = [PoligonalModel([])]
        self.flashes: list[Flash] = [Flash()]
        self.cameras: list[Camera] = [Camera()]
        self.scenes: list[Scene] = [Scene(self.models, self.flashes, self.cameras)]
      
    def get_scene(self, id):
      for scene in self.scenes:
         if scene.id == id:
            return scene
      return None
   
    def notify_change(self, sender) -> None:
      return super().notify_change(sender)