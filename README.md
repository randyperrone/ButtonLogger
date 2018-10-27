# ButtonLogger
**DESCRIPTION:**

  Quick C# program that logs a timestamp and button pressed in a .csv file when a button is clicked.

**HOW TO USE:**

  By clicking the "start recording" button, a new file is created that is timestamped with the current date and time.  A line is also written in the file with the current time and the "start recording" tag.  If button 1 or button 2 are pressed, the time will be logged along with the button number that was pressed.
  
**SETUP:**

  This program is written in C# with Windows Presentation Foundation, so a Windows computer is needed or a program in Mac/Linux to open with.  
  
**AUTHOR:**

  Randy Perrone
  
**LIMITATIONS:**

There may be some lag in the time that the system processes the button click and the actual time the button is clicked.  There could also be some lag due to the creation of the file and the first time "start recording" is being logged.  After running numerous tests, I found that the seconds were the same each time indicating that there wasn't lag more than a second.
