# Computer Networks Fundamentals

### References:

**Books:**

* Cisco Student Guide ICND1
* CompTIA Network N10-006 Cert Guide
* Data and Computer Communications - William Stallings, 8th Edition
* TCP/IP Protocol Suite - Behrouz A. Forouzan, 4th Edition
* Understanding IPv6 – Joseph Davies, 2nd Edition

---

## Objective:

* Introduction to Computer Networks
* OSI Model
* TCP/IP Model
* Ethernet Protocol
* Network Devices
* Network Media
* Introduction to Wireless Networks
* Security Fundamentals

---

## What is a Computer Network?

* A computer network is a collection of computers and other devices or peripherals connected together through communication media to perform tasks such as **resource sharing**.

## Benefits of Computer Networks:

* Resource Sharing:

  * File Sharing
  * Device Sharing
  * Software Sharing
  * Voice and Video Communication

* Shared Internet Access

## Basic Network Terminologies:

* **NIC (Network Interface Card):** A hardware device plugged into the motherboard that provides access to the network.
* **MAC Address:** A unique physical address burned into the NIC card.
* **IP Address:** A logical address that identifies each device in an IP network.
* **Protocols:** A set of communication rules that all devices must follow.

---

## How to Apply Networks?

### Network Classifications:

* By Geographic Area:

  * PAN – LAN – MAN – WAN – Internet

* By Network Topology:

  * Bus – Star – Ring – Mesh – Hybrid

* By Network Model:

  * Peer-to-Peer
  * Client/Server

---

## Network Types by Geographic Area:

### 1. PAN (Personal Area Network):

* A network around a person’s workspace for connecting devices like phones, printers, and laptops.

### 2. LAN (Local Area Network):

* A group of computers in a small geographic area (e.g., office, university).
* High-speed communication.

### 3. MAN (Metropolitan Area Network):

* Covers a larger area than LAN but smaller than WAN (e.g., city).
* Requires high-performance hardware.

### 4. WAN (Wide Area Network):

* Covers large geographic areas (e.g., country).
* Connects LANs through ISPs.
* Lower speed.

### 5. Internet:

* Global mesh of interconnected networks.
* Main service: World Wide Web (WWW).
* Owned by many organizations, including:

  * ISOC, IETF, ICANN.

---

## Network Topology:

### 1. Bus:

* All devices connect to a central cable (backbone).
* Messages are sent to all; only the recipient processes it.

**Advantages:** Simple, low cost.

**Disadvantages:** One cable failure disrupts the network, hard to troubleshoot.

### 2. Star:

* Devices connect to a central unit (Hub/Switch).

**Types:**

* Hubbed Star: Hub broadcasts to all.
* Switched Star: Switch sends to specific device.

### 3. Ring:

* Devices form a closed loop.
* Messages travel in one direction using a token.

**Disadvantages:** Failure in one node disrupts the whole network.

### 4. Mesh:

* Every device connects to every other device.
* Cable calculation: $CN = \frac{D \times (D - 1)}{2}$
* **Types:** Full Mesh, Partial Mesh

**Disadvantages:** Expensive due to cabling.

### 5. Hybrid:

* Combination of two or more topologies.
* Flexible and allows easy expansion.

---

## By Network Model:

### Peer-to-Peer:

* No dedicated servers.
* All nodes are equal.

**Example:** Windows Workgroup

### Client/Server:

* Servers provide services to client nodes.
* Fewer servers than clients.

**Examples:**

* Mail Server
* Web Server
* File Server
* Print Server

---

## Building the Network:

### Basic Network Elements:

**Hardware:**

* Computers/Peripherals
* NICs
* Transmission Media (Wired/Wireless)
* Networking Devices: Routers, Switches, Hubs

**Software:**

* Protocols (rules for communication)
* Messages (emails, chats, etc.)

---

## Protocols:

* Define rules for communication.
* Required for managing message flow and efficiency.

**Examples:**

* HTTP, HTTPS, FTP, RDP

---

## OSI Model:

* Developed by ISO in 1983.

### Benefits of OSI Model:

* Reduces complexity.
* Standardizes interfaces.
* Enables multi-vendor compatibility.
* Easier maintenance and learning.

### The Seven Layers:

| No. | Layer            | Main Function                                                  |
| --- | ---------------- | -------------------------------------------------------------- |
| 7   | **Application**  | User interaction (HTTP, FTP, etc.)                             |
| 6   | **Presentation** | Data conversion, encryption, and compression                   |
| 5   | **Session**      | Session management between systems                             |
| 4   | **Transport**    | Reliable data transport, error recovery                        |
| 3   | **Network**      | Routing and logical addressing (IP)                            |
| 2   | **Data Link**    | Frame creation, MAC addressing, error detection                |
| 1   | **Physical**     | Physical signal transmission over media (cables, radio, fiber) |

---

### Layer Functions:

* **Application:** Interfaces with user applications.
* **Presentation:** Translates and encrypts data.
* **Session:** Establishes, manages, and terminates sessions.
* **Transport:** Segments and delivers data reliably.
* **Network:** Routes packets using IP addresses.
* **Data Link:** Ensures error-free frame transmission.
* **Physical:** Converts bits into signals and vice versa.

---

## Data Encapsulation and De-Encapsulation:

| Sender                     | Receiver           |
| -------------------------- | ------------------ |
| Application Layer          | Application Layer  |
| Presentation Layer         | Presentation Layer |
| Session Layer              | Session Layer      |
| Transport Layer (Segments) | Transport Layer    |
| Network Layer (Packets)    | Network Layer      |
| Data Link Layer (Frames)   | Data Link Layer    |
| Physical Layer (Bits)      | Physical Layer     |

---

---

---

---


# أساسيات شبكات الحاسوب (Computer Networks Fundamentals)

### المراجع:

**كتب:**

* Cisco Student Guide ICND1
* CompTIA Network N10-006 Cert Guide
* Data and Computer Communications - William Stallings الإصدار الثامن
* TCP/IP Protocol Suite - Behrouz A. Forouzan الإصدار الرابع
* Understanding IPv6 – Joseph Davies الإصدار الثاني

---

## الهدف:

* مقدمة في شبكات الحاسوب
* نموذج OSI
* نموذج TCP/IP
* بروتوكول الإيثرنت
* أجهزة الشبكة
* وسائط الشبكة
* مقدمة في الشبكات اللاسلكية
* أساسيات الأمان

---

## ما هي شبكة الحاسوب؟

* شبكة الحاسوب:
  هي مجموعة من الحواسيب والأجهزة الطرفية الأخرى المتصلة ببعضها من خلال وسائط اتصال بهدف تنفيذ مهام معينة مثل **مشاركة الموارد**.

## فوائد شبكات الحاسوب:

* مشاركة الموارد:

  * مشاركة الملفات
  * مشاركة الأجهزة
  * مشاركة البرمجيات
  * المكالمات الصوتية والمرئية

* مشاركة الاتصال بالإنترنت

## المصطلحات الأساسية في الشبكات:

* **NIC (Network Interface Card):** بطاقة توصيل الشبكة، تركب على اللوحة الأم وتستخدم للاتصال بالشبكة.
* **Mac Address:** العنوان الفيزيائي الفريد لكل بطاقة NIC، لا يتكرر عالميًا.
* **IP Address:** العنوان المنطقي، يستخدم للتعريف بكل جهاز على الشبكة.
* **Protocol:** مجموعة من القواعد التي تنظم الاتصال بين الأجهزة.

---

## كيفية تطبيق الشبكات؟

### تصنيف الشبكات:

* حسب النطاق الجغرافي:

  * PAN – LAN – MAN – WAN – Internet

* حسب الطوبولوجيا (Network Topology):

  * Bus – Star – Ring – Mesh – Hybrid

* حسب نموذج الشبكة:

  * Peer-to-Peer
  * Client/Server

---

## أنواع الشبكات حسب النطاق:

### 1. شبكة PAN:

* تربط الأجهزة الشخصية لمساحة صغيرة حول فرد واحد (مثل الهواتف، الطابعات، اللابتوب).

### 2. شبكة LAN:

* شبكة محلية في نطاق جغرافي صغير (مثل مكتب أو جامعة).
* تسمح بمشاركة الملفات والخدمات.
* سرعة اتصال عالية.

### 3. شبكة MAN:

* تغطي مدينة أو جزء منها.
* تعتمد على أجهزة أداء عالي.

### 4. شبكة WAN:

* تغطي مناطق جغرافية واسعة مثل دولة.
* توصل بين شبكتين LAN عبر مزود خدمة الإنترنت (ISP).
* سرعة أقل.

### 5. الإنترنت:

* شبكة عالمية مترابطة.
* أهم خدمة عليها: World Wide Web.
* لا يملكها أحد بالكامل، إنما تملكها منظمات وشركات:

  * ISOC، IETF، ICANN.

---

## طوبولوجيا الشبكات:

### 1. Bus:

* الأجهزة تتصل بكابل رئيسي (Backbone).
* الرسائل تنتقل للجميع، ويستجيب المستهدف فقط.

**المزايا:** بسيطة، قليلة التكلفة.

**العيوب:** خلل بسيط يوقف الشبكة، صعوبة في التشخيص، لا يوجد أمان.

### 2. Star:

* كل الأجهزة تتصل بجهاز مركزي (Hub أو Switch).

* **أنواع:**

  * Hubbed Star: نقل البيانات يتم عبر Hub (بث).
  * Switched Star: نقل البيانات يتم عبر Switch (انتقائي).

### 3. Ring:

* الأجهزة تتصل على شكل حلقة مغلقة.
* الرسائل تسير في اتجاه واحد.
* يتم استخدام **Token** للنقل.

**العيوب:** تأثر الشبكة بفشل أي جهاز، صعبة التوسعة.

### 4. Mesh:

* كل جهاز متصل بجميع الأجهزة الأخرى.
* المعادلة: $CN = \frac{D \times (D - 1)}{2}$
* **أنواع:** Full Mesh – Partial Mesh

**العيوب:** تكلفة مرتفعة بسبب عدد الكابلات.

### 5. Hybrid:

* دمج لأكثر من طوبولوجيا.
* يسمح بالمرونة وسهولة التوسع.

---

## حسب نموذج الشبكة:

### Peer to Peer:

* لا يوجد جهاز مركزي.
* جميع الأجهزة متساوية.

**مثال:** Windows Workgroup

### Client/Server:

* خوادم تقدم خدمات للعملاء.
* عدد السيرفرات قليل مقارنة بعدد العملاء.

**أمثلة:**

* Mail Server
* File Server
* Print Server

---

## بناء الشبكة:

### العناصر الأساسية:

**المكونات المادية:**

* أجهزة الحاسوب والطابعات.
* كروت الشبكة.
* وسائط الاتصال (سلكية أو لاسلكية).
* أجهزة الشبكة: (Router – Switch – Hub)

**المكونات البرمجية:**

* البروتوكولات
* الرسائل (مثل البريد الإلكتروني، WhatsApp)

---

## البروتوكولات:

* قواعد الاتصال.
* نحتاجها لضبط تدفق البيانات والتحكم بها.

**أمثلة:**

* HTTP – HTTPS – FTP – RDP

---

## نموذج OSI:

* أنشأته منظمة ISO في 1983.

### مزايا النموذج:

* تقليل التعقيد.
* سهولة الصيانة.
* دعم تعدد البائعين.
* فصل بين الطبقات.

### الطبقات السبع:

| رقم | الطبقة           | الوظيفة الأساسية                         |
| --- | ---------------- | ---------------------------------------- |
| 7   | **Application**  | تفاعل المستخدم مع التطبيقات (HTTP, FTP)  |
| 6   | **Presentation** | تحويل البيانات والتشفير                  |
| 5   | **Session**      | إدارة الجلسات بين الأنظمة                |
| 4   | **Transport**    | التحكم في النقل والتأكد من وصول البيانات |
| 3   | **Network**      | التوجيه وعناوين IP                       |
| 2   | **Data Link**    | التحكم في الوصول ونقل الإطارات           |
| 1   | **Physical**     | الإرسال الفيزيائي للإشارات               |

### وظائف كل طبقة:

* **Application:** واجهة المستخدم.
* **Presentation:** تحويل الترميز.
* **Session:** إدارة الاتصال.
* **Transport:** تجزئة البيانات وضمان الاستلام.
* **Network:** التوجيه والعناوين.
* **Data Link:** كشف الأخطاء.
* **Physical:** إرسال الإشارات عبر الكابلات أو اللاسلكي.

---

## عملية التغليف (Encapsulation) وفك التغليف (De-Encapsulation):

| المرسل                     | المستقبل           |
| -------------------------- | ------------------ |
| Application Layer          | Application Layer  |
| Presentation Layer         | Presentation Layer |
| Session Layer              | Session Layer      |
| Transport Layer (Segments) | Transport Layer    |
| Network Layer (Packets)    | Network Layer      |
| Data Link Layer (Frames)   | Data Link Layer    |
| Physical Layer (Bits)      | Physical Layer     |

---

*BY: Abdelwahab Shandy*



