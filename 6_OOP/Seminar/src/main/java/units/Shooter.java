package units;

import java.util.ArrayList;

public abstract class Shooter extends Character implements CharacterInterface{
  protected int range;
  protected int arrows;
  protected int maxArrows;

  public Shooter(Names name, int hp, int maxHp, int damage, int defense, int initiative, int arrows, int maxArrows, int x, int y) {
    super(name, hp, maxHp, damage, defense, initiative, x, y);
    this.arrows = arrows;
    this.maxArrows = maxArrows;
  }

  @Override
  public void step(ArrayList<Character> teamFoe, ArrayList<Character> teamFriend) {
    if (this.isDead()) return;
    this.state = States.READY;
    if (arrows <= 0) {
      this.state = States.NOAMMO;
      return;
    }
    Character nearestFoe = findNearest(teamFoe);
    if (nearestFoe != null) {
      nearestFoe.getDamage(damage);
      this.arrows -= 1;
      state = States.SHOOT;
    }
    for (Character c : teamFriend) {
      if (this.arrows < this.maxArrows && c.getClass() == Farmer.class && c.state.equals(States.READY)) {
        this.arrows += 1;
        c.state = States.SUPPLY;
        break;
      }
    }
  }
  @Override
  public String getInfo() {
    return super.getInfo() + String.format(" ammo: %d/%d", this.arrows, this.maxArrows);
  }
}