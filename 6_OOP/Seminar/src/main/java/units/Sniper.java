package units;

import java.util.ArrayList;

public class Sniper extends Shooter {
  public Sniper(String name, int x, int y) {
    super(name, x, y);
  }

  @Override
  public void step(ArrayList<Character> teamFoe, ArrayList<Character> teamFriend){
    if (this.hp == 0 || arrows == 0) {return;}
    Character nearestFoe = findNearest(teamFoe);
    nearestFoe.hp -= (this.damage - this.defense);
    for (Character c:teamFriend) {
      if (c.getClass() == Farmer.class) {
        return;
      }
    }
    this.arrows -= 1;
  }
}
