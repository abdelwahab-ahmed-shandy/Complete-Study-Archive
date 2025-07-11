# 🧪 **Most Common Wireshark Display Filters – With Explanations and Use Cases**

| 🔍 Filter                                   | 📌 Description                                                       | 🧰 Real-World Use Case                                    |
| ------------------------------------------- | -------------------------------------------------------------------- | --------------------------------------------------------- |
| `ip.addr == 192.168.1.5`                    | Shows all packets where this IP is either the source or destination. | Monitor traffic from/to a specific device.                |
| `ip.src == 192.168.1.5`                     | Shows only packets **sent by** this IP address.                      | Detect unusual outbound traffic or data exfiltration.     |
| `ip.dst == 8.8.8.8`                         | Shows only packets **going to** this IP.                             | Track communication with external services like DNS.      |
| `tcp.port == 80`                            | Filters packets on **port 80**, usually HTTP.                        | Analyze unencrypted web traffic.                          |
| `udp.port == 53`                            | Filters **DNS traffic** over UDP.                                    | Monitor DNS queries and detect tunneling or leaks.        |
| `tcp.flags.syn == 1 and tcp.flags.ack == 0` | Shows only **SYN** packets initiating TCP handshakes.                | Detect port scanning or SYN flood attacks.                |
| `http`                                      | Displays only HTTP protocol packets.                                 | Inspect website requests, headers, and data.              |
| `http.request.uri contains "login"`         | Searches for URLs containing “login” in requests.                    | Track login attempts or identify brute-force targets.     |
| `tcp.stream eq 5`                           | Shows only packets in TCP stream number 5.                           | Follow a full session (e.g., login, file transfer).       |
| `ftp`                                       | Displays all FTP traffic.                                            | Monitor file uploads/downloads over insecure FTP.         |
| `icmp`                                      | Filters ICMP packets like **ping requests/replies**.                 | Detect ping sweeps, flooding, or connectivity checks.     |
| `arp`                                       | Filters ARP protocol traffic.                                        | Detect ARP spoofing or investigate local network mapping. |
| `dns`                                       | Displays all DNS query and response packets.                         | Identify domain lookups and suspicious DNS activity.      |
| `frame contains "password"`                 | Searches all packet content for the word “password”.                 | Catch plaintext password leakage.                         |
| `tcp contains "admin"`                      | Finds TCP packets with the word "admin" in data.                     | Discover attempts to access admin panels.                 |
| `tls` or `ssl`                              | Shows encrypted traffic like HTTPS, SMTP over TLS.                   | Check if communication is encrypted and secure.           |
| `not arp and not dns and not icmp`          | Excludes background traffic; focuses on core protocols.              | Useful for decluttering the packet view.                  |
| `tcp.len > 0`                               | Shows packets **containing actual data**, not just control flags.    | Focus on meaningful communication.                        |
| `tcp.analysis.flags`                        | Highlights retransmissions, delays, and dropped packets.             | Troubleshoot network performance and reliability issues.  |

---
## ✅ Important Notes for Understanding Filters

### 1. ✅ **You can combine filters:**

```
ip.src == 10.0.0.5 and tcp.port == 443
```
- To analyze traffic for a specific device on HTTPS only.
---
### 2. ✅ **A filter containing a word:**

```
http contains "login"
```
- Good for tracking login pages or POSTs.
---
### 3. ✅ **A filter to track a specific session:**
```
Follow → TCP Stream
```
- Or use:
```
tcp.stream eq X
```
- where X is the session number that appears when tracking any packet.
---
## 🧠 Scenario-Based Use Cases:

|🧭 Goal|✅ Suggested Filter|
|---|---|
|Monitor a device’s network usage|`ip.addr == 192.168.1.x`|
|Detect port scanning or SYN flood|`tcp.flags.syn == 1 and tcp.flags.ack == 0`|
|Analyze web browsing behavior|`http`|
|Monitor DNS queries|`dns`|
|Check for leaked credentials|`frame contains "password"`|
|Follow a single session|Use `tcp.stream eq X` (right-click > Follow TCP Stream)|
|Detect ARP spoofing|`arp`|
|Investigate network slowness|`tcp.analysis.flags`|
|Verify encrypted traffic|`tls` or `ssl`|
|Monitor file downloads (e.g. EXE or ZIP)|`http contains ".exe"` or `http contains ".zip"`|


---
---
---
# 🧪 أشهر فلاتر Wireshark (Display Filters)

|🔍 الفلتر|📌 الوصف|🧰 مثال تطبيقي|
|---|---|---|
|`ip.addr == 192.168.1.5`|يعرض كل الحزم التي يكون فيها هذا العنوان إما مصدرًا أو هدفًا.|تتبع نشاط جهاز معين داخل الشبكة.|
|`ip.src == 192.168.1.5`|يعرض الحزم التي يكون مصدرها هذا الـ IP فقط.|كشف محاولات إرسال مشبوهة من جهاز معيّن.|
|`ip.dst == 8.8.8.8`|يعرض الحزم المتوجهة إلى عنوان محدد.|تتبع الاتصالات إلى DNS خارجي أو جهة مشبوهة.|
|`tcp.port == 80`|يعرض فقط الحزم التي تستخدم بروتوكول TCP عبر المنفذ 80 (HTTP).|تحليل حركة الويب غير المشفّرة.|
|`udp.port == 53`|يعرض حركة DNS على بروتوكول UDP (افتراضيًا).|مراقبة طلبات وتحليل تسريبات DNS.|
|`tcp.flags.syn == 1 and tcp.flags.ack == 0`|يعرض الحزم التي تحاول إنشاء اتصال TCP (SYN).|كشف عمليات Port Scanning أو SYN Flood.|
|`http`|يعرض فقط الحزم التي تستخدم بروتوكول HTTP.|مراقبة الطلبات إلى مواقع الويب.|
|`http.request.uri contains "login"`|يبحث عن طلبات تحتوي على كلمة “login” في عنوان URL.|تتبع صفحات تسجيل الدخول أو محاولات اختراق.|
|`tcp.stream eq 5`|يعرض فقط الحزم المرتبطة بتدفق TCP رقم 5.|تتبع جلسة محددة لتحليل حوار كامل (TCP Conversation).|
|`ftp`|عرض كل حركة FTP (نقل الملفات غير المشفّر).|البحث عن نقل كلمات مرور أو ملفات حساسة.|
|`icmp`|يعرض كل حزم ICMP (مثل الـ Ping).|كشف عمليات Ping Flood أو المسح الشبكي.|
|`arp`|يعرض فقط رسائل ARP.|تحليل مشاكل ARP أو كشف ARP Spoofing.|
|`dns`|عرض جميع حزم DNS.|مراقبة النطاقات التي يتم الوصول لها أو اكتشاف tunneling.|
|`frame contains "password"`|يبحث عن كلمة "password" داخل محتوى الحزم.|تتبع تسريب بيانات غير مشفرة.|
|`tcp contains "admin"`|يعرض الحزم التي تحتوي على الكلمة "admin" في البيانات.|تحليل محاولات وصول إلى حسابات إدارية.|
|`tls` أو `ssl`|يعرض كل الترافيك المشفر باستخدام TLS/SSL (HTTPS مثلًا).|تأكيد تشفير الترافيك أو تحليل الشهادات.|
|`not arp and not dns and not icmp`|تصفية الحزم لعرض فقط الترافيك الأساسي (مثلاً TCP/UDP الحقيقي).|التركيز على التطبيقات دون الترافيك الثانوي.|
|`tcp.len > 0`|عرض الحزم التي تحتوي على بيانات فقط (ليست تحكم فقط).|التركيز على الجلسات التي تنقل بيانات حقيقية.|
|`tcp.analysis.flags`|عرض الحزم التي تشير إلى مشاكل مثل التأخير، إعادة الإرسال، فقدان حزم.|تحليل مشاكل الشبكة أو الأداء.|

---

## ✅ ملاحظات هامة لفهم الفلاتر

### 1. ✅ **يمكنك دمج الفلاتر:**

```
ip.src == 10.0.0.5 and tcp.port == 443
```
	- لتحليل حركة جهاز معين على HTTPS فقط.
---
### 2. ✅ **فلتر يحتوي على كلمة:**

```
http contains "login"
```
	- جيد لتتبع صفحات تسجيل الدخول أو عمليات POST.
---
### 3. ✅ **فلتر لتتبع جلسة محددة:**
```
Follow → TCP Stream
```
- أو استخدم:
```
tcp.stream eq X
```
	- حيث X هو رقم الجلسة الذي يظهر عند تتبع أي حزمة.

## 🧠 سيناريوهات استخدام الفلاتر:

|🎯 الحالة|🧪 الفلتر المناسب|
|---|---|
|تريد تحليل كل الاتصالات من جهاز معيّن|`ip.src == [عنوان الجهاز]`|
|تشتبه في محاولة تسجيل دخول مشبوهة|`http.request.uri contains "login"`|
|تريد فحص DNS tunneling|`dns` + راقب أسماء نطاقات غريبة وطويلة|
|تشك في DoS أو Flood|`icmp`, `tcp.flags.syn == 1`|
|تحقيق في بطء الشبكة|`tcp.analysis.flags` لتحليل التأخير وإعادة الإرسال|
|البحث عن كلمات مرور|`frame contains "password"` أو `tcp contains "pass"`|
|تتبع نقل ملفات غير مشفر|`ftp` أو `http contains ".zip"`|

---
**By : AbdelwahabShandy**
