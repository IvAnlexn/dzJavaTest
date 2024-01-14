def sort_imperative(arr):
    n = len(arr)
    for i in range(n):
        for j in range(0, n-i-1):
            if arr[j] < arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]

# Пример использования:
numbers = [64, 34, 25, 12, 22, 11, 90]
sort_imperative(numbers)
print("Отсортированный список в порядке убывания:", numbers)

def sort_declarative(arr):
    return sorted(arr, reverse=True)

# Пример использования:
numbers = [64, 34, 25, 12, 22, 11, 90]
sorted_numbers = sort_declarative(numbers)
print("Отсортированный список в порядке убывания:", sorted_numbers)