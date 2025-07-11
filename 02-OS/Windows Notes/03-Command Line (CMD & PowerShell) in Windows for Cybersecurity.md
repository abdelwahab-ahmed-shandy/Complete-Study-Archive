## 🔡 **الباب الرابع: سطر الأوامر (CMD & PowerShell) في Windows للأمن السيبراني**

> الهدف من هذا الباب هو فهم كيفية استخدام سطر الأوامر **بشكل احترافي** في مهام الأمن السيبراني مثل:

- جمع المعلومات
- تحليل الأنظمة
- فحص الشبكات
- التحكم في العمليات
- التعامل مع السجلات والـ Registry

---
## 🧭 **مقدمة: الفرق بين CMD وPowerShell**

| المقارنة          | CMD                        | PowerShell                                        |
| ----------------- | -------------------------- | ------------------------------------------------- |
| الأصل             | قديم – منذ DOS             | أحدث – تم تصميمه كبيئة Scripting                  |
| القوة             | محدود – تنفيذ أوامر أساسية | قوي جدًا – يدعم البرمجة بالأوامر (Scriptable)     |
| التعامل مع النظام | ملفات ونصوص فقط            | كل شيء كـ Objects (مخرجات قابلة للفلترة والتحليل) |
| الاستخدام الأمني  | جيد للفحص السريع           | ممتاز للتحليل والهجوم والدفاع                     |

---

## 💻 أولاً: أوامر CMD الأساسية للأمن السيبراني

> يتم تنفيذها في نافذة **Command Prompt (cmd.exe)**

### 🛠️ 1. **معلومات النظام**

- يُعطيك تفاصيل عن نوع النظام، الباتشات، المعالج، إلخ.
```
systeminfo
```

- اسم الجهاز واسم المستخدم الحالي.
```
hostname whoami
```

- رقم إصدار Windows.
```
ver
```

---
### 🌐 2. **فحص الشبكة**

- عرض معلومات الشبكة بالتفصيل.
```
ipconfig /all
```

- عرض كل الاتصالات النشطة، مع رقم العملية (PID).
```
netstat -ano
```

- جدول ARP – لعرض الأجهزة المرتبطة محليًا.
```
arp -a
```

- اختبار استجابة DNS.
```
nslookup google.com
```

---
### 🧍‍♂️ 3. **المستخدمين والصلاحيات**

- عرض المستخدمين والمجموعات والصلاحيات.
```
net user net localgroup administrators
```

- يعرض المجموعات التي ينتمي إليها المستخدم الحالي.
```
whoami /groups
```

---
### 🧠 4. **العمليات والخدمات**

- عرض جميع العمليات الجارية.
```
tasklist
```

- إنهاء عملية معينة بالقوة.
```
taskkill /PID 1234 /F
```

- عرض الخدمات التي تعمل على النظام.
```
sc query
```

- عرض خصائص خدمة معينة.
```
sc qc [اسم الخدمة]
```

---
### 📁 5. **الملفات والتصفح**

- عرض جميع الملفات في المجلد والمجلدات الفرعية (نموذج لجمع الأدلة).
```
dir /s /b
```

- الانتقال بين المجلدات.
```
cd
```

- نسخ ملف.
```
copy /y file.txt C:\Backup\
```

- حذف ملف بالقوة بدون تأكيد.
```
del /f /q file.txt
```

---

## ⚡ ثانيًا: أوامر PowerShell المتقدمة :

> يُنفذ من خلال PowerShell (`powershell.exe`) أو (Windows Terminal)
### 🧠 1. **إدارة العمليات**

- عرض وإنهاء العمليات.
```
Get-Process Stop-Process -Id 1234 -Force
```

- عرض أكثر 5 عمليات تستهلك المعالج.
```
Get-Process | Sort CPU -Descending | Select -First 5
```

---
### 🧍‍♂️ 2. **المستخدمين والمجموعات**

- لمعرفة من لديه صلاحيات المسؤول.
```
Get-LocalUser Get-LocalGroup

Get-LocalGroupMember -Group "Administrators"
```

---
### 🔐 3. **تحليل الـ Registry**

- عرض البرامج التي تعمل عند الإقلاع.
```
Get-ItemProperty -Path "HKLM:\Software\Microsoft\Windows\CurrentVersion\Run"
```

---
### 📂 4. **التعامل مع الملفات والأدلة**

- البحث عن كل ملفات exe في مسار معين.
```
Get-ChildItem -Recurse C:\Users | Where-Object {$_.Extension -eq ".exe"}
```

- قراءة محتوى ملف نصي (logs مثلًا).
```
Get-Content C:\Logs\security.log
```

---

### 📡 5. **فحص الشبكة**

- Ping باستخدام PowerShell.
```
Test-Connection google.com -Count 3
```

- جميع الاتصالات النشطة مثل netstat : 

```
Get-NetTCPConnection
```

-  استعلام DNS (بديل لـ nslookup) :

```
Resolve-DnsName google.com
```
---

### 💡 6. **تشغيل السكربتات**

- للسماح بتشغيل سكربتات `.ps1`
```
Set-ExecutionPolicy RemoteSigned
```

- تنفيذ سكربت PowerShell محلي.
```
.\script.ps1
```

---
## 🧪 سيناريو تدريبي:

> تحليل جهاز باستخدام CMD وPowerShell

1. افتح CMD:
```
systeminfo

net user

netstat -ano

tasklist
```

2. افتح PowerShell:
```
Get-LocalUser

Get-Process | Sort CPU -Descending

Get-NetTCPConnection

Get-ItemProperty -Path "HKCU:\Software\Microsoft\Windows\CurrentVersion\Run"
```

ثم:

- لاحظ هل هناك مستخدمين غير مألوفين؟

- هل توجد اتصالات غريبة إلى IPs؟

- هل هناك برامج تعمل تلقائيًا بشكل غير عادي؟

---

## 📌 خلاصة

|نقطة القوة|CMD|PowerShell|
|---|---|---|
|فحص سريع|✅|✅|
|تحليل متقدم|❌|✅|
|التعامل مع الكائنات|❌|✅|
|البرمجة والأتمتة|❌|✅|

---
	`Abdelwahab Shandy`