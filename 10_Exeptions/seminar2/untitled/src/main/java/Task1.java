import java.util.Scanner;

public class Task1 {
  public static void main(String[] args) {
    System.out.println(userInput());
  }

  /**
   * Метод, который запрашивает у пользователя ввод дробного числа (типа float),
   * и возвращает введенное значение.
   * @return float
   */
  public static float userInput() {
    Scanner scanner = new Scanner(System.in);
    System.out.println("Введите дробное число типа float: ");
    try {
      return Float.parseFloat(scanner.nextLine());
    }
    catch (NumberFormatException e) {
      System.out.println("Значение должно быть числом.");
      return userInput();
    }
  }
}
