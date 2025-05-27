# Chapter8_Controlling_Services_and_Daemons

systemd:
- System startup and server processes are managed by the systemd.
- For many years, process ID 1 of Linux and UNIX systems has been the init process. Frequently used daemons were started on systems at boot time with SystemV and LSB init scripts. Less frequently used daemons were started on demand by another service, such as initd or xinetd, which listens for client connections. 
---

## Listing unit files with systemctl:

### 🛠️ systemctl – Services Management:
```
[root@master ~]# systemctl                   # Display the status of all units that are active by default
[root@master ~]# systemctl -t help           # Display the available unit types
[root@master ~]# systemctl --type service    # Display only units of type service

# Or use the following more explicit syntax:
[root@master ~]# systemctl list-units --type service         # Display all currently active services
[root@master ~]# systemctl list-units --type service --all   # Display all services (active and inactive)
[root@master ~]# systemctl --failed --type=service           # Display services that failed to start
```
### 🔍 Check the status of a specific service:
```
[root@master ~]# systemctl status sshd.service        # Display SSH service status details
[root@master ~]# systemctl status sshd                # Shortcut to the same command
[root@master ~]# systemctl status firewalld.service   # Display firewalld status
[root@master ~]# systemctl status firewalld           # Shortcut to the same command
[root@master ~]# systemctl status firewalld -l        # Display firewalld status with full log details

[root@master ~]# systemctl is-active sshd             # Check if the sshd service is active
[root@master ~]# systemctl is-enabled sshd            # Check if the sshd service is automatically started at boot (enabled)
```
---

### Controlling System Services:
```
[root@master ~]# systemctl status sshd       # Display the current status of the SSH service (active, enabled, errors if any)

[root@master ~]# systemctl restart sshd      # Restart the SSH service (stop and start)

[root@master ~]# systemctl stop sshd         # Stop the SSH service

[root@master ~]# systemctl start sshd        # Start the SSH service

[root@master ~]# systemctl reload sshd       # Reload the service's settings without stopping it (useful for applying configuration changes)
```
---

### Unit dependencies:
```
[root@master ~]# systemctl stop cups
# Stops the CUPS printing service, but a warning message is displayed because the service may restart automatically on request due to:
# - cups.socket: A component that accepts connections and starts the service when needed
# - cups.path: A component that monitors files or paths and restarts the service when they change

[root@master ~]# systemctl list-dependencies cups
# Displays a list of all modules (services, sockets, targets, etc.) on which the CUPS service depends

[root@master ~]# systemctl list-dependencies cups --reverse
# Displays the modules that depend on the CUPS service (i.e., the reverse: who depends on this service)
```
---

### Masking services:
A masked service can not be started manually or automatically
network vs NetworkManager 
iptables vs firewalld
```
[root@master ~]# systemctl mask network
# Makes the "network" service completely inoperable, even if the user or system tries to start it.

[root@master ~]# systemctl unmask network
# Lifts the mask from the service and makes it operable again.
```
---

### Enabling system daemons to start or stop at boot:
```
[root@master ~]# systemctl enable sshd
# Makes the SSH service start automatically at system boot

[root@master ~]# systemctl disable sshd
# Prevents the SSH service from starting automatically at boot, but it can still be started manually
```
---

✍️ Author: Abdelwahab Shandy "))
