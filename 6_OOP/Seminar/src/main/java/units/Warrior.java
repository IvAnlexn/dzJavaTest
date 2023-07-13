//1. Проверяем здоровье
//2. Ищем ближайшего врага
//5. Если расстояние до врага одна клетка бём его!
//3. Двигаемся в сторну врага
//4. Не наступаем на живых персонажей
package units;

import map.Coordinates;

import java.util.ArrayList;

public abstract class Warrior extends Character implements CharacterInterface {
  public Warrior(Names name, int hp, int maxHp, int damage, int defense, int initiative, int x, int y) {
    super(name, hp, maxHp, damage, defense, initiative, x, y);
  }

  @Override
  public void step(ArrayList<Character> teamFoe, ArrayList<Character> teamFriend) {
    if (this.isDead()) return;
    Character nearestFoe = findNearest(teamFoe);
    this.move(nearestFoe, teamFriend);
  }

  @Override
  public String getInfo() {
    return super.getInfo();
  }

  public void move(Character enemy, ArrayList<Character> team) {
    if (enemy.getCoordinates().getDistance(enemy.getCoordinates()) == 1) {
      enemy.getDamage(damage);
      return;
    }
    String direction = this.getCoordinates().getDirection(enemy.getCoordinates());
    switch (direction) {
      case "right":
        if (this.isFilled(team, new Coordinates(this.getCoordinates().getPosition()[0] + 1, this.getCoordinates().getPosition()[1])))
          return;
        this.position.x++;
        break;
      case "left":
        if (this.isFilled(team, new Coordinates(this.getCoordinates().getPosition()[0] - 1, this.getCoordinates().getPosition()[1])))
          return;
        this.position.x--;
        break;
      case "forward":
        if (this.isFilled(team, new Coordinates(this.getCoordinates().getPosition()[0], this.getCoordinates().getPosition()[1] + 1)))
          return;
        this.position.y--;
        break;
      case "back":
        if (this.isFilled(team, new Coordinates(this.getCoordinates().getPosition()[0], this.getCoordinates().getPosition()[1] - 1)))
          return;
        this.position.y++;
        break;


    }
  }

  private boolean isFilled(ArrayList<Character> team, Coordinates coordinates) {
    for (Character character : team) {
      if (coordinates.isEqual(character.getCoordinates())) return true;
    }
    return false;
  }
}

