//Крестьянин, разбойник, снайпер, колдун, копейщик, арбалетчик, монах.
//Для каждого сформировать список свойств и возможных действий.
// Например, свойство скорость, действие, нанести удар.
// Проанализировать получившиеся свойства и действия персонажей и создать Обобщённый
// класс описывающий свойства и действия имеющиеся у всех персонажей.
// Создать этот класс.
// Создать классы для каждого типа персонажей наследующие и расширяющие абстрактный(обобщённый) класс.
// В основной программе создать по одному экземпляру каждого типа персонажей.

//Добавить файл с описанием интерфейса.
// В котором описать два метода, void step(); и String getInfo();
// Реализовать интерфейс в абстрактном классе и в наследниках так,
// чтобы getInfo возвращал тип персонажа.
// Создать два списка в классе main.
// В каждый из списков добавить по десять экземпляров наследников BaseHero.
// Удалить ненужные методы из абстрактного класса, если такие есть.
// В main пройти по спискам и вызвать у всех персонажей getInfo.

//1. Создать класс с описанием координат, x и y.
//2. Добавить в абстрактный класс поле с координатами и пробросить его
//инициализацию до конструкторов персонажей.
// Farmer farmer = new Farmer(getName(), x, y);
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;

public class Main {
  public static void main(String[] args) {

    ArrayList<Character> teamOne = new ArrayList<>();
    ArrayList<Character> teamTwo = new ArrayList<>();
    fillList(teamOne, 0);
    fillList(teamTwo, 9);
    System.out.println(Arrays.toString(teamOne.toArray()));
    System.out.println("-----");
    System.out.println(Arrays.toString(teamTwo.toArray()));
    System.out.println("-----");
    for (Character c:
         teamOne) {
      c.step(teamTwo);
    }
    System.out.println("_____");
    for (Character c:
            teamTwo) {
      c.step(teamOne);
    }
  }


    public static void fillList (ArrayList <Character> list, int xPosition) {
      for (int i = 0; i < 10; i++) {
        int cnt = new Random().nextInt(0, 7);
        switch (cnt) {
          case 0: {
            list.add(new Crossbowman("crossbowman", xPosition, i));
            break;
          }
          case 1: {
            list.add(new Farmer("farmer", xPosition, i));
            break;
          }
          case 2: {
            list.add(new Mage("mage", xPosition, i));
            break;
          }
          case 3: {
            list.add(new Priest("priest", xPosition, i));
            break;
          }
          case 4: {
            list.add(new Rogue("rogue", xPosition, i));
            break;
          }
          case 5: {
            list.add(new Sniper("sniper", xPosition, i));
            break;
          }
          default: {
            list.add(new Spearman("spearman", xPosition, i));
            break;
          }
        }
      }
    }
  }
