


import tkinter as tk
from tkinter import *
from tkinter import filedialog as fd


class ParentWindow(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        self.master = master
        self.master.minsize(500,175) # (Width, Height)
        self.master.maxsize(500,175)

        self.master.title("Check files")
        self.master.configure(bg="#F0F0F0")

        self.btn_browse = tk.Button(self.master, width=12, height=1, text='Browse...', command=self.browse_dir1)
        self.btn_browse.grid(row=0, column=0, padx=(15,0), pady=(40,0), sticky=W)
        self.btn_browse2 = tk.Button(self.master, width=12, height=1, text='Browse...', command=self.browse_dir2)
        self.btn_browse2.grid(row=1, column=0, padx=(15,0), pady=(10,0), sticky=W)
        self.btn_check = tk.Button(self.master, width=12, height=2, text='Check for files...')
        self.btn_check.grid(row=2, column=0, padx=(15,0), pady=(10,0), sticky=W)
        self.btn_close = tk.Button(self.master, width=12, height=2, text='Close Program')
        self.btn_close.grid(row=2, column=3, padx=(15,0), pady=(10,0), sticky=E)

        self.txt_browse = tk.Entry(self.master, width=58)
        self.txt_browse.grid(row=0, column=1, columnspan=3, padx=(15,0), pady=(40,0), sticky=W+E+N+S)
        self.txt_browse2 = tk.Entry(self.master, width=58)
        self.txt_browse2.grid(row=1, column=1, columnspan=3, padx=(15,0), pady=(10,0), sticky=W+E+N+S)


    def browse_dir1(self):
        name = fd.askdirectory()
        self.txt_browse.delete(0,END)
        self.txt_browse.insert(0,name)
        return


    def browse_dir2(self):
        name = fd.askdirectory()
        self.txt_browse2.delete(0,END)
        self.txt_browse2.insert(0,name)
        return






if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()

