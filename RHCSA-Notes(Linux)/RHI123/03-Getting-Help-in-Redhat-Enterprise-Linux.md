# 📁 Chapter 3: Getting Help in Red Hat Enterprise Linux :

## 1️⃣ Using --help Command: 

```
[root@master ~]# date --help
[root@master ~]# date -s 03:00
```

---

## 2️⃣ Man Pages:
```
[root@master ~]# man passwd 			   # Default partition is 1
[root@master ~]# passwd -l abdo 		 # Lock user
[root@master ~]# passwd -u abdo 		 # Unlock user
[root@master ~]# man 1 passwd 			 # Partition 1 - User Commands
[root@master ~]# man 5 passwd 			 # Partition 5 - File Formats
[root@master ~]# man man 				     # About the man command
[root@master ~]# man -k "print files" 		 # Search for commands related to "print files"
[root@master doc]# apropos "print files" 	 # Same function as man -k
[root@master ~]# man -K "print files" 		 # Search within page content
[root@master ~]# man -k time | grep 1	 # Filter results to partition 1 only
[root@master ~]# man -k print | grep 1
[root@master ~]# man 1 su
```
📌 Popular man sections:

Section 1 ➝ User Commands

Section 5 ➝ File Formats

Section 8 ➝ System Administration Commands

🖱️ Navigation Tips:

PageDown / Space ➝ Scroll down

PageUp ➝ Scroll up

/string ➝ Search for a word
```
n ➝ Loop forward

N ➝ Loop backward

g ➝ Page start

G ➝ Page end

q ➝ Exit man
```
---

## 3️⃣ info and pinfo Commands:

```
[root@master ~]# pinfo
[root@master ~]# info passwd
[root@master ~]# pinfo passwd
```
---

## 4️⃣ Reading Documentation in /usr/share/doc/:
```
[root@master doc]# firefox /usr/share/doc/
```
---

### ✍️ Author: Abdelwahab Shandy
