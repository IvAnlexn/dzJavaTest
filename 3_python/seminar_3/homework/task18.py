#!/usr/bin/env python3
# Задача 18: Требуется найти в массиве A[1..N] самый близкий по величине элемент к заданному числу X.
# Пользователь в первой строке вводит натуральное число N – количество элементов в массиве.
# В последующих  строках записаны N целых чисел Ai. Последняя строка содержит число X
def find_closest_element(array, target_num):
    closest = array[0]
    for num in array:
        if abs(target_num - num) < abs(target_num - closest) or (
            abs(target_num - num) == abs(target_num - closest) and num < closest
        ):
            closest = num
    return closest


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
print(find_closest_element(array, target_num))
