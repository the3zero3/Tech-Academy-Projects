#
# Python:   3.11.7
#
# Author:   Chris Dini
#
# Purpose:  To write a script that creates a database and adds new data
#           into that database.


import sqlite3


# Opens connection to database
conn = sqlite3.connect('files.db')

# Creates a table in the database
with conn:
    # Captures the cursor as a variable 
    cur = conn.cursor()
    cur.execute("CREATE TABLE IF NOT EXISTS tbl_txtfiles( \
        col_ID INTEGER PRIMARY KEY AUTOINCREMENT, \
        col_filename TEXT \
        )")
    conn.commit()
conn.close()



conn = sqlite3.connect('files.db')

# Tuple of file names
fileList = ('information.docx', 'Hello.txt', 'myImage.png', \
            'myMovie.mpg', 'World.txt', 'data.pdf', 'myPhoto.jpg')

# Loop to find each object in the tuple that ends with .txt and add them to the database
for item in fileList:
    if item.endswith('.txt'):
        with conn:
            cur = conn.cursor()
            cur.execute("INSERT INTO tbl_txtfiles (col_filename) VALUES (?)", (item,))
            print(item)
conn.close()
