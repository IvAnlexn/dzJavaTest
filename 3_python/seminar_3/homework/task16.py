#!/usr/bin/env python3
# Задача 16: Требуется вычислить, сколько раз встречается некоторое число X в массиве A[1..N].
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
def count_target_num_in_arr(array, target_num):
    count = 0
    for i in array:
        if i == target_num:
            count += 1
    return count


num_of_elements = int(input("Введите количество элементов в массиве "))
array = [
    int(
        input(
            "Введите целое число ",
        )
    )
    for _ in range(num_of_elements)
]
target_num = int(input("Введите число для поиска "))
print(count_target_num_in_arr(array, target_num))
