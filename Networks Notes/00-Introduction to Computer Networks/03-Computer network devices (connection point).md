# أجهزة شبكات الحاسبات — نقطة التوصيل (Access Point)

## مقدمة
نقطة التوصيل (Access Point - AP) تعد من أهم مكونات الشبكات اللاسلكية، حيث تسمح بربط الأجهزة اللاسلكية مثل الهواتف الذكية، الحواسيب المحمولة، والأجهزة اللوحية بالشبكة السلكية المحلية (LAN) من خلال بث واستقبال الموجات الكهرومغناطيسية عبر هوائياتها.

---

## الوظائف الأساسية لـ Access Point

- 📡 **جسر بين الشبكات اللاسلكية والسلكية:**  
  AP يحوّل الإشارات الكهربائية (التي تصل عبر كابل RJ-45 Ethernet) إلى إشارات كهرومغناطيسية والعكس صحيح، ليتمكن جهاز مثل اللابتوب من الاتصال بالشبكة السلكية.

- 🔄 **نطاق تصادم واحد (Collision Domain):**  
  جميع الأجهزة المتصلة بنفس الـ AP تشترك في نفس المجال، ما يجعل التصادمات ممكنة. يتم تقليل هذه التصادمات باستخدام بروتوكول **CSMA/CA** (Carrier Sense Multiple Access with Collision Avoidance).

---

## بروتوكولات تجنب التصادم (CSMA/CA)

- يستخدم AP بروتوكول CSMA/CA لمنع التصادمات اللاسلكية عبر ميكانيزم:
  - **RTS (Request to Send):** يطلب الإذن قبل إرسال البيانات.
  - **CTS (Clear to Send):** يعطى الإذن لجهاز واحد فقط بالإرسال.
- هذه الطريقة تحسّن الأداء، خاصةً في البيئات المزدحمة مثل الشركات أو المطارات.

---

## SSID (معرّف مجموعة الخدمة)

- 🔑 كل شبكة لاسلكية تملك **SSID** (اسم الشبكة) يصل طوله حتى 32 حرفًا.
- يمكن:
  - بث الـ SSID علنًا (Visible Network).
  - إخفاء الـ SSID (Hidden Network) لتحسين الأمان، حيث يتطلب من المستخدم كتابة الاسم يدويًا.
- نقطة التوصيل الواحدة قد تدعم **عدة SSIDs** (مثلاً: شبكة للضيوف وأخرى للموظفين).

---

## الأمان والتحكم في الوصول

- 🛡️ **تصفية العناوين (Filtering):**
  - يمكن لـ AP تقييد الوصول حسب:
    - **MAC Address Filtering:** السماح فقط لأجهزة محددة بناءً على عنوان MAC.
    - **IP Address Filtering:** التحكم في الوصول عبر عناوين IP.

- 🔐 **التشفير (Encryption):**
  - WEP (قديم - ضعيف الأمان).
  - WPA / WPA2 (أكثر أمانًا).
  - **AES** (Advanced Encryption Standard) مع WPA2 هو الأفضل حاليًا.
  - WPA3 (الأحدث، لكن لا يزال قيد الانتشار).

- 🔄 **عزل العملاء (Client Isolation):**
  - تمنع الأجهزة المتصلة بنفس الـ AP من التواصل مع بعضها، مفيدة في الشبكات العامة.

---

## خصائص إضافية لنقطة التوصيل

- 📶 **Multiple SSIDs:** يمكن للـ AP توفير أكثر من شبكة في نفس الوقت مع سياسات مختلفة.
- 🌐 **VLAN Integration:** ربط كل SSID بشبكة محلية ظاهرية (VLAN) لفصل حركة المرور.
- ⚙️ **Power over Ethernet (PoE):** تزويد الـ AP بالطاقة والكهرباء عبر نفس كابل الإيثرنت.
- 🔄 **Roaming Support:** دعم تنقل الأجهزة بين عدة APs بدون انقطاع الاتصال.
- 📈 **QoS (Quality of Service):** لتحديد أولويات أنواع معينة من البيانات مثل المكالمات الصوتية أو الفيديو.
- 🔍 **Monitoring and Management:** عبر واجهات إدارة مثل واجهة الويب أو SNMP.

---

## مقارنة بين AP والراوتر

| الميزة               | Access Point | Router  |
|---------------------|-------------|---------|
| توصيل الأجهزة اللاسلكية | ✅          | ✅      |
| توصيل الأجهزة السلكية | ❌ (إلا إذا كان يحتوي منافذ إضافية) | ✅ |
| توزيع عناوين IP (DHCP) | ❌ (إلا في بعض الأنواع المتقدمة) | ✅ |
| جدار الحماية (Firewall) | ❌         | ✅      |
| الربط بالإنترنت      | ❌         | ✅      |

---

## ملحوظات إضافية (Did You Know?)

- 🎯 نقطة التوصيل ليست جهاز "راوتر"؛ فهي تحتاج إلى راوتر لتوجيه البيانات خارج الشبكة المحلية.
- 🏢 تستخدم المؤسسات الكبيرة عدة APs لإنشاء تغطية واسعة مع دعم التنقل (Seamless Roaming).
- 🔌 يمكن لبعض الـ APs أن تعمل أيضًا كنقطة توزيع (Repeater) لتوسيع مدى الشبكة اللاسلكية.

---

## خلاصة

نقطة التوصيل عنصر حيوي في الشبكات اللاسلكية الحديثة، حيث تؤدي دور الوسيط بين الأجهزة المحمولة والبنية التحتية السلكية، مع تقديم مزايا أمان، تحكم، وتوسعة ضرورية لأي بيئة شبكية فعالة.

---

---

# Computer Networking Devices — Access Point

## Introduction
An access point (AP) is one of the most important components of wireless networks. It allows wireless devices such as smartphones, laptops, and tablets to connect to a wired local area network (LAN) by transmitting and receiving electromagnetic waves through its antennas.

---
## Basic Functions of an Access Point

- 📡 **Bridge between wireless and wired networks:**
The AP converts electrical signals (which arrive via an RJ-45 Ethernet cable) into electromagnetic signals and vice versa, enabling a device such as a laptop to connect to a wired network.

- 🔄 **Collision Domain:**
All devices connected to the same AP share the same domain, making collisions possible. These collisions are reduced using the **CSMA/CA** (Carrier Sense Multiple Access with Collision Avoidance) protocol.

---

## Collision Avoidance Protocols (CSMA/CA)

- The AP uses the CSMA/CA protocol to prevent wireless collisions via the following mechanisms:
- **RTS (Request to Send):** Requests permission before sending data.
- **CTS (Clear to Send):** Only one device is given permission to transmit.
- This method improves performance, especially in crowded environments such as businesses or airports.

---
## SSID (Service Set Identifier)

- 🔑 Each wireless network has an **SSID** (network name) of up to 32 characters.
- It is possible to:
- Broadcast the SSID publicly (Visible Network).
- Hide the SSID (Hidden Network) to improve security, requiring the user to manually type the name.
- A single access point may support **multiple SSIDs** (for example, a guest network and another for employees).

---

## Security and Access Control

- 🛡️ **Address Filtering:**
- The AP can restrict access based on:
- **MAC Address Filtering:** Allow only specific devices based on MAC address.
- **IP Address Filtering:** Control access via IP addresses.

- 🔐 **Encryption:**
- WEP (old - weak security).
- WPA / WPA2 (more secure).
- **AES** (Advanced Encryption Standard), with WPA2 currently the best.
- WPA3 (newer, but still in widespread use).

- 🔄 **Client Isolation:**
- Prevents devices connected to the same AP from communicating with each other, useful in public networks.

---

## Additional Access Point Features

- 📶 **Multiple SSIDs:** The AP can provide access to more than one network at the same time with different policies.
- 🌐 **VLAN Integration:** Bind each SSID to a virtual local area network (VLAN) to separate traffic.
- ⚙️ **Power over Ethernet (PoE):** Provides power and electricity to the AP over the same Ethernet cable.
- 🔄 **Roaming Support:** Supports device movement between multiple APs without disconnecting.
- 📈 **QoS (Quality of Service):** To prioritize specific types of data, such as voice or video calls.
- 🔍 **Monitoring and Management:** Via management interfaces such as the web interface or SNMP.

---

## Comparison Between an AP and a Router

| Feature | Access Point | Router |
|------------------------------|

| Connecting Wireless Devices | ✅ | ✅ |
| Connecting Wired Devices | ❌ (unless it has additional ports) | ✅ |
| Distributing IP Addresses (DHCP) | ❌ (except in some advanced models) | ✅ |
| Firewall | ❌ | ✅ |
| Connecting to the Internet | ❌ | ✅ |

---

## Additional Notes (Did You Know?)

- 🎯 An access point is not a router; it requires a router to route data outside the local network.
- 🏢 Large organizations use multiple APs to create wide coverage with support for Seamless Roaming.
- 🔌 Some APs can also function as a repeater to extend the range of the wireless network.

---

## Summary

The access point is a vital component of modern wireless networks, acting as an intermediary between mobile devices and the wired infrastructure, while providing the security, control, and scalability features essential to any effective network environment.