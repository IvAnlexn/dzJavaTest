import datetime


class Ticket:
    def __init__(self, price: int, valid_on_date: datetime, start_zone: int, finish_zone: int, is_luggage: bool, place: int, road_number: int,) -> None:
        self.price = price
        self.valid_on_date: datetime = valid_on_date
        self.start_zone = start_zone
        self.finish_zone = finish_zone
        self.is_luggage = is_luggage
        self.place = place
        self.road_number = road_number