numbers = [9, 4, 5, 6, 7, 1]
N = len(numbers)
min = 0
max = 0
sum = 0
for i in range(0, N):
    if numbers[i] > numbers[max]:
        max = i
    if numbers[i] < numbers[min]:
        min = i
if max > min:
    start = min
    fin = max
else:
    start = max
    fin = min
for j in range(start + 1, fin):
    sum = sum + numbers[j]
print(sum)
# add test comment
