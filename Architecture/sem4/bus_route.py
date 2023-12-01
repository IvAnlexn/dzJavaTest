from bus_stop import BusStop

class BusRoute:
    def __init__(self, id: int, remark: str, capacity: int, bus_stops: [BusStop]):
        self.id = id
        self.remark = remark
        self.capacity = capacity
        self.bus_stops : list[BusStop] = bus_stops
    
    def add_bus_stop(self, bus_stop: BusStop):
        self.bus_stops.append(bus_stop)
            
    def get_bus_stops(self):
        return self.bus_stops
    
    def remove_bus_stop(self, bus_stop: BusStop):
        if bus_stop in self.bus_stops:
            self.bus_stops.remove(bus_stop)