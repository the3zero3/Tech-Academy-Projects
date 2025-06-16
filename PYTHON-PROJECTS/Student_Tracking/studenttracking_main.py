#
# Python:       3.11.7
#
# Author:       Chris Dini
#
# Purpose:      Student Tracking Assignment. Creating a student tracking system application using Python with Tkinter and SQLite3.
#
# Tested OS:    This code was written and tested to work with Windows 10.
#


from tkinter import *
import tkinter as tk


import studenttracking_gui
import studenttracking_func


class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        # Define out master frame configuration
        self.master = master
        self.master.minsize(450,375) # (Width, Height)
        self.master.maxsize(450,375)

        studenttracking_func.center_window(self,450,375)
        self.master.title("Student Tracking Assignment")
        self.master.configure(bg="#F0F0F0")

        self.master.protocol("WM_DELETE_WINDOW", lambda: studenttracking_func.ask_quit(self))
        arg = self.master

        studenttracking_gui.load_gui(self)


















if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
