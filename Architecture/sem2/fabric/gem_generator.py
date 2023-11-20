from product.gem import Gem
from fabric.item_fabric import ItemFabric


class GemGenerator(ItemFabric):
    def create_item(self):
        return Gem()