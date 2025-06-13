# بروتوكول IP (Internet Protocol)

## 🌐 ما هو بروتوكول IP؟
IP هو بروتوكول يعمل في **طبقة الإنترنت (Internet Layer)** في نموذج TCP/IP (والتي تقابل طبقة الشبكة في نموذج OSI).  
وظيفته الأساسية هي:
- تقسيم البيانات إلى وحدات صغيرة تسمى **رزم (Packets)**.
- تعيين **عناوين IP** منطقية (Source & Destination) لكل رزمة.
- توجيه الرزم عبر الشبكة إلى وجهتها الصحيحة باستخدام الموجهات (Routers).

---

## 🚦 التوجيه (Routing)
- يتم توجيه الرزم بناءً فقط على **عنوان IP الوجهة** (Destination IP).
- يستخدم كل موجه **جدول توجيه (Routing Table)** لتحديد المسار الأفضل.
  
### أنواع الجداول:
| النوع          | الوصف                                 |
|---------------|--------------------------------------|
| 🔧 **Static** | يتم إنشاؤه يدويًا بواسطة المدير الشبكي. |
| 🔄 **Dynamic**| يتم إنشاؤه تلقائيًا عبر بروتوكولات التوجيه (مثل RIP, OSPF). |

---

## 📦 هيكل عنوان IP (IPv4)
- طوله **32 بت (4 بايت)**، يكتب بالشكل: `192.168.1.1`.
- كل بايت (Octet) يتراوح من 0 إلى 255.

---

## 🧩 تصنيف عناوين IPv4 إلى Classes

| الفئة (Class) | المدى                | الشبكة / المضيف | النطاق الخاص (Private Range) |
|--------------|----------------------|-----------------|-----------------------------|
| **A**        | 1 - 126               | 1 بايت شبكة + 3 بايت مضيف | `10.0.0.0/8`           |
| **B**        | 128 - 191             | 2 بايت شبكة + 2 بايت مضيف | `172.16.0.0/12`        |
| **C**        | 192 - 223             | 3 بايت شبكة + 1 بايت مضيف | `192.168.0.0/16`       |

> **ملاحظة:**  
- 127.x.x.x = محجوز للـ Loopback (عادة 127.0.0.1).

---

## 🔒 العناوين الخاصة (Private IPs)
- لا يمكن الوصول إليها من الإنترنت مباشرة.
- تستخدم في الشبكات المحلية (LAN).
- تتطلب **NAT (Network Address Translation)** للاتصال بالإنترنت.

---

## 🌍 تقسيم العنوان (Network/Host)

| Class | جزء الشبكة | جزء المضيف | الاستخدام |
|-------|------------|-----------|-----------|
| A     | Octet 1    | Octets 2,3,4 | شبكات ضخمة جدًا |
| B     | Octets 1,2 | Octets 3,4   | شبكات متوسطة |
| C     | Octets 1,2,3 | Octet 4 | شبكات صغيرة |

---

## 🎯 وظائف بروتوكول IP

- 📦 **Packetization:** تقسيم البيانات إلى رزم.
- 🔢 **Addressing:** تعيين عنوان IP لكل رزمة.
- 🚦 **Routing:** توجيه الرزم للوجهة عبر الموجهات.
- 🌍 **Geolocation:** بعض العناوين يمكن أن تكشف الموقع الجغرافي أو المؤسسة.

---

## 💡 أهم النقاط:
- IP هو بروتوكول **بدون اتصال (Connectionless)**، لا يضمن تسليم الرزم أو ترتيبها.
- يستخدم مع بروتوكولات الطبقة الأعلى مثل **TCP و UDP** لإتمام عملية الاتصال.
- العنوان يتكون من **Network + Host** لتحديد الشبكة والمضيف داخلها.
- يدعم إما **Static Routing** (ثابت) أو **Dynamic Routing** (ذكي ومتغير).
- **العناوين الخاصة** محجوزة للشبكات الداخلية وتحتاج NAT للوصول للإنترنت.

---

## 🛡️ IPv4 مقابل IPv6 (مستقبليًا):
| المعيار       | IPv4              | IPv6                          |
|---------------|-------------------|-------------------------------|
| الطول         | 32 بت              | 128 بت                        |
| الشكل         | `192.168.1.1`     | `2001:0db8:85a3::8a2e:0370:7334` |
| السعة         | ~4.3 مليار عنوان | عدد ضخم جدًا (غير محدود عمليًا) |

---

---

# IP (Internet Protocol)

## 🌐 What is the IP protocol?
IP is a protocol that operates at the Internet Layer of the TCP/IP model (which corresponds to the Network Layer of the OSI model).
Its primary function is to:
- Divide data into smaller units called packets.
- Assign logical IP addresses (Source and Destination) to each packet.
- Route packets across the network to their correct destination using routers.

---
## 🚦 Routing
- Packets are routed based solely on the destination IP address.
- Each router uses a routing table to determine the best path.

### Table Types:
| Type | Description |
|- ... It is manually created by the network administrator. |

🔄 **Dynamic**| It is automatically created via routing protocols (such as RIP, OSPF). |

---

## 📦 IP Address Structure (IPv4)
- It is **32 bits (4 bytes)** long, written as: `192.168.1.1`.
- Each byte (octet) ranges from 0 to 255.

---

## 🧩 Classification of IPv4 Addresses

| Class | Range | Network/Host | Private Range |

|- ... **B** | 128 - 191 | 2 Network Bytes + 2 Host Bytes | `172.16.0.0/12` |

| **C** | 192 - 223 | 3 Network Bytes + 1 Host Byte | `192.168.0.0/16` |

> **Note:**
- 127.x.x.x = Reserved for Loopback (usually 127.0.0.1).

---

## 🔒 Private IPs
- Cannot be accessed directly from the Internet.
- Used in local area networks (LANs).
- Requires **NAT (Network Address Translation)** to connect to the Internet.

---

## 🌍 Address Split (Network/Host)

| Class | Network Part | Host Part | Usage |
|------|-----------|-----------|-----------|
| A | Octet 1 | Octets 2, 3, 4 | Very Large Networks |
| B | Octets 1, 2 | Octets 3, 4 | Medium Networks |
| C | Octets 1, 2, 3 | Octet 4 | Small Networks |

---
## 🎯 IP Protocol Functions

- 📦 **Packetization:** Dividing data into packets.
- 🔢 **Addressing:** Assigning an IP address to each packet.
- 🚦 **Routing:** Routing packets to their destination via routers.
- 🌍 **Geolocation:** Some addresses can reveal a person's geographic location or organization.

---

## 💡 Key Points:
- IP is a connectionless protocol; it does not guarantee packet delivery or ordering.
- It is used with higher-layer protocols such as TCP and UDP to complete the communication process.
- The address consists of Network + Host to identify the network and the host within it.
- It supports either Static Routing (fixed) or Dynamic Routing (intelligent and variable).
- Private addresses are reserved for internal networks and require NAT to access the internet.

---

## 🛡️ IPv4 vs. IPv6 (future):
| Standard | IPv4 | IPv6 |

- ... `192.168.1.1` | `2001:0db8:85a3::8a2e:0370:7334` |
| Capacity | ~4.3 billion addresses | A very large number (practically unlimited) |