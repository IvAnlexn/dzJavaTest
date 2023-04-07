# Найдите сумму цифр трехзначного числа.

three_digit_number = int(input("Пожалуйста введите трехзначное целое число: "))
if three_digit_number < 100 or three_digit_number > 999:
    print("Число должно быть трехзначным")
else:
    sum = (
        three_digit_number % 10
        + three_digit_number // 10 % 10
        + three_digit_number // 100
    )
    print(f"Сумма цифр трехзачного числа {three_digit_number} = {sum}")
