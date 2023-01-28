#!/usr/bin/env python3

a = [5, 4, 3, 2, 1]
N = len(a)
for i in range(N-1):
    for j in range(N-1-i):
        if a[j] > a[j+1]:
            temp = a[j]
            a[j] = a[j+1]
            a[j+1] = temp
print(a)
