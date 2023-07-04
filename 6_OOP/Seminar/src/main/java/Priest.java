import java.util.ArrayList;

public class Priest extends Caster{
  public Priest(String name, int x, int y) {
    super(name, x, y);
  }
  @Override
  public String getInfo() {
    return "Priest";
  }
  @Override
  public void step(ArrayList<Character> team){
    Character nearestFoe = findNearest(team);
    System.out.printf("%s in %d\n", nearestFoe.getInfo(), position.getDistance(nearestFoe.getCoordinates()));
  }
}
