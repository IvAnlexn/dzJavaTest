public abstract class Shooter extends Character {
  int range;
  public Shooter(String name, int x, int y) {
    super(name, 5, 5, 3, 2, 4, x, y);
    this.range = 5;
  }
}
