public abstract class Caster extends Character{
  int mana;
  public Caster(String name, int experience, int level, int hp, int damage, int defense, int speed, int mana) {
    super(name, experience, level, hp, damage, defense, speed);
    this.mana = mana;
  }
  public Caster(String name) {
    super(name);
    this.mana = 200;
  }
  public int cast() {
    return mana;
  }
}
