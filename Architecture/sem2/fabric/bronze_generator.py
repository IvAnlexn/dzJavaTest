from product.bronze import Bronze
from fabric.item_fabric import ItemFabric


class BronzeGenerator(ItemFabric):
    def create_item(self):
        return Bronze()