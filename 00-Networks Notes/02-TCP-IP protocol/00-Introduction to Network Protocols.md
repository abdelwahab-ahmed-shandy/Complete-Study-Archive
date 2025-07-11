# مقدمة عن بروتوكولات الشبكات

## 🔍 ما هو البروتوكول؟
**البروتوكول في الشبكات** هو مجموعة من القواعد والمعايير التي تنظم كيفية إرسال واستقبال البيانات بين الأجهزة عبر الشبكة.  
يحدد البروتوكول:
- كيفية بناء البيانات (التغليف).
- كيفية بدء وإنهاء الاتصال.
- كيفية التعامل مع الأخطاء وفقدان البيانات.

---

## 🏗️ نموذج OSI (المرجعي):
نموذج نظري يتكون من **7 طبقات**، يحدد كيف تنتقل البيانات من برنامج إلى وسيط فيزيائي:

1. Application
2. Presentation
3. Session
4. Transport
5. Network
6. Data Link
7. Physical

> 📌 لكن في الواقع العملي، استخدام نموذج OSI كامل غير شائع، بل تم تبسيطه إلى نموذج آخر عملي أكثر.

---

## 🌐 نموذج TCP/IP (العملي):

نموذج TCP/IP يُستخدم فعليًا في جميع شبكات الإنترنت والأجهزة الحديثة.  
يتكون من **4 طبقات فقط**:

| طبقة TCP/IP            | مقابلها في OSI                                     | مثال على بروتوكولاتها            |
|-----------------------|---------------------------------------------------|----------------------------------|
| **Application Layer**  | OSI Layers 5, 6, 7 (Application, Presentation, Session) | HTTP, FTP, SMTP, DNS            |
| **Transport Layer**    | OSI Layer 4 (Transport)                           | TCP, UDP                        |
| **Internet Layer**     | OSI Layer 3 (Network)                             | IP (IPv4, IPv6), ICMP           |
| **Network Access Layer** | OSI Layers 1 & 2 (Physical, Data Link)             | Ethernet, Wi-Fi, ARP            |

---

## 💡 مميزات TCP/IP:
- ✅ **عملي وبسيط** مقارنة بنموذج OSI.
- 🌍 **يدعم الإنترنت بالكامل** وهو الأساس لجميع شبكات الحاسب حول العالم.
- 🔓 **مفتوح وغير مملوك لشركة**، مما يتيح تطويره من قبل الجميع.
- 🖥️ مدعوم من **جميع أنظمة التشغيل** (Windows, Linux, macOS, Android, iOS).

---

## 🧩 أمثلة على بروتوكولات TCP/IP:

| الطبقة              | البروتوكولات المشهورة                     | الوظيفة                               |
|-------------------|-------------------------------------------|-------------------------------------|
| Application       | HTTP, FTP, SMTP, DNS                      | تصفح الإنترنت، إرسال البريد، نقل الملفات |
| Transport         | TCP, UDP                                 | التحكم في تدفق البيانات، ضمان الوصول   |
| Internet          | IP (IPv4, IPv6), ICMP                    | تحديد العناوين، توجيه البيانات        |
| Network Access    | Ethernet, Wi-Fi, ARP                     | النقل الفيزيائي للبيانات               |

---

## 🔗 الفرق بين OSI و TCP/IP:

| المقارنة            | OSI                                       | TCP/IP                                   |
|--------------------|-----------------------------------------|-----------------------------------------|
| عدد الطبقات        | 7 طبقات                                    | 4 طبقات                                  |
| الأصل              | نظري - لأغراض الفهم والتصميم               | عملي - يُستخدم فعليًا في الشبكات        |
| مرونة التطوير      | معقد للتطبيق                               | بسيط ومرن، ومفتوح للتطوير              |
| الاستخدام الحالي   | للتعليم والمفاهيم العامة                    | في جميع شبكات الإنترنت والأجهزة الحديثة |

---

## 🚀 أهمية بروتوكولات TCP/IP:
1. **التواصل بين جميع أنواع الأجهزة (PC, هواتف, سيرفرات)**.
2. **ضمان توافق الأنظمة المختلفة مع بعضها البعض**.
3. **توفر أدوات وخدمات أساسية (مثل تصفح الويب - HTTP)**.
4. **تدعم الإنترنت العالمي بالكامل**.

---

## 🛠️ ماذا بعد؟
سيتم لاحقًا دراسة:
- الأوامر العملية (مثل: `ping`, `tracert`, `netstat`) لفحص الشبكات.
- أدوار TCP و IP في التحكم بالاتصال وتوجيه البيانات.
- كيفية تحليل حركة الشبكة باستخدام أدوات مثل Wireshark.

---

---

# Introduction to Network Protocols

## 🔍 What is a Protocol?
**A protocol in networks** is a set of rules and standards that govern how data is sent and received between devices over a network.
A protocol specifies:
- How data is structured (encapsulated).
- How a connection is initiated and terminated.
- How errors and data loss are handled.

---

## 🏗️ OSI Model (Reference):
A theoretical model consisting of **7 layers**, defining how data moves from a program to a physical medium:

1. Application
2. Presentation
3. Session
4. Transport
5. Network
6. Data Link
7. Physical

> 📌 However, in practice, the use of the full OSI model is uncommon; rather, it has been simplified into a more practical model.

---

## 🌐 TCP/IP Model (Practical):

The TCP/IP model is used in virtually all modern internet networks and devices.
It consists of **only 4 layers**:

| TCP/IP Layer | OSI Correspondence | Example of its Protocols |

-------|- ... - 🔓 **Open and non-proprietary**, allowing development by anyone.
- 🖥️ Supported by **all operating systems** (Windows, Linux, macOS, Android, iOS).

---

## 🧩 Examples of TCP/IP Protocols:

| Layer | Popular Protocols | Function |
|- ... |--------------------|----------------- ... - The roles of TCP and IP in controlling connections and routing data.
- How to analyze network traffic using tools like Wireshark.

---

### By Abdelwahab Shandy 