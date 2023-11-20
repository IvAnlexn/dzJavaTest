from abc import ABC, abstractmethod
from ast import List

from Architecture.in_memory_model import IModelChangeObserver, IModelChanger
   
class ModelStore(IModelChanger):
   def __init__(self, changeObservers: List[IModelChangeObserver]):
      self.models = []
      self.scenes = []
      self.flashes = []
      self.cameras = []
      
   def get_scene(self, id):
      for scene in self.scenes:
         if scene.id == id:
            return scene
      return None
   
   def notify_change(self, sender) -> None:
      return super().notify_change(sender)