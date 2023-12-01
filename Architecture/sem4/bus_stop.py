class BusStop:
    def __init__(self, id: int, name: str, altitude: int, latitude: int) -> None:
        self.id = id
        self.name = name
        self.altitude = altitude
        self.latitude = latitude
        
    def get_coordinates(self):
        return [self.altitude, self.latitude]
    
    def set_coordinates(self, altitude: int, latitude: int) -> None:
        self.altitude = altitude
        self.latitude = latitude