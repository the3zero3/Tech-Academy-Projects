

# Parent class
class Racetrack:
    name = ""
    length = ""
    num_corners = 0
    elevation = ""
    slogan = ""

    def __init__(self, name, length, num_corners, elevation, slogan):
        self.name = name
        self.length = length
        self.num_corners = num_corners
        self.elevation = elevation
        self.slogan = slogan

    def information(self):
        msg = "\nTrack Name: {}\nTrack Length: {}\nNumber of Corners: {}\nTrack Elevation: {}".format(self.name, self.length, self.num_corners, self.elevation)
        return msg

    def slog(self):
        msg = "\n{}".format(self.slogan)
        return msg


# Child class
class Dirttrack(Racetrack):
    surface = ""
    track_shape = ""






if __name__ == "__main__":
    silverstone = Racetrack("Silverstone", "5.891 km", 18, "150 m", "Home of British Motor Racing!")
    print(silverstone.information())
    print(silverstone.slog())

    
