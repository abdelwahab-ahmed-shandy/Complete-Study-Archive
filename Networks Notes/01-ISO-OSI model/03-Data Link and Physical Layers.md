# الطبقتان الثانية والأولى من نموذج OSI: وصلة البيانات والفيزيائية

## 1️⃣ الطبقة الثانية: طبقة وصلة البيانات (Data Link Layer)

### ✔️ الوظائف الأساسية:
- مسؤولة عن **نقل البيانات من جهاز إلى آخر ضمن نفس الشبكة المحلية (LAN)**.
- تتعامل مع **إطارات البيانات (Frames)** بدلاً من الحزم (Packets).
- توفر وسائل لاكتشاف الأخطاء وتصحيحها، وضمان تدفق البيانات بطريقة منظمة.
- تنقسم إلى قسمين (Sublayers):
  1. **LLC (Logical Link Control)** — التحكم المنطقي بالارتباط.
  2. **MAC (Media Access Control)** — التحكم بالوصول إلى الوسائط.

---

### 📌 1. التحكم المنطقي بالارتباط (LLC):
| الوظيفة                  | الوصف                                                                      |
|-------------------------|---------------------------------------------------------------------------|
| تحويل الحزم إلى إطارات    | تغليف الحزم القادمة من طبقة الشبكة في إطارات قابلة للنقل عبر الوسيط الفيزيائي.   |
| الكشف عن الأخطاء (FCS)    | إضافة **تسلسل فحص الإطار (Frame Check Sequence)** لاكتشاف الأخطاء أثناء النقل. |
| التحكم في التدفق Flow Control | منع إرسال بيانات أكثر مما يستطيع المستقبل معالجته، لتجنب فقد البيانات.          |
| إعادة الإرسال            | عند اكتشاف خطأ، يطلب إعادة إرسال الإطار المتضرر فقط، وليس كل البيانات.              |

---

### 📌 2. التحكم بالوصول إلى الوسائط (MAC):
| الوظيفة                  | الوصف                                                                                  |
|-------------------------|-----------------------------------------------------------------------------------------|
| إضافة العناوين الفيزيائية (MAC Address) | كل إطار يحتوي على عنوان المصدر والوجهة الفيزيائي (Hardware Address) الخاص ببطاقة الشبكة. |
| تنظيم الوصول إلى الوسيط  | يمنع التصادمات عبر تنظيم متى وكيف يمكن للجهاز أن يرسل البيانات (مثال: CSMA/CD في Ethernet). |
| العمل مع السويتشات Switches | السويتش يستخدم عناوين MAC لتوجيه الإطارات إلى الجهاز الصحيح داخل نفس الشبكة.                          |

---

### 🎯 ملخص طبقة وصلة البيانات:
- مسؤولة عن **النقل المحلي للبيانات داخل الشبكة**.
- تعمل مع العناوين الفيزيائية (MAC Address) وليس العناوين المنطقية (IP).
- توفر **آلية كشف وتصحيح الأخطاء محليًا** قبل وصول البيانات لطبقات أعلى.
- تعتمد عليها أجهزة مثل **Switch**.

---

## 2️⃣ الطبقة الأولى: الطبقة الفيزيائية (Physical Layer)

### ✔️ الوظائف الأساسية:
- مسؤولة عن **النقل الفعلي للإشارات الكهربائية أو الضوئية أو الكهرومغناطيسية** عبر الوسط الناقل.
- تقوم بتحويل البيانات الثنائية (0 و 1) إلى إشارات قابلة للإرسال عبر:
  - كابلات نحاسية (Electrical signals)
  - ألياف ضوئية (Light pulses)
  - موجات لاسلكية (Radio waves)

---

### 🎯 وظائف الطبقة الفيزيائية:
| الوظيفة                   | الوصف                                                   |
|--------------------------|--------------------------------------------------------|
| تحويل البيانات إلى إشارات | تحويل الـ Bits إلى شكل فيزيائي مناسب للوسيط (كهربائي/ضوئي/لاسلكي). |
| تحديد نوع الوسيط         | تعتمد على الكابل (UTP/STP/Fiber) أو الوسط اللاسلكي (Wi-Fi/Bluetooth). |
| تحديد شكل الموصلات       | المقابس، الفيش، الأطوال، مقاييس الكابلات.                   |
| التحكم في معدل الإرسال    | تحديد سرعة نقل البيانات (مثلاً 100 Mbps أو 1 Gbps).         |

---

### 📌 أمثلة:
| الوسيط                  | الإشارة المستخدمة         |
|------------------------|-------------------------|
| كابل نحاسي (Ethernet)    | إشارات كهربائية (Voltage Levels) |
| ألياف ضوئية (Fiber Optic) | نبضات ضوئية (Light Pulses)       |
| لاسلكي (Wi-Fi, Bluetooth)| موجات كهرومغناطيسية (Radio Waves)|

---

## 💡 مقارنة بين الطبقتين:

| الجانب                  | طبقة وصلة البيانات (Data Link)         | الطبقة الفيزيائية (Physical)        |
|------------------------|----------------------------------------|-------------------------------------|
| وحدة البيانات          | Frame (إطار)                          | Bit (بت)                           |
| التعامل مع العناوين    | MAC Address                           | لا يوجد (تتعامل مع الإشارة فقط)    |
| الوظيفة الأساسية       | كشف وتصحيح الأخطاء، عنونة الأجهزة     | تحويل الـ Bits إلى إشارات ونقلها عبر الوسط |
| الأجهزة المرتبطة       | Switches, NICs                         | Hubs, Repeaters, Cables            |

---

## 🔍 ملاحظات هامة:
- طبقة وصلة البيانات هي آخر طبقة **منطقية** قبل التحول للفيزيائية.
- الطبقة الفيزيائية تتعامل فقط مع **النقل الفعلي للإشارات** وليس محتوى البيانات.
- مشكلات مثل **التداخل الكهرومغناطيسي (EMI)** أو ضعف الإشارة تخص الطبقة الفيزيائية.

---

## 📦 مثال عملي:

1. عند إرسال ملف عبر شبكة LAN:
   - طبقة وصلة البيانات (MAC) تضيف عنوان MAC للمرسل والمستقبل وتتحقق من صحة الإطارات (FCS).
   - الطبقة الفيزيائية تحول الإطارات إلى إشارات كهربائية وتُرسل عبر الكابل إلى الجهاز الآخر.


---

---

# The first and second layers of the OSI model: Data Link and Physical

## 1️⃣ Layer 2: Data Link Layer

### ✔️ Basic Functions:
- Responsible for **transferring data from one device to another within the same local area network (LAN)**.
- Handles **data frames** instead of packets.
- Provides means for detecting and correcting errors, ensuring the orderly flow of data.
- Divided into two sublayers:
1. **LLC (Logical Link Control)** — Logical link control.
2. **MAC (Media Access Control)** — Media access control.

---

### 📌 1. Logical Link Control (LLC):
| Function | Description |
|---------|- ... Encapsulating packets coming from the network layer into frames that can be transported across the physical medium. |
| Error Detection (FCS) | Adds a Frame Check Sequence to detect errors during transmission. |
| Flow Control | Prevents sending more data than the receiver can handle, avoiding data loss. |
| Retransmission | When an error is detected, only the affected frame, not the entire data, is requested to be retransmitted. |

---

### 📌 2. Media Access Control (MAC):
| Function | Description |
|---------|------------------------------------------------------------------------------------------------------------|
| Adding Physical Addresses (MAC Addresses) | Each frame contains the source and destination physical (hardware) addresses of the network card. |
| Regulating Access to the Medium | Prevents collisions by regulating when and how a device can send data (e.g., CSMA/CD in Ethernet). |
| Working with Switches | Switches use MAC addresses to route frames to the correct device within the same network. |

---

### 🎯 Data Link Layer Summary:
- Responsible for the local transmission of data within the network.
- Works with physical addresses (MAC addresses), not logical addresses (IP addresses).
- Provides a local error detection and correction mechanism before the data reaches higher layers.
- Devices such as switches rely on it.

---

## 2️⃣ Layer 1: Physical Layer

### ✔️ Basic Functions:
- Responsible for the actual transmission of electrical, optical, or electromagnetic signals through the transmission medium.
- Converts binary data (0s and 1s) into signals that can be transmitted over:
- Copper cables (Electrical signals)
- Optical fibers (Light pulses)
- Radio waves

---

### 🎯 Physical Layer Functions:
| Function | Description |
|---------------------------|---------------------------------------------------------|
| Converting Data to Signals | Converting Bits into a physical form suitable for the medium (electrical/optical/wireless). |
| Determining the Type of Medium | Depends on the cable (UTP/STP/Fiber) or the wireless medium (Wi-Fi/Bluetooth). |
| Determining the Connector Shape | Plugs, Sockets, Lengths, Cable Gauges. |
| Controlling the Transmission Rate | Determining the data transfer speed (e.g., 100 Mbps or 1 Gbps). |

---

### 📌 Examples:
| Medium | Signal Used |
|-----------------------------------|
| Copper Cable (Ethernet) | Electrical Signals (Voltage Levels) |
| Fiber Optic (Fiber Optic) | Light Pulses (Light Pulses) |
| Wireless (Wi-Fi, Bluetooth) | Radio Waves |

---

## 💡 Comparison between the two layers:

| Side | Data Link Layer | Physical Layer |
|- ... - Problems such as **Electromagnetic Interference (EMI)** or weak signal are specific to the physical layer.

---

## 📦 Practical Example:

1. When sending a file over a LAN:
- The data link layer (MAC) adds the MAC address of the sender and receiver and validates the frames (FCS).
- The physical layer converts the frames into electrical signals and sends them over the cable to the other device.