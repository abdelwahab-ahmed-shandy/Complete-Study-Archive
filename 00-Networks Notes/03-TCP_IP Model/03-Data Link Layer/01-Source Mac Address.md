# 🧾 Source MAC Address – Layer 2 Concept

---

## 📌 Basic Definition
The **MAC address** is a unique **48-bit (6-byte)** physical identifier assigned to every **Network Interface Card (NIC)**.  
It’s used in the **Data Link Layer (Layer 2)** to ensure accurate delivery of data within the **local area network (LAN)**.

---

## 🧠 Overview of the Concept

| Element     | Explanation                                                                |
|-------------|----------------------------------------------------------------------------|
| 🔑 Definition | Globally unique identifier for each NIC used for local communication       |
| 📏 Length    | 48 bits (6 bytes) – typically displayed as 6 hexadecimal pairs (e.g., `00-1A-2B-3C-4D-5E`) |
| 🏭 Source    | Assigned by manufacturers registered with IEEE                            |
| 🧩 Structure | First 3 bytes = OUI (manufacturer), last 3 bytes = device serial number     |

---

## 🖥️ How to Find Your MAC Address

### On Windows:
```bash
ipconfig /all
getmac

### On Linux:
```bash
ip a
ifconfig

### Using ARP Table:
```bash
arp -a

📌 Shows recently connected devices in your local network along with their IP and MAC addresses.

### 📡 Multiple Interfaces = Multiple MAC Addresses

| Interface Type | MAC Address Description             |
| -------------- | ----------------------------------- |
| Ethernet (LAN) | Static – used for wired connections |
| Wi-Fi (WLAN)   | Different from LAN card             |
| Bluetooth      | Has its own MAC address             |

Each interface on a device has its own unique MAC address.

### 🛡️ MAC Address and Network Security

| Use Case                   | Explanation                                                      |
| -------------------------- | ---------------------------------------------------------------- |
| 🎯 Device Tracking         | Identifies connected devices in the local network                |
| 🔒 MAC Filtering           | Used to allow or block specific devices via routers or firewalls |
| 🔍 Forensic Investigations | Helps trace the source of network activity or attacks            |

⚠️ Warning:
Malware may spoof the MAC address to bypass security restrictions (MAC Spoofing).

### 🔄 Can the MAC Address Be Changed?

| Aspect              | Reality                                                               |
| ------------------- | --------------------------------------------------------------------- |
| 🧪 Temporary Change | Yes – can be modified via software (for testing or privacy)           |
| 🔩 Permanent Change | No – the original is burned into the device by the manufacturer (BIA) |
| 🛠 Tools            | Windows: Device Manager / Linux: `macchanger`                         |


### 🧭 Identify Manufacturer Using MAC (OUI)
The first 3 bytes = OUI (Organizationally Unique Identifier)

Example:
00-1A-2B → belongs to Cisco Systems

🔍 Useful Tools:

https://macvendors.com

https://aruljohn.com/mac.pl

### 💡 Summary Points

✅ MAC address is a unique physical identifier used within local networks.
✅ Assigned by the manufacturer, globally unique.
✅ Used in Layer 2 to build frames for local communication.
✅ Easily viewable via OS commands.
✅ May be exploited or spoofed, so understanding it is crucial for network security.

---

---

---

# 🧾 عنوان MAC المصدر – مفهوم من الطبقة الثانية (Layer 2)

---

## 📌 التعريف الأساسي
عنوان MAC هو معرف فيزيائي فريد يتكون من **48 بت (6 بايت)**، يُستخدم لتمييز كل بطاقة شبكة (NIC) داخل الشبكة المحلية (LAN).  
يُضاف هذا العنوان إلى الإطارات (Frames) في **طبقة ربط البيانات (Data Link Layer)** لضمان وصول البيانات إلى الجهاز المستهدف بدقة داخل نفس الشبكة.

---

## 🧠 نظرة شاملة على المفهوم

| العنصر     | التوضيح                                                                 |
|------------|--------------------------------------------------------------------------|
| 🔑 التعريف | معرف فريد عالميًا لكل كرت شبكة يُستخدم للتواصل داخل الشبكات المحلية      |
| 📏 الطول   | 48 بت = 6 بايت – يُعرض كـ 6 أزواج هيكساديسمل (مثل: `00-1A-2B-3C-4D-5E`) |
| 🏭 المصدر  | يُخصص من الشركات المصنعة المُسجلة لدى IEEE                              |
| 🧩 الهيكل   | أول 3 بايت = OUI (رمز الشركة) – آخر 3 بايت = رقم تسلسلي للجهاز           |

---

## 🖥️ كيفية الحصول على عنوان MAC

### في Windows:
```bash
ipconfig /all
getmac

في Linux:
```bash
ip a
ifconfig
باستخدام ARP:
```bash
arp -a
📌 يُظهر عناوين MAC للأجهزة المتصلة بالشبكة المحلية التي تواصلت معها مؤخرًا.

### 📡 تعدد بطاقات الشبكة = تعدد عناوين MAC
نوع البطاقة	عنوان MAC
Ethernet (LAN)	ثابت ومخصص للاتصال السلكي
Wi-Fi (WLAN)	مختلف عن كارت LAN
Bluetooth	له MAC خاص أيضًا

كل واجهة اتصال بالجهاز تمتلك عنوان MAC خاص بها.

### 🛡️ عنوان MAC وأمن الشبكات
الفائدة	التوضيح
🎯 تتبّع الأجهزة	يُستخدم لمعرفة الأجهزة المتصلة محليًا
🔒 تصفية الوصول (MAC Filter)	يُستخدم في الراوترات لمنع أو السماح لأجهزة محددة
🔍 التحقيق الجنائي الشبكي	يُساعد في تعقب مصدر الاتصالات في حالة الهجمات أو النشاط المشبوه

⚠️ تنبيه:
بعض البرمجيات الخبيثة قد تُغير عنوان MAC برمجيًا (MAC Spoofing) لتجاوز السياسات الأمنية.

### 🔄 هل يمكن تغيير عنوان MAC؟
الجانب	الحقيقة
🧪 تغيير مؤقت	نعم – ممكن برمجيًا (للاختبار أو الخصوصية)
🔩 تغيير دائم	لا – العنوان محفور بالجهاز (BIA – Burned-In Address)
🛠️ أدوات التعديل	Device Manager (Windows) / macchanger (Linux)

### 🧭 تحديد الشركة المُصنّعة عبر OUI
أول 3 بايت من عنوان MAC = OUI (Organizationally Unique Identifier)

مثال:
00-1A-2B → تخص شركة Cisco Systems

🔍 أدوات مساعدة:

https://macvendors.com

https://aruljohn.com/mac.pl

### 💡 خلاصة تعليمية
✅ عنوان MAC معرف فيزيائي فريد للجهاز داخل الشبكة.
✅ لا يتكرر عالميًا ويُستخدم للتوجيه المحلي فقط.
✅ يُضاف في طبقة البيانات (Layer 2) داخل الإطار (Frame).
✅ يمكن فحصه بسهولة عبر أوامر النظام.
✅ قد يُستخدم في بعض الهجمات مثل MAC Spoofing، لذا فهمه أساسي في أمن الشبكات.

