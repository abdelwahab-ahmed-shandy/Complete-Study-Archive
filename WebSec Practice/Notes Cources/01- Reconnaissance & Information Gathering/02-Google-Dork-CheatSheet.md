
# 🛡️ دليل Google Dork للمختبرين الأمنيين

> ⚠️ هذا الدليل يُستخدم لأغراض تعليمية فقط، ولا يجوز استخدامه في أي أنشطة غير قانونية.

---

## 🔍 مرشحات البحث (Search Filters)

| الفلتر           | الوصف                                                             | مثال الاستخدام                           |
|------------------|--------------------------------------------------------------------|-------------------------------------------|
| `allintext`      | البحث عن جميع الكلمات المحددة في نص الصفحات.                      | `allintext:"كلمة"`                        |
| `intext`         | البحث عن كلمة أو أكثر داخل النص.                                 | `intext:"كلمة"`                           |
| `inurl`          | البحث عن كلمة داخل عنوان الصفحة (URL).                            | `inurl:"admin"`                           |
| `allinurl`       | البحث عن كل الكلمات داخل عنوان الصفحة.                            | `allinurl:"login admin"`                  |
| `intitle`        | البحث عن كلمة أو أكثر داخل عنوان الصفحة.                         | `intitle:"لوحة التحكم"`                   |
| `allintitle`     | البحث عن جميع الكلمات داخل عنوان الصفحة.                          | `allintitle:"لوحة التحكم دخول"`           |
| `site`           | حصر النتائج داخل موقع معين.                                       | `site:example.com`                        |
| `filetype`       | البحث عن نوع معين من الملفات.                                     | `filetype:pdf`                            |
| `link`           | عرض الروابط المؤدية إلى صفحات تحتوي على الكلمة.                   | `link:"login"`                            |
| `numrange`       | البحث داخل نطاق أرقام معين.                                       | `numrange:2000-2020`                      |
| `before/after`   | البحث حسب التاريخ.                                                | `before:2020-01-01 after:2018-01-01`      |
| `inanchor`       | البحث عن الصفحات التي تحتوي على الكلمات في الروابط المؤدية لها.  | `inanchor:"download"`                     |
| `inpostauthor`   | البحث في المقالات المكتوبة بواسطة كاتب معين.                      | `inpostauthor:"اسم الكاتب"`              |
| `related`        | عرض الصفحات المشابهة لصفحة معينة.                                | `related:www.example.com`                 |
| `cache`          | عرض نسخة محفوظة من صفحة ما في Google Cache.                       | `cache:www.example.com`                   |

---

## 🧪 أمثلة عملية (Advanced Dorks)

```bash
# ملفات غير محمية ومتاحة للتحميل
intitle:"index of" "admin"

# ملفات حساسة
filetype:env inurl:.env
filetype:log inurl:password
filetype:conf inurl:web.config

# وثائق تحتوي على معلومات سرية
filetype:pdf intext:"confidential" site:gov

# أسماء المستخدمين وكلمات المرور
intext:"username" intext:"password" filetype:log

# لوحات تحكم
intitle:"Admin Panel" inurl:admin

# أدوات المراقبة (كاميرات IP)
inurl:"view.shtml"
inurl:"/admin/view.cgi"

---

## ⚙️ معاملات البحث (Operators)

| المعامل       | الوصف                                                                                  | مثال الاستخدام                                      |
|----------------|------------------------------------------------------------------------------------------|------------------------------------------------------|
| `"كلمة"`       | للبحث عن عبارة دقيقة بين علامات تنصيص.                                                  | `"كلمة سر المسؤول"`                                 |
| `OR`           | البحث عن أي من المصطلحين.                                                               | `site:facebook.com OR site:twitter.com`             |
| `AND`          | البحث عن الصفحات التي تحتوي على المصطلحين معًا.                                        | `site:gov AND login`                                |
| `+`            | لإجبار Google على تضمين كلمة معينة.                                                     | `+login`                                            |
| `-`            | لاستبعاد النتائج التي تحتوي على كلمة معينة.                                            | `login -site:facebook.com`                          |
| `~`            | للبحث عن مرادفات الكلمة.                                                               | `~download`                                         |
| `*`            | للبحث عن كلمات مفقودة أو غير معروفة.                                                  | `"admin * login"`                                   |

---

## 🧰 أدوات الاستطلاع السلبي (Passive Recon Tools)

| الأداة         | الوظيفة                                                         |
|----------------|------------------------------------------------------------------|
| [crt.sh](https://crt.sh)        | البحث عن شهادات SSL ومعرفة النطاقات المرتبطة.         |
| [hunter.io](https://hunter.io) | استخراج عناوين البريد من النطاقات.                     |
| [Shodan](https://www.shodan.io)| محرك بحث للأجهزة المتصلة بالإنترنت (كاميرات، سيرفرات). |
| [Censys](https://censys.io)    | محرك بحث للبيانات العامة لشهادات SSL وخدمات الإنترنت.  |
| [Wayback Machine](https://archive.org/web/) | مراجعة نسخ قديمة من المواقع.         |
| [BuiltWith](https://builtwith.com)| معرفة تقنيات المواقع.                             |
| [VirusTotal](https://www.virustotal.com)| تحليل الملفات والروابط واستخراج النطاقات ذات الصلة. |

---

📚 **ملاحظات:**  
- ✅ تأكد من أنك تقوم بالبحث داخل نطاق قانوني ومصرّح به.

- 🔒 استخدم أدوات مثل robots.txt لفهم الملفات التي لا يُفترض أن تكون مفهرسة.

- 🧠 يمكن أن تكون Google Dorks فعالة جدًا في مرحلة جمع المعلومات (Reconnaissance) أثناء اختبار الاختراق.

- ⚠️ لا تقم أبدًا باستخدام هذه المهارات ضد مواقع دون إذن كتابي رسمي.

---

---

# 🛡️ Google Dork Guide for Security Testers

> ⚠️ This guide is for educational purposes only and may not be used for any illegal activities.

---

## 🔍 Search Filters

| Filter | Description | Example Usage |
|------------------|- ... Search for one or more words within a page title. | `intitle:"Control Panel"` |
| `allintitle` | Search for all words within a page title. | `allintitle:"Control Panel Login"` |
| `site` | Limit results to a specific site. | `site:example.com` |
| `filetype` | Search for a specific file type. | `filetype:pdf` |

| `link` | Display links to pages containing the word. | `link:"login"` |

| `numrange` | Search within a specific number range. | `numrange:2000-2020` |

| `before/after` | Search by date. | `before:2020-01-01 after:2018-01-01` |

| `inanchor` | Search for pages that contain the words in their links. | `inanchor:"download"` |
| `inpostauthor` | Search articles written by a specific author. | `inpostauthor:"Author's Name"` |
| `related` | Display pages similar to a specific page. | `related:www.example.com` |
| `cache` | Display a cached version of a page in Google Cache. | `cache:www.example.com` |

---

## 🧪 Practical Examples (Advanced Dorks)

```bash
# Unprotected Files Available for Download
intitle:"index of" "admin"

# Sensitive Files
filetype:env inurl:.env
filetype:log inurl:password
filetype:conf inurl:web.config

# Documents Containing Confidential Information
filetype:pdf intext:"confidential" site:gov

# Usernames and Passwords
intext:"username" intext:"password" filetype:log

# Control Panels
intitle:"Admin Panel" inurl:admin

# Surveillance Tools (IP Cameras)
inurl:"view.shtml"
inurl:"/admin/view.cgi"

---

📚 **Notes:**
- ✅ Ensure you are searching within a legal and authorized domain.

- 🔒 Use tools like robots.txt to understand files that are not supposed to be indexed.

- 🧠 Google Dorks can be very effective in the information gathering (reconnaissance) phase of a penetration test.

- ⚠️ Never use these skills against websites without formal written permission.

--
