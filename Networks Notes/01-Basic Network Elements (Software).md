# 🖧 Basic Network Elements (Software)

## TCP/IP Protocol Suite

## ✅ Table of Contents

* TCP/IP Protocol Suite (Expanded)
* Major Protocols in Networking (Detailed)
* OSI vs TCP/IP (Clarified)
* Data Encapsulation (In-depth)
* MAC & IP Addressing (Explained)
* IPv4 Addressing (Deeper Look)
* IP Classes (Analyzed)
* Private vs Public IP (Clarified)
* DHCP & APIPA (Expanded)
* Reserved IPs (Functions)
* NAT (Network Address Translation)
* ARP (Address Resolution Protocol)
* IPv6 Overview (Explained)
* Internet of Things (IoT)
* TCP vs UDP (Comparison)
* Port Numbers & Sockets (Explained)
* Useful Commands (with Examples)


---

## TCP/IP Protocol Suite (Expanded)

TCP/IP is a protocol suite originally developed by the U.S. Department of Defense.

* It is the official standard of the internet.
* Supports communication between different OSs.
* Includes many protocols beyond TCP and IP:

  * HTTP / HTTPS
  * DNS
  * FTP / SFTP
  * SMTP / POP3 / IMAP
  * SSH / Telnet

### Difference between TCP/IP v4 and v6:

* **v4** uses 32-bit addressing (limited → IPv4 exhaustion)
* **v6** uses 128-bit addressing

  * Better support for QoS and security
  * IPSec is built-in

---

## Major Protocols in Networking (Detailed)

| Protocol  | Vendor    | Routable  | Notes                             |
| --------- | --------- | --------- | --------------------------------- |
| TCP/IP    | Open Std  | ✅ Yes     | Core protocol of the internet     |
| IPX/SPX   | Novell    | ✅ Yes     | Previously used in Novell NetWare |
| NetBEUI   | Microsoft | ❌ No      | LAN only, non-routable, very fast |
| AppleTalk | Apple     | ✅ Yes     | Deprecated since macOS X          |
| DLC       | IBM       | ❌ Partial | For old mainframe infrastructure  |

---

## OSI vs TCP/IP (Clarified)

* **OSI Model**: 7-layer theoretical framework
* **TCP/IP Model**: Practical 4-layer model

| OSI Layer        | Description                   | TCP/IP Equivalent |
| ---------------- | ----------------------------- | ----------------- |
| Application (7)  | Applications like browsers    | Application       |
| Presentation (6) | Data format, encryption       | Application       |
| Session (5)      | Session control               | Application       |
| Transport (4)    | Reliable delivery (TCP/UDP)   | Transport         |
| Network (3)      | Routing, IP addressing        | Internet          |
| Data Link (2)    | MAC-level communication       | Network Access    |
| Physical (1)     | Electrical/Physical signaling | Network Access    |

---

## Data Encapsulation (In-depth)

Each layer adds its own header (control info):

```
[Application Data]
   ↓
[+ Transport Header: TCP/UDP]
   ↓
[+ Network Header: IP]
   ↓
[+ Data Link Header: MAC (Ethernet)]
   ↓
[Physical Transmission: 1s & 0s via cable/wireless]
```

---

## MAC & IP Addressing (Explained)

### MAC (Media Access Control):

* Hardcoded on NIC (Network Interface Card)
* Identifies device uniquely on LAN
* Cannot be changed easily

### IP Address:

* Logical address (static/dynamic)
* Used for routing between networks
* Can be changed

---

## IPv4 Addressing (Deeper Look)

* IPv4 = 2³² ≈ 4.29 billion addresses
* Each **octet** = 8 bits → value range 0–255
* Example: `192.168.1.10`

  * Binary: `11000000.10101000.00000001.00001010`

---

## IP Classes (Analyzed)

| Class | Starting Bits | Host Bits | Max Hosts    | Notes                   |
| ----- | ------------- | --------- | ------------ | ----------------------- |
| A     | 0             | 24        | \~16 million | For large networks      |
| B     | 10            | 16        | \~65,000     | Medium-sized networks   |
| C     | 110           | 8         | 254          | Small networks          |
| D     | 1110          | N/A       | Multicast    | Not for host assignment |
| E     | 1111          | N/A       | Experimental | Reserved for research   |

---

## Private vs Public IP (Clarified)

* **Private IPs:**

  * Not directly reachable over internet
  * Used in homes/offices
  * Require NAT to access the internet

* **Public IPs:**

  * Assigned by ISPs
  * Must be globally unique

---

## DHCP & APIPA (Expanded)

### DHCP – Dynamic Host Configuration Protocol:

* Automatically assigns:

  * IP address
  * Subnet mask
  * Default gateway
  * DNS server
* Process (DORA):

  * Discover → Offer → Request → Acknowledge

### APIPA – Automatic Private IP Addressing:

* Used when DHCP is unreachable
* Address range: 169.254.0.1 – 169.254.255.254

---

## Reserved IPs (Functions)

| Usage Type      | Example       | Function                       |
| --------------- | ------------- | ------------------------------ |
| Network ID      | 192.168.1.0   | Identifies the network         |
| Broadcast       | 192.168.1.255 | Send to all devices on subnet  |
| Loopback        | 127.0.0.1     | Test local machine (localhost) |
| Default Gateway | 192.168.1.1   | Router for internet access     |

---

## NAT – Network Address Translation (Detailed)

* Translates between private and public IPs

### Types:

* **Static NAT:** One-to-one mapping
* **Dynamic NAT:** Pool of public IPs
* **PAT:** Port-based translation (many-to-one), most common

---

## ARP – Address Resolution Protocol

* Maps IP address to MAC address on LAN
* Types:

  * ARP Request
  * ARP Reply

**Command:** `arp -a` (view ARP cache)

---

## IPv6 Overview (Explained)

* 128-bit addresses: 2¹²⁸ ≈ 3.4 × 10³⁸ addresses
* Example:

  * Full: `2001:0db8:0000:0000:0000:8a2e:0370:7334`
  * Compressed: `2001:db8::8a2e:370:7334`

### Features:

* No need for NAT
* Built-in IPSec
* Auto-addressing (Stateless)

---

## Internet of Things (IoT)

* Connects everyday devices to the internet

### Requirements:

* Sensors
* Lightweight protocols (e.g., MQTT)
* IPv6 to support many devices

### Risks:

* Security vulnerabilities
* Weak embedded OSs

---

## TCP vs UDP (Comparison)

| Feature     | TCP                             | UDP                    |
| ----------- | ------------------------------- | ---------------------- |
| Connection  | Connection-oriented (handshake) | Connectionless         |
| Reliability | Reliable, guaranteed delivery   | No delivery guarantees |
| Order       | Maintains data order            | No ordering            |
| Use Cases   | Web, Email, FTP, SSH            | Live video, VoIP, DNS  |

---

## Port Numbers & Sockets (Explained)

### Well-known Ports:

* HTTP: 80
* HTTPS: 443
* FTP: 21
* SSH: 22
* SMTP: 25

### Socket:

* Combination of IP + Port
* Example: `192.168.1.5:80` → HTTP request to a device

---

## Useful Commands (with Examples)

| Command              | Function                          | Example Output          |
| -------------------- | --------------------------------- | ----------------------- |
| `ipconfig /all`      | View full network details         | IP, DNS, Gateway        |
| `getmac`             | Display MAC address               | Physical Address        |
| `ping 8.8.8.8`       | Test external connection (Google) | Ping reply              |
| `netstat -an`        | Show all active connections       | TCP/UDP ports           |
| `tracert google.com` | Trace route to server             | Shows intermediate hops |

---

---

---

---

---

# 🖧 عناصر الشبكة الأساسية (البرمجيات)

## مجموعة بروتوكولات TCP/IP

## ✅ الفهرس

* مجموعة بروتوكولات TCP/IP (بتوسع)
* البروتوكولات الأساسية في الشبكات (بتفصيل)
* الفرق بين OSI و TCP/IP (بتوضيح أكثر)
* تغليف البيانات (Data Encapsulation) (تفصيلي)
* العناوين MAC و IP (بتفصيل)
* عنونة IPv4 (شرح أعمق)
* فئات IP (تحليل معمق)
* الفرق بين IP خاص وعام (تفصيل أكثر)
* DHCP و APIPA (بتوسيع)
* العناوين المحجوزة (Reserved IPs) (بتوضيح الوظائف)
* NAT – ترجمة عناوين الشبكة (بتفصيل)
* بروتوكول ARP (تفصيل)
* لمحة عن IPv6 (بتفصيل)
* إنترنت الأشياء (IoT) (بتفصيل)
* الفرق بين TCP و UDP (بتوسيع)
* أرقام المنافذ والمقابس (Port Numbers & Sockets)
* أوامر مفيدة (بأمثلة)

---

## مجموعة بروتوكولات TCP/IP (بتوسع)

تم تطويرها بواسطة وزارة الدفاع الأمريكية.

* تُعد المعيار الأساسي للإنترنت.
* تدعم الاتصال بين أنظمة تشغيل مختلفة.
* تحتوي على العديد من البروتوكولات:

  * HTTP / HTTPS
  * DNS
  * FTP / SFTP
  * SMTP / POP3 / IMAP
  * SSH / Telnet

### الفرق بين TCP/IP v4 و v6:

* **IPv4:** يستخدم 32 بت – محدود (ظهور مشكلة نقص العناوين)
* **IPv6:** يستخدم 128 بت – يدعم جودة الخدمة (QoS) والأمان (IPSec مدمج)

---

## البروتوكولات الأساسية في الشبكات (بتفصيل)

| البروتوكول | المطور      | قابل للتوجيه | الملاحظات                               |
| ---------- | ----------- | ------------ | --------------------------------------- |
| TCP/IP     | معيار مفتوح | ✅ نعم        | الأساسي في الإنترنت                     |
| IPX/SPX    | Novell      | ✅ نعم        | مستخدم سابقًا في أنظمة Novell           |
| NetBEUI    | Microsoft   | ❌ لا         | LAN فقط، سريع جدًا، لا يدعم التوجيه     |
| AppleTalk  | Apple       | ✅ نعم        | تم إيقافه منذ macOS X                   |
| DLC        | IBM         | ❌ جزئي       | يُستخدم في الأنظمة القديمة (mainframes) |

---

## الفرق بين OSI و TCP/IP (بتوضيح أكثر)

* **OSI:** نموذج نظري يتكوّن من 7 طبقات
* **TCP/IP:** نموذج عملي يتكوّن من 4 طبقات ويؤدي نفس الوظائف

| طبقة OSI         | الوصف                          | ما يقابلها في TCP/IP |
| ---------------- | ------------------------------ | -------------------- |
| Application (7)  | التطبيقات (مثل المتصفح)        | Application          |
| Presentation (6) | تنسيق البيانات والتشفير        | Application          |
| Session (5)      | إدارة الجلسات                  | Application          |
| Transport (4)    | نقل موثوق للبيانات             | Transport            |
| Network (3)      | التوجيه، IP                    | Internet             |
| Data Link (2)    | الوصول للوسيط                  | Network Access       |
| Physical (1)     | الإشارات الكهربائية/الفيزيائية | Network Access       |

---

## تغليف البيانات (Data Encapsulation)

كل طبقة تضيف Header (معلومات التحكم):

```
[بيانات التطبيق]
   ↓
[+ رأس النقل: TCP/UDP]
   ↓
[+ رأس الشبكة: IP]
   ↓
[+ رأس ربط البيانات: MAC]
   ↓
[نقل فيزيائي: 1s و 0s عبر الكابل أو اللاسلكي]
```

---

## العناوين MAC و IP (بتفصيل)

### MAC:

* عنوان ثابت، مدمج في كرت الشبكة
* يحدد الجهاز بشكل فريد في الشبكة المحلية
* لا يمكن تغييره بسهولة

### IP:

* عنوان منطقي، يمكن تغييره
* يُستخدم لتحديد الموقع المنطقي للجهاز في الشبكة
* يُستخدم في التوجيه بين الشبكات

---

## عنونة IPv4 (شرح أعمق)

* IPv4 = $2^{32}$ ≈ 4.29 مليار عنوان
* كل جزء (Octet) = 8 بت → من 0 إلى 255
* مثال: `192.168.1.10` ⇨ ثنائيًا: `11000000.10101000.00000001.00001010`

---

## فئات IP (تحليل معمق)

| الفئة | أول بتات | بتات المضيف | عدد الأجهزة | الملاحظات            |
| ----- | -------- | ----------- | ----------- | -------------------- |
| A     | 0        | 24          | \~16 مليون  | للشبكات الكبيرة      |
| B     | 10       | 16          | \~65 ألف    | للشبكات المتوسطة     |
| C     | 110      | 8           | 254         | للشبكات الصغيرة      |
| D     | 1110     | -           | بث متعدد    | للبث فقط (Multicast) |
| E     | 1111     | -           | تجريبي      | غير مستخدم غالبًا    |

---

## الفرق بين IP خاص وعام (تفصيل أكثر)

### IP خاص:

* غير متاح للإنترنت مباشرة
* يُستخدم داخل الشبكات الداخلية
* يعمل مع NAT

### IP عام:

* يتم تخصيصه من قبل مزود الخدمة (ISP)
* يجب أن يكون فريدًا عالميًا

---

## DHCP و APIPA (بتوسيع)

### DHCP:

* يوزع:

  * عنوان IP
  * قناع الشبكة (Subnet Mask)
  * بوابة الشبكة (Gateway)
  * DNS

**خطوات العمل (DORA):**

* Discover → Offer → Request → Acknowledge

### APIPA:

* يُستخدم عند فشل DHCP
* النطاق: 169.254.0.1 – 169.254.255.254

---

## العناوين المحجوزة (Reserved IPs)

| نوع الاستخدام   | مثال          | الوظيفة                        |
| --------------- | ------------- | ------------------------------ |
| Network ID      | 192.168.1.0   | يحدد عنوان الشبكة              |
| Broadcast       | 192.168.1.255 | إرسال لجميع الأجهزة بالشبكة    |
| Loopback        | 127.0.0.1     | اختبار الجهاز نفسه (localhost) |
| Default Gateway | 192.168.1.1   | بوابة الخروج إلى الإنترنت      |

---

## NAT – ترجمة عناوين الشبكة (بتفصيل)

* ترجمة بين IP خاص و IP عام

### الأنواع:

* Static NAT: جهاز واحد ⇆ IP عام محدد
* Dynamic NAT: مجموعة أجهزة ⇆ مجموعة IP عام
* PAT: الأكثر شيوعًا – جميع الأجهزة تستخدم IP واحد مع بورتات مختلفة

---

## ARP – بروتوكول تحليل العناوين

* يُستخدم للحصول على عنوان MAC مقابل عنوان IP
* يُستخدم داخل الشبكات المحلية (LAN)
* أنواع:

  * ARP Request
  * ARP Reply

**أمر مفيد:** `arp -a` لعرض الكاش الحالي

---

## لمحة عن IPv6 (بتفصيل)

* يستخدم 128-بت ⇒ $2^{128}$ ≈ 3.4 × 10³⁸ عنوان

**مثال:**

* كامل: `2001:0db8:0000:0000:0000:8a2e:0370:7334`
* مختصر: `2001:db8::8a2e:370:7334`

**مميزات:**

* لا حاجة لـ NAT
* الأمان مدمج (IPSec)
* ضبط ذاتي للعناوين

---

## إنترنت الأشياء (IoT) (بتفصيل)

* توصيل الأجهزة اليومية بالإنترنت

**المتطلبات:**

* حساسات
* بروتوكولات خفيفة مثل MQTT
* IPv6

**المخاطر:**

* ضعف الأمان
* كثرة الثغرات

---

## الفرق بين TCP و UDP (بتوسيع)

| الميزة      | TCP                      | UDP                 |
| ----------- | ------------------------ | ------------------- |
| الاتصال     | يتطلب اتصال              | بدون اتصال          |
| الضمان      | يضمن التسليم             | لا يضمن             |
| الترتيب     | يحافظ على ترتيب البيانات | لا يهتم بالترتيب    |
| الاستخدامات | ويب، إيميل، FTP، SSH     | بث مباشر، VoIP، DNS |

---

## أرقام المنافذ والمقابس (Ports & Sockets)

### أشهر المنافذ:

* HTTP: 80
* HTTPS: 443
* FTP: 21
* SSH: 22
* SMTP: 25

### Socket:

* \= عنوان IP + منفذ
* مثال: `192.168.1.5:80` ⇨ طلب HTTP لجهاز معين

---

## أوامر مفيدة (بأمثلة)

| الأمر              | الوظيفة                    | مثال               |
| ------------------ | -------------------------- | ------------------ |
| ipconfig /all      | عرض كل تفاصيل الشبكة       | IP, DNS, Gateway   |
| getmac             | عرض عنوان MAC              | Physical Address   |
| ping 8.8.8.8       | اختبار الاتصال بجوجل       | اختبار خارجي       |
| netstat -an        | عرض الجلسات النشطة         | TCP/UDP Ports      |
| tracert google.com | تتبع المسار إلى سيرفر معين | عرض القفزات (Hops) |


---

*By: Abdelwahab Shandy*
