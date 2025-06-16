

# Parent class with core attributes
class Planet:
    name = ""
    orbital_period = None
    num_satallites = None
    is_habitable = False

    def __init__(self, name, orbital_period, num_satallites, is_habitable):
        self.name = name
        self.orbital_period = orbital_period
        self.num_satallites = num_satallites
        self.is_habitable = is_habitable

    def information(self):
        msg = "\nHello!\nMy name is {}\nMy orbital period is {} days\nI have {} satellite(s)\n".format(self.name, self.orbital_period, self.num_satallites)
        return msg


# Child class with additional attributes
class DwarfPlanet(Planet):
    is_planet = False
    mass = None

    def __init__(self, name, orbital_period, num_satallites, is_habitable, is_planet, mass):
        super().__init__(name, orbital_period, num_satallites, is_habitable)
        self.is_planet = is_planet
        self.mass = mass

    def information(self):
        msg = "\nHelp! My name is {} and I'm not a planet because my mass of only {} Earths disqualifies me!\n".format(self.name, self.mass)
        return msg
    

# Another child class with additional attributes
class Moon(Planet):
    is_planet = False
    satellite_of = ""

    def __init__(self, name, orbital_period, num_satallites, is_habitable, is_planet, satellite_of):
        super().__init__(name, orbital_period, num_satallites, is_habitable)
        self.is_planet = is_planet
        self.satellite_of = satellite_of

    def information(self):
        msg = "\nHi there! My name is {} and I orbit {}.\n".format(self.name, self.satellite_of)
        return msg









if __name__ == "__main__":
    # Creates the earth and prints its information
    earth = Planet("Earth", 365, 1, True)
    print(earth.information())

    # Creates pluto and prints its information
    pluto = DwarfPlanet("Pluto", 90560, 5, False, False, 0.00218)
    print(pluto.information())

    # Creates the moon and prints its information
    moon = Moon("The Moon", 30, 0, False, False, "Earth")
    print(moon.information())
