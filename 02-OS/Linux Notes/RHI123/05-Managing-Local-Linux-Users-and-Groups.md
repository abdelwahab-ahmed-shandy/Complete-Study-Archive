# Chapter 5 – Managing Local Linux Users and Groups

## 👤Users:

```
[root@master ~]# ls -l
[root@master ~]# ps aux
[root@master ~]# useradd --help
```
## Create a user
```
[root@master ~]# useradd abeer
[root@master ~]# passwd abeer
```
## Create a user with specific group, UID, and shell

```
[root@master ~]# useradd -G admin -u 1005 -s /usr/sbin/nologin abdo
```

## Create a user with comment (GECOS), expiration date, and specific shell
```
[root@master ~]# useradd -c "ahmed hosni" -e 12-31-2016 -s /bin/csh ahmed
```
---

## ✅ To verify:

```
[root@master ~]# id
[root@master ~]# id abdo
[root@master ~]# id -u abdo      # UID for abdo
[root@master ~]# tail -n 1 /etc/passwd
```

### Format: username:password:UID:GID:GECOS:/home/dir:shell

!! means the user has no password.

Hash types:

1 = MD5

6 = SHA-512

## To change password hashing algorithm:

```
[root@master ~]# authconfig --passalgo=<descrypt|bigcrypt|md5|sha256|sha512>
```
---

## 👥 Groups:

## Create groups
```
[root@master ~]# groupadd sales
[root@master ~]# groupadd -g 1005 admin
```
## ✅ To verify:

```
[root@master ~]# id
[root@master ~]# id abeer
[root@master ~]# grep sales /etc/group
```

## Format: groupname:password:GID:user1,user2,...

🛠 Modify groups:

```
[root@master ~]# groupmod -g 2000 admin        # Change GID
[root@master ~]# groupadd old
[root@master ~]# groupmod -n new old           # Rename a group
```
---

## 🔁 Switching Users with su:

```
[root@master ~]# su abdo
[abeer@master root]$ exit

[root@master ~]# su - abdo
[abeer@master ~]$ 

[abeer@master ~]$ su 
[abeer@master ~]$ su -
```

## ⚙️ Running Commands as root with sudo:

```
[root@master ~]# vim /etc/sudoers
```

## Add:
abeer   ALL=(ALL)       ALL
%sales  ALL=(ALL)       ALL

```
[abdo@master ~]$ sudo passwd ahmed
[abdo@master ~]$ sudo passwd -l ahmed
```

## To monitor:

```
[root@master ~]# tail -f /var/log/secure
```

---

## 🛠 Modify Users:
```
[root@master ~]# usermod -L abeer             # Lock the user
[root@master ~]# usermod -U abeer             # Unlock the user
[root@master ~]# usermod -G sales abeer       # Set new secondary group (overwrite)
[root@master ~]# usermod -aG admin abeer      # Add to secondary group (append)
```
## Or manually edit:
```
[root@master ~]# vim /etc/group
```
✅ Verify changes:
```
[root@master ~]# id abdo
```
---

## ❌ Delete Users:
```
[root@master ~]# userdel abdo
[root@master ~]# userdel -r test      # Also removes home directory
```

## ❌ Delete Groups:
```
[root@master ~]# groupdel admin
```
🆔 UID Ranges:

UID 0 → root

UID 1-200 → Static system accounts (e.g., kernel processes)

UID 201-999 → System processes without files

UID 1000+ → Regular users

🔧 To change the default UID range:
```
[root@master ~]# vim /etc/login.defs
```
---

## 🔑 Password Aging:
```
[root@master ~]# chage -l abeer                 # View password aging
[root@master ~]# chage -E 2017-1-1 abeer        # Expire account
[root@master ~]# chage -m 1 abeer               # Minimum days between password changes
[root@master ~]# chage -M 120 abeer             # Maximum password age
[root@master ~]# passwd -x 90 abeer             # Set expiration after 90 days
```

## 🏠 Default Files for New Users:
```
[root@master ~]# touch /etc/skel/new_file
```
##🖥 GUI Tool to Manage Users:
```
[root@master ~]# yum install system-config-users
[root@master ~]# system-config-users
```
---

### ✍️ Author: Abdelwahab Shandy
