'''Основные причины выбора процедурной парадигмы в данном случае:

Простота и понятность: Процедурный подход часто является более простым и понятным, что упрощает создание такого небольшого скрипта.
Линейная структура: Программа линейна и состоит из последовательных шагов, что соответствует процедурной парадигме.
Модульность: Функция print_multiplication_table выполняет конкретную задачу, что соответствует концепции модульности процедурного программирования.'''

def print_multiplication_table(n):
    for i in range(1, n + 1):
        for j in range(1, 10):
            result = i * j
            print(f"{i} * {j} = {result}")

if __name__ == "__main__":
    try:
        n = int(input("Введите число n: "))
        if n < 1:
            print("Введите положительное число.")
        else:
            print_multiplication_table(n)
    except ValueError:
        print("Введено недопустимое значение.")