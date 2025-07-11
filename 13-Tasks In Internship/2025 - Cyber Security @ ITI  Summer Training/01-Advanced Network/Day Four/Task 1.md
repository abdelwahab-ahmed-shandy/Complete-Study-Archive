
![[Pasted image 20250709101319.png]]

	- الشبكة الأولى (أعلى الصورة): تستخدم راوتر كخادم DHCP. 
	- الشبكة الثانية (أسفل الصورة): تستخدم سيرفر كخادم DHCP.

## 🧱 **الشبكة الأولى (باستخدام الراوتر كـ DHCP Server)**

### 🎯 **الإعدادات المطلوبة**:

- **Network**: 192.168.1.0/24
- **Gateway**: 192.168.1.1
- **DNS**: 192.168.1.50
- **Excluded IPs**: من 192.168.1.2 إلى 192.168.1.40
- **DHCP Scope Name**: مثلاً `LAN1`
---
### 🛠️ **الخطوات:**

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
    - سيتم استلام IP تلقائيًا من الراوتر إذا كل شيء مضبوط.

---
---
---
## 🧱 **الشبكة الثانية (باستخدام DHCP Server مستقل)**

### 🎯 **الإعدادات المطلوبة**:
- **Network**: 10.0.0.0/8
- **Gateway**: 10.0.0.1    
- **DNS**: 8.8.8.8

### 🛠️ **الخطوات:**

#### ✅ 1. إعداد السيرفر (Server0):

- افتح Server0 > Services > DHCP    
- اضغط على **DHCP** من القائمة الجانبية:

```
Pool Name: LAN2
Default Gateway: 10.0.0.1
DNS Server: 8.8.8.8
Starting IP Address: 10.0.0.2
Subnet Mask: 255.0.0.0
Maximum Number of Users: 50 (مثلاً)
```
	اضغط على ON لتشغيل الخدمة.
---
### 2. ✅ **تأكد من أن السيرفر نفسه مهيّأ يدويًا بشكل صحيح**

افتح: `Server > Desktop > IP Configuration`

تأكد من التالي:
```
IP Address: 10.0.0.1
Subnet Mask: 255.0.0.0
Default Gateway: 10.0.0.1
DNS Server: 8.8.8.8
```

### 3. ✅ **تأكد من التوصيلات بين الأجهزة**:

- استخدم **Copper Straight-Through** في توصيل:
    - PC إلى Switch        
    - Server إلى Switch

🟢 افتح السويتش وتأكد أن المنافذ ليس عليها علامة × أو سهم أحمر.

---
#### ✅ 4. إعداد PC5 (1):

- Interface → FastEthernet → DHCP
- يجب أن يستقبل IP من السيرفر مثل 10.0.0.2

#### ✅ 5. إعداد Switch4(1):

لا حاجة لإعدادات خاصة على السويتش، فقط تأكد أن الأجهزة متصلة بنفس السويتش.

---
## ✅ **اختبار الاتصال:**

- من كل PC جرب تعمل:
```
ipconfig
ping 8.8.8.8
ping Default Gateway
```

---
----
---
### إذًا الجهاز لا يرى السيرفر أصلًا → تحقق من الكابلات والبورتات :

### ✅ **أعد طلب IP من DHCP**:

من الـ PC:

```
ipconfig /release
ipconfig /renew
```
	أو من واجهة `IP Configuration` اختَر DHCP.

### ✅ **احذف APIPA يدويًا وارجع لطلب DHCP**:

- في `IP Configuration`: اضغط على **Static** ثم ارجع إلى **DHCP**
    
- أو اضغط زر **DHCP** مرتين