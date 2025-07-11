## 📌 أولاً: ما هو DHCP؟

**DHCP (Dynamic Host Configuration Protocol)** هو بروتوكول يُستخدم لتوزيع معلومات الشبكة تلقائيًا للأجهزة مثل:

- **IP Address**
- **Subnet Mask**
- **Default Gateway**
- **DNS Server**
---
## ⚙️ ثانياً: عملية DORA – دورة عمل DHCP

اسم العملية "DORA" هو اختصار لأربع خطوات بين العميل (Client) والمزود (DHCP Server):

| الخطوة                 | التفسير                                             |
| ---------------------- | --------------------------------------------------- |
| **D = Discover**       | يرسل العميل بثًا (Broadcast) للبحث عن أي سيرفر DHCP |
| **O = Offer**          | يرد السيرفر بعرض IP                                 |
| **R = Request**        | العميل يطلب رسميًا هذا الـ IP                       |
| **A = Acknowledgment** | يوافق السيرفر ويُرسِل تفاصيل التكوين                |

### 🖥️ **مثال عملي (باكيت تراسر)**:

1. اربط PC مع سويتش.
2. اربط السويتش براوتر.    
3. فعّل DHCP على الراوتر:

```
Router(config)# interface f0/0

Router(config-if)# ip address 192.168.1.1 255.255.255.0

Router(config-if)# no shutdown

Router(config)# ip dhcp pool MYPOOL

Router(dhcp-config)# network 192.168.1.0 255.255.255.0

Router(dhcp-config)# default-router 192.168.1.1

Router(dhcp-config)# dns-server 8.8.8.8

Router(dhcp-config)# exit

Router(config)# ip dhcp excluded-address 192.168.1.1 192.168.1.10
```
---
## 🧩 ثالثاً: أنواع بناء DHCP

### 1. ✅ DHCP باستخدام الراوتر (Router DHCP)

- جيد للشبكات الصغيرة.
- سهل التكوين وسريع.    
- يستخدم أوامر كما سبق بالأعلى.

### 2. ✅ DHCP باستخدام سيرفر مخصص (DHCP Server)

- أكثر احترافًا وتحكمًا.
- مناسب للشبكات الكبيرة (مثلاً: شركات).
- يتيح:
    - حجز IPs.
    - إعدادات لكل VLAN.
    - تخصيص DNS وغيرها.

### 🖥️ **مثال عملي (Packet Tracer):**

![[Pasted image 20250709200754.png]]

## 🧱 **الشبكة الأولى (باستخدام الراوتر كـ DHCP Server)**

### 🎯 **الإعدادات المطلوبة**:

- **Network**: 192.168.1.0/24
- **Gateway**: 192.168.1.1
- **DNS**: 192.168.1.50
- **Excluded IPs**: من 192.168.1.2 إلى 192.168.1.40
- **DHCP Scope Name**: مثلاً `LAN1`

## 🛠️ **الخطوات:**

#### ✅ 1. إعداد الراوتر:

	ادخل على الراوتر > CLI

```
enable
configure terminal

! استبعاد بعض العناوين
ip dhcp excluded-address 192.168.1.2 192.168.1.40

! إنشاء DHCP Pool
ip dhcp pool LAN1
 network 192.168.1.0 255.255.255.0
 default-router 192.168.1.1
 dns-server 192.168.1.50

! إعداد عنوان الواجهة
interface GigabitEthernet0/0
 ip address 192.168.1.1 255.255.255.0
 no shutdown

exit
```

#### ✅ 2. إعداد PC5:

- من نافذة الجهاز (PC5):
    - Interface → FastEthernet → DHCP
    - سيتم استلام IP تلقائيًا من الراوتر إذا كل شيء مضبوط

## 🧱 **الشبكة الثانية (باستخدام DHCP Server مستقل)**

### 🎯 **الإعدادات المطلوبة**:

- **Network**: 10.0.0.0/8
- **Gateway**: 10.0.0.1
- **DNS**: 8.8.8.8
### 🛠️ **الخطوات:**

#### ✅ 1. إعداد السيرفر (Server0):

- الزر في وضع **ON**
- الإعدادات مكتملة:

```
Pool Name: LAN2 (أي اسم)
Default Gateway: 10.0.0.1
DNS Server: 8.8.8.8
Starting IP Address: 10.0.0.2
Subnet Mask: 255.0.0.0
Maximum Number of Users: 50 (مثلاً)
```

🟢 اضغط **Save** بعد إدخال البيانات.

### 2. ✅ **تأكد من أن السيرفر نفسه مهيّأ يدويًا بشكل صحيح**

افتح: `Server > Desktop > IP Configuration`

تأكد من التالي:

```
IP Address: 10.0.0.1
Subnet Mask: 255.0.0.0
Default Gateway: 10.0.0.1
DNS Server: 8.8.8.8
```

#### ✅ 2. إعداد PC5 (1):

- Interface → FastEthernet → DHCP
- يجب أن يستقبل IP من السيرفر مثل 10.0.0.2
#### ✅ 3. إعداد Switch4(1):

لا حاجة لإعدادات خاصة على السويتش، فقط تأكد أن الأجهزة متصلة بنفس السويتش.
## ✅ **اختبار الاتصال:**

- من كل PC جرب تعمل:
```
ipconfig
ping 8.8.8.8
ping Default Gateway
```

---
---
## 🔒 رابعاً: DHCP Spoofing – الهجوم على DHCP

### 📌 ما هو؟

هجوم يقوم به المهاجم من خلال:

- وضع **DHCP Server مزيف** على الشبكة.
- إعطاء **IP خاطئ** و**Gateway مزور** للضحية.
- بعدها يستطيع المهاجم عمل:
    - **Man-in-the-middle attack**
    - **تنصت (Sniffing)**
    - **إعادة توجيه الضحية لمواقع مزيفة**

---
## 🛡 خامساً: الحماية من DHCP Spoofing

### 🛑 الحل: تمكين خاصية DHCP Snooping على السويتش

### ✅ ماذا تفعل DHCP Snooping؟

- تميز بين المنافذ "الموثوقة" (trusted) و"غير الموثوقة" (untrusted).    
- تمنع الأجهزة على المنافذ غير الموثوقة من إرسال رسائل DHCP Offer.
### 🛠 الخطوات العملية على السويتش:
```
Switch(config)# ip dhcp snooping

Switch(config)# ip dhcp snooping vlan 1

! حدد المنفذ الموثوق (الذي يتصل بالسيرفر أو الراوتر)
Switch(config)# interface fa0/1

Switch(config-if)# ip dhcp snooping trust

! المنافذ الأخرى تظل untrusted تلقائيًا
```

---
## 🧪 سادساً: أمثلة واقعية وتمارين Packet Tracer

### 📁 Lab 1: DHCP from Router

1. راوتر ← سويتش ← 2 PC
2. فعّل DHCP على الراوتر.
3. تأكد أن كل PC يحصل على IP تلقائيًا.

### 📁 Lab 2: DHCP from Server + VLAN

1. سويتش به VLAN 10 وVLAN 20.
2. سيرفر DHCP موصل بمنفذ موثوق.
3. عدّل السيرفر ليقدم DHCP لكل VLAN.    

### 📁 Lab 3: Attack Simulation

1. ضع PC يمثل "المهاجم" مع DHCP Server وهمي.
2. شاهد كيف يحصل PC آخر على IP مزيف.
3. فعّل DHCP Snooping وأعد المحاولة.

## 🧠 نصائح إضافية لفهم الموضوع بعمق:

- 🧪 جرب كل سيناريو في Packet Tracer بنفسك.
- 📄 راقب رسائل DORA باستخدام **Wireshark**.
- 🛡 تعلم كيف يمكن الدمج بين DHCP Snooping و**Port Security**.

## 🧷 ملخص سريع

|العنصر|الهدف|
|---|---|
|DHCP من الراوتر|مناسب للشبكات الصغيرة|
|DHCP من سيرفر|احترافي وأكثر تحكمًا|
|DORA|خطوات التفاوض بين الجهاز والسيرفر|
|DHCP Spoofing|هجوم يمنح IP مزيف|
|DHCP Snooping|الحماية منه بتحديد المنافذ الموثوقة|

---
	Abdelwahab Shandy