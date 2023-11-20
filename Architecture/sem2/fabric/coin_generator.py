from product.coin import Coin
from fabric.item_fabric import ItemFabric


class CoinGenerator(ItemFabric):
    def create_item(self):
        return Coin()