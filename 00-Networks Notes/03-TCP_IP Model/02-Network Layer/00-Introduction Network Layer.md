# 🌐 Layer 3 – Network Layer
## TCP/IP Model – Introduction and Core Functions

---

## 📌 What Is the Role of the Network Layer?

Responsible for routing data across different networks using **IP addressing** and forming **data packets**.

---

## 🧱 Core Functions of the Network Layer

| Function                       | Description                                                                 |
|--------------------------------|------------------------------------------------------------------------------|
| 🧩 Segment-to-Packet Conversion | Converts transport layer segments into packets with source and destination IPs |
| 🌍 Addressing                   | Uses IP addresses to identify devices on the network                        |
| 🔁 Routing                      | Determines the best path for packet delivery                               |
| 🛠️ Diagnostics (ICMP)          | Uses protocols like ICMP to test connectivity and detect issues             |

---

## 🔗 Key Protocols in This Layer

| Protocol | Function                                                       |
|----------|----------------------------------------------------------------|
| **IP**   | Handles addressing and routing of data                         |
| **ICMP** | Used for diagnostics and connectivity testing (e.g., `ping`)   |
| **ARP**  | Resolves IP to MAC addresses (bridges Network & Data Link)     |
| **DHCP** | Assigns IP addresses automatically (belongs to Application Layer but impacts this layer) |

---

## 🖥️ How Devices Get an IP Address

| Method            | Benefit                                                      |
|-------------------|--------------------------------------------------------------|
| **Automatic (DHCP)** | Easy to set up, reduces configuration errors              |
| **Manual (Static)**  | Full control, suitable for servers or fixed devices       |

---

## 🚦 Routing – How Data Finds Its Path

| Concept              | Explanation                                                           |
|----------------------|------------------------------------------------------------------------|
| **Routing Table**     | Maintains the best path for each destination address                  |
| **Router**            | Device that forwards packets based on the destination IP              |
| **Routing Protocols** | e.g., RIP, OSPF, EIGRP – dynamically update paths across the network  |

---

## 🛠️ ICMP – The Network Diagnostic Tool

- Used for testing connectivity (`ping`)
- Utilized in tools like `tracert`
- Sends error messages such as:
  - `Destination Unreachable`
  - `Time Exceeded`

---

## ⚠️ ICMP Security Risks

| Attack Type          | Impact                                                            |
|----------------------|--------------------------------------------------------------------|
| **Ping Flood (DoS)** | Overwhelms target with ICMP requests to cause denial of service   |
| **Smurf Attack**     | Exploits broadcast to flood victim with spoofed ICMP replies       |

✅ **Security Tip**: Limit or monitor ICMP using firewall or router configurations.

---

## 💡 Key Concepts Summary

| Concept       | Meaning                                                   |
|---------------|------------------------------------------------------------|
| **IP Address**| Unique digital identity for a device on the network        |
| **Packet**    | Basic data unit at the Network Layer                       |
| **Routing**   | Moving packets between networks                            |
| **ICMP**      | Protocol for testing and troubleshooting network issues    |



---

---

---

# 🌐 الطبقة الثالثة – طبقة الشبكة (Network Layer)
## نموذج TCP/IP – مقدمة والوظائف الأساسية

---

## 📌 ما دور الطبقة الثالثة؟
طبقة مسؤولة عن توجيه البيانات بين الشبكات المختلفة من خلال استخدام **عناوين IP** وتكوين **حزم البيانات (Packets)**.

---

## 🧱 الوظائف الأساسية لطبقة الشبكة

| الوظيفة                         | التوضيح                                                                 |
|----------------------------------|--------------------------------------------------------------------------|
| 🧩 تحويل Segments إلى Packets     | استقبال البيانات من طبقة النقل وإضافة رؤوس تحتوي على IP المصدر والوجهة |
| 🌍 العنونة (Addressing)           | تحديد المواقع على الشبكة باستخدام عناوين IP                             |
| 🔁 التوجيه (Routing)              | تحديد أفضل مسار لنقل الحزم إلى الوجهة النهائية                          |
| 🛠️ التشخيص (ICMP)                 | استخدام بروتوكولات مثل ICMP لفحص الاتصال واكتشاف الأعطال               |

---

## 🔗 أهم البروتوكولات في هذه الطبقة

| البروتوكول | الوظيفة                                                    |
|------------|-------------------------------------------------------------|
| **IP**     | عنونة وتوجيه البيانات                                       |
| **ICMP**   | تشخيص الشبكة واختبار الاتصال (مثل: `ping`)                 |
| **ARP**    | ترجمة عنوان IP إلى MAC (بين طبقتي Network وData Link)     |
| **DHCP**   | توزيع عناوين IP تلقائيًا (من طبقة التطبيقات لكنه مهم هنا) |

---

## 🖥️ كيف يحصل الجهاز على عنوان IP؟

| الطريقة         | الميزة                                       |
|------------------|-----------------------------------------------|
| تلقائيًا (DHCP) | إعداد سهل ويقلل من الأخطاء                   |
| يدويًا (Static) | تحكم كامل – مفيد للخوادم والأجهزة الثابتة    |

---

## 🚦 التوجيه – Routing

| المفهوم             | التوضيح                                                          |
|----------------------|-------------------------------------------------------------------|
| **جدول التوجيه**      | يحدد المسار المناسب لإرسال الحزم إلى كل عنوان وجهة              |
| **الراوتر (Router)** | جهاز يوجه الحزم بناءً على عنوان الوجهة                          |
| **بروتوكولات التوجيه**| مثل RIP, OSPF, EIGRP – لتحديث المسارات ديناميكيًا               |

---

## 🛠️ ICMP – أداة التشخيص الأساسية

- يُستخدم لاختبار الاتصال (مثل الأمر `ping`)
- يُستخدم في أدوات التتبع مثل `tracert`
- يوفّر رسائل مثل:
  - `Destination Unreachable`
  - `Time Exceeded`

---

## ⚠️ مخاطر ICMP

| الهجوم                 | التأثير                                                       |
|--------------------------|----------------------------------------------------------------|
| **Ping Flood (DoS)**     | إغراق الجهاز بطلبات ICMP لتعطيل الخدمة                        |
| **Smurf Attack**         | استغلال بث ICMP لتنفيذ هجوم جماعي باستخدام عدة أجهزة وهمية     |

✅ **الحل الأمني**: تقييد أو مراقبة استخدام ICMP باستخدام الجدار الناري أو إعدادات الراوتر.

---

## 💡 خلاصة المفاهيم الرئيسية

| المفهوم        | المعنى                                             |
|------------------|----------------------------------------------------|
| **IP Address**   | بطاقة تعريف رقمية للجهاز على الشبكة               |
| **Packet**       | وحدة البيانات الأساسية في الطبقة الثالثة          |
| **Routing**      | عملية نقل الحزم بين الشبكات المختلفة              |
| **ICMP**         | بروتوكول لتشخيص الاتصال واكتشاف الأعطال          |
