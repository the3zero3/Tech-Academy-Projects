

import tkinter as tk
from tkinter import *
import webbrowser


class ParentWindow(Frame):
    def __init__(self, master):
        Frame.__init__(self, master)
        # Sets title of GUI window
        self.master.title("Web Page Generator")

        # Creates label with description for the end user
        self.lbl_custom = tk.Label(text="Enter custom text or click the Default HTML page button")
        self.lbl_custom.grid(row=0, column=0, columnspan=2, padx=(28, 0), pady=(15, 10), sticky=W)

        # Creates entry field for the end user to type in                           
        self.txt_custom = tk.Entry(width=130)
        self.txt_custom.grid(row=1, column=0, columnspan=4, padx=(30, 10), sticky=W)

        # Button to generate default HTML page
        self.btn = Button(text="Default HTML Page", width=30, height=2, command=self.defaultHTML)
        self.btn.grid(row=2, column=2, padx=(0, 0), pady=(10, 10), sticky=E)

        # Button to generate custom HTML page
        self.btn2 = Button(text="Submit Custom Text", width=30, height=2, command=self.customHTML)
        self.btn2.grid(row=2, column=3, padx=(0, 10), pady=(10, 10), sticky=E)


    # Creates function to generate default HTML page
    def defaultHTML(self):
        htmlText = "Stay tuned for our amazing summer sale!"
        htmlFile = open("index.html", "w")
        htmlContent = "<html>\n<body>\n<h1>" + htmlText + "</h1>\n</body>\n</html>"
        htmlFile.write(htmlContent)
        htmlFile.close()
        webbrowser.open_new_tab("index.html")


    # Creates function to generate custom HTML page
    def customHTML(self):
        # Captures what the end user typed into the entry field and sets it as a variable
        htmlText = self.txt_custom.get()
        htmlFile = open("index.html", "w")
        htmlContent = "<html>\n<body>\n<h1>" + htmlText + "</h1>\n</body>\n</html>"
        htmlFile.write(htmlContent)
        htmlFile.close()
        webbrowser.open_new_tab("index.html")


















if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWindow(root)
    root.mainloop()
