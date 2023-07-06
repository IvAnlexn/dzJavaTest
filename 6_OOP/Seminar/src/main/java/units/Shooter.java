package units;

public abstract class Shooter extends Character {
  protected int range;
  protected int arrows;
  public Shooter(String name, int x, int y) {
    super(name, 5, 5, 3, 2, 4, 4, x, y);
    this.range = 5;
    this.arrows = 5;
  }
  @Override
  public String getInfo() {
    return String.format("%s: hp=%d, ammo=%d", this.name, this.hp, this.arrows);
  }
}
