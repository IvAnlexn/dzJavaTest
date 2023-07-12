package units;

import java.util.ArrayList;

public abstract class Shooter extends Character implements CharacterInterface{
  protected int range;
  protected int arrows;
  protected int maxArrows;

  public Shooter(Names name, int hp, int maxHp, int damage, int defense, int initiative, int speed,int arrows, int maxArrows, int x, int y) {
    super(name, hp, maxHp, damage, defense, initiative, speed, x, y);
    this.arrows = arrows;
    this.maxArrows = maxArrows;
  }

  @Override
  public void step(ArrayList<Character> teamFoe, ArrayList<Character> teamFriend) {
    if (state.equals(States.DEAD) || arrows <= 0) return;
    Character nearestFoe = findNearest(teamFoe);
    if (nearestFoe != null) {
      nearestFoe.getDamage(damage);
      for (Character c : teamFriend) {
        if (c.getClass() == Farmer.class && c.state.equals(States.READY)) {
          if (this.arrows< this.maxArrows) this.arrows += 1;
          return;
        }
      }
      this.arrows -= 1;
    }
  }
  @Override
  public String getInfo() {
    return super.getInfo() + String.format(" ammo: %d/%d", this.arrows, this.maxArrows);
  }
}