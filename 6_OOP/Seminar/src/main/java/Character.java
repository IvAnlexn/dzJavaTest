public abstract class Character implements CharacterInterface{
  public String name;
  public int experience;
  public int level;
  public int hp;
  public int damage;
  public int defense;
  public int speed;

  public Character(String name, int experience, int level, int hp, int damage, int defense, int speed) {
    this.name = name;
    this.experience = experience;
    this.level = level;
    this.hp = hp;
    this.damage = damage;
    this.defense = defense;
    this.speed = speed;
  }
  public Character(String name) {
    this.name = name;
    this.experience = 0;
    this.level = 1;
    this.hp = 100;
    this.damage = 10;
    this.defense = 0;
    this.speed = 1;

  }

  public int move() {
    return speed;
  }
  public int attack() {
    return damage;
  }
  public int defend(int damage) {
    return damage - defense;
  }
}
