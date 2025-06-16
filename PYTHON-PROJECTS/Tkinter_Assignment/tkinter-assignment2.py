

from tkinter import *

win = Tk()
v = StringVar()
e = Entry(win, textvariable = v)
e.pack()


v.get()


v.set("This is set by the program")
