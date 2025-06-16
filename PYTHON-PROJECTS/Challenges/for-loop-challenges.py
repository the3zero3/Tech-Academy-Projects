# For loop
fruits = ["apple", "banana", "cherry"]
for x in fruits:
    print(x)


# For loop with break statement
fruits = ["apple", "banana", "cherry"]
for x in fruits:
    print(x)
    if x == "banana":
        break


# For loop with continue statement
fruits = ["apple", "banana", "cherry"]
for x in fruits:
  if x == "banana":
    continue
  print(x)


# For loop using range() function
for x in range(6):
    print(x)


# For loop with else statement
for x in range(6):
    print(x)
else:
    print("Finally finished!")
