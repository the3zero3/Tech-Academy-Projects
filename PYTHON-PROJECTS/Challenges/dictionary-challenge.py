myDictionary = {'brand': 'Ferrari', 'model': 'F355', 'year': 1996}
print(myDictionary)


x = myDictionary.get('brand')
print(x)


myDictionary['year'] = 1998
print(myDictionary['year'])


myDictionary['color'] = 'red'
print(myDictionary)


supercarDic = {'super1': {'brand': 'Ferrari', 'model': 'F355', 'year': 1996}, 'super2': {'brand': 'Lamborghini', 'model': 'Gallardo', 'year': 2006}, 'super3': {'brand': 'Porsche', 'model': 'GT3', 'year': 2011} }
print(supercarDic)


x = ('key1', 'key2', 'key3')
y = ('Value for all!')

newDict = dict.fromkeys(x, y)

print(newDict)
