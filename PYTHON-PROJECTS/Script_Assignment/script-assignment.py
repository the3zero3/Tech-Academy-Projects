#
# Python:   3.11.7
#
# Author:   Chris Dini
#
# Purpose:  Write a script that will check a specific folder on the hard drive,
#           verify whether those files end with a “.txt” file extension and,
#           if they do, print those qualifying file names and their corresponding
#           modified time-stamps to the console.


import os
import time


# Variables to hold the current working directory and a list of the files found in the directory
path = os.getcwd()
files = os.listdir()


# Initial check for txt files
for f in files:
    txt = [f for f in files if ".txt" in f]


# Two empty lists, one to hold the path values and one to hold the modified times
fullPath = []
modTime = []


# Loop to fill lists with appropriate data
for f in txt:
    # Concatenates the file name to its file path, forming an absolute path
    fullPath.append(os.path.join(path, f))
    # Finds the latest date that each text file has been created or modified
    modTime.append(time.ctime(os.path.getmtime(path)))


# Loop to print the file path and the last modified time
for p, t in zip(fullPath, modTime):
    print("File path: \n{}".format(p))
    print("Last modified: \n{}\n".format(t))


