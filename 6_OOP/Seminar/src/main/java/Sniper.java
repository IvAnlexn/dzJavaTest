import java.util.ArrayList;

public class Sniper extends Shooter {
  public Sniper(String name, int x, int y) {
    super(name, x, y);
  }
  @Override
  public String getInfo() {
    return "Sniper";
  }
  @Override
  public void step(ArrayList<Character> team){
    Character nearestFoe = findNearest(team);
    System.out.printf("%s in %d\n", nearestFoe.getInfo(), position.getDistance(nearestFoe.getCoordinates()));
  }
}
