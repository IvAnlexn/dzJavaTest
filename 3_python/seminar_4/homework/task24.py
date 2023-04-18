bushes = [1, 3, 2, 1, 1, 6]
max = bushes[0]
for i in range(len(bushes)):
    if i < len(bushes)-2:
        collected = sum(bushes[i:i+3])
    else:
        collected = sum(bushes[i:]+bushes[:3-(len(bushes)-i)])
    if collected>max:
        max = collected
print(max)
