# 📁 Chapter 4: Creating, Viewing, and Editing Text Files

##🔹 Standard Input, Output, and Error:

```
[root@master ~]# date > /tmp/saved-timestamp
[root@master ~]# tail -n 100 /var/log/dmesg > /tmp/last-100-boot-messages
[root@master ~]# cat file1 file2 file3 file4 > /tmp/all-four-in-one
[root@master ~]# ls -a > /tmp/my-file-names 
```

---

## ➕ Append Output to an Existing File:

```
[root@master ~]# echo "new line of information" >> /tmp/many-lines-of-information
[root@master ~]# find /etc -name passwd 2> /tmp/errors
[root@master ~]# find /etc -name passwd > /tmp/output 2> /tmp/errors
[root@master ~]# find /etc -name passwd > /tmp/output 2> /dev/null
[root@master ~]# find /etc -name passwd &> /tmp/save-both
[root@master ~]# find /etc -name passwd >> /tmp/save-both 2>&1
```

---

## 🔗Constructing Pipelines:

```
[root@master ~]# ls -l /usr/bin | less
[root@master ~]# ls | wc -l > /tmp/how-many-files
[root@master ~]# ls -t | head -n 10 > /tmp/ten-last-changed-files
[root@master ~]# ls -l | tee /tmp/saved-output
[root@master ~]# ls -l | tee /dev/pts/0 | mail -s subject
```
---

## ✍️ Editing Files with Vim:
```
[root@master ~]# vim file1
```
---

## ✏️ Editing Files with Gedit:

Applications > Accessories > gedit
[root@master ~]# gedit file1

---

📝 Editing Files with Nano:
```
[root@master ~]# nano file1
```
---

### ✍️ Author: Abdelwahab Shandy
