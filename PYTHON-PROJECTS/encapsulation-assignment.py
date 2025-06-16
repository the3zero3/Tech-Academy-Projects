
# Class to make use of a protected attribute
class Protected:
    def __init__(self):
        self._protectedVar = 0

obj = Protected()
obj._protectedVar = 34
print(obj._protectedVar)


# Class to make use of a private attribute
class Private:
    def __init__(self):
        self.__privateVar = 12

    def getPrivate(self):
        print(self.__privateVar)

    def setPrivate(self, private):
        self.__privateVar = private

obj2 = Private()
obj2.getPrivate()
obj2.setPrivate(23)
obj2.getPrivate()

