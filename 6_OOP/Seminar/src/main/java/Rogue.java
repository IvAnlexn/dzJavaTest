public class Rogue extends Warrior{
  public Rogue(String name, int experience, int level, int hp, int damage, int defense, int speed, int armor) {
    super(name, experience, level, hp, damage, defense, speed, armor);
  }
  public Rogue(String name) {
    super(name);
  }
  @Override
  public String getInfo() {
    return "Rogue";
  }
  @Override
  public void step(){}
}
