public class Sniper extends Shooter {

  public Sniper(String name, int experience, int level, int hp, int damage, int defense, int speed, int range) {
    super(name, experience, level, hp, damage, defense, speed, range);
  }
  public Sniper(String name) {
    super(name);
  }
  @Override
  public String getInfo() {
    return "Sniper";
  }
  @Override
  public void step(){}
}
