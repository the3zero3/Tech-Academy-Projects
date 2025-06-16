

import sqlite3


# Get personal data from user and insert into a tuple
firstName = input("Enter your first name: ")
lastName = input("Enter your last name: ")
age = int(input("Enter your age: "))
personData = (firstName, lastName, age)

# Execute insert statement for supplied person data
with sqlite3.connect('test_database.db') as connection:
    c = connection.cursor()
    c.execute("INSERT INTO People VALUES (?, ?, ?)", personData)


