package shop;

import static org.assertj.core.api.Assertions.*;

import java.util.*;


public class TestShop {

  /*
     Задание 2. (необязательное) *
     Мы хотим улучшить функциональность нашего интернет-магазина.
     Ваша задача - добавить два новых метода в класс Shop:
     Метод sortProductsByPrice(), который сортирует список продуктов по стоимости.
     Метод getMostExpensiveProduct(), который возвращает самый дорогой продукт.
     Напишите тесты, чтобы проверить, что магазин хранит верный список продуктов
     (правильное количество продуктов, верное содержимое корзины).
     Напишите тесты для проверки корректности работы метода getMostExpensiveProduct.
     Напишите тесты для проверки корректности работы метода sortProductsByPrice
     (проверьте правильность сортировки). Используйте класс Product для создания
     экземпляров продуктов и класс Shop для написания методов сортировки и тестов.
  */
  public static void testSortProductsByPrice() {
    List<Product> products = Arrays.asList(
            new Product(10, "Apple"),
            new Product(20, "Banana"),
            new Product(5, "Bread"),
            new Product(40, "Eggs"),
            new Product(30, "Milk"),
            new Product(10, "Apple"));
    Shop shop = new Shop(products);
    assertThat(shop.sortProductsByPrice())
            .isInstanceOf(List.class)
            .containsAll(products);
    assertThat(shop.sortProductsByPrice().toArray().length).isEqualTo(products.toArray().length);
  }

  public static void testGetMostExpensiveProduct() {
    List<Product> products = Arrays.asList(
            new Product(10, "Apple"),
            new Product(20, "Banana"),
            new Product(5, "Bread"),
            new Product(40, "Eggs"),
            new Product(30, "Milk"),
            new Product(10, "Apple"));
    Shop shop = new Shop(products);
    assertThat(shop.getMostExpensiveProduct())
            .isInstanceOf(Product.class)
            .isEqualTo(products.get(3));
  }

  public static void testGetMostExpensiveProductExeptions() {
    List<Product> products = new ArrayList<Product>();
    Shop shop = new Shop(products);
    assertThatThrownBy(shop::getMostExpensiveProduct)
            .isInstanceOf(NoSuchElementException.class);
  }
}