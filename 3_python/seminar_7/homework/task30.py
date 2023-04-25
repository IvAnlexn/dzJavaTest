def progression(start, dif, quantity):
    prog_arr = [start+dif*i for i in range(quantity)]
    return prog_arr
start = int(input("Введите начальное значение: "))
dif = int(input("Введите разность между значениями: "))
quantity = int(input("Введите колличество элементов в прогрессии: "))
print(progression(start, dif, quantity))
    