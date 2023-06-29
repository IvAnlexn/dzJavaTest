public class Mage extends Caster{
  public Mage(String name, int experience, int level, int hp, int damage, int defense, int speed, int mana) {
    super(name, experience, level, hp, damage, defense, speed, mana);
  }
  public Mage(String name) {
    super(name);
  }
  @Override
  public String getInfo() {
    return "Mage";
  }
  @Override
  public void step(){}
}
