# 🛠️ Port Scanning – فحص المنافذ في الشبكات

---

## 🔢 ما هو رقم المنفذ (Port Number)؟

رقم المنفذ هو رقم منطقي يُستخدم لتوجيه البيانات إلى الخدمة المناسبة داخل جهاز معين.

> **مثال**: الجهاز يستقبل بيانات على IP `192.168.1.10`، والمنفذ `21` = خدمة **FTP**

---

## 🎯 لماذا نستخدم فحص المنافذ؟

| الهدف              | التوضيح                                                                 |
|---------------------|--------------------------------------------------------------------------|
| 🔍 كشف الخدمات النشطة | معرفة ما إذا كانت خدمات مثل SSH، FTP، HTTP قيد التشغيل                    |
| 🔐 تعزيز الأمان       | إغلاق المنافذ غير المستخدمة لتقليل سطح الهجوم                          |
| 🛠️ التأكد من الأداء   | التحقق من أن الخدمات الضرورية تعمل على البورتات الصحيحة                 |

---

## 📦 أنواع البورتات

| الفئة                | النطاق           | الاستخدام                                      |
|----------------------|------------------|------------------------------------------------|
| **Well-known Ports** | 0 – 1023         | خدمات معروفة مثل HTTP (80)، FTP (21)          |
| **Registered Ports** | 1024 – 49151     | تطبيقات مُسجّلة مثل MySQL (3306)              |
| **Dynamic / Private**| 49152 – 65535    | مستخدمة مؤقتًا أو من قبل التطبيقات الديناميكية |

---

## 🔍 أدوات فحص البورتات

| الأداة                | الاستخدام                                                  |
|------------------------|-------------------------------------------------------------|
| `nmap`                | أداة قوية لفحص المنافذ والأجهزة في الشبكة                   |
| `netstat`             | مراقبة الاتصالات النشطة والبورتات المفتوحة                 |
| **برامج واجهة رسومية** | مثل **Zenmap** (واجهة رسومية لـ nmap)                      |

---

## ✅ مثال عملي – فحص FTP على المنفذ 21

```bash
nmap -p 21 192.168.1.10

🔄 يعرض ما إذا كانت خدمة FTP تعمل على هذا الجهاز


🌐 فحص شبكة كاملة

```
nmap -p 20-100 192.168.1.0/24
```
🔎 يفحص البورتات من 20 إلى 100 لكل جهاز في هذا النطاق


📡 TCP vs UDP في الفحص

| البروتوكول   | الخصائص                                     |
| ------------ | ------------------------------------------- |
| **TCP Scan** | موثوق – يتطلب استجابة من الخدمة             |
| **UDP Scan** | أصعب في الفحص – لا يُظهر دائمًا نتائج واضحة |


🛡️ الأمن وفحص البورتات

| التهديد                     | الإجراء                             |
| --------------------------- | ----------------------------------- |
| بورت مفتوح بدون خدمة        | أغلقه فورًا                         |
| خدمة قديمة على بورت معروف   | حدّثها أو أزلها إن لم تكن مستخدمة   |
| فحص من مصدر خارجي غير معروف | تحقق من الـ IP واحظر الاتصال إن لزم |

🔍 أنواع فحص nmap الشائعة
nmap يدعم عدة أنواع من الفحص تساعد في كشف المنافذ وحالة الجهاز المستهدف بناءً على طريقة التفاعل مع المنافذ

| نوع الفحص       | الأمر المستخدم | الوصف                                                      |
| --------------- | -------------- | ---------------------------------------------------------- |
| **SYN Scan**    | `-sS`          | (الأكثر شيوعًا) يرسل حزمة SYN دون إكمال الاتصال (Stealthy) |
| **TCP Connect** | `-sT`          | يستخدم الاتصال الكامل 3-Way Handshake                      |
| **UDP Scan**    | `-sU`          | يفحص خدمات الـ UDP غير المستندة إلى اتصال                  |
| **ACK Scan**    | `-sA`          | يحدد حالة الجدار الناري (Firewall)                         |
| **XMAS Scan**   | `-sX`          | يرسل حزم TCP بها جميع الأعلام مفعّلة - لكشف أنظمة معينة    |
| **NULL Scan**   | `-sN`          | لا يضع أي أعلام في رأس TCP - للكشف عن رد فعل الجهاز الصامت |
| **FIN Scan**    | `-sF`          | يرسل فقط حزمة FIN - يخدع بعض أنظمة التشغيل القديمة         |


---

---

---

# 🛠️ Port Scanning in Networks

---

## 🔢 What is a Port Number?

A port number is a logical identifier used to direct data to the appropriate service within a device.

> **Example**: A device receiving data at IP `192.168.1.10` on port `21` = **FTP service**

---

## 🎯 Why Do We Use Port Scanning?

| Purpose             | Description                                                        |
|---------------------|--------------------------------------------------------------------|
| 🔍 Discover Services | Identify if services like SSH, FTP, HTTP are running              |
| 🔐 Security Hardening| Close unused ports to reduce the attack surface                   |
| 🛠️ Performance Check| Ensure necessary services are running on their proper ports        |

---

## 📦 Types of Ports

| Category              | Range           | Usage                                          |
|------------------------|------------------|------------------------------------------------|
| **Well-known Ports**   | 0 – 1023         | Common services like HTTP (80), FTP (21)       |
| **Registered Ports**   | 1024 – 49151     | Registered applications like MySQL (3306)      |
| **Dynamic/Private**    | 49152 – 65535    | Temporary or dynamic use by applications       |

---

## 🔍 Port Scanning Tools

| Tool                 | Usage                                                           |
|----------------------|-----------------------------------------------------------------|
| `nmap`               | A powerful tool for scanning ports and devices in the network   |
| `netstat`            | Monitor active connections and open ports                      |
| **GUI Tools**        | Like **Zenmap**, a graphical interface for `nmap`              |

---

## ✅ Practical Example – FTP Scan on Port 21

```bash
nmap -p 21 192.168.1.10

🔄 Checks if FTP service is running on the specified host.

🌐 Scanning a Whole Network
```
nmap -p 20-100 192.168.1.0/24
```
🔎 Scans ports from 20 to 100 on all devices in the subnet.

📡 TCP vs UDP Scans

| Protocol     | Features                                      |
| ------------ | --------------------------------------------- |
| **TCP Scan** | Reliable – requires response from the service |
| **UDP Scan** | Harder – doesn't always give clear results    |


🛡️ Security and Port Scanning

| Threat                         | Action                                    |
| ------------------------------ | ----------------------------------------- |
| Open port without a service    | Close it immediately                      |
| Outdated service on known port | Update or remove the service              |
| Scan from unknown external IP  | Investigate and block the IP if necessary |


🔍 Common nmap Scan Types

| Scan Type       | Command | Description                                                  |
| --------------- | ------- | ------------------------------------------------------------ |
| **SYN Scan**    | `-sS`   | Most common – sends SYN packet without completing connection |
| **TCP Connect** | `-sT`   | Uses full 3-Way Handshake                                    |
| **UDP Scan**    | `-sU`   | Scans for non-connection-based UDP services                  |
| **ACK Scan**    | `-sA`   | Used to determine firewall presence                          |
| **XMAS Scan**   | `-sX`   | Sends TCP packets with all flags set                         |
| **NULL Scan**   | `-sN`   | Sends TCP packets with no flags – detects silent systems     |
| **FIN Scan**    | `-sF`   | Sends FIN only – bypasses some older systems                 |


---

by Abdelwahab Shandy