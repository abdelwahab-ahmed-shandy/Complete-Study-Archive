# Chapter6 Controlling Access to Files with Linux File System Permission

## Linux file system permissions:

- User permissions override group permissions, which override other permissions.
- If a user only has read access on a directory, the names of the files in it can be listed, but no other information, including permissions or time stamps, are available, nor can they be accessed.
- If a user only has exec access on a directory, they can not list the names of the files in the directory, but if they already know the name of a file which they have permission to read, then they can access the contents of that file by explicitly specifying the file name. 
- All permissions in Linux are set directly on each file or directory (not inherited)
- The write permission implies the ability to delete files and subdirectories.
- If write and the sticky bit are both set on a directory, then only the user that owns a file or subdirectory in the directory may delete it. 
- Only the root and the owner can change the permissions.
```
[root@master ~]# ls -l file    # Display file details such as permissions, owner, size, and modification date
[root@master ~]# ll file       # Shortcut for the previous command (if defined as an alias for ls -l)
[root@master ~]# ls -ld /home  # Display information about the /home directory itself, not its contents (d stands for directory)
```
---

## Changing file/directory permissions:
1- Symbolic method:
• Who is u, g, o, a (for user, group, other, all)
• What is +, -, = (for add, remove, set exactly)
• Which is r, w, x (for read, write, executable)

```
[root@master ~]# chmod g+w file1             # Add write permissions to the group on file1
[root@master ~]# chmod o+w file1             # Add write permissions to others on file1
[root@master ~]# chmod u-w file1             # Remove write permissions for the owner (user) on file1
[root@master ~]# chmod u+w,g+wx,o+r file1    # Add write permissions for the owner (user), write and run permissions for the group (group), and read permissions for others
[root@master ~]# chmod go-rw file1           # Remove read and write permissions for the group (group) and others
[root@master ~]# chmod u=rw,g=r,o=r file1    # Reset permissions: the owner has read and write permissions, and the group and others have only read permissions
[root@master ~]# chmod a+x file1             # Add run permissions for everyone (owner, group, others) on the file file1
[root@master ~]# chmod ugo+x file1           # Same as above, add run permissions to all parties (owner, group, and others)
[root@master ~]# chmod a=rw file1            # Set read and write permissions for everyone on file1
[root@master ~]# chmod ugo=rw file1          # Same as above, set read and write permissions for all parties (owner, group, and others)
[root@master ~]# chmod u= file1              # Remove all permissions from the owner (user) on file1
[root@master ~]# chmod +rw file1             # Add read and write permissions to the owner (user) on file1
[root@master ~]# chmod =rw file1             # Set read and write permissions to the owner only
[root@master ~]# chmod -R g+rwx dir1         # Recursively add read, write, and run permissions to the group (group) for all files within the directory dir1

```
### 2- Numeric method:
r=4, w=2, x=1
```
[root@master ~]# chmod 754 file1     # Gives: rwx for owner (7), r-x for group (5), r-- for others (4)
# ⤷ owner: read+write+execute
# ⤷ group: read+execute
# ⤷ others: read-only

[root@master ~]# chmod 400 file1     # Gives: r-- for owner, --- for group, --- for others
# ⤷ owner: read-only
# ⤷ group+others: no permissions

[root@master ~]# chmod -R 755 dir1   # Gives 755 permissions to all files and directories within dir1 recursively
# ⤷ owner: read+write+execute
# ⤷ group+others: read+execute only

```
---

## Changing file/directory user or group ownership:
- Only root can change the ownership of a file.
- Root or the file's owner can change group ownership.

```
[root@master ~]# chown abdo file1             # Change the owner of file1 to the user abeer

[root@master ~]# chown abdo dir1              # Change the owner of folder dir1 to the user abeer

[root@master ~]# chown -R abdo dir1           # Change the owner of dir1 and all files and folders inside it (recursively) to abeer

[root@master ~]# chown :sales file1           # Change the owner group of file1 to the sales group (without changing the owner)

[root@master ~]# chgrp sales file1            # Same effect as the previous command: Change the owner group of the file to sales

[root@master ~]# chown abdo:sales file1       # Change the owner of the file to abeer and the owner group to sales

[root@master ~]# chown -R abeer:sales dir1    # Change the owner and group of all items inside dir1 recursively to Abeer and sales

```
---

## Special permissions:
- The setuid (or setgid) permission on an executable file means that the command will run as the user (or group) of the file, not as the user that ran the command.
```
[root@master ~]# ls -l /usr/bin/passwd

✍️ Example of possible output:
-rwsr-xr-x. 1 root root 27832 Apr 1 10:24 /usr/bin/passwd

| Item               | Explanation |
| ------------------ | --------------------------------------------------- |
| `-rwsr-xr-x.`      | File Permissions: Regular file (`-`), with special permissions (explained below). |
| `1`                | Number of links to the file. |
| `root`             | Owner – The user who owns the file. |
| `root`             | Group – The group that owns the file. |
| `27832`            | File size in bytes. |
| `Apr 1 10:24`      | Date and time the file was last modified. |
| `/usr/bin/passwd`  | Full file name and path. |

🔐 What does the s in rws mean?

- The s in place of the owner's executable privileges (x) means that SetUID is enabled.
- This means that the passwd command runs with root privileges, even if executed by a regular user.
- This privilege is necessary because the passwd command needs to modify protected system files such as /etc/shadow.
- Without SetUID, users cannot change their passwords because they do not have write access to system files.

```

-The sticky bit for a directory sets a special restriction on deletion of files. Only the owner of the
file (and root) can delete files within the directory. 
```
[root@master ~]# ls -ld /tmp/

Example output:
drwxrwxrwt. 10 root root 4096 May 13 10:00 /tmp/

d             => This is a directory file.
rwxrwxrwt     => Permissions: Read/write/execute permissions for the user, group, and everyone. The t stands for "sticky bit."
.             => SELinux-specific (can be ignored here).
10            => Number of links (subdirectories, etc.).
root          => Owner name (user).
root          => Group name (group).
4096          => Size in bytes (usually 4KB for directories).
May 13 10:00  => Last modification time of the directory.
/tmp/         => Name of the directory.

📌 What is a Sticky Bit (t)?
The t at the end of permissions means that only the file owner or the root user can delete files within the folder, even if other users have write permissions.
This is very important in public folders like /tmp/ to protect users' files from each other.

✍️ Summary:
The /tmp/ folder is used by the system and applications to store temporary files.
The presence of a sticky bit makes the folder safe for sharing among users.

```
• Symbolically: setuid=u+s; setgid=g+s; sticky=o+t
• Numerically (fourth preceding digit): setuid=4; setgid=2; sticky=1 
```
[root@master ~]# chown g+s dir1
[root@master ~]# chown 2770 dir1
Used to enable Set Group ID (SGID) on dir1
```
✅ Explanation of each command:
🔹 1. chmod g+s dir1
Adds the group ID (SGID) to the folder.
When SGID is enabled on a folder, any files or folders created within it automatically inherit the folder's group.

🔹 2. chmod 2770 dir1
This is the numeric (octal) format for specifying permissions:

2 at the beginning → indicates that the SGID is enabled.
7 → indicates that the owner has rwx (read, write, execute).
7 → The group also has rwx.
0 → No permissions for others.

📁 SGID's impact on folders:
When SGID is enabled on a folder:

All files/folders created within it have the same group as the folder.

This is useful in collaborative work environments (for example, a project folder shared by multiple users).
```
📘 Practical example:
Before SGID:
[root@master ~]# mkdir /shared
[root@master ~]# chown root:developers /shared
[root@master ~]# chmod 770 /shared

Any user who creates a file inside /shared will have its default group as their personal group.

```
---
## 🔐 Comparison between SUID, SGID, and Sticky Bit:
```
| Property | Full Name | Used with | Function | Permissions format when scanning (`ls -l`) |
| -------------- | ----------- | ---------------- | ------------- | -------------- |
| **SUID** | Set User ID | 🔹 Files Only | When the file is run, it is executed with the **owner** permissions, not the current user | `rwsr-xr-x` (note the `s` for owner permissions) |
| **SGID** | Set Group ID | 🔸 Files and Folders | 🔸 Files: The file is executed with the **group** permissions<br>🔸 Folders: New files inherit the **group** | `rwxr-sr-x` (note the `s` for group) |
| **Sticky Bit** | Sticky Bit (or "T" Bit) | 🔹 Folders Only | No file inside the folder can be deleted unless **its owner or the system administrator (root)** | `rwxrwxrwt` (note the `t` at the end of the permissions) |
```

--- 

## Default file permissions:

- The default permissions for files are set by the processes that create them. For example, text editors create files so they are readable and writeable, but not executable, by everyone.
- Every process on the system has a umask. 

```
[root@master ~]# umask # Display the current umask value for the root user
[abeer@master ~]$ umask # Display the current umask value for the abeer user
[root@master ~]# umask 007 # Temporarily set umask to prevent any permissions for others (new files will be 770)

[root@master ~]# vim /etc/bashrc # Modify umask for all users in interactive sessions
[root@master ~]# vim /etc/profile # Modify umask in all login shell sessions
[root@master ~]# vim .bashrc # Modify umask for current user in interactive subsessions
[root@master ~]# vim .bash_profile # Modify umask for current user in login sessions

```
---

### ✍️ Author: Abdelwahab Shandy
