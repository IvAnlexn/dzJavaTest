public class Spearman extends Warrior{
  public Spearman(String name, int experience, int level, int hp, int damage, int defense, int speed, int armor) {
    super(name, experience, level, hp, damage, defense, speed, armor);
  }
  public Spearman(String name) {
    super(name);
  }
  @Override
  public String getInfo() {
    return "Spearman";
  }
  @Override
  public void step(){}
}
