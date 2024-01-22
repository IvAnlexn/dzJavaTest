import numpy as np

def calculate_mean_centered(arr):
    return arr - np.mean(arr)

def calculate_norm(arr):
    return np.sqrt(np.sum(arr ** 2))

def calculate_pearson_correlation(arr_x, arr_y):
    x_diff = calculate_mean_centered(arr_x)
    y_diff = calculate_mean_centered(arr_y)
    
    denominator = calculate_norm(x_diff) * calculate_norm(y_diff)
    
    if denominator == 0:
        return 0
    
    pearson_corr = np.sum(x_diff * y_diff) / denominator
    return pearson_corr

# Ввод данных
arr_x = np.array(list(map(float, input("Введите значения первого массива через пробел: ").split())))
arr_y = np.array(list(map(float, input("Введите значения второго массива через пробел: ").split())))

# Расчет и вывод корреляции
correlation_coefficient = calculate_pearson_correlation(arr_x, arr_y)
print(f"Коэффициент корреляции Пирсона: {correlation_coefficient}")