vovels = set(["а", "и", "о", "у", "ы", "э"])


def check_poem(poem: str):
    rythm = list(
        map(lambda syllable_num: len(syllable_num),
            [list(filter(lambda char: char in vovels, phrase))
                for phrase in poem.split(" ")])
    )
    if all(i == rythm[0] for i in rythm):
        print("Парам пам-пам")
    else:
        print("Пам парам")


text = input("Введите текст стихотворения: ")
check_poem(text)
