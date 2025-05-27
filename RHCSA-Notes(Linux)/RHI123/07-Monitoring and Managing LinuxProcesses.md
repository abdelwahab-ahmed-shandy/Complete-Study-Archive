# Chapter7 Monitoring and Managing Linux Processes

### What is a process?
- A process is a program which is being executed
- Any process may create a child process. All processes are descendants of the first system process, which is systemd on a RHEL7 system.
```
[root@master ~]# echo $$ # Display the PID (process ID) of the current shell
4085

[root@master ~]# bash # Open a new shell (a subprocess within the current root)

[root@master ~]# echo $$ # Display the PID of the new shell (note that the number has changed because it is a different process)
8686

[root@master ~]# exit # Exit the subshell and return to the original shell
exit

[root@master ~]# echo $$ # Return to the original shell; the old PID appears again
4085

🔹 Quick explanation:
Each time you open a new shell (for example, by typing bash), a new process is created with a unique PID. When you exit, it returns to the original process.
The echo $$ command helps you find the running process number, which is useful for tracking the shell or dealing with temporary processes and tasks.


```
---

### Listing processes:
```
[root@master ~]# ps              # Display only processes associated with the current shell
[root@master ~]# ps aux          # Display all processes in the system in detail
[root@master ~]# ps -aux         # Same as above (syntactically incorrect, but works on some systems)
[root@master ~]# ps -aux | less  # Display long results using less for easy browsing

[root@master ~]# ps aux | grep -i syslogd   # Search for a process whose name contains syslogd (case-insensitive)
[root@master ~]# ls /proc/                  # Browse the process directory on the system (each process has a directory with a PID number)
[root@master ~]# ps aux | grep 264          # Search for process number 264 (which you might see in the /proc folder)
[root@master ~]# pidof vim                  # Display the PID of vim (if running)
# OR
[root@master ~]# pgrep vim                 # Alternative to pidof: Searches for processes named vim and displays the PID

[root@master ~]# ps -l        # Display process information, including PPID (Parent Process ID)
[root@master ~]# ps -ef       # Display all processes with PPID and niceness (process priority value)

## Symbol explanation:

# a: Display all processes associated with the terminal
# u: Additional display of columns such as user and runtime
# x: Display processes that are not associated with the terminal (e.g., background processes)

[root@master ~]# pstree       # Display processes in a tree
# OR
[root@master ~]# ps fax       # Alternative method for displaying processes in a tree
[root@master ~]# pstree -p    # Display processes in tree form with PID next to each process

```
Processes in brackets (usually at the top) are scheduled kernel threads.
---

## Real-time process monitoring:

```
[root@master ~]# uptime     # Display the current time, system uptime, number of users, and load average

[root@master ~]# grep "model name" /proc/cpuinfo     # To find out the number and types of CPUs on the machine


[root@master ~]# top        # An interactive tool to display running processes and resource consumption in real time
🎛️ While running the top command, you can use the following commands:

type 1 → Display all CPU cores
type s → Change the default refresh rate (3 seconds)
type h → Display top's help instructions
type k → Kill a process using the PID number
type r → Change the process priority (renice)
type M → Sort processes by memory consumption
type P → Sort processes by CPU consumption
type n → Specify the number of processes displayed
type w → Save the current setting as the default
type q → Exit the top tool

🧾 Explanation of the important columns in the top:

PID   → Process ID
USER  → Username of the user who owns the process
VIRT  → Virtual memory used by the process (including swap)
RES   → Physical memory (RAM) used without swap
TIME  → Total time the process has used the processor since its start

```
---

### 🖥️ GUI Tools to Manage Processes:
```
[root@master ~]# gnome-system-monitor # A graphical tool for monitoring processes and resource consumption (similar to Task Manager in Windows)

Or via the graphical path:

Applications → System Tools → System Monitor # to access the tool from the GNOME interface

```
---

### Controlling Jobs:
- Background processes display a question mark (?) in the TTY column in a ps aux command.

```
[root@master ~]# dd if=/dev/zero of=/dev/null
[root@master ~]# sleep 100000 &               (Running a job in the background)
[1] 5151

[root@master ~]# jobs
[1]+  Running       sleep 100000 &

[root@master ~]# fg %1
sleep 100000

^Z                                    (To resend to the background)
[1]+  Stopped       sleep 100000

[root@master ~]# bg %1                (To restart the process in the background)              
[1]+ sleep 100000 &

OR
[root@master ~]# bg 5151

^C                                    (End the process)
```
---
### Killing Processes:
```
[root@master ~]# kill -l       # Display all available kill signals
[root@master ~]# man 7 signal  # Display a guide explaining the function of each signal

# Most important signals:
1) SIGHUP → Requests the process to reread the configuration files
9) SIGKILL → Kills the process directly (cannot be ignored), use with caution
15) SIGTERM → The default signal, requests that the process be terminated gently

[root@master ~]# pidof vim   # Get the PID of the vim application
4123
[root@master ~]# kill 4123   # Kill the process using the default signal (SIGTERM 15)

[root@master ~]# pidof vim   # Check if the process is still running
7073

[root@master ~]# kill -9 7073         # Forcefully kill the process using SIGKILL
[root@master ~]# kill -SIGKILL 7073   # Same command in a different form

[root@master ~]# pkill vim     # Kill all processes named "vim" (using SIGTERM by default)
[root@master ~]# killall vim   # Kill all processes associated with vim
```
---
### Managing Process Priorities:
- Processes are scheduled according to priority.
- negative values are allowed only to root.
```
[root@master ~]# ps l # Display the list of processes with the nice value for each process
```
-The nice command is used to start a process with a user defined priority.

```
🟢 Use nice to set a priority when starting a process :

[root@master ~]# nice vim text & # Run vim with nice priority = 10 (default)
[1] 9182

[root@master ~]# nice -n 15 vim text & # Run vim with a lower priority (nice = 15), i.e., a slower execution priority

🔄 Use renice to change the priority of an already running process:

[root@master ~]# renice 19 9182 # Change the priority of the process with PID 9182 to nice = 19

```
---
✍️ Author: Abdelwahab Shandy "))
