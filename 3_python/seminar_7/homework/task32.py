
arr = list(map(int, input("Введите значения массива: ").split()))
min = int(input("min: "))
max = int(input("max: "))
indexes = [i for i, el in enumerate(arr) if el > min and el < max]
print(indexes)    