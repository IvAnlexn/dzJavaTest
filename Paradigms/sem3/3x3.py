def check_line(matrix, symbol):
    # Проверка по горизонтали и вертикали
    for i in range(3):
        if all(matrix[i][j] == symbol for j in range(3)) or all(matrix[j][i] == symbol for j in range(3)):
            return True

    # Проверка по диагоналям
    if all(matrix[i][i] == symbol for i in range(3)) or all(matrix[i][2 - i] == symbol for i in range(3)):
        return True

    return False


def print_matrix(matrix):
    for row in matrix:
        print('|'.join(row))
        print('-' * 5)
    print()


def enter_coord(matrix):
    while True:
        coord = input("Введите координаты квадрата от 1-1 до 3-3 или q для завершения: ")
        if coord == 'q':
            print('Game over!')
            exit()

        if len(coord) != 3 or coord not in '1-1-2-2-1-3-3-2-3-1':
            print('Введите значение от 1-1 до 3-3')
            continue

        x, y = map(lambda n: int(n) - 1, coord.split('-'))

        if matrix[x][y] != ' ':
            print('Клетка занята: ')
        else:
            return x, y


m = [[' ']*3 for _ in range(3)]

cnt = 0
while cnt < 9:
    x, y = enter_coord(m)
    m[x][y] = 'XO'[cnt % 2]
    cnt += 1
    print_matrix(m)

    for who in 'XO':
        if check_line(m, who):
            print(f'{who} выиграл!')
            exit()

# Если выход из цикла произошел после 9-го хода и не было победителя
print('Ничья!')