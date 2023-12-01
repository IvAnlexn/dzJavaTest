class Person:
    def __init__(
        self, id: int, fio: str, card_number: int, hash_pass: int, login: str
    ) -> None:
        self.id = id
        self.fio = fio
        self.card_number = card_number
        self.hash_pass = hash_pass
        self.login = login

    def get_id(self):
        return self.id

    def get_fio(self):
        return self.fio

    def get_login(self):
        return self.login

    def get_card_number(self):
        return self.card_number

    def set_login(self, login: str):
        self.login = login

    def get_hash_pass(self):
        return self.hash_pass

    def set_hash_pass(self, hash_pass: int):
        self.hash_pass = hash_pass