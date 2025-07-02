# 📤 FTP Protocol – Practical and Applied Explanation

The **FTP (File Transfer Protocol)** protocol is one of the oldest and most popular Internet protocols, used to transfer files between a client and a server. This protocol allows files to be easily uploaded and downloaded within a local network or over the Internet.

---
## 📌 Highlights

### 📁 What is FTP?
A protocol used to transfer files between devices within a single network or over the Internet using a client/server approach.

---

### 💻 Setting up an FTP server (practical example on PC1)
- Use an operating system such as **Windows Server** or **Linux**.
- Install a program such as **FileZilla Server** or **vsftpd**.
- Create a home directory known as **Home Directory** as the access point.

---

### 🔐 Authentication and Access Security
- Set a **Username** and **Password**.
- Prevent anonymous logins unless necessary.
- Define each user's permissions (read/write).

---

### 🏠 Home Directory
- A dedicated folder for each user that specifies which files they can access.
- Helps organize files and prevent users from accessing unauthorized areas.

---

### ✍️ User Permissions Management
| Permission Type | Description |

|------------|--------|
| Read Only | The user can only download files |
| Read and Write | Can upload, modify, and delete files |
| Limited Access | Restrict access to specific folders only |

---

### ⚙️ FTP Setup and Operation Tools

| Tool | Function | Operating System |

|---|--------------------|
| FileZilla Server | Create and Run an FTP Server | Windows |
| vsftpd / ProFTPD | Advanced FTP Services | Linux |
| FileZilla Client | Connect and Download/Upload Files | All Platforms |

| ftp (CLI) | Command Prompt | All Platforms |

---

## 🌐 Connecting Two Machines Using FTP

- Use the **FileZilla Client** or **Command Prompt** (`ftp`).
- Enter the server's IP address, username, and password.
- Access files within a custom folder.

---

## 🔍 Key Technical Insights

### 🔄 FTP as a Primary Protocol
Remains widely used due to:
- Its simplicity.
- Its efficiency in transferring files, especially within local networks.

---

### 🔐 FTP Security

> ⚠️ **FTP does not support encryption by default.**

#### Threats:
- Possibility of login credentials being captured (sniffing).
- Using an anonymous connection exposes files to risk.

#### Solutions:
- **FTPS**: Add an SSL/TLS layer for encryption.
- **SFTP**: A secure alternative that runs over SSH.

---

### 🏠 Home Directory as a Line of Defense
Helps:
- Restrict user movements within the server.
- Protect system files and other users.

---

### ⚙️ Easy and Flexible Setup
- Can be executed via a graphical interface (GUI) or command line (CLI).
- Suitable even for non-technical users.

---

### 🌐 Network Settings
For a successful connection, you must:
- Open **Port 21** in your firewall.
- Use Passive Mode in NAT situations.
- Match login credentials with authorized accounts.

---

## 🚀 Common Uses of FTP

- Uploading website files to the server.
- Sharing files between teams.
- Archiving and backing up data.
- Easily managing content within local networks.

---

## 💡 Summary

FTP is an efficient way to transfer files within networks or over the internet. It features:
- Ease of setup.
- Broad tool support.
- Flexible permission control.

> Although it is a traditional protocol, FTP remains a popular choice in environments that require speed and flexibility in file exchange.


---

---

---

---


# 📤 FTP Protocol – شرح عملي وتطبيقي

بروتوكول **FTP (File Transfer Protocol)** هو أحد أقدم وأشهر بروتوكولات الإنترنت، ويُستخدم لنقل الملفات بين جهاز العميل (Client) والخادم (Server). يتيح هذا البروتوكول رفع وتنزيل الملفات بسهولة داخل شبكة محلية أو عبر الإنترنت.

---

## 📌 النقاط البارزة

### 📁 ما هو FTP؟
بروتوكول يُستخدم لنقل الملفات بين الأجهزة داخل شبكة واحدة أو عبر الإنترنت باستخدام أسلوب العميل/الخادم.

---

### 💻 إعداد سيرفر FTP (مثال عملي على PC1)
- استخدام نظام تشغيل مثل **Windows Server** أو **Linux**.
- تثبيت برنامج مثل **FileZilla Server** أو **vsftpd**.
- إنشاء مجلد رئيسي يُعرف بـ **Home Directory** ليكون نقطة الوصول.

---

### 🔐 المصادقة وتأمين الوصول
- ضبط **اسم المستخدم** و**كلمة المرور**.
- منع تسجيل الدخول المجهول **(Anonymous Login)** إلا إذا كان ضروريًا.
- تحديد صلاحيات كل مستخدم (قراءة / كتابة).

---

### 🏠 Home Directory
- مجلد مخصص لكل مستخدم يحدد الملفات التي يمكنه الوصول إليها.
- يساعد على تنظيم الملفات ومنع المستخدمين من الوصول لمناطق غير مصرح بها.

---

### ✍️ إدارة صلاحيات المستخدمين
| نوع الصلاحية | الوصف |
|--------------|--------|
| قراءة فقط     | يمكن للمستخدم تنزيل الملفات فقط |
| قراءة وكتابة  | يمكنه رفع، تعديل، حذف الملفات |
| وصول محدود   | تقييد الوصول لمجلدات معينة فقط |

---

### ⚙️ أدوات إعداد وتشغيل FTP

| الأداة            | الوظيفة                       | نظام التشغيل |
|------------------|-------------------------------|---------------|
| FileZilla Server | إنشاء وتشغيل سيرفر FTP        | Windows       |
| vsftpd / ProFTPD | خدمات FTP متقدمة              | Linux         |
| FileZilla Client | الاتصال وتنزيل/رفع الملفات    | All Platforms |
| ftp (CLI)        | أداة أوامر لإجراء الاتصال     | جميع الأنظمة |

---

## 🌐 الاتصال بين جهازين باستخدام FTP

- استخدام **FileZilla Client** أو **موجه الأوامر** (`ftp`).
- إدخال عنوان IP الخاص بالسيرفر، واسم المستخدم وكلمة المرور.
- الوصول إلى الملفات داخل المجلد المخصص.

---

## 🔍 الرؤى التقنية الرئيسية

### 🔄 FTP كبروتوكول أساسي
لا يزال مستخدمًا بشكل واسع بسبب:
- بساطته.
- كفاءته في نقل الملفات، خاصة داخل الشبكات المحلية.

---

### 🔐 الأمان في FTP

> ⚠️ **FTP لا يدعم التشفير افتراضيًا.**

#### التهديدات:
- إمكانية التقاط بيانات الدخول (Sniffing).
- استخدام الاتصال المجهول يعرض الملفات للخطر.

#### الحلول:
- **FTPS**: إضافة طبقة SSL/TLS للتشفير.
- **SFTP**: بديل آمن يعمل عبر SSH.

---

### 🏠 Home Directory كخط دفاع
يساعد على:
- تقييد تحركات المستخدم داخل السيرفر.
- حماية ملفات النظام والمستخدمين الآخرين.

---

### ⚙️ إعداد سهل ومرن
- يمكن تنفيذه من خلال واجهة رسومية (GUI) أو أوامر (CLI).
- مناسب حتى للمستخدمين غير التقنيين.

---

### 🌐 إعدادات الشبكة
لنجاح الاتصال يجب:
- فتح **المنفذ 21** في الجدار الناري.
- استخدام **Passive Mode** في حالات NAT.
- مطابقة بيانات الدخول مع الحسابات المصرح بها.

---

## 🚀 استخدامات FTP الشائعة

- **رفع ملفات المواقع** إلى السيرفر.
- **تبادل ملفات بين الفرق**.
- **أرشفة ونسخ احتياطي** للبيانات.
- إدارة المحتوى داخل الشبكات المحلية بسهولة.

---

## 💡 خلاصة

FTP هو وسيلة فعالة لنقل الملفات داخل الشبكات أو عبر الإنترنت. يتميز بـ:
- سهولة الإعداد.
- دعم واسع للأدوات.
- مرونة في التحكم بالصلاحيات.

> ومع أنه بروتوكول تقليدي، إلا أن FTP ما يزال خيارًا شائعًا في بيئات تتطلب سرعة ومرونة في تبادل الملفات.


