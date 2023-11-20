from product.poop import Poop
from fabric.item_fabric import ItemFabric


class PoopGenerator(ItemFabric):
    def create_item(self):
        return Poop()