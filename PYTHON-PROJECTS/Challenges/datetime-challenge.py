

from datetime import datetime
import pytz

"""

Branches are open 9am to 5pm

Create a script that will find out the current times in the Portland HQ and NYC and London branches.

Then, compare that time with each branch's hours to see if they are open or closed.

Print out to the screen the three branches and whether they are open or closed.

"""

# Finds the current time in the specified time zone, splices the current hour and 
# makes it into an integer variable for each location
datetime_port = datetime.now(pytz.timezone('US/Pacific'))
port_hour = int(datetime_port.strftime('%H'))
datetime_nyc = datetime.now(pytz.timezone('US/Eastern'))
nyc_hour = int(datetime_nyc.strftime('%H'))
datetime_lon = datetime.now(pytz.timezone('Europe/London'))
lon_hour = int(datetime_lon.strftime('%H'))


# Compares the hour variable to the branch's hours to determine if they are opened or closed
if (port_hour < 9 or port_hour > 17):
    print("Portland is Closed")
else:
    print("Portland is Open")


if (nyc_hour < 9 or nyc_hour > 17):
    print("NYC is Closed")
else:
    print("NYC is Open")


if (lon_hour < 9 or lon_hour > 17):
    print("London is Closed")
else:
    print("London is Open")
