public class EmptyStringException extends Exception {
  public EmptyStringException(String message) {
    super("Возникло исключение EmptyStringException" + message);
  }
}
