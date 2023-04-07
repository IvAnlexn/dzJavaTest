# Задача 6: Вы пользуетесь общественным транспортом?
# Вероятно, вы расплачивались за проезд и получали билет с номером.
# Счастливым билетом называют такой билет с шестизначным номером,
# где сумма первых трех цифр равна сумме последних трех.
# Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6.
# Вам требуется написать программу, которая проверяет счастливость билета.
def count_three_digits_sum(three_digit_number):
    sum = (
        three_digit_number % 10
        + three_digit_number // 10 % 10
        + three_digit_number // 100
    )
    return sum


ticket_number = int(
    input("Введите шестизначный номер билета содержащий только цифры: ")
)
if ticket_number >= 100000 and ticket_number <= 999999:
    first_number = ticket_number // 1000
    second_number = ticket_number % 1000
    if count_three_digits_sum(first_number) == count_three_digits_sum(second_number):
        print("Ваш билет счастливый")
    else:
        print("Ваш билет не счастливый")
else:
    print("Вы ввели неверное число")
