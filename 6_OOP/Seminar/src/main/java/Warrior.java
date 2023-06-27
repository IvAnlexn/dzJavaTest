public abstract class Warrior extends Character{
int armor;
  public Warrior(String name, int experience, int level, int hp, int damage, int defense, int speed, int armor) {
    super(name, experience, level, hp, damage, defense, speed);
    this.armor = armor;
  }
  public Warrior(String name) {
    super(name);
    this.armor = 5;
  }
  @Override
  public int defend(int damage) {
    return damage - defense - armor;
  }
}
