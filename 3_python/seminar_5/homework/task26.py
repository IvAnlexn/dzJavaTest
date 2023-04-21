#!/usr/bin/env python3
def power_numbers(base: int | float, exponent: int) -> int | float:
    if exponent == 0:
        return 1
    return power_numbers(base, exponent-1) * base

if __name__ == "__main__":
    base = int(input("Введите основание степени: "))
    exponent = int(input("Введите значение степени: "))
    print(f"{base}**{exponent} = {power_numbers(base, exponent)}")
