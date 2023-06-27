//Крестьянин, разбойник, снайпер, колдун, копейщик, арбалетчик, монах.
//Для каждого сформировать список свойств и возможных действий.
// Например, свойство скорость, действие, нанести удар.
// Проанализировать получившиеся свойства и действия персонажей и создать Обобщённый
// класс описывающий свойства и действия имеющиеся у всех персонажей.
// Создать этот класс.
// Создать классы для каждого типа персонажей наследующие и расширяющие абстрактный(обобщённый) класс.
// В основной программе создать по одному экземпляру каждого типа персонажей.
public class Main {
  public static void main(String[] args) {
    Character farmer = new Farmer("farmer");
    Character spearman = new Spearman("spearman");
    Character rogue = new Rogue("rogue");
    Character sniper = new Sniper("sniper");
    Character crossbowman = new Crossbowman("crossbowman");
    Character mage = new Mage("mage");
    Character priest = new Priest("priest");

  }
}
