public class Priest extends Caster{
  public Priest(String name, int experience, int level, int hp, int damage, int defense, int speed, int mana) {
    super(name, experience, level, hp, damage, defense, speed, mana);
  }
  public Priest(String name) {
    super(name);
  }
  @Override
  public String getInfo() {
    return "Priest";
  }
  @Override
  public void step(){}
}
