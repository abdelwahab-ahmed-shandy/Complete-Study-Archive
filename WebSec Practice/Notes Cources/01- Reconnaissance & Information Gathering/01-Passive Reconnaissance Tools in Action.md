
# 🕵️‍♂️ أدوات وتقنيات جمع المعلومات السلبية (Passive Reconnaissance Tools)

## 🧩 أولًا: أدوات اكتشاف تقنيات المواقع (Technology Fingerprinting)

### ✅ Wappalyzer
- **طريقة الاستخدام**: إضافة على المتصفح (Chrome أو Firefox) أو أداة CLI.
- **الهدف**: معرفة الأدوات والتقنيات التي يستخدمها الموقع.

#### 🧠 ما الذي يمكن اكتشافه باستخدام Wappalyzer؟
| العنصر         | أمثلة                          | فائدته في الاختراق |
|----------------|--------------------------------|---------------------|
| نظام إدارة المحتوى | WordPress، Joomla              | البحث عن ثغرات في هذه الأنظمة |
| لغات البرمجة   | PHP، ASP.NET، Node.js           | معرفة نوع السيرفر وسطح الهجوم |
| الحماية        | Cloudflare، reCAPTCHA          | الحذر من الحماية وتجاوزها لاحقًا |
| مكتبات JS      | jQuery، Angular، React          | هل هي قديمة؟ تحتوي على ثغرات؟ |
| أدوات Analytics| Google Analytics, Hotjar        | معرفة أساليب تتبع المستخدم |

> 🔍 **مثال عملي**: إذا اكتشفت أن الموقع يستخدم jQuery إصدار 1.8، يمكنك التحقق في [CVE Details](https://www.cvedetails.com/) عن ثغرات الإصدار واستغلالها لاحقًا في مرحلة الاستغلال (Exploitation).

---

## 🌐 ثانيًا: أدوات تحليل الدومين والبنية التحتية

### ✅ WHOIS Lookup
- أدوات مثل:
  - [whois.domaintools.com](https://whois.domaintools.com/)
  - [who.is](https://who.is/)

#### البيانات التي يمكن استخراجها:
- تاريخ إنشاء وتعديل النطاق
- مزود خدمة الدومين
- بريد إلكتروني إداري (أحيانًا يكون مكشوفًا)
- الدولة والموقع الجغرافي لصاحب النطاق

---

### ✅ DNS Records Lookup
استخدم أدوات مثل [MXToolbox](https://mxtoolbox.com/)

| السجل | الوظيفة | مثال |
|-------|---------|-------|
| A     | يربط اسم النطاق بـ IP | example.com → 192.168.1.1 |
| MX    | خوادم البريد الإلكتروني | mail.example.com |
| NS    | أسماء السيرفرات | ns1.example.com |
| TXT   | يُستخدم للتحقق من الخدمات | google-site-verification |

---

## 🔍 ثالثًا: Google Dorking

### ✅ أمثلة على Dorks فعالة:

| الهدف | Dork المستخدم | مثال |
|-------|----------------|-------|
| عرض ملفات مخزنة | `intitle:"index of"` | `intitle:"index of" passwords` |
| البحث في موقع معين | `site:` | `site:example.com login` |
| العثور على ملفات حساسة | `filetype:env OR filetype:sql` | `filetype:env site:example.com` |
| العثور على صفحات إدارة | `inurl:admin` | `site:example.com inurl:admin` |

> 💡 نصيحة: يمكن تركيب Dorks مثل:
```
site:example.com filetype:log intext:password
```

---

## 💥 رابعًا: Exploit-DB و Google Hacking Database

### ✅ Exploit Database
- موقع: [https://www.exploit-db.com/](https://www.exploit-db.com/)
- يحتوي على:
  - استغلالات ثغرات (Exploit Code)
  - قاعدة بيانات Google Dorks [GHDB](https://www.exploit-db.com/google-hacking-database)

#### 📂 أقسام GHDB المهمة:
| القسم | ما يكشفه |
|-------|----------|
| Files containing passwords | ملفات تحتوي على كلمات مرور |
| Vulnerable servers | سيرفرات بها مشاكل |
| Error messages | صفحات تحتوي رسائل خطأ تكشف تفاصيل السيرفر |
| Sensitive directories | دلائل تحتوي بيانات خاصة |

---

## 🖥️ خامسًا: Shodan — محرك بحث للبنية التحتية

### ✅ ماذا يمكن أن تكتشف باستخدام Shodan؟
- الكاميرات المتصلة بالإنترنت
- خوادم قواعد البيانات المكشوفة
- خوادم FTP أو Telnet مفتوحة
- إصدارات Apache وNginx
- أجهزة إنترنت الأشياء (IoT)

### 🧪 أمثلة:
- `http.title:"Login"`
- `port:21 Anonymous FTP`

---

## 🧯 تنبيهات أخلاقية وقانونية

- ❌ لا ترسل رسائل Phishing أو بريد مزيف، إلا إذا كان مصرحًا بذلك.
- ✅ المرحلة هنا فقط لجمع المعلومات — لا يُسمح بأي تفاعل مباشر مع النظام بدون تصريح.

---

---

# 🕵️‍♂️ Passive Reconnaissance Tools and Techniques

## 🧩 First: Website Technology Fingerprinting Tools

### ✅ Wappalyzer
- **How ​​to Use**: Browser add-on (Chrome or Firefox) or CLI tool.
- **Goal**: Identify the tools and technologies used by the website.

### 🧠 What can be detected using Wappalyzer?
| Element | Examples | Its Usefulness in Hacking |
|----------------|--------------------------------|----------------------|
| Content Management System | WordPress, Joomla | Searching for Vulnerabilities in These Systems |
| Programming Languages ​​| PHP, ASP.NET, Node.js | Knowing the Server Type and Attack Surface |
| Security | Cloudflare, reCAPTCHA | Beware of Security and Bypass It Later |
| JS Libraries | jQuery, Angular, React | Is it outdated? Contains vulnerabilities? |
| Analytics Tools | Google Analytics, Hotjar | Learn about user tracking techniques |

> 🔍 **Practical Example**: If you discover that a site is using jQuery version 1.8, you can check the CVE Details (https://www.cvedetails.com/) for vulnerabilities and exploit them later in the exploitation phase.

---

## 🌐 Second: Domain and Infrastructure Analysis Tools

### ✅ WHOIS Lookup
- Tools such as:
- [whois.domaintools.com](https://whois.domaintools.com/)
- [who.is](https://who.is/)

#### Data that can be extracted:
- Domain creation and modification date
- Domain service provider
- Administrative email address (sometimes exposed)
- Country and geographic location of the domain owner

---

### ✅ DNS Records Lookup
Use tools such as [MXToolbox](https://mxtoolbox.com/)

| Record | Function | Example |
|------|--------|-------|
| A | Associates the domain name with the IP | example.com → 192.168.1.1 |
| MX | Email Servers | mail.example.com |
| NS | Server Names | ns1.example.com |

| TXT | Used for Service Verification | google-site-verification |

---

## 🔍 Third: Google Dorking

### ✅ Examples of Effective Dorks:

| Target | Dork User | Example |

|-------|----------------|-------|
| View Stored Files | `intitle:"index of"` | `intitle:"index of" passwords` |
| Search a Specific Site | `site:` | `site:example.com login` |
| Find Sensitive Files | `filetype:env OR filetype:sql` | `filetype:env site:example.com` |
| Find Administration Pages | `inurl:admin` | `site:example.com inurl:admin` |

> 💡 Tip: Dorks can be installed like this:
```
site:example.com filetype:log intext:password
```

---

## 💥 Fourth: Exploit-DB and Google Hacking Database

### ✅ Exploit Database
- Website: [https://www.exploit-db.com/](https://www.exploit-db.com/)
- Contains:
- Exploit Code
- Google Dorks Database [GHDB](https://www.exploit-db.com/google-hacking-database)

#### 📂 Important GHDB Sections:
| Section | What It Reveals |
|------|---------|
| Files Containing Passwords | Files containing passwords |
| Vulnerable servers | Servers with problems |
| Error messages | Pages containing error messages revealing server details |
| Sensitive directories | Directories containing private data |

---

## 🖥️ Fifth: Shodan — An infrastructure search engine

### ✅ What can you discover using Shodan?
- Internet-connected cameras
- Exposed database servers
- Open FTP or Telnet servers
- Apache and Nginx versions
- Internet of Things (IoT) devices

### 🧪 Examples:
- `http.title:"Login"`
- `port:21 Anonymous FTP`

---

## 🧯 Ethical and legal warnings

- ❌ Do not send phishing or fake emails unless authorized.
- ✅ This stage is for information gathering only — no direct interaction with the system is permitted without authorization.