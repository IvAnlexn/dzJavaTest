public class Crossbowman extends Shooter{
  public Crossbowman(String name, int experience, int level, int hp, int damage, int defense, int speed, int range) {
    super(name, experience, level, hp, damage, defense, speed, range);
  }
  public Crossbowman(String name) {
    super(name);
  }

  @Override
  public String getInfo() {
    return "Crossbowman";
  }
  @Override
  public void step(){}
}
