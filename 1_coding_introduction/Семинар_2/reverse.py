#!/usr/bin/env python3

num = [1, 2, 3, 4, 5, 6]
N = len(num)
for i in range(N // 2):
    print(i)
    temp = num[i]
    num[i] = num[N-1-i]
    num[N-1-i] = temp
print(num)
