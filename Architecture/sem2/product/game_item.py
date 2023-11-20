from abc import ABC, abstractmethod

class GameItem(ABC):
    @abstractmethod
    def open(self):
        pass