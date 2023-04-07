# Задача 8: Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек,
# если разрешается сделать один разлом по прямой между дольками
# (то есть разломить шоколадку на два прямоугольника).
def check_user_input(user_input):
    return user_input > 0


width = int(input("Введите ширину шоколадки в дольках: "))
length = int(input("Введите длину шоколадки в дольках: "))
pieces = int(input("Введите число долек которые хотите отломить: "))

if check_user_input(width) and check_user_input(length) and check_user_input(pieces):
    if (pieces % width == 0 or pieces % length == 0) and width * length > pieces:
        print(f"Вы сможете отломить {pieces} долек")
    else:
        print(f"Вы не сможете отломить {pieces} долек")
else:
    print("Одно из введеных чисел неверное")
