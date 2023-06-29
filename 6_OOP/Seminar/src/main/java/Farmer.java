public class Farmer extends Character {

  public Farmer(String name, int experience, int level, int hp, int damage, int defense, int speed) {
    super(name, experience, level, hp, damage, defense, speed);
  }
  public Farmer(String name) {
    super(name);
  }
    @Override
    public String getInfo() {
      return "Farmer";
    }
    @Override
    public void step(){}
  }
