public abstract class Shooter extends Character {
  int range;
  public Shooter(String name, int experience, int level, int hp, int damage, int defense, int speed, int range) {
    super(name, experience, level, hp, damage, defense, speed);
    this.range = range;
  }
  public Shooter(String name) {
    super(name);
    this.range = 5;
  }
  public int shoot() {
    return range;
  }
}
