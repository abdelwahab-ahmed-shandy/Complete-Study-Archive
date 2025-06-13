# بروتوكولات النقل (Transport Layer Protocols)

## 🚧 ما هي طبقة النقل؟
طبقة النقل في نموذج TCP/IP مسؤولة عن **نقل البيانات بين الأجهزة** عبر الشبكة بطريقة موثوقة أو غير موثوقة حسب الحاجة.  
أهم بروتوكولين في هذه الطبقة هما:

- **TCP (Transmission Control Protocol)**  
- **UDP (User Datagram Protocol)**  

---

## 🔄 TCP (بروتوكول التحكم في النقل)
### ✔️ المميزات:
- **اتصال موجه (Connection-Oriented):** يجب إنشاء اتصال بين الطرفين قبل إرسال البيانات.
- **موثوق (Reliable):** يضمن وصول البيانات كاملة وبالترتيب الصحيح.
- **إعادة الإرسال (Retransmission):** إذا فقدت حزمة بيانات، يتم إرسالها مرة أخرى.
- **ترتيب البيانات (Sequencing):** كل حزمة بيانات تحتوي على رقم تسلسلي (Sequence Number).
- **التحكم في التدفق (Flow Control)** و **التحكم في الازدحام (Congestion Control)**.

### ❌ العيوب:
- أبطأ من UDP بسبب الخطوات الإضافية لضمان الموثوقية.

### 📌 الاستخدامات:
- البريد الإلكتروني (SMTP, POP3)
- تصفح الإنترنت (HTTP, HTTPS)
- نقل الملفات (FTP)

---

## ⚡ UDP (بروتوكول بيانات المستخدم)
### ✔️ المميزات:
- **بدون اتصال (Connectionless):** لا يتطلب إنشاء اتصال قبل إرسال البيانات.
- **سريع (Fast):** لا يتحقق من وصول الحزم أو ترتيبها.
- **بسيط (Lightweight):** يحتوي على رأس بيانات (Header) بسيط جداً (4 حقول فقط).

### ❌ العيوب:
- غير موثوق: قد تضيع بعض الحزم أثناء النقل بدون إعادة إرسال.
- لا يضمن ترتيب الحزم.

### 📌 الاستخدامات:
- البث المباشر (Streaming)
- المكالمات الصوتية والفيديو (VoIP)
- الألعاب عبر الإنترنت (Online Games)

---

## 📦 مقارنة بين TCP و UDP

| المعيار              | TCP                        | UDP                       |
|---------------------|--------------------------|--------------------------|
| الاتصال             | موجه (يتطلب اتصال)        | بدون اتصال               |
| الموثوقية            | عالي (ضمان الوصول والترتيب) | منخفض (لا ضمان)          |
| السرعة              | أبطأ نسبياً                | أسرع                     |
| الحجم (Header)       | كبير ومعقد                | صغير وبسيط               |
| الاستخدام الشائع     | الويب، البريد، FTP        | الفيديو، VoIP، الألعاب   |

---

## 🔢 أرقام المنافذ (Ports)

كل من TCP و UDP يستخدم **أرقام المنافذ (Port Numbers)** لتحديد التطبيقات المستهدفة على الأجهزة:

| التطبيق       | البروتوكول | رقم المنفذ |
|--------------|------------|-----------|
| HTTP         | TCP        | 80        |
| HTTPS        | TCP        | 443       |
| FTP          | TCP        | 21        |
| SMTP         | TCP        | 25        |
| POP3         | TCP        | 110       |
| DNS          | TCP/UDP    | 53        |
| DHCP         | UDP        | 67/68     |

> 📝 **DNS** يستخدم كلا البروتوكولين حسب الحاجة: UDP للطلبات السريعة، TCP للنقل الأكبر.

---

## 💡 أهم النقاط:

- 🔄 **TCP = موثوق بطيء** (للبيانات الهامة)
- ⚡ **UDP = سريع غير موثوق** (للزمن الحقيقي)
- 🔢 أرقام المنافذ تسمح بوجود عدة خدمات في نفس الجهاز.
- 🛠️ اختيار البروتوكول يعتمد على التطبيق:  
  - نقل ملفات = TCP  
  - بث مباشر = UDP  

---

## 🎯 متى تستخدم كل بروتوكول؟
| الحالة                           | البروتوكول الأنسب |
|----------------------------------|------------------|
| تحميل ملفات/مواقع ويب              | TCP              |
| مكالمات صوتية / فيديو مباشر        | UDP              |
| تطبيقات تحتاج ضمان تسليم البيانات | TCP              |
| تطبيقات لا تحتمل التأخير الزمني    | UDP              |


---

---

# Transport Layer Protocols

## 🚧 What is the Transport Layer?
The Transport Layer in the TCP/IP model is responsible for **transferring data between devices** across the network, whether reliably or unreliably.
The two most important protocols in this layer are:

- **TCP (Transmission Control Protocol)**
- **UDP (User Datagram Protocol)**

---

## 🔄 TCP (Transport Control Protocol)
### ✔️ Features:
- **Connection-Oriented**: A connection must be established between the two parties before data can be transmitted.
- **Reliable**: Ensures that the data arrives in its entirety and in the correct order.
- **Retransmission**: If a data packet is lost, it is sent again.
- **Sequencing**: Each data packet contains a sequence number.
- **Flow Control** and **Congestion Control**.

### ❌ Disadvantages:
- Slower than UDP due to the additional steps to ensure reliability.

### 📌 Uses:
- Email (SMTP, POP3)
- Web browsing (HTTP, HTTPS)
- File transfer (FTP)

---

## ⚡ UDP (User Data Protocol)
### ✔️ Advantages:
- **Connectionless:** Does not require establishing a connection before sending data.
- **Fast:** Does not check packet arrival or order.
- **Lightweight:** Has a very simple header (only 4 fields).

### ❌ Disadvantages:
- Unreliable: Some packets may be lost during transmission without retransmission.
- Does not guarantee packet order.

### 📌 Uses:
- Live streaming
- Voice and video calls (VoIP)
- Online gaming

---

## 📦 Comparison between TCP and UDP

| Standard | TCP | UDP |
|-----|-----------------------------|- ... Port Number |
|-----------|----------|----------|
| HTTP | TCP | 80 |
| HTTPS | TCP | 443 |
| FTP | TCP | 21 |
| SMTP | TCP | 25 |
| POP3 | TCP | 110 |
| DNS | TCP/UDP | 53 |
| DHCP | UDP | 67/68 |

> 📝 **DNS** uses both protocols as needed: UDP for fast requests, TCP for larger transfers.

---

## 💡 Key Points:

- 🔄 **TCP = Reliable, Slow** (for important data)
- ⚡ **UDP = Fast, Unreliable** (for real-time)
- 🔢 Port numbers allow multiple services to coexist on the same device.
- 🛠️ The choice of protocol depends on the application:
- File Transfer = TCP
- Live Streaming = UDP

---

## 🎯 When to Use Each Protocol?
| Situation | Most Appropriate Protocol |
|- ...