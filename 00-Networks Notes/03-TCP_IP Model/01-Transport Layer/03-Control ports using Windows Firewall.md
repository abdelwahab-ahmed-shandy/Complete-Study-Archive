# 🔐 Controlling Open Ports Using Windows Firewall

---

## 🛡️ Network Security Starts with Ports!

### 🎯 Why Should We Close Ports?

| Reason                          | Explanation                                                             |
|---------------------------------|--------------------------------------------------------------------------|
| 🔓 Open Ports = Attack Surface   | Can be exploited by malware or hackers                                  |
| 📉 Reduce Attack Exposure       | Closing unused ports minimizes risk                                      |
| ⚙️ Precise Service Control      | Only necessary ports are left open for valid services                    |

---

## 🔄 Types of Traffic Through Ports

| Type              | Description                                                       |
|-------------------|--------------------------------------------------------------------|
| 🚪 Inbound         | Data coming into the device from the network or the internet       |
| 📤 Outbound        | Data leaving the device to the internet or other network devices   |

---

## 🧱 Windows Firewall – Step-by-Step

1. Open Windows Firewall:
   - Control Panel → Windows Defender Firewall → Advanced Settings

2. Choose rule direction:
   - **Inbound Rule** (incoming traffic)
   - **Outbound Rule** (outgoing traffic)

3. Create a new rule:
   - **Type**: Port  
   - **Protocol**: TCP or UDP  
   - **Port number**: e.g., `21`, `80`, `443`

4. Choose the action:
   - **Block the connection**

5. Scope of application:
   - **Domain**, **Private**, or **Public** (choose based on environment)

6. Naming and documentation:
   - Give the rule a clear name (e.g., `Block FTP Port 21`)  
   - Add a note (e.g., *"Blocked due to security policy – FTP not allowed"*).

---

## 🔍 Best Practices

| Practice                         | Reason                                                                      |
|----------------------------------|-----------------------------------------------------------------------------|
| 📝 Name rules clearly            | Makes it easier to manage later                                             |
| 🧪 Test services after blocking  | Ensure network or app functionality isn’t unintentionally affected         |
| 🌍 Define scope accurately        | Avoid unnecessary blocking (choose Domain / Private / Public carefully)    |
| 🎯 Use IP blocking when needed   | Target specific devices instead of disabling legitimate services globally  |

---

## 📌 Examples of Sensitive Ports to Monitor

| Port | Protocol | Service | Security Note                                       |
|------|----------|---------|-----------------------------------------------------|
| 21   | TCP      | FTP     | Can be exploited to transfer malicious files        |
| 135  | TCP      | RPC     | Known to be used in various attacks                 |
| 3389 | TCP      | RDP     | Must be monitored and secured, especially remotely  |


---

---

---

# 🔐 التحكم في المنافذ باستخدام جدار الحماية في ويندوز

---

## 🛡️ أمان الشبكة يبدأ من البورتات!

### 🎯 لماذا نغلق البورتات؟

| السبب                         | التوضيح                                                            |
|------------------------------|---------------------------------------------------------------------|
| 🔓 البورتات المفتوحة = أبواب للهجمات | يمكن استغلالها من قبل برمجيات خبيثة وهاكرز                        |
| 📉 تقليل السطح المعرض للهجوم         | إغلاق البورتات غير المستخدمة يقلل احتمالات الاختراق               |
| ⚙️ التحكم الدقيق في الخدمات          | نسمح فقط بالبورتات التي تحتاجها الخدمات الحقيقية                  |

---

## 🔄 أنواع حركة البيانات عبر المنافذ

| النوع              | التوضيح                                                   |
|--------------------|------------------------------------------------------------|
| 🚪 واردة (Inbound)  | بيانات تدخل إلى الجهاز من الإنترنت أو الشبكة             |
| 📤 صادرة (Outbound)| بيانات تخرج من الجهاز إلى الشبكة أو الإنترنت             |

---

## 🧱 خطوات استخدام جدار الحماية في ويندوز

1. افتح جدار الحماية:
   - Control Panel → Windows Defender Firewall → Advanced Settings

2. اختر نوع القاعدة:
   - **Inbound Rule** (قواعد الدخول)
   - **Outbound Rule** (قواعد الخروج)

3. أنشئ قاعدة جديدة:
   - **النوع**: Port  
   - **البروتوكول**: TCP أو UDP  
   - **رقم المنفذ**: مثل `21`, `80`, `443`

4. حدد الإجراء:
   - Block the connection (لحظر الاتصال)

5. اختر نطاق التطبيق:
   - Domain – Private – Public (حسب بيئة الشبكة)

6. التسمية والتوثيق:
   - اسم واضح للقاعدة (مثال: `Block FTP Port 21`)
   - ملاحظة توضح السبب (مثال: *"تم الحظر بسبب سياسة الأمان – لا تستخدم FTP"*).

---

## 🔍 أفضل الممارسات

| الممارسة                          | السبب                                                                 |
|----------------------------------|------------------------------------------------------------------------|
| 📝 سمِّ القواعد بوضوح             | لتسهيل إدارتها لاحقًا                                                 |
| 🧪 اختبر الخدمات بعد الحظر         | تأكد من عدم تأثر الأداء أو تجربة المستخدم                            |
| 🌍 حدد النطاق بدقة                | لتجنب حظر خاطئ في بيئة العمل (Domain / Private / Public)            |
| 🎯 استخدم حظر IP عند الضرورة     | لحظر جهاز معين بدلاً من إيقاف الخدمة للجميع                         |

---

## 📌 أمثلة على منافذ يجب الانتباه لها

| المنفذ | البروتوكول | الخدمة | ملاحظات أمنية                              |
|--------|------------|--------|---------------------------------------------|
| 21     | TCP        | FTP    | قد يُستغل لنقل ملفات خبيثة                  |
| 135    | TCP        | RPC    | يُستخدم في بعض الهجمات                      |
| 3389   | TCP        | RDP    | يجب مراقبته وتأمينه خاصة في بيئات العمل     |


---

By Abdelwahab Shandy