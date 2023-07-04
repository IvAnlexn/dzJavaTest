public abstract class Caster extends Character{
  int mana;
  public Caster(String name, int x, int y) {
    super(name, 5, 5, 1, 1,2, x, y);
    this.mana = 200;
  }
}
