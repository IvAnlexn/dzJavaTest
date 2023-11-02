package calculator;

import static org.assertj.core.api.Assertions.*;

import calculator.Calculator;
// Задание 1.
// ** В классе Calculator создайте метод calculateDiscount,
// который принимает сумму покупки и процент скидки и возвращает сумму с учетом скидки.
// Ваша задача - проверить этот метод с использованием библиотеки AssertJ.
// Если метод calculateDiscount получает недопустимые аргументы,
// он должен выбрасывать исключение ArithmeticException.
// Не забудьте написать тесты для проверки этого поведения.

public class TestCalculator {
  public static void testCalculator() {
    Calculator calculator = new Calculator();
    assertThat(calculator.calculateDiscount(100f, 0.5f)).isEqualTo(50.0f);
    assertThat(calculator.calculateDiscount(100f, 1f)).isEqualTo(0f);
    assertThat(calculator.calculateDiscount(100f, 0f)).isEqualTo(100f);
    assertThatThrownBy(() -> calculator.calculateDiscount(-100f, 0.5f)).isInstanceOf(ArithmeticException.class);
    assertThatThrownBy(() -> calculator.calculateDiscount(100f, 1.1f)).isInstanceOf(ArithmeticException.class);
    assertThatThrownBy(() -> calculator.calculateDiscount(100f, -0.1f)).isInstanceOf(ArithmeticException.class);
  }
}
