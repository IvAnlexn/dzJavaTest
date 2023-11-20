from random import choices, randint
from fabric.coin_generator import CoinGenerator
from fabric.gem_generator import GemGenerator
from fabric.gold_generator import GoldGenerator
from fabric.silver_generator import SilverGenerator
from fabric.poop_generator import PoopGenerator
from fabric.bronze_generator import BronzeGenerator


if __name__=='__main__':

    generator=[GemGenerator(), GoldGenerator(), SilverGenerator(), BronzeGenerator(), CoinGenerator(), PoopGenerator()]
    
    probabilities = [1, 5, 10, 15, 20, 49]

    for i in range(10):
        index = choices(range(len(generator)), probabilities)[0]
        generator[index].create_item().open()