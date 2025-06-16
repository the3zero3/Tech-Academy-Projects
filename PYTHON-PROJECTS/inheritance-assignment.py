

# Parent class for cars
class Car:
    make = ''
    model = ''
    year = 0
    doors = 0
    color = ''


# Inherits Car class attributes and adds ICE vehicle attributes
class gasCar(Car):
    engine_volume = 0
    num_cylinders = 0


# Inherits Car class attributes and adds electric vehicle attributes
class elecCar(Car):
    battery_size = 0
    num_motors = 1
    
