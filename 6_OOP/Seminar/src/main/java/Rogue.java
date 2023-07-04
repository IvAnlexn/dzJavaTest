import java.util.ArrayList;

public class Rogue extends Warrior{
  public Rogue(String name, int x, int y) {
    super(name, x, y);
  }
  @Override
  public String getInfo() {
    return "Rogue";
  }
  @Override
  public void step(ArrayList<Character> team){
    Character nearestFoe = findNearest(team);
    System.out.printf("%s in %d\n", nearestFoe.getInfo(), position.getDistance(nearestFoe.getCoordinates()));
  }
}
