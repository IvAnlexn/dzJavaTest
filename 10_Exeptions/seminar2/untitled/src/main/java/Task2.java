public class Task2 {
  /**
   * Если необходимо, исправьте данный код
   * @param args
   */
  public static void main(String[] args) {
    double[] intArray = new double[] {3,5,2,6,7,3,3,5,8};
    try {
      int d = 0;
      double catchedRes1 = intArray[8] / d;
      System.out.println("catchedRes1 = " + catchedRes1);
    } catch (ArithmeticException e) {
      System.out.println("Catching exception: " + e);
    }
  }
  }
