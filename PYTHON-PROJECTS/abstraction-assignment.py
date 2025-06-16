

from abc import ABC, abstractmethod


# Class containing at least one abstract method and one regular method
class card(ABC):
    def paySlip(self, amount):
        print("Your purchase amount:",amount)

    @abstractmethod
    def payment(self, amount):
        pass


# Child class that defines the implementation of its parent's abstract method
class DebitCardPayment(card):
    def payment(self, amount):
        print("Your purchase amount of {} exceeded your $100 limit".format(amount))


# Object that utilizes both the parent and child methods
obj = DebitCardPayment()
obj.paySlip("$400")
obj.payment("$400")
