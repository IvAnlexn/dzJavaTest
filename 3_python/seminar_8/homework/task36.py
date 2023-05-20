def modify(keys_values: str):
    return tuple(map(lambda pair: tuple(pair.split("=")), keys_values.split(" ")))


keys_values = input("Введите строку ключей и значений: ")
tp = modify(keys_values)
