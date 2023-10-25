package calculator;

public class Calculator {
  public float calculateDiscount(float sum, float discountPercent) throws ArithmeticException {
    if (sum <= 0.0f) {
      throw new ArithmeticException("Purchase sum less or equal 0");
    }
    if (discountPercent < 0.0f) {
      throw new ArithmeticException("Discount less than 0");
    }
    if (discountPercent > 1.0f) {
      throw new ArithmeticException("Discount more than 1(100%)");
    }
    return sum - (sum * discountPercent);
  }
}
