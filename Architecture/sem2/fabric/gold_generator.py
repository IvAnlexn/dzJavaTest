from product.gold import Gold
from fabric.item_fabric import ItemFabric


class GoldGenerator(ItemFabric):
    def create_item(self):
        return Gold()