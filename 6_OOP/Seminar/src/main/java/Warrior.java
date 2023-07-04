public abstract class Warrior extends Character{
int armor;
  public Warrior(String name, int x, int y) {
    super(name, 7, 7, 5,5, 2, x, y);
    this.armor = 5;
  }
}
