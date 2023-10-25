import calculator.TestCalculator;
import shop.TestShop;


public class Main {
  public static void main(String[] args) {
    TestCalculator.testCalculator();
    TestShop.testSortProductsByPrice();
    TestShop.testGetMostExpensiveProduct();
    TestShop.testGetMostExpensiveProductExeptions();
  }
}
