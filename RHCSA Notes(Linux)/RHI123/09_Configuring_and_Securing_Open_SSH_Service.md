# Chapter9_Configuring_and_Securing_Open_SSH_Service :

### ✅ Checking SSH Status and Installation :
```
[root@server ~]# systemctl status sshd
# Display the current SSH service status (active, stopped, etc.)

[root@server ~]# rpm -qa | grep -i ssh
# Search for all SSH-related packages on the system

[root@server ~]# yum search sshd
# Search for the sshd package in the YUM repositories
```
---
### 🔑 Generating SSH Keys on the Client Side
```
[abdo@client ~]$ ssh-keygen           # Generate an SSH key (RSA is the default)
[abdo@client ~]$ ssh-keygen -t dsa    # Generate a DSA key
[abdo@client ~]$ ssh-keygen -t rsa    # Generate an RSA key (recommended)
[abdo@client ~]$ cd .ssh/             # Access the keys folder
```
---
### 🔗 Connecting via SSH
```
[abeer@client ~]$ ssh 192.168.1.10
# Connect to the server via SSH using the IP address

[abeer@client ~]$ ssh abeer@192.168.1.10
# Connect to the server as a specific user

[abeer@client ~]$ ssh abeer@192.168.1.10 hostname
# Execute a direct command on the server via SSH

[abeer@client ~]$ exit
# Exit the SSH session
```
---
### 👤 Check Who's Logged In on Server
```
[root@server ~]# w
# Show who's currently logged in and what they're doing

[root@server ~]# who
# Show who's currently logged in to the system
```
---
### 📌 Important notes about SSH:
The first time a user connects to a specific server, the server's public key is stored in the file:
```
~/.ssh/known_hosts
```
When connecting later, the key is verified to ensure security.
The server's host keys are stored in:
```
/etc/ssh/ssh_host_*
```
---
### 🗝️ SSH Key-based Authentication
```
[abdo@client ~]$ ssh-copy-id 192.168.1.1
[abdo@client ~]$ ssh-copy-id abeer@192.168.1.1
[abdo@client ~]$ ssh-copy-id -p 2020 abeer@192.168.1.1
[abdo@client ~]$ ssh-copy-id -i ~/ssh/id_rsa.pub abeer@192.168.1.1
```
📌 Notes:

The public key is copied to the server in the file:
/home/USERNAME/.ssh/authorized_keys

If the private key is stolen, the presence of a passphrase makes it difficult to use.

The ssh-copy-id command copies the file ~/.ssh/id_rsa.pub by default.

---

### 🔍 Check and run SSH on the server
```
[root@server ~]# cd /home/abeer/.ssh/
# Check the presence of authorized_keys in the user directory

[root@server ~]# ps aux | grep -i ssh
# Check SSH-related processes

[root@server ~]# kill 8619
# Kill a specific SSH process using the PID
```
--- 

### ⚙️ Customizing SSH Server Configuration
```
[root@server ~]# vim /etc/ssh/sshd_config
```
#Port 22 ← Change the default port number
#PermitRootLogin yes ← Prevent login as root
#PasswordAuthentication yes ← Enable password login

### 🔐 Example of a custom connection:
```
[abdo@client ~]$ ssh root@192.168.1.1 -p 2200
# Connect to SSH on a custom port
```
---

✍️ Author: Abdelwahab Shandy "))
