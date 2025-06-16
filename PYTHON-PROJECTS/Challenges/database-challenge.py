

import sqlite3

peopleData = (('Jean-Baptiste Zorg', 'Human', 122), ('Korben Dallas', 'Meat Popsicle', 100), ('Ak\'not', 'Mangalore', -5))

with sqlite3.connect(':memory:') as conn:
    c = conn.cursor()

    # Create a database table in RAM named Roster that includes the fields ‘Name’, ‘Species’ and ‘IQ’
    c.execute("CREATE TABLE IF NOT EXISTS Roster(Name TEXT, Species TEXT, IQ INT)")

    # Populate the new table with the provided values
    c.executemany("INSERT INTO Roster VALUES (?, ?, ?)", peopleData)

    # Update the Species of Korben Dallas to be Human
    c.execute("UPDATE Roster SET Species='Human' WHERE Name='Korben Dallas'")

    # Display the names and IQs of everyone in the table who is classified as Human
    c.execute("SELECT Name, IQ FROM Roster WHERE Species='Human'")
    print(c.fetchall())
    
