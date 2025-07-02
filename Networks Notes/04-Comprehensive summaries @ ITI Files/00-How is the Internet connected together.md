# 🌐 How is the Internet Connected?

The Internet is a massive network of interconnected smaller networks—like those of companies, universities, organizations, and more. For devices to communicate, domain names (like `google.com`) must be translated into IP addresses (like `142.250.185.206`), because devices only understand numbers.

This is the job of the **DNS – Domain Name System**.

---

## 🧠 What is a Root Server or dot-root?

* A Root Server is a server that answers queries related to the top-level of domain names.
* Examples of top-level domains (TLDs): `.com`, `.net`, `.org`, `.eg`

### DNS Resolution Steps:

1. You type `www.google.com`
2. Your device asks a **Root Server**: “Where can I find `.com`?”
3. Root server replies: “Go to the TLD server for `.com`”
4. Device asks the TLD server: “Where is `google.com`?”
5. TLD replies with the authoritative server address for `google.com`
6. Finally, your device receives the IP address.

---

## 🏛️ Are there really only 13 Root Servers?

* Yes, there are **13 main root server names** (A to M)
* But this doesn’t mean there are only 13 physical servers! Each name represents **a large network of distributed servers** using **Anycast** technology.

### What is Anycast?

* Anycast allows multiple servers to share the same IP address.
* A device is automatically directed to the nearest available server.

### The 13 Root Servers:

| Server Name | Responsible Organization          |
| ----------- | --------------------------------- |
| A-root      | ICANN                             |
| B-root      | USC-ISI                           |
| C-root      | Cogent Communications             |
| D-root      | University of Maryland            |
| E-root      | NASA Ames                         |
| F-root      | Internet Systems Consortium (ISC) |
| G-root      | US DoD NIC                        |
| H-root      | US Army                           |
| I-root      | Netnod (Sweden)                   |
| J-root      | Verisign                          |
| K-root      | RIPE NCC                          |
| L-root      | ICANN                             |
| M-root      | WIDE Project (Japan)              |

---

## 🛰️ Global Distribution

Although there are only 13 names, there are **more than 500 instances** distributed across all continents:

* Europe
* North America
* Asia
* Africa
* Australia
* South America

Each instance responds the same way to root-level queries.

---

## ⚙️ What Happens When You Request a Website?

Let’s take an example: `www.wikipedia.org`

1. Your device asks the **DNS Resolver** (usually provided by your ISP)
2. If the resolver doesn’t have the IP cached:

   * It asks the Root Server: “Where is `.org`?”
   * Then asks the TLD server for `.org`: “Where is `wikipedia.org`?”
   * Then asks the Authoritative server for the final IP
3. Finally, your device connects to the IP of `wikipedia.org`

---

## 🛡️ Why Are Root Servers So Important?

* They are the backbone of the domain resolution process.
* Without them, DNS lookups cannot begin.
* Hence, they are distributed and protected with strong security measures.

---

## 🧩 Quick Summary

| Item            | Description                                         |
| --------------- | --------------------------------------------------- |
| Number of Roots | 13 main servers, named A to M                       |
| Technology Used | Anycast for global redundancy and proximity routing |
| Main Function   | Guide requests to the correct TLD servers           |
| Importance      | Critical for translating domain names into IPs      |

---

## 🧠 What is a DNS Resolver?

* A component of the DNS system that searches for the IP address corresponding to a domain name typed into your browser.
* Often provided by your ISP, but alternatives include:

  * Google DNS (`8.8.8.8`)
  * Cloudflare DNS (`1.1.1.1`)

### 🌀 DNS Resolver Process

Let’s say you type: `www.wikipedia.org`

1. **Check Cache:**

   * If already stored, respond immediately.
2. **Ask Root Server:**

   * Where can I find `.org`?
3. **Receive TLD Server Info:**

   * Get the address of the `.org` TLD server.
4. **Ask TLD Server:**

   * Where is `wikipedia.org`?
5. **Get Authoritative Server Info:**

   * Address of the server that knows the IP.
6. **Ask Authoritative Server:**

   * What is the IP of `www.wikipedia.org`?
   * Reply: e.g., `208.80.154.224`
7. **Send IP to Your Device:**

   * Now your browser can access the site.
8. **Store in Cache:**

   * Result is stored for future use (duration depends on TTL).

---

## 🎯 Resolution Process Summary

| Step                 | Description             |
| -------------------- | ----------------------- |
| Cache Check          | Look in memory          |
| Root Server          | Ask for TLD location    |
| TLD Server           | Ask for domain location |
| Authoritative Server | Get final IP address    |
| Final Reply          | Send IP back to browser |


---

---

---

# 🌐 كيف يتم ربط الإنترنت؟

الإنترنت هو شبكة ضخمة من الشبكات المتصلة ببعضها، مثل شبكات الشركات، الجامعات، المنظمات، وغيرها. ولكي تتمكن الأجهزة من التواصل، يجب ترجمة أسماء النطاقات (مثل `google.com`) إلى عناوين IP رقمية (مثل `142.250.185.206`).

وهذه مهمة **نظام أسماء النطاقات (DNS)**.

---

## 🧠 ما هو Root Server أو dot-root؟

* هو خادم مسؤول عن الرد على الاستفسارات المتعلقة بأعلى مستوى في أسماء النطاقات.
* أمثلة على النطاقات العليا: `.com` – `.net` – `.org` – `.eg`

### خطوات الاستعلام:

1. تكتب: `www.google.com`
2. يسأل الجهاز **خادم الجذر (Root Server)**: "فين .com؟"
3. يرد عليه: "روح لـ **TLD Server** الخاص بـ .com"
4. يسأل TLD: "فين google.com؟"
5. يرد عليه بعنوان الخادم الخاص بـ google.
6. يحصل على عنوان الـ IP النهائي.

---

## 🏛️ كم عدد خوادم الجذر؟

* **13 اسم رئيسي** فقط (من A إلى M)
* لكن كل واحد منهم يحتوي على مئات أو آلاف النسخ حول العالم.
* يتم استخدام تقنية **Anycast**، وهي تسمح بوجود نفس عنوان IP في أماكن مختلفة، ويتم توجيه المستخدم لأقرب نسخة.

### قائمة خوادم الجذر:

| اسم السيرفر | الجهة المسؤولة                    |
| ----------- | --------------------------------- |
| A-root      | ICANN                             |
| B-root      | USC-ISI                           |
| C-root      | Cogent Communications             |
| D-root      | University of Maryland            |
| E-root      | NASA Ames                         |
| F-root      | Internet Systems Consortium (ISC) |
| G-root      | US DoD NIC                        |
| H-root      | US Army                           |
| I-root      | Netnod (Sweden)                   |
| J-root      | Verisign                          |
| K-root      | RIPE NCC                          |
| L-root      | ICANN                             |
| M-root      | WIDE Project (Japan)              |

---

## 🛰️ التوزيع الجغرافي

* الخوادم موجودة في **أكثر من 500 موقع حول العالم** في:

  * أوروبا
  * أمريكا الشمالية
  * آسيا
  * أفريقيا
  * أستراليا
  * أمريكا الجنوبية

---

## ⚙️ ماذا يحدث عند طلب موقع؟

مثال: `www.wikipedia.org`

1. يسأل جهازك الـ **DNS Resolver** (غالبًا تابع لـ ISP)
2. إن لم يكن العنوان في الكاش:

   * يسأل Root Server عن `.org`
   * ينتقل إلى TLD الخاص بـ `.org`
   * ثم إلى الخادم الرسمي لـ `wikipedia.org`
   * يحصل على عنوان الـ IP
3. يتصل جهازك مباشرةً بالموقع باستخدام الـ IP.

---

## 🛡️ أهمية خوادم الجذر

* تعتبر الأساس الذي يُبنى عليه استعلام أسماء النطاقات.
* بدونها، لا يمكن الوصول إلى مواقع الإنترنت بالاسم.
* يتم توزيعها وتأمينها بعناية.

---

## 🧩 ملخص سريع

| النقطة            | التوضيح                                      |
| ----------------- | -------------------------------------------- |
| عدد السيرفرات     | 13 رئيسية باسم من A إلى M                    |
| التقنية المستخدمة | Anycast لتوزيع نسخ الخوادم                   |
| الوظيفة           | توجيه الاستعلامات نحو النطاقات العليا (TLDs) |
| الأهمية           | ضرورية لترجمة أسماء المواقع إلى عناوين IP    |

---

## 🧠 ما هو DNS Resolver؟

* هو خادم وسيط مسؤول عن إيجاد عنوان IP لأي اسم نطاق يُكتب في المتصفح.
* يكون تابعًا لمزود الإنترنت أو يمكن تغييره إلى خوادم مثل:

  * Google DNS (`8.8.8.8`)
  * Cloudflare DNS (`1.1.1.1`)

### 🌀 خطوات عمل DNS Resolver:

1. **التحقق من الكاش:**

   * إن كان الاسم موجودًا، يتم الرد فورًا.
2. **سؤال خادم الجذر (Root Server):**

   * للحصول على مكان TLD للنطاق.
3. **الحصول على TLD Server:**

   * المسؤول عن نطاق `.org` مثلا.
4. **سؤال خادم TLD:**

   * للحصول على عنوان الخادم الرسمي للنطاق.
5. **الوصول إلى الخادم الرسمي (Authoritative Server):**

   * للحصول على IP النهائي.
6. **الرد بالجـواب:**

   * يرسل عنوان IP إلى جهازك.
7. **الاتصال بالموقع:**

   * جهازك يتصل باستخدام الـ IP.
8. **تخزين في الكاش:**

   * يتم حفظ النتيجة مؤقتًا لتسريع الاستعلامات القادمة.

---

## 🎯 ملخص مراحل الاستعلام

| المرحلة              | التفاصيل               |
| -------------------- | ---------------------- |
| الكاش                | فحص داخلي سريع         |
| Root Server          | سؤال عن TLD المناسب    |
| TLD Server           | سؤال عن النطاق المطلوب |
| Authoritative Server | إرجاع عنوان IP النهائي |
| الرد النهائي         | إرساله إلى المتصفح     |

---

*By Abdelwahaba Shandy*
