
## Using tools like LTCP Dump and Wireshark is an essential step in:

* Securing networks.
* Understanding user and application behavior.
* Analyzing security incidents.
* Building robust defense systems.

## 🧪 **Practical Examples Using LTCP Dump and Wireshark**
### 📍 **Example 1: Tracing a Ping Flood - ICMP DoS Attack**

#### 📌 Scenario:

Administration has noticed extremely slow network speeds and suspects a Denial of Service (DoS) attack.

#### ✅ Steps:

1. **Using LTCP Dump:**
```
sudo tcpdump icmp
```
- Captures all ICMP packets (such as pings).

- If a very large number is detected within seconds, it indicates an attack.

- **Verify via Wireshark:**

- Apply filter: `icmp`

- Analyze timestamps: Are more than 100 ICMPs being sent per second?

- Check the attacker's IP and begin blocking it immediately.

---
### 📍 **Example 2: Extracting Unencrypted Passwords (Telnet/FTP Sniffing)**

#### 📌 Scenario:

You suspect a user is using insecure protocols (such as Telnet).

#### ✅ Steps:

1. **Using LTCP Dump:**
```
sudo tcpdump -i eth0 port 23 -A
```
- Displays the text content of Telnet packets.

- **In Wireshark:**

- Apply filter: `telnet`

- Select a single session → Right click → “Follow TCP stream”.

- Displays the username and password in plain text.

---
### 📍 **Example 3: Analyzing Website Data Exchange (HTTP)**

#### 📌 Scenario:

You want to analyze requests and responses from an internal website running without HTTPS.

#### ✅ Steps:

1. **In Wireshark:**

- Apply filter: `http`

- Trace requests: GET/POST

- Session information, cookies, and even input data can be seen if they are not encrypted.

2. **In LTCP Dump:**
```
sudo tcpdump -i eth0 port 80 -A
```

---
### 📍 **Example 4: Trace a Malicious File Download**

#### 📌 Scenario:

A device has downloaded a file from a suspicious source.

#### ✅ Steps:

1. **In Wireshark:**

- Apply filter: `http contains ".exe"` or `tcp.port == 80`

- Search for download links.

- Trace the source of the file from the IP/Domain → Determine if it is malicious.

2. **Save the file from the packages (Export Objects):**

- `File > Export Objects > HTTP`

- Analyze it later using tools like VirusTotal or Cuckoo Sandbox.

---
### 📍 **Example 5: Detect a Port Scanning Process (e.g., using Nmap)**

#### 📌 Scenario:

You suspect a device is sending too many connections in a short time.

#### ✅ Steps:

1. **In LTCP Dump:**
```
sudo tcpdump -n src host 192.168.1.100
```
- Trace packets originating from the suspicious device.

2. **In Wireshark:**

- Apply filter: `tcp.flags.syn==1 and tcp.flags.ack==0`

- These packets indicate attempts to open a connection (SYN Scan).

- If they are sent to multiple ports, this indicates the use of a tool like `nmap`.

---

### 📍 **Example 6: Analyzing Email Connection Problems (SMTP/IMAP)**

#### 📌 Scenario:

One of the users is unable to send email.

#### ✅ Steps:

1. **In Wireshark:**

- Apply filter: `smtp` or `imap`

- Monitor the messages sent and the server's responses.

- Are there any error messages? Is authentication failing? Which IP address is causing the problem?

---
### 📍 **Example 7: Identifying a device consuming excessive traffic**

#### 📌 Scenario:

Network slowdown without knowing the cause.

#### ✅ Steps:

1. **In Wireshark:**

- Statistics → Conversations → Select the IP with the highest volume.

- Analyze the sessions to determine the type of content (video, file transfer, data extraction programs).

2. **Preventive Action:**

- Isolate the device from the network or restrict its use via QoS.

---
### 📍 **Example 8: Detecting DNS Tunneling (Encrypted Data Transfer via DNS)**

#### 📌 Scenario:

The network is experiencing data leaks, and there are no clear HTTP connections.

#### ✅ Steps:

1. **In Wireshark:**

- Apply filter: `dns`

- Are there too many DNS requests to the same domain?

- Are strange queries being sent that resemble encrypted data? For example:
```
GET www.secretdata.base64encoded.example.com
```
2. **Manually analyze the Base64 or monitor the network flow to understand the purpose of the traffic.**

---
### 📍 **Example 9: Detecting a Duplicate Authentication Attempt (Brute Force Login Attempt)**

#### 📌 Scenario:

You suspect a brute-force attack on an SSH server.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `tcp.port == 22`

- Monitor repeated attempts from the same IP over a short period of time.

- Flag a brute-force attempt if authentication attempts fail repeatedly.

2. **Additional Action:**

- Analyze the size of each packet; if small and repeated, indicate login or password attempts.

---

### 📍 **Example 10: Monitoring a Suspicious Tor or VPN Connection**

#### 📌 Scenario:

An employee is suspected of using anonymization tools to bypass censorship.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `tcp.port == 9001 or tcp.port == 443`

- Monitor for very long connections with IP addresses known to be Tor/VPN servers.

- Use GeoIP databases or https://iplists.firehol.org to verify IP addresses.

---

### 📍 **Example 11: Analyzing Web Page Load Slowness Within a Network**

#### 📌 Scenario:

An internal website is taking a long time to load, and you want to determine the cause of the delay.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `http`

- Track TCP handshake: Is it fast?

- Look at the timing of `GET` → `Response` → `Data transfer`

- If the server takes a while to respond, it may be an infrastructure issue.

---

### 📍 **Example 12: Detecting Reverse Engineering Tools (Reverse Shell / Netcat Listener)**

#### 📌 Scenario:

A device has likely compromised the network and is attempting to establish a remote access connection.

#### ✅ Steps:

1. **In tcpdump:**
```
sudo tcpdump -i eth0 port not 80 and port not 443
```

1. - Detect any unusual open ports.

2. **In Wireshark:**

- Filter: `tcp.port != 80 and tcp.port != 443`

- Look for unusual two-way connections, especially on ports like 4444, 1234, and 5555.

- Follow the session: "Follow TCP Stream" → Commands will be displayed if they are unencrypted.

---

### 📍 **Example 13: Analyzing an Internal DNS Data Leak**

#### 📌 Scenario:

Suspect a device is leaking data using DNS queries.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `dns`

- Monitor the number of repeated requests to an unusual or random domain.

- Requests are in an unnatural format, such as:
```
76dhrui32kjnd.example.com
```
1. - Monitor the number of requests and the size of suspicious data → analyze their content.
---
### 📍 **Example 14: Analyzing FTP Sessions and File Transfers**

#### 📌 Scenario:

You want to ensure that file transfers are occurring securely over the internal network.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `ftp-data or ftp`

- Follow commands such as:

- `USER`, `PASS`, `RETR`, `STOR`

- Are file names or passwords exposed? FTP is not encrypted.

2. **A secure alternative?**

- Check if the user is using FTPS or SFTP.

---

### 📍 **Example 15: Detecting an ARP Spoofing / MITM Attack**

#### 📌 Scenario:

Devices are disconnected, or strange DNS issues occur.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `arp`

- Check if a single device is responding to all ARP queries for the same MAC address.

- This means that a device is identifying itself as a router → MITM.

---
### 📍 **Example 16: Analyzing the performance of VoIP protocols (such as SIP or RTP)**

#### 📌 Scenario:

There is a delay or interruption in voice calls over the network.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `sip || rtp`

- Use the built-in tools to analyze the session: Telephony → RTP Streams.

- Check for jitter, packet loss, and delay.

---

### 📍 **Example 17: Monitoring Sent and Received Email (SMTP/POP/IMAP)**

#### 📌 Scenario:

You want to analyze email usage on your network.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `smtp || pop || imap`

- Check for error messages, failed attempts, or attempts to exceed quotas.

- Monitor the sender, recipient, and subject addresses (for some unencrypted protocols).

---

### 📍 **Example 18: Testing for Sensitive Data Leakage**

#### 📌 Scenario:

During a security test, you want to ensure that employees are not sending confidential data without encryption.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `http contains "confidential"` or `tcp contains "password"`

- Look for passwords or sensitive words in the transmitted text data.

---

### 📍 **Example 19: Analyzing a Very Large File Download (Bandwidth Abuse)**

#### 📌 Scenario:

You notice a sudden slowdown in your internet speed. You suspect that one of the devices is downloading large files.

#### ✅ Steps:

1. **In Wireshark:**

- Statistics > Endpoints → IP using the most bandwidth.

- Open the session and look at the file types: `.iso`, `.mp4`, `.exe`.

---

### 📍 **Example 20: Monitoring Login Sessions to an Internal Application**

#### 📌 Scenario:

You want to know who is accessing an internal administrative application and when.

#### ✅ Steps:

1. **In Wireshark:**

- Filter: `http contains "login"`

- Monitor the time of the login data transmission (POST), followed by the response from the server.

- Record the IP and login times for review and analysis.


---
---
---
## استخدام أدوات مثل **LTCP Dump** و**Wireshark** يُعد خطوة أساسية في:

- تأمين الشبكات.
- فهم سلوك المستخدمين والتطبيقات.
- تحليل الحوادث الأمنية.
- بناء أنظمة دفاعية قوية.

## 🧪 **أمثلة عملية باستخدام LTCP Dump وWireshark**
### 📍 **المثال 1: تتبع هجوم (Ping Flood - ICMP DoS Attack)**

#### 📌 السيناريو:

لاحظت الإدارة بطء شديد في الشبكة، وتعتقد أن هناك هجوم إنكار خدمة (DoS).

#### ✅ الخطوات:

1. **استخدام LTCP Dump:**
```
sudo tcpdump icmp
```
	 - يلتقط جميع حزم ICMP (مثل الـ ping).
        
    - لو تم رصد عدد كبير جدًا خلال ثوانٍ → مؤشر لهجوم.
        
- **التحقق عبر Wireshark:**
    
    - Apply filter: `icmp`
        
    - تحليل timestamps: هل يتم إرسال أكثر من 100 ICMP في الثانية؟
        
    - تحقق من IP المهاجم وابدأ بحظره على الفور.

---
### 📍 **المثال 2: استخراج كلمات مرور غير مشفّرة (Telnet/FTP Sniffing)**

#### 📌 السيناريو:

تشتبه في أن أحد المستخدمين يستخدم بروتوكولات غير آمنة (مثل Telnet).

#### ✅ الخطوات:

1. **باستخدام LTCP Dump:**
```
sudo tcpdump -i eth0 port 23 -A
```
	- - يعرض المحتوى النصي لحزم Telnet.
        
- **في Wireshark:**
    
    - Apply filter: `telnet`
        
    - اختر جلسة واحدة → Right click → “Follow TCP stream”.
        
    - يظهر اسم المستخدم وكلمة المرور بالنص الصريح.
 
---
### 📍 **المثال 3: تحليل تبادل بيانات موقع إلكتروني (HTTP)**

#### 📌 السيناريو:

تريد تحليل طلبات واستجابات موقع ويب داخلي يعمل بدون HTTPS.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Apply filter: `http`
        
    - تابع الطلبات: GET/POST
        
    - يمكن رؤية معلومات الجلسات، الكوكيز، وحتى بيانات الإدخال إن لم تكن مشفّرة.
        
2. **في LTCP Dump:**
```
sudo tcpdump -i eth0 port 80 -A
```

---
### 📍 **المثال 4: تتبع تحميل ملف ضار (Malicious File Download)**

#### 📌 السيناريو:

يوجد جهاز قام بتحميل ملف من مصدر مشبوه.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Apply filter: `http contains ".exe"` أو `tcp.port == 80`
        
    - ابحث عن روابط التحميل.
        
    - تتبع مصدر الملف من IP/Domain → تحديد ما إذا كان خبيثًا.
        
2. **احفظ الملف من الحزم (Export Objects):**
    
    - `File > Export Objects > HTTP`
        
    - قم بتحليله لاحقًا باستخدام أدوات مثل VirusTotal أو Cuckoo Sandbox.

---
### 📍 **المثال 5: كشف عملية Port Scanning (مثل استخدام Nmap)**

#### 📌 السيناريو:

شككت بوجود جهاز يرسل اتصالات كثيرة جدًا خلال وقت قصير.

#### ✅ الخطوات:

1. **في LTCP Dump:**
```
sudo tcpdump -n src host 192.168.1.100
```
	 - تعقب الحزم الصادرة من الجهاز المشكوك فيه.
        
2. **في Wireshark:**
    
    - Apply filter: `tcp.flags.syn==1 and tcp.flags.ack==0`
        
    - تشير هذه الحزم إلى محاولات فتح اتصال (SYN Scan).
        
    - إذا تم إرسالها إلى منافذ متعددة → هذا مؤشر على استخدام أداة مثل `nmap`.

---

### 📍 **المثال 6: تحليل مشاكل الاتصال بالبريد الإلكتروني (SMTP/IMAP)**

#### 📌 السيناريو:

أحد المستخدمين لا يستطيع إرسال البريد الإلكتروني.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Apply filter: `smtp` أو `imap`
        
    - راقب الرسائل المرسلة وردود السيرفر.
        
    - هل هناك رسائل خطأ؟ هل المصادقة تفشل؟ أي عنوان IP يسبب المشكلة؟

---
### 📍 **المثال 7: تحديد جهاز يستهلك الترافيك بشكل مفرط**

#### 📌 السيناريو:

بطء في الشبكة دون معرفة السبب.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Statistics → Conversations → اختر أعلى IP من حيث الحجم.
        
    - تحليل الجلسات لمعرفة نوع المحتوى (فيديو، نقل ملفات، برامج سحب بيانات).
        
2. **إجراء وقائي:**
    
    - عزل الجهاز عن الشبكة أو تحديد استخدامه عبر QoS.
        

---

### 📍 **المثال 8: كشف DNS Tunneling (نقل بيانات مشفرة عبر DNS)**

#### 📌 السيناريو:

الشبكة تعاني من تسريب بيانات، ولا توجد اتصالات HTTP واضحة.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Apply filter: `dns`
        
    - هل هناك طلبات DNS كثيرة جدًا إلى نفس النطاق؟
        
    - هل يتم إرسال استفسارات غريبة تشبه بيانات مشفّرة؟ مثل:
```
GET www.secretdata.base64encoded.example.com
```
2. **تحليل يدوي للـ Base64 أو متابعة التدفق الشبكي لفهم الغرض من الترافيك.**

---
### 📍 **المثال 9: كشف محاولة مصادقة مكررة (Brute Force Login Attempt)**

#### 📌 السيناريو:

تشك في أن هناك هجوم brute-force على أحد خوادم SSH.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `tcp.port == 22`
        
    - تابع المحاولات المتكررة من نفس IP خلال فترة زمنية قصيرة.
        
    - إشارة إلى محاولة brute-force إذا تكررت محاولات المصادقة الفاشلة.
        
2. **إجراء إضافي:**
    
    - تحليل حجم كل حزمة، إن كانت صغيرة ومتكررة → مؤشر لمحاولات تسجيل دخول أو إرسال كلمات مرور.
        

---

### 📍 **المثال 10: مراقبة اتصال Tor أو VPN مشبوه**

#### 📌 السيناريو:

يشتبه بأن أحد الموظفين يستخدم أدوات إخفاء الهوية لتجاوز الرقابة.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `tcp.port == 9001 or tcp.port == 443`
        
    - مراقبة الاتصالات الطويلة جدًا مع عناوين IP معروفة بأنها خوادم Tor/VPN.
        
    - استخدام قواعد بيانات GeoIP أو https://iplists.firehol.org للتحقق من IPs.
        

---

### 📍 **المثال 11: تحليل بطء فتح صفحة ويب داخل الشبكة**

#### 📌 السيناريو:

موقع داخلي يستغرق وقتًا طويلاً للتحميل، وتريد تحديد سبب التأخير.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `http`
        
    - Track TCP handshake: هل يتم بسرعة؟
        
    - انظر إلى توقيت `GET` → `Response` → `Data transfer`
        
    - إذا استغرق السيرفر وقتًا في الاستجابة → قد تكون مشكلة في البنية التحتية.
        

---

### 📍 **المثال 12: كشف أدوات الهندسة العكسية (Reverse Shell / Netcat Listener)**

#### 📌 السيناريو:

يُحتمل وجود جهاز اخترق الشبكة ويحاول إنشاء اتصال تحكّم عن بُعد.

#### ✅ الخطوات:

1. **في tcpdump:**
```
sudo tcpdump -i eth0 port not 80 and port not 443
```

1. - كشف أي منافذ غير معتادة مفتوحة.
        
2. **في Wireshark:**
    
    - Filter: `tcp.port != 80 and tcp.port != 443`
        
    - ابحث عن اتصالات غريبة ثنائية الاتجاه، خصوصًا على منافذ مثل 4444، 1234، 5555.
        
    - تابع الجلسة: “Follow TCP Stream” → ستظهر الأوامر إن كانت غير مشفرة.

---

### 📍 **المثال 13: تحليل تسريب بيانات DNS داخلي**

#### 📌 السيناريو:

شكوك حول جهاز يقوم بتسريب بيانات باستخدام DNS queries.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `dns`
        
    - مراقبة عدد الطلبات المتكررة لنطاق غريب أو عشوائي.
        
    - الطلبات تكون بصيغة غير طبيعية مثل:
```
76dhrui32kjnd.example.com
```
1. - تابع عدد الطلبات وحجم البيانات المشبوهة → تحليل محتواها.

---
### 📍 **المثال 14: تحليل جلسات FTP ونقل الملفات**

#### 📌 السيناريو:

تريد التأكد من أن نقل الملفات يتم بطريقة آمنة عبر الشبكة الداخلية.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `ftp-data or ftp`
        
    - تابع أوامر مثل:
        
        - `USER`, `PASS`, `RETR`, `STOR`
            
    - هل أسماء الملفات أو كلمات المرور مكشوفة؟ FTP غير مشفر.
        
2. **بديل آمن؟**
    
    - تحقق إن كان المستخدم يستعمل FTPS أو SFTP.
        

---

### 📍 **المثال 15: كشف هجوم ARP Spoofing / MITM**

#### 📌 السيناريو:

يتم قطع الاتصال عن الأجهزة، أو تظهر مشاكل DNS غريبة.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `arp`
        
    - راقب إن كان جهاز واحد يرد على جميع الاستفسارات ARP لنفس عنوان MAC.
        
    - هذا يعني أن جهازًا يُعرّف نفسه بأنه الراوتر → MITM.
        

---

### 📍 **المثال 16: تحليل أداء بروتوكولات VoIP (مثل SIP أو RTP)**

#### 📌 السيناريو:

هناك تأخير أو تقطيع في مكالمات الصوت عبر الشبكة.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `sip || rtp`
        
    - استخدم الأدوات المدمجة لتحليل الجلسة: Telephony → RTP Streams.
        
    - تحقق من jitter، packet loss، التأخير (delay).
        

---

### 📍 **المثال 17: مراقبة البريد الإلكتروني المرسل والمستلم (SMTP/POP/IMAP)**

#### 📌 السيناريو:

تريد تحليل استخدام البريد الإلكتروني في الشبكة.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `smtp || pop || imap`
        
    - تحقق من رسائل الخطأ، المحاولات الفاشلة، أو محاولات تجاوز الحصص.
        
    - متابعة عنوان المرسل، المستلم، والموضوع (في بعض البروتوكولات غير المشفرة).
        

---

### 📍 **المثال 18: اختبار مدى تسرب البيانات الحساسة (Data Leakage)**

#### 📌 السيناريو:

أثناء اختبار أمني، تريد التأكد أن الموظفين لا يرسلون بيانات سرية بدون تشفير.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `http contains "confidential"` أو `tcp contains "password"`
        
    - ابحث عن كلمات مرور أو كلمات حساسة ضمن البيانات المرسلة نصيًا.
        

---

### 📍 **المثال 19: تحليل تحميل ملف كبير جدًا (Bandwidth Abuse)**

#### 📌 السيناريو:

رصدت تباطؤًا مفاجئًا في سرعة الإنترنت، تشك أن أحد الأجهزة يقوم بتنزيل ملفات ضخمة.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Statistics > Endpoints → أكثر IP استهلاكًا للباندويث.
        
    - افتح الجلسة وانظر إلى أنواع الملفات: `.iso`, `.mp4`, `.exe`.
        

---

### 📍 **المثال 20: مراقبة جلسات تسجيل الدخول إلى تطبيق داخلي**

#### 📌 السيناريو:

تريد معرفة من يدخل إلى تطبيق داخلي إداري ووقت الدخول.

#### ✅ الخطوات:

1. **في Wireshark:**
    
    - Filter: `http contains "login"`
        
    - راقب توقيت إرسال بيانات الدخول (POST)، ثم الرد من السيرفر.
        
    - سجل IP وأوقات الدخول للمراجعة والتحليل.

### By Abdelwahab Shandy