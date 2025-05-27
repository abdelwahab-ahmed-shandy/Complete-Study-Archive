# 📘 Chapter 1: Accessing the Command Line and Shell Basics

## 🎯 Virtual Consoles
- `Alt + Ctrl + Fn`: Switch between graphical and text terminals.
- `Alt + Fn`: Switch between TTYs when using the text-only interface.
- `Alt + →` or `Alt + ←`: Switch between terminals.
- `chvt 6`: Switch to terminal number 6 (tty6).
- `tty`: Display the name of the current terminal.
- `/dev/pts/0` → Virtual terminal (inside the terminal).
- `/dev/tty2` → Physical terminal (TTY).

---

## 💻 Shell Basics

```bash
clear # Clear the screen (or Ctrl + L)
reset # Reset the terminal screen
ls # Display files and folders
ls -l # Display detailed files in list format
ls -a # Display hidden files as well
ls -la # Display detailed + hidden files
ls -la /home # Display the contents of the /home directory in detail
exit # Exit the terminal (or Ctrl + D)
```

---

## 🕒 History and Help Command

```bash
date --help # Show how to use the date command
```
- `[ ]` → Optional items
- `...` → List of infinite lengths
- `|` → One of the options only
- `< >` → Variable value such as `<filename>`

---

## 🖥️ GNOME Desktop Environment

- Default version: **GNOME Classic**
- To show help:
- Press `F1`
- Or from the path: Applications > Documentation > Help
- Or using the command: `yelp`

---

## 📌 Examples of simple commands

```bash
date 		 # Display the current date and time
cal 		 # Display the current month's calendar
cal 2016 	 # Display the entire 2016 calendar
cal 3 		 # Display the calendar for March of the current year
cal 3 2016	 # Display the March 2016 calendar
date +%R 	 # Display only the current time (hours and minutes)
date +%x 	 # Display the date in local format
passwd 		 # Change the password for the current user
passwd abeer 	 # Change the password for the user "abeer"
file /etc/passwd # Determine the file type
file /home 	 # Same as /home
which passwd 	 # Determine the full path to the passwd command
file /bin/passwd # Check the executable type
head /etc/passwd # Display first 10 lines of the file

head -n 3 /etc/passwd   # Display the first 3 lines
tail -n 3 /etc/passwd   # Display the last 3 lines
wc /etc/passwd 		# Count words, lines, and characters
wc -lwc /etc/passwd 	# Count lines, words, and characters
```

---

## 🔁 Tab Completion

```bash
pas <TAB> # Display suggestions starting with "pas"
passwd # Execute the full command after it is completed
ls /etc/pas <TAB> # Pathname completion
useradd -- <TAB> # Display the possible options with useradd
```

---

## 📜 Command History

```bash
cat .bash_history # Display the command history
history 	  # Display the last used commands
!88 		  # Execute command number 88
!-10 		  # Execute the last command before 10 commands
!ls 		  # Execute the last command starting with ls
!! 		  # Execute the entire last command
history -c 	  # Clear the command history
```

📝 **Note**: Commands are saved in memory and appear after exiting the terminal.

---

## ⌨️ Useful Shortcuts

- `Ctrl + A` : Go to the beginning of the line.
- `Ctrl + E` : Go to the end of the line.
- `ls ; date ; cal` : Execute multiple commands in sequence.
- `ls && date` : Execute date only if the ls command succeeds.
- `ls /div || date` : Execute date only if ls fails.
- `head <ESC>.` : Use the last argument used.

---

### ✍️ Author: Abdelwahab Shandy