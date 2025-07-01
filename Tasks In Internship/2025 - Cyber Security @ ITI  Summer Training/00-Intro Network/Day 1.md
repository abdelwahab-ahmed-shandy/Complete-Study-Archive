# 💡 Why Do We Use IP Address Instead of MAC Address (Even Though MAC is Unique)?

We use an **IP address** because it’s designed for logical addressing and global routing across networks,  
while the **MAC address** is only used to identify devices within a **local network (LAN)**.  
Routers, firewalls, and most internet systems depend on IP addresses for cross-network communication.

---

## 🛠️ Step-by-Step: How Data Moves from Your Device to a Remote Server (Using IP & MAC)

### 🎯 Objective: Access `google.com` from your device

#### 🖥️ Your Device  
- **IP:** `192.168.1.10`  
- **MAC:** `AA:AA:AA:AA:AA:AA`

#### 📶 Home Router  
- **LAN IP:** `192.168.1.1`  
- **WAN IP:** `102.30.50.5`  
- **MAC:** `BB:BB:BB:BB:BB:BB`

#### 🌐 Internet → 🔄 Multiple Routers  
#### 🌍 Google Server  
- **IP:** `142.250.184.206`  
- **MAC:** Not visible from your network

```

[Your Device]
IP: 192.168.1.10
MAC: AA:AA:AA:AA:AA:AA
│
▼
[Home Router]
LAN IP: 192.168.1.1
MAC: BB:BB:BB:BB:BB:BB
│ ⇦ MAC is replaced here
▼
[Internet]
NAT → Public IP: 102.30.50.5
│
▼
[Routers in Internet]
(Ignore MAC, route via IP)
│
▼
[Google Server]
IP: 142.250.184.206
MAC: Not visible to your device

```


---

## 🔍 What Happens at Each Step?

🟢 **1. Device Prepares the Packet:**  
- Source IP: `192.168.1.10`  
- Destination IP: `142.250.184.206`  
- Source MAC: `AA...`  
- Destination MAC: `BB...` (Router)

🟢 **2. Router Receives Packet:**  
- Replaces MAC address for next hop  
- Translates IP (Private → Public) via NAT

🟢 **3. Routers on the Internet:**  
- Ignore MAC addresses  
- Route based on IP addresses

🟢 **4. Server Receives the Packet:**  
- Responds to public IP  
- Doesn’t know your MAC address

📌 **Important Notes:**  
- MAC address never leaves the local network  
- IP address is essential for internet routing  
- Every router hop updates MAC, but keeps the IP intact

---

## 📘 In Detail:

### 1. 🧭 MAC is Local – Not Suitable for Internet Routing  
MAC addresses are used only inside the LAN. Routers cannot route data based on MAC across the internet.

### 2. 🔁 IP Address is Flexible and Routable  
IP addresses can be dynamically assigned (DHCP) and translated (NAT), while MACs are fixed.

### 3. 🧠 Routers Understand IP, Not MAC  
IP is used by routers to move packets across different networks, while MAC is used just in one local segment.

### 4. ✈️ IP Enables Inter-Networking  
Internet = billions of interconnected networks. MAC works only within one. IP connects across many.

### 5. 🔐 Security and Filtering  
Using IP enables powerful features:
- Firewalls
- VPNs
- NAT
- Subnetting
- Port Forwarding

---

## 📊 Comparison Table:

|                     Feature                     |          IP Address           |           MAC Address           |
|:----------------------------------------------:|:-----------------------------:|:-------------------------------:|
| 🌍 Internet Routing                             | ✅ Yes                        | ❌ No                           |
| 🔄 Changeable                                   | ✅ Dynamic or Static          | ❌ Fixed                        |
| 🧱 Layer                                         | Network Layer (Layer 3)      | Data Link Layer (Layer 2)      |
| 🌐 Scope                                         | Global (Cross-network)        | Local (Same LAN only)          |
| 🔧 Used For                                      | NAT, Routing, VPN, DNS, etc. | LAN communication only         |


### BY Abdelwahab Shandy

---

---
# 💡 لماذا نستخدم عنوان الـ IP بدلًا من عنوان الـ MAC رغم أن الأخير لا يتكرر؟

نستخدم عنوان الـ IP لأنه مصمم لتحديد موقع الجهاز على الإنترنت (أي توجيه منطقي عالمي)،  
بينما عنوان الـ MAC يُستخدم فقط لتعريف الجهاز داخل الشبكة المحلية (LAN).  
جميع أجهزة التوجيه (Routers)، الجدران النارية (Firewalls)، والتطبيقات تعتمد على الـ IP للتوجيه بين الشبكات المختلفة.

---

## 🛠️ كيف تنتقل البيانات من جهازك إلى خادم خارجي باستخدام عنواني IP وMAC؟ خطوة بخطوة:

### 🎯 الهدف: الوصول إلى `google.com` من جهازك

#### 🖥️ جهازك  
- **IP:** `192.168.1.10`  
- **MAC:** `AA:AA:AA:AA:AA:AA`

#### 📶 الراوتر  
- **IP خاص (LAN):** `192.168.1.1`  
- **IP عام (WAN):** `102.30.50.5`  
- **MAC:** `BB:BB:BB:BB:BB:BB`

#### 🌐 الإنترنت ← 🔄 عدة راوترات  
#### 🌍 خادم Google  
- **IP:** `142.250.184.206`  
- **MAC:** غير معروف لأن الخادم خارج شبكتك

```

[جهازك]
IP: 192.168.1.10
MAC: AA:AA:AA:AA:AA:AA
│
▼
[الراوتر المنزلي]
LAN IP: 192.168.1.1
MAC: BB:BB:BB:BB:BB:BB
│ ⇦ هنا يتم استبدال عنوان MAC
▼
[الإنترنت]
NAT ← يستخدم IP عام: 102.30.50.5
│
▼
[عدة راوترات]
(تتجاهل MAC وتعتمد على IP فقط)
│
▼
[خادم Google]
IP: 142.250.184.206
MAC: لا يمكن رؤيته من شبكتك

```


---

## 🔍 ماذا يحدث في كل خطوة؟

🟢 **١. جهازك يُعد الحزمة (Packet):**  
- المصدر IP: `192.168.1.10`  
- الوجهة IP: `142.250.184.206`  
- المصدر MAC: `AA...`  
- الوجهة MAC: `BB...` (الراوتر)

🟢 **٢. الراوتر يستلم الحزمة:**  
- يبدّل عنوان MAC  
- يبدّل عنوان IP إلى IP عام باستخدام NAT

🟢 **٣. الإنترنت:**  
- أجهزة التوجيه لا تقرأ MAC  
- تعتمد فقط على IP في التوجيه

🟢 **٤. الخادم يستلم الحزمة:**  
- يرد على عنوان الـ IP  
- لا يعرف MAC الخاص بجهازك، فقط يعرف IP العام للراوتر

📌 **ملاحظات هامة:**  
- عنوان MAC لا يغادر الشبكة المحلية  
- عنوان IP هو الأساس في التوجيه عبر الإنترنت  
- عند كل Hop يتم تبديل MAC، بينما يظل IP ثابتًا

---

## 📘 في التفاصيل:

### 1. 🧭 MAC محلي فقط – غير مناسب للتوجيه العالمي  
MAC يُستخدم فقط داخل الشبكة المحلية، أما أجهزة التوجيه فلا يمكنها استخدامه عبر الإنترنت.

### 2. 🔁 عنوان IP يمكن تغييره بسهولة  
IP مرن وقابل للتوزيع عبر DHCP ويدعم NAT، بينما MAC ثابت ويصعب تغييره.

### 3. 🧠 الراوترات لا تفهم MAC – بل تعتمد على IP  
IP هو العنوان الذي تنتقل به الحزم من جهاز لآخر في الشبكات المختلفة.

### 4. ✈️ IP يعمل عبر الشبكات (Inter-networking)  
بينما MAC فقط داخل الشبكة الواحدة، فلا يمكن توصيل شبكتين مختلفتين باستخدام MAC.

### 5. 🔐 أمان وفلترة:
مع IP يمكن استخدام أدوات الأمان مثل:
- الجدران النارية (Firewall)
- الشبكات الافتراضية الخاصة (VPN)
- التوجيه والتصفية (Routing & Filtering)

---

## 📊 جدول المقارنة:

|                 العنصر                |              IP Address              |              MAC Address             |
|:------------------------------------:|:------------------------------------:|:------------------------------------:|
| 🌍 التوجيه عبر الإنترنت              | ✅ ضروري                             | ❌ غير ممكن                          |
| 🔄 إمكانية التغيير                   | ✅ ممكن (Dynamic)                    | ❌ ثابت                              |
| 📶 الطبقة المستخدمة                   | Network Layer                        | Data Link Layer                      |
| 🌐 مدى الاستخدام                     | عالمي (Global)                       | محلي (Local فقط)                     |
| 🛠️ يُستخدم في:                      | NAT، VPN، DNS، Routing              | التواصل داخل شبكة LAN فقط          |



