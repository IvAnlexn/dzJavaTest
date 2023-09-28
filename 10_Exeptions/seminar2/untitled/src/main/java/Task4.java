import java.util.Scanner;

/**
 * Разработайте программу, которая выбросит Exception,
 * когда пользователь вводит пустую строку.
 * Пользователю должно показаться сообщение,
 * что пустые строки вводить нельзя.
 */
public class Task4 {
  public static void main(String[] args) {
    mainHelper();
  }
  public static void mainHelper(){
    try {
      String userInput = getUserInput();
      System.out.println(userInput);
    } catch (EmptyStringException e) {
      System.out.println("Пустые строки вводить нельзя");
      System.out.println("Попробуйте снова");
      mainHelper();
    }
  }
  static Scanner scanner = new Scanner(System.in);
  public static String getUserInput() throws EmptyStringException {
    System.out.println("Введите строку:");
    String input = scanner.nextLine();
    if (input.equals("")) {
      throw new EmptyStringException("Пользователь ввел пустую строку");
    }
    return input;
  }
}
