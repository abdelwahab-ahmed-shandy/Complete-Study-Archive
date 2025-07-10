
هذا **اللّاب العملي الكامل** لك **من البداية إلى النهاية**، مع **كل التفاصيل الصغيرة** وشرح شامل، خطوة بخطوة، وكأنك تبنيه بنفسك لأول مرة. هذا اللاب سيغطي:

✅ إعداد الشبكة  
✅ تفعيل DHCP (راوتر وسيرفر)  
✅ حماية DHCP بـ DHCP Snooping  
✅ ACL (Standard + Extended)  
✅ Access-class للتحكم في Telnet  
✅ اختبار DORA  
✅ ACL لفلترة الخدمات (HTTP - FTP - DNS - ICMP)  
✅ سيناريو هجوم DHCP Spoofing  
✅ التحقق النهائي من كل شيء

---
# 🔧 **اللاب الكامل: ACL + DHCP + Snooping + Security**

---

## 🔹 المرحلة 1: إعداد الأجهزة والتوصيلات

### ✅ الأجهزة:

- 1 راوتر (Router)
- 1 سويتش (Switch)
- 1 سيرفر (DHCP/DNS/FTP/HTTP)
- 2 PCs من قسم الإدارة
- 2 PCs من الموظفين
- 1 Attacker PC
- 1 Cloud (شبكة خارجية)
---
### ✅ التوصيلات:

| الجهاز              | المنفذ على السويتش | VLAN    |
| ------------------- | ------------------ | ------- |
| Router (G0/0, G0/1) | Fa0/1              | trunk   |
| Server              | Fa0/2              | trunk   |
| PC-Admin1           | Fa0/3              | VLAN 20 |
| PC-Admin2           | Fa0/4              | VLAN 20 |
| PC-User1            | Fa0/5              | VLAN 10 |
| PC-User2            | Fa0/6              | VLAN 10 |
| Attacker            | Fa0/7              | VLAN 10 |

---

## 🔹 المرحلة 2: إعداد VLAN على السويتش
```
Switch> enable Switch# configure terminal Switch(config)# vlan 10 Switch(config-vlan)# name USERS 

Switch(config)# vlan 20 Switch(config-vlan)# name ADMINS  ! إعداد المنافذ 

Switch(config)# interface range fa0/5 - 6 Switch(config-if-range)# switchport access vlan 10 

Switch(config-if-range)# switchport mode access  

Switch(config)# interface range fa0/3 - 4 Switch(config-if-range)# switchport access vlan 20 

Switch(config-if-range)# switchport mode access  ! المنفذ مع الراوتر والسيرفر 

Switch(config)# interface fa0/1 Switch(config-if)# switchport mode trunk  

Switch(config)# interface fa0/2 Switch(config-if)# switchport mode trunk
```

---

## 🔹 المرحلة 3: إعداد DHCP على الراوتر (Router-on-a-stick)

### ✅ إعداد الإنترفيسات الفرعية:

```
Router(config)# interface g0/0.10 

Router(config-subif)# encapsulation dot1Q 10 

Router(config-subif)# ip address 192.168.10.1 255.255.255.0  

Router(config)# interface g0/0.20 

Router(config-subif)# encapsulation dot1Q 20 

Router(config-subif)# ip address 192.168.20.1 255.255.255.0  

Router(config)# interface g0/1 

Router(config-if)# ip address 10.0.0.1 255.255.255.0 

Router(config-if)# no shutdown

```

### ✅ DHCP Configuration:

```
! استثناء عناوين 
Router(config)# ip dhcp excluded-address 192.168.10.1 192.168.10.10 

! DHCP للموظفين 
Router(config)# ip dhcp excluded-address 192.168.20.1 192.168.20.10  

Router(config)# ip dhcp pool USERS 

Router(dhcp-config)# network 192.168.10.0 255.255.255.0 

Router(dhcp-config)# default-router 192.168.10.1 

! DHCP للإدارة 
Router(dhcp-config)# dns-server 8.8.8.8  

Router(config)# ip dhcp pool ADMINS 

Router(dhcp-config)# network 192.168.20.0 255.255.255.0 

Router(dhcp-config)# default-router 192.168.20.1 

Router(dhcp-config)# dns-server 8.8.4.4
```

---
## 🔹 المرحلة 4: تفعيل DHCP Snooping
```
Switch(config)# ip dhcp snooping 

Switch(config)# ip dhcp snooping vlan 10,20  ! منفذ الراوتر والسيرفر → trusted 

Switch(config)# interface range fa0/1 , fa0/2 

Switch(config-if-range)# ip dhcp snooping trust  ! Attacker في Fa0/7 → untrusted 

Switch(config)# interface fa0/7 

Switch(config-if)# no ip dhcp snooping trust
```

---
## 🔹 المرحلة 5: ACL Standard (لـ Telnet فقط)

### ✅ فقط الإدارة يمكنها الدخول على الراوتر:

```
Router(config)# access-list 10 permit 192.168.20.0 0.0.0.255 

Router(config)# line vty 0 4 

Router(config-line)# access-class 10 in 

Router(config-line)# password cisco 

Router(config-line)# login 

Router(config-line)# transport input telnet

```

---
## 🔹 المرحلة 6: ACL Extended (فلترة الخدمات)
### ✅ حجب HTTP على الموظفين
```
Router(config)# access-list 110 deny tcp 192.168.10.0 0.0.0.255 any eq 80 

Router(config)# access-list 110 permit ip any any Router(config)# interface g0/1 

Router(config-if)# ip access-group 110 out
```
### ✅ مثال إضافي: السماح فقط للمديرين باستخدام FTP
```
Router(config)# access-list 111 permit tcp 192.168.20.0 0.0.0.255 host 10.0.0.100 eq 21 

Router(config)# access-list 111 deny ip any any 

Router(config)# interface g0/1 

Router(config-if)# ip access-group 111 out
```


---
## 🔹 المرحلة 7: اختبار DORA عمليًا

### ✅ من Simulation Mode:

1. افتح PC → Desktop → IP Config → Set to DHCP
2. راقب المراحل (Discover → Offer → Request → ACK)
3. تحقق من أن الجهاز أخذ IP صحيح من السيرفر

---
## 🔹 المرحلة 8: اختبار الحماية ضد DHCP Spoofing

1. ضع DHCP Server على جهاز Attacker
2. فعّله يرسل عروض DHCP
3. تحقق من أن الأجهزة لا تأخذ IP منه
4. تأكد أن منفذ Attacker غير موثوق (untrusted)

---
## 🔹 المرحلة 9: اختبار كل ACLs

|الحالة|النتيجة|
|---|---|
|موظف يفتح موقع HTTP|❌ مرفوض|
|مدير يفتح موقع HTTP|✅ مسموح|
|موظف يستخدم Telnet للراوتر|❌ مرفوض|
|مدير يستخدم Telnet للراوتر|✅ مسموح|
|موظف يستخدم FTP|❌ مرفوض|
|مدير يستخدم FTP|✅ مسموح|
|Attacker يعمل DHCP Spoof|❌ غير مسموح|

---
## ✅ الملخص النهائي

لقد غطّينا:

- 🔹 إعداد الشبكة وVLANs
- 🔹 DHCP من الراوتر
- 🔹 حماية DHCP Snooping
- 🔹 ACL للتحكم في Telnet
- 🔹 ACL للتحكم في الخدمات
- 🔹 ACL للبورتات
- 🔹 تطبيق واقعي لهجوم DHCP Spoofing
- 🔹 اختبار شامل لكامل النظام 