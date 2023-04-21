#!/usr/bin/env python3
def custom_sum(first_num: int, second_num: int, sum: int = 0) -> int:
    if first_num > 0:
        return custom_sum(first_num-1, second_num, sum+1)
    if second_num > 0:
        return custom_sum(first_num, second_num-1, sum+1)
    return sum


if __name__ == "__main__":
    first_num = int(input("Введите первый номер: "))
    second_num = int(input("Введите второй номер: "))
    print(f"{first_num} + {second_num} = {custom_sum(first_num, second_num)}")
