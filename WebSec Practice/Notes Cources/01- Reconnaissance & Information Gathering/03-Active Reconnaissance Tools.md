# 🛡️ أدوات وتقنيات الاستطلاع النشط

في مرحلة **الاستطلاع النشط** من اختبار الاختراق، نتفاعل بنشاط مع الهدف لجمع التفاصيل الفنية. فيما يلي ملخص مُفصّل للأدوات والتقنيات الأساسية المستخدمة.

---

## 📚 جدول المحتويات

- [🔍 تحديد التكنولوجيا (البصمة)](#-تحديد-التكنولوجيا-البصمة)
- [📂 اكتشاف محتوى الويب](#-اكتشاف-محتوى-الويب)
- [🔐 تحديد بصمة التطبيق](#-بصمة-التطبيق)
- [🌐 استطلاع نظام أسماء النطاقات](#-استطلاع-نظام-أسماء-الأسماء)
- [💻 نظام التشغيل](#-نظام-التشغيل)
- [✅ ملاحظات ختامية](#-ملاحظات-نهائية)
- [📖 ملخص](#ملخص)
- [✨ أهم النقاط](#أهم النقاط)
- [💡 أهم الأفكار](#أفكار-رئيسية)

---

## 🔍 تحديد التكنولوجيا (البصمة)

### الأدوات:

- [**Wappalyzer**](https://www.wappalyzer.com/): ملحق متصفح يكشف التقنيات وإصداراتها التي يستخدمها الموقع المستهدف (مثل Angular 15.1.3).
- [**WhatWeb**](https://github.com/urbanadventurer/WhatWeb): أداة سطر أوامر تكشف تفاصيل الخادم، والتقنيات، والمواقع، ورؤوس HTTP.

> ⚠️ قد تكشف كل أداة جوانب مختلفة. استخدم كليهما للحصول على صورة أشمل.

- ---

## 📂 اكتشاف محتوى الويب

### الأداة:

- [**ffuf**](https://github.com/ffuf/ffuf) (أداة التعتيم السريع):
- اللغة: Go (سريعة وفعّالة).
- الاستخدام: اكتشاف المجلدات والملفات المخفية.
- قوائم الكلمات: استخدم من [SecLists](https://github.com/danielmiessler/SecLists) (مثل: `common.txt`، `Apache`، `IIS`، `Tomcat`، حسب نوع الخادم).

### ملاحظات حول رمز حالة HTTP:

- `200`: موجود
- `301/302`: إعادة توجيه
- `403`: محظور (قد لا يزال موجودًا)
- `404`: غير موجود
- `500`: خطأ في الخادم (قد يتأثر الهدف بالفحص)

> ✅ التحقق اليدوي مهم لتجنب النتائج الإيجابية الخاطئة.

- ---

## 🔐 بصمة التطبيق

### الأدوات:

- [**Nikto**](https://github.com/sullo/nikto): فحص شامل لثغرات خادم الويب المعروفة.
- [**WPScan**](https://wpscan.com/): ماسح ضوئي متخصص لمواقع ووردبريس.
- [**nmap**](https://nmap.org/): يُستخدم للكشف عن الإصدارات وبرمجة NSE.

---

## 🌐 استطلاع DNS

### الأداة:

- [**dnsrecon**](https://github.com/darkoperator/dnsrecon): يكتشف سجلات DNS (A، MX، TXT، CNAME...) ويكشف عن النطاقات الفرعية أو الإدخالات التي تم تكوينها بشكل خاطئ.

---

## 💻 نظام التشغيل

- **كالي لينكس**: توزيعة لينكس مصممة لاختبار الاختراق وتحتوي على جميع الأدوات المذكورة أعلاه افتراضيًا.

---

## ✅ ملاحظات ختامية

- 🔁 لا تعتمد على أداة واحدة فقط - اجمع النتائج.
- 🔍 قد تؤدي كل تفصيلة صغيرة إلى ثغرات أمنية حرجة.
- 📌 يجب التحقق من الإصدارات المُحددة (مثل Angular 15.1.3) في قواعد بيانات CVE بحثًا عن الثغرات الأمنية المعروفة.

---

## 📖 ملخص

يناقش الفيديو مرحلة الاستطلاع في اختبار الأمن السيبراني، مُركزًا على العملية المنهجية لجمع معلومات مُفصلة حول تطبيق ما لتحديد نقاط الهجوم المُحتملة. تُعدّ هذه المرحلة بالغة الأهمية لفهم بنية التطبيق ومكوناته وثغراته قبل محاولة الهجوم.

تشمل الخطوات الرئيسية ما يلي:

- فحص خوادم الويب المُستهدفة لاستخراج تفاصيل إطار العمل ورؤوس HTTP.
- استخدام أدوات آلية مثل **dnsrecon** لجمع سجلات DNS.
- تشغيل **Subfinder** و**ffuf** للكشف عن النطاقات الفرعية والمجلدات المخفية.
- التأكيد على الأهمية القانونية لحصر نطاق الاختبار في عناوين IP والنطاقات المُستهدفة.

---

## ✨ أهم النقاط

- 🔍 يتضمن الاستطلاع جمع معلومات مفصلة لرسم خريطة لسطح هجوم التطبيق.
- 🛠️ استخدام أدوات المسح لتحديد العناوين، وأطر العمل، وإصدارات الخادم.
- 🌐 يُؤتمت DNS Recon استخراج السجلات، وهو أمر ضروري لإجراء تحليل أعمق.
- 🎯 حصر النطاق في عناوين IP/النطاقات المصرح بها لضمان إجراء اختبار قانوني.
- 📂 اكتشاف النطاقات الفرعية باستخدام أدوات مثل `Subfinder`.
- 💻 استخدام التشويش (`ffuf`) للكشف عن المسارات المخفية.
- 🧰 أدوات متعددة = نتائج أوسع وأكثر دقة.

---

## 💡 رؤى رئيسية

- 🔍 **الاستطلاع الشامل أساسي لاختبار الأمن السيبراني.** قد يؤدي تجاهله إلى تفويت الثغرات الأمنية.
- 🛠️ **تُعدّ عناوين الأمان وإصدارات أطر العمل مؤشرات مبكرة** على وجود أنظمة قديمة أو غير مُهيأة بشكل صحيح.
- 🌐 **يُسرّع تعداد DNS الآلي** اكتشاف الأهداف والبنية التحتية المفيدة.
- 🎯 **يضمن تحديد النطاق بدقة** إجراء اختبارات مُركّزة ويتجنب المشاكل القانونية.
- 📂 **تُحسّن الأدوات المُتنوعة** من فرصة العثور على أصول غامضة.
- 💻 **يُوسّع الاكتشاف الضبابي** نطاق التعداد الأساسي.
- 🧰 **يؤدي دمج المنهجيات** إلى استطلاع أعمق وأكثر تنوعًا لضمان نجاح اختبارات الاختراق.

---

## ⚙️ نصائح التثبيت

> تأتي مُعظم الأدوات مُثبّتة مُسبقًا في **كالي لينكس**. للتثبيت يدويًا:

```bash
sudo apt install whatweb ffuf nikto nmap
gem install wpscan
git clone https://github.com/darkoperator/dnsrecon.git


---

---

# 🛡️ Active Reconnaissance Tools & Techniques

In the **Active Reconnaissance** phase of penetration testing, we actively interact with the target to collect technical details. Below is a structured summary of the essential tools and techniques used.

---

## 📚 Table of Contents

- [🔍 Technology Identification (Fingerprinting)](#-technology-identification-fingerprinting)
- [📂 Web Content Discovery](#-web-content-discovery)
- [🔐 Application Fingerprinting](#-application-fingerprinting)
- [🌐 DNS Reconnaissance](#-dns-reconnaissance)
- [💻 Operating System](#-operating-system)
- [✅ Final Notes](#-final-notes)
- [📖 Summary](#summary)
- [✨ Highlights](#highlights)
- [💡 Key Insights](#key-insights)

---

## 🔍 Technology Identification (Fingerprinting)

### Tools:

- [**Wappalyzer**](https://www.wappalyzer.com/): Browser extension that detects technologies and their versions used by the target site (e.g., Angular 15.1.3).
- [**WhatWeb**](https://github.com/urbanadventurer/WhatWeb): CLI tool that reveals server details, technologies, locations, and HTTP headers.

> ⚠️ Each tool may reveal different aspects. Use both to get a fuller picture.

---

## 📂 Web Content Discovery

### Tool:

- [**ffuf**](https://github.com/ffuf/ffuf) (Fast Fuzzing Tool):
  - Language: Go (fast and efficient).
  - Usage: Discover hidden directories and files.
  - Wordlists: Use from [SecLists](https://github.com/danielmiessler/SecLists) (e.g., `common.txt`, `Apache`, `IIS`, `Tomcat` depending on the server type).

### HTTP Status Code Notes:

- `200`: Exists
- `301/302`: Redirect
- `403`: Forbidden (May still exist)
- `404`: Not found
- `500`: Server error (target might be impacted by scanning)

> ✅ Manual verification is important to avoid false positives.

---

## 🔐 Application Fingerprinting

### Tools:

- [**Nikto**](https://github.com/sullo/nikto): Comprehensive scanner for known web server vulnerabilities.
- [**WPScan**](https://wpscan.com/): Specialized scanner for WordPress sites.
- [**nmap**](https://nmap.org/): Use for version detection and NSE scripting.

---

## 🌐 DNS Reconnaissance

### Tool:

- [**dnsrecon**](https://github.com/darkoperator/dnsrecon): Discovers DNS records (A, MX, TXT, CNAME...) and uncovers subdomains or misconfigured entries.

---

## 💻 Operating System

- **Kali Linux**: A Linux distro tailored for penetration testing and contains all of the above tools by default.

---

## ✅ Final Notes

- 🔁 Never rely on one tool alone — combine results.
- 🔍 Every small detail may lead to critical vulnerabilities.
- 📌 Identified versions (e.g., Angular 15.1.3) should be checked in CVE databases for known vulnerabilities.

---

## 📖 Summary

The video discusses the reconnaissance phase of cybersecurity testing, focusing on the systematic process of gathering detailed information about an application to identify potential attack surfaces. This stage is crucial for understanding the application’s structure, components, and vulnerabilities before attempting an attack.

Key steps include:

- Scanning target web servers to extract framework details and HTTP headers.
- Using automated tools like **dnsrecon** to gather DNS records.
- Running **Subfinder** and **ffuf** to uncover subdomains and hidden directories.
- Emphasizing the legal importance of limiting scope to in-scope IPs and domains.

---

## ✨ Highlights

- 🔍 Reconnaissance involves detailed information gathering to map the application's attack surface.
- 🛠️ Use scanning tools to identify headers, frameworks, and server versions.
- 🌐 DNS Recon automates record extraction essential for deeper analysis.
- 🎯 Limit scope to authorized IPs/domains to ensure legal testing.
- 📂 Subdomain discovery with tools like `Subfinder`.
- 💻 Use of fuzzing (`ffuf`) to uncover hidden paths.
- 🧰 Multiple tools = broader, more accurate results.

---

## 💡 Key Insights

- 🔍 **Thorough reconnaissance is foundational to cybersecurity testing.** Skipping it can result in missed vulnerabilities.
- 🛠️ **Security headers and framework versions are early indicators** of outdated or misconfigured systems.
- 🌐 **Automated DNS enumeration** speeds up discovery of useful targets and infrastructure.
- 🎯 **Proper scope definition** ensures focused testing and avoids legal issues.
- 📂 **Diverse tooling** improves the chance of finding obscure assets.
- 💻 **Fuzzing extends discovery** beyond basic enumeration.
- 🧰 **Combining methodologies** leads to deeper, layered reconnaissance for successful pentests.

---

## ⚙️ Installation Tips

> Most tools come pre-installed in **Kali Linux**. To install manually:

```bash
sudo apt install whatweb ffuf nikto nmap
gem install wpscan
git clone https://github.com/darkoperator/dnsrecon.git

---

### By Abdelwahab Shandy 
