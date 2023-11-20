from product.game_item import GameItem


class Coin(GameItem):
    def open(self):
        print('Coin')