# 🖧 Data Link Layer – Layer 2 (OSI Model)

> "The layer responsible for accurate and organized data transmission within the local network."

---

## 📌 Core Functions of the Data Link Layer

| Function                     | Description                                                                 |
|------------------------------|-----------------------------------------------------------------------------|
| 🔄 Encapsulation              | Converts packets into frames by adding headers including MAC addresses     |
| 🎯 MAC Addressing             | Uses unique physical MAC addresses to identify devices locally             |
| 🔐 Media Access Control (MAC) | Controls which device is allowed to send on the medium (cable/Wi-Fi)       |
| 📋 Error Detection            | Adds trailer with checks to detect transmission errors                     |

---

## 🧱 Key Concepts in This Layer

| Concept             | Explanation                                                                      |
|---------------------|----------------------------------------------------------------------------------|
| 🧩 Frame             | Unit of data in Layer 2: Header + Payload + Trailer                              |
| 💳 MAC Address       | Physical hardware address assigned to each NIC (used for local communication)    |
| 📦 Packet to Frame   | Layer 3 packets are encapsulated in Layer 2 frames for local delivery            |

---

## 🛠️ Useful Windows Commands

| Command         | Purpose                                                         |
|------------------|-----------------------------------------------------------------|
| `arp -a`         | Displays ARP table (IP to MAC mappings)                         |
| `getmac`         | Shows the MAC address of the local device                       |
| `ipconfig /all`  | Displays full network info including MAC, IP, connection status |

---

## 🧠 Analytical Insights

- 🔍 **IP vs MAC**:  
  - **IP**: Logical address used for routing between networks.  
  - **MAC**: Physical address used within the local network only.

- 🔁 **Intermediate Layer**:  
  The Data Link Layer bridges logical (Layer 3) and physical (Layer 1) layers. It prepares data to travel across media (cable/wireless).

- ⚠️ **Frame Importance**:  
  The structure of a frame allows devices to understand, verify, and process the data, including error handling.

---

## 📘 Real-World Scenarios

| Scenario                            | Role of Layer 2                                                    |
|-------------------------------------|---------------------------------------------------------------------|
| Printer connected via LAN           | Data is sent using the printer's MAC address                        |
| Discovering devices on the network  | Use ARP or tools like Wireshark to find MAC addresses               |
| File transfer between 2 local PCs   | Data encapsulated using MACs – no need for external IP routing      |

---

## 🧩 Layer Encapsulation Relationship

```
[ Layer 3: IP Packet ]
↓ (Encapsulation)
[ Layer 2: Ethernet Frame ]
↓
[ Layer 1: Bits on Wire ]
```

---

## 📌 Quick Summary

✅ MAC addresses are used for **local delivery**.  
✅ Packets are encapsulated into frames for transmission.  
✅ Commands like `arp -a` help discover connected devices.  
✅ This layer connects logical addressing to physical transmission.


---

---

---

# 🖧 الطبقة الثانية – Data Link Layer (Layer 2 - OSI Model)

> "الطبقة المسؤولة عن نقل البيانات داخل الشبكة المحلية بدقة وتنظيم."

---

## 📌 الوظائف الأساسية لطبقة ربط البيانات

| الوظيفة                        | الوصف                                                                 |
|-------------------------------|------------------------------------------------------------------------|
| 🔄 التغليف (Encapsulation)    | تحويل الحزم (Packets) إلى إطارات (Frames) عبر إضافة رؤوس تشمل عناوين MAC |
| 🎯 عنونة MAC                  | استخدام عنوان MAC كمُعرف فيزيائي فريد لكل جهاز في الشبكة المحلية       |
| 🔐 التحكم في الوصول للوسيط     | تنظيم من يُسمح له بإرسال البيانات عبر الكابل أو الواي فاي               |
| 📋 التحقق من الأخطاء           | تضمين معلومات تحقق في التذييل (Trailer) لضمان سلامة البيانات           |

---

## 🧱 مفاهيم أساسية في هذه الطبقة

| المفهوم             | التوضيح                                                                 |
|----------------------|--------------------------------------------------------------------------|
| 🧩 Frame              | وحدة البيانات في الطبقة الثانية (Header + Data + Trailer)               |
| 💳 عنوان MAC         | عنوان فيزيائي ثابت (رقم HEX) مرتبط بكرت الشبكة – يُستخدم للتوجيه المحلي |
| 📦 Packet to Frame    | تحويل الحزمة (من الطبقة الثالثة) إلى إطار لإرسالها في نفس الشبكة         |

---

## 🛠️ أوامر مهمة في نظام ويندوز

| الأمر             | الوظيفة                                               |
|-------------------|--------------------------------------------------------|
| `arp -a`          | عرض جدول ARP لمعرفة عناوين MAC المرتبطة بـ IP         |
| `getmac`          | معرفة عنوان MAC الخاص بجهازك                           |
| `ipconfig /all`   | عرض كل تفاصيل الاتصال، بما في ذلك MAC و IP              |

---

## 🧠 رؤى تحليلية مهمة

- 🔍 **الفصل بين عنوان IP وMAC**:  
  - `IP` منطقي يستخدم في التوجيه بين الشبكات.  
  - `MAC` فيزيائي يُستخدم داخل الشبكة المحلية فقط.

- 🔁 **طبقة وسيطة**:  
  تربط الطبقة الثانية بين الطبقة الثالثة (المنطقية) والأولى (الفيزيائية)، حيث تُهيّئ البيانات لإرسالها عبر السلك أو الموجات.

- ⚠️ **أهمية الإطارات**:  
  الهيكلية التي تضيفها هذه الطبقة تُمكن الأجهزة من فهم، تحليل، وتصحيح البيانات في حال وجود أخطاء.

---

## 📘 أمثلة من الواقع

| السيناريو                                | دور الطبقة الثانية                                                |
|------------------------------------------|---------------------------------------------------------------------|
| طابعة متصلة عبر LAN                      | تُستخدم عناوين MAC لإرسال البيانات مباشرة للطابعة                 |
| كشف الأجهزة المتصلة                      | يتم عبر قراءة ARP أو أدوات تحليل الشبكة مثل Wireshark              |
| إرسال ملف من جهاز A إلى B داخل نفس الشبكة | يتم التغليف بإطارات تعتمد على MAC فقط دون الحاجة لتوجيه IP خارجي |

---

## 🧩 العلاقة بين الطبقات

```
[ Layer 3: IP Packet ]
↓ (Encapsulation)
[ Layer 2: Ethernet Frame ]
↓
[ Layer 1: Bits on Wire ]
```

---

## 📌 خلاصة سريعة

✅ تُستخدم عناوين MAC للتوجيه المحلي.  
✅ يتم تحويل Packets إلى Frames لإرسالها عبر الشبكة.  
✅ أوامر مثل `arp -a` تُساعد في كشف الأجهزة المتصلة.  
✅ الطبقة الثانية تربط المنطق (IP) بالفيزيائي (سلك/موجات).

---
