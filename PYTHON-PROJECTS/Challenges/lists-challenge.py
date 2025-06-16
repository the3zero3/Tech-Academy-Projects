carList = ['mercedes', 'audi', 'bmw', 'alfa romeo', 'fiat']
print(carList)


for i in carList:
    print(i)


carList.append("maserati")
print(carList)


newList = carList.copy()
print(newList)


list1 = ["a", "b", "c"]
list2 = [1, 2, 3]
list3 = list1 + list2
print(list3)


newList.reverse()
print(newList)
