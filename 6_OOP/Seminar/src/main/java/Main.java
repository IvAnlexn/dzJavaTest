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

import java.util.ArrayList;
import java.util.Random;

public class Main {
  public static void main(String[] args) {
    CharacterInterface farmer = new Farmer("farmer");
    Character spearman = new Spearman("spearman");
    Character rogue = new Rogue("rogue");
    Character sniper = new Sniper("sniper");
    Character crossbowman = new Crossbowman("crossbowman");
    Character mage = new Mage("mage");
    Character priest = new Priest("priest");
farmer.getInfo();

    ArrayList<Character> teamOne = new ArrayList<>();
    ArrayList<Character> teamTwo = new ArrayList<>();
    fillList(teamOne);
    fillList(teamTwo);
    for (Character c:
         teamOne) {
      System.out.println(c.getInfo());
    }
    for (Character c:
            teamTwo) {
      System.out.println(c.getInfo());
    }
  }


    public static void fillList (ArrayList < Character > list) {
      for (int i = 0; i < 10; i++) {
        int cnt = new Random().nextInt(0, 7);
        switch (cnt) {
          case 0: {
            list.add(new Crossbowman("crossbowman"));
            break;
          }
          case 1: {
            list.add(new Farmer("farmer"));
            break;
          }
          case 2: {
            list.add(new Mage("mage"));
            break;
          }
          case 3: {
            list.add(new Priest("priest"));
            break;
          }
          case 4: {
            list.add(new Rogue("rogue"));
            break;
          }
          case 5: {
            list.add(new Sniper("sniper"));
            break;
          }
          default: {
            list.add(new Spearman("spearman"));
            break;
          }
        }
      }
    }
  }
