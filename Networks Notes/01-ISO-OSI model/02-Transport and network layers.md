# الطبقتان الرابعة والثالثة من نموذج OSI: النقل والشبكة

## 1️⃣ الطبقة الرابعة: طبقة النقل (Transport Layer)

### ✔️ الوظائف الأساسية:
- مسؤولة عن **نقل البيانات من جهاز إلى آخر** بشكل موثوق.
- تقسيم البيانات إلى **Segments** ثم إعادة تجميعها في الطرف المستقبل.
- التأكد من وصول البيانات **بالترتيب الصحيح**، دون فقد أو تكرار.
- تقدم نوعين من طرق النقل:
  1. **معتمد على الاتصال (Connection-Oriented)** — مثل بروتوكول TCP.
  2. **غير معتمد على الاتصال (Connectionless)** — مثل بروتوكول UDP.

### 🎯 الأدوار:
| الوظيفة                    | الوصف                                                                |
|---------------------------|---------------------------------------------------------------------|
| التقسيم والتجميع Segmentation & Reassembly | تقسيم البيانات الكبيرة إلى وحدات صغيرة (Segments) وإعادة جمعها في المستقبل.|
| التسلسل Sequencing        | إعطاء كل Segment رقم تسلسلي لضمان وصولها وإعادة ترتيبها بشكل صحيح.    |
| التحكم في الأخطاء Error Control| ضمان خلو البيانات من الأخطاء (في طريقة الاتصال المعتمد).             |
| التحكم في التدفق Flow Control | منع غمر الطرف المستقبل بكمية بيانات أكبر مما يمكنه معالجتها.            |

### 📌 الفرق بين الاتصال المعتمد وغير المعتمد:
| الاتصال المعتمد (TCP)                        | الاتصال غير المعتمد (UDP)             |
|---------------------------------------------|--------------------------------------|
| يحتاج لإنشاء اتصال (Handshake) قبل نقل البيانات | لا يحتاج لإنشاء اتصال |
| يضمن وصول كل البيانات (موثوقية عالية)            | لا يضمن وصول كل البيانات (غير موثوق لكنه سريع) |
| يستخدم في البريد الإلكتروني، تصفح الويب        | يستخدم في بث الفيديو، الألعاب عبر الإنترنت |

---

## 2️⃣ الطبقة الثالثة: طبقة الشبكة (Network Layer)

### ✔️ الوظائف الأساسية:
- مسؤولة عن **تحديد المسار (Routing)** من الجهاز المرسل إلى الجهاز المستقبل عبر الشبكة.
- تحول Segments المستلمة من طبقة النقل إلى **Packets**.
- تضيف عناوين منطقية (Logical Addresses) لكل Packet مثل:
  - **IP Address** (IPv4/IPv6)
- تقرر أي مسار سيتخذه كل Packet للوصول إلى الوجهة المطلوبة.

### 🎯 الأدوار:
| الوظيفة                  | الوصف                                                                 |
|-------------------------|----------------------------------------------------------------------|
| التوجيه Routing         | تحديد الطريق الأمثل لنقل الحزمة من المصدر إلى الوجهة عبر عدة شبكات.     |
| العنونة Addressing      | إضافة عنوان المصدر والوجهة لكل حزمة (Packet) لضمان الوصول السليم.         |
| تجزئة الحزم Packet Fragmentation | تجزئة الحزم الكبيرة لتتناسب مع قدرة الشبكات المختلفة.              |
| التحكم في الازدحام Congestion Control | تقليل الزحام في الشبكة عبر تنظيم إرسال الحزم.                       |

### 📌 أمثلة:
- بروتوكول الإنترنت (IP)
- بروتوكولات التوجيه مثل RIP، OSPF، BGP.

---

## 💡 مقارنة بين الطبقتين:

| الجانب                  | طبقة النقل (Transport)             | طبقة الشبكة (Network)             |
|------------------------|------------------------------------|-----------------------------------|
| وحدة البيانات          | Segment                            | Packet                            |
| العنوان المستخدم        | رقم المنفذ (Port Number)            | العنوان المنطقي (IP Address)       |
| الهدف                  | ضمان سلامة ووصول البيانات بين التطبيقات | توجيه الحزم بين الأجهزة عبر الشبكات |
| البروتوكولات الشائعة   | TCP, UDP                           | IP, ICMP, IGMP                    |

---

## 🔍 ملاحظات هامة:
- طبقة النقل مسؤولة عن **من نقطة إلى نقطة (End-to-End Communication)**.
- طبقة الشبكة مسؤولة عن **من شبكة إلى شبكة (Network-to-Network Communication)**.
- طبقة النقل تتعامل مع التطبيقات، أما طبقة الشبكة تتعامل مع الأجهزة (Routers).

---

## 📦 مثال عملي:

1. عند إرسال بريد إلكتروني:
   - طبقة النقل (TCP) تقسم الرسالة إلى Segments وتضيف أرقام تسلسلية.
   - طبقة الشبكة (IP) تضيف عنوان IP للمرسل والمستقبل وتختار أفضل مسار للحزم.

2. عند إجراء مكالمة فيديو:
   - طبقة النقل (UDP) ترسل البيانات بسرعة بدون التأكد من التسلسل.
   - طبقة الشبكة (IP) توجه الحزم وفق عنوان الوجهة، مع احتمال فقد أو ترتيب عشوائي.


---

---

# Layers 4 and 3 of the OSI Model: Transport and Network

## 1️⃣ Layer 4: Transport Layer

### ✔️ Key Functions:
- Responsible for **transferring data from one device to another** reliably.
- Dividing data into **segments** and then reassembling them at the receiving end.
- Ensuring that data arrives **in the correct order**, without loss or duplication.
- Offers two types of transmission methods:
1. **Connection-oriented** — such as TCP.
2. **Connectionless** — such as UDP.

### 🎯 Roles:
| Function | Description |
|- ... Each segment is assigned a sequence number to ensure it arrives and is reordered correctly. |
| Error Control | Ensuring data is error-free (in a reliable connection). |
| Flow Control | Preventing the receiving end from being overwhelmed with more data than it can process. |

### 📌 The difference between reliable and untrusted connections:
| Trusted connection (TCP) | Untrusted connection (UDP) |
|- ... ---

## 2️⃣ Layer 3: Network Layer

### ✔️ Main Functions:
- Responsible for determining the path (Routing) from the sending device to the receiving device across the network.
- Converts received segments from the Transport Layer into packets.
- Adds logical addresses to each packet, such as:
- IP Address (IPv4/IPv6)
- Determines the path each packet will take to reach its desired destination.

### 🎯 Roles:
| Job | Description |
|------------------------|-----------------------------------------------------------------------|
| Routing | Determining the optimal path for transporting a packet from the source to the destination across multiple networks. |
| Addressing | Adding the source and destination addresses to each packet to ensure proper access. |
| Packet Fragmentation | Fragmenting large packets to suit the capacity of different networks. |
| Congestion Control | Reducing network congestion by regulating packet transmission. |

### 📌 Examples:
- Internet Protocol (IP)
- Routing protocols such as RIP, OSPF, and BGP.

---
## 💡 Comparison between the two layers:

| Side | Transport Layer | Network Layer |
|- ... The network layer is responsible for network-to-network communication.

The transport layer handles applications, while the network layer handles devices (routers).

---

## 📦 Practical Example:

1. When sending an email:
- The transport layer (TCP) divides the message into segments and adds sequence numbers.
- The network layer (IP) adds the IP addresses of the sender and receiver and chooses the best path for the packets.

2. When making a video call:
- The transport layer (UDP) sends data quickly without ensuring sequence.
- The network layer (IP) routes packets according to the destination address, with the possibility of loss or randomization.

---

### By Abdelwahab Shandy 