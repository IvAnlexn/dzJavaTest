import java.util.ArrayList;

public abstract class Character implements CharacterInterface {
  private String name;
  private int hp;
  private int maxHp;
  private int damage;
  private int defense;
  private int speed;
  protected Coordinates position;

  public Character(String name, int hp, int maxHp, int damage, int defense, int speed, int x, int y) {
    this.name = name;
    this.hp = hp;
    this.maxHp = maxHp;
    this.damage = damage;
    this.defense = defense;
    this.speed = speed;
    this.position = new Coordinates(x, y);
  }

  public Coordinates getCoordinates() {
    return position;
  }

  protected Character findNearest(ArrayList<Character> team) {
    Character nearest = team.get(0);
    for (Character character : team) {
      if (position.getDistance(character.getCoordinates()) < position.getDistance(nearest.getCoordinates())) {
        nearest = character;
      }
    }
    return nearest;
  }

}
