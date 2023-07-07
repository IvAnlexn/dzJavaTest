package units;

import map.Coordinates;
import java.util.ArrayList;

public abstract class Character implements CharacterInterface {
  protected String name;
  protected int hp;
  protected int maxHp;
  protected int damage;
  protected int defense;
  protected int initiative;
  protected int speed;
  protected Coordinates position;

  public Character(String name, int hp, int maxHp, int damage, int defense, int initiative, int speed, int x, int y) {
    this.name = name;
    this.hp = hp;
    this.maxHp = maxHp;
    this.damage = damage;
    this.defense = defense;
    this.initiative = initiative;
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

  public String getInfo() {
    return String.format("%s: hp=%d", this.name, this.hp);
  }
  public int getInitiative() {return this.initiative;}
}