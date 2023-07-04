import java.util.ArrayList;

public class Spearman extends Warrior{
  public Spearman(String name, int x, int y) {
    super(name, x, y);
  }
  @Override
  public String getInfo() {
    return "Spearman";
  }
  @Override
  public void step(ArrayList<Character> team){
    Character nearestFoe = findNearest(team);
    System.out.printf("%s in %d\n", nearestFoe.getInfo(), position.getDistance(nearestFoe.getCoordinates()));
  }
}
