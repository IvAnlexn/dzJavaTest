from product.silver import Silver
from fabric.item_fabric import ItemFabric


class SilverGenerator(ItemFabric):
    def create_item(self):
        return Silver()