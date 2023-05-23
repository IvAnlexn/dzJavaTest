import sys


def show_data() -> None:
    """Выводит информацию из справочника"""
    print(read_book())


def read_book() -> str:
    """Читает информацию из файла"""
    with open("book.txt", "r", encoding="utf-8") as f:
        return f.read()


def add_data() -> None:
    """Добавляет информацию в справочник."""
    fullname = fullname_input()
    phone = input("Введите телефон: ")
    with open("book.txt", "a", encoding="utf-8") as f:
        print(f"{fullname} | {replace_empty_name(phone)}", file=f)


def fullname_input() -> str:
    """Создает строку с полным именем"""
    last_name = input("Введите фамилию: ")
    first_name = input("Введите имя: ")
    father_name = input("Введите отчество: ")
    fullname = " ".join(
        (
            replace_empty_name(last_name),
            replace_empty_name(first_name),
            replace_empty_name(father_name),
        )
    )
    return fullname


def replace_empty_name(name: str) -> str:
    """Заменяет пустое имя на плэйсхолдер"""
    if name:
        return name
    return "_"


def find_data() -> None:
    """Печатает результат поиска по справочнику."""
    data = read_book()
    search_query = input_search_query()
    contacts = search(data.split("\n"), search_query)
    if contacts:
        print("Нашлись контакты:")
        print_contacts(contacts)
    else:
        print("Ничего не найдено")


def input_search_query() -> str:
    return input("Варианы ввода:\nСтрока для поиска;\naccept - принять результаты;\nquit - отменить поиск\n-> ")


def search(book: list[str], info: str) -> list[str] | None:
    """Находит в списке записи по определенному критерию поиска"""
    if info == "quit":
        print("Вы отменили поиск")
        return []
    if info == "accept":
        print("Вы приняли результаты поиска")
        return book
    finded_contacts = list(filter(lambda contact: info in contact, book))
    if len(finded_contacts) == 0:
        return None
    if len(finded_contacts) == 1:
        return finded_contacts
    elif len(finded_contacts) > 1:
        print_contacts(finded_contacts)
        print("Нашлось более одного результата")
        info = input("Уточните параметры поиска: ")
        return search(finded_contacts, info)


def print_contacts(search_results: list[str], destination=sys.stdout) -> None:
    """Печатает список контактов"""
    print("\n".join(search_results), file=destination)


def delete_data() -> None:
    """Удаляет контакт из справочника"""
    data = read_book()
    search_query = input_search_query()
    book = list(filter(lambda contact: contact, data.split("\n")))
    contacts_to_remove = search(book, search_query)
    if contacts_to_remove:
        for contact in contacts_to_remove:
            book.remove(contact)
        print("Были удалены следующие контакты:")
        print_contacts(contacts_to_remove)
    else:
        print("Нечего удалять")
    write_data(book)


def write_data(data: list[str]) -> None:
    """Перезаписывает информацию в файле"""
    with open("book.txt", "w", encoding="utf-8") as f:
        print_contacts(data, destination=f)


def change_data() -> None:
    """Изменяет информацию контакта в справочнике"""
    data = read_book()
    search_query = input_search_query()
    book = data.split("\n")
    contacts_to_change = search(book, search_query)
    changes_made = []
    if contacts_to_change:
        for contact in contacts_to_change:
            contact_changed = edit_contact(contact)
            book[book.index(contact)] = contact_changed
            changes_made.append(contact_changed)
        print("Были изменены следующие контакты:")
        print_contacts(changes_made)
    else:
        print("Нечего изменять")
    write_data(book)


def edit_contact(contact: str) -> str:
    """Редактриует отдельный контакт по его полям"""
    person_phone = contact.split(" | ")
    last_name, first_name, father_name = person_phone[0].split(" ", maxsplit=2)
    phone = person_phone[1]
    while True:
        print(
            f"Что вы хотите поменять для контакта {contact}:\n1. фамилия, 2. имя, 3. отчество, 4. телефон, 0. для выхода из редактирования контакта"
        )
        mode = int(input())
        if mode == 1:
            last_name = input("Введите фамилию: ")
        elif mode == 2:
            first_name = input("Введите имя: ")
        elif mode == 3:
            father_name = input("Введите отчество: ")
        elif mode == 4:
            phone = input("Введите телефон: ")
        else:
            break
    person = " ".join(
        (
            replace_empty_name(last_name),
            replace_empty_name(first_name),
            replace_empty_name(father_name),
        )
    )
    contact = " | ".join((person, replace_empty_name(phone)))
    return contact
