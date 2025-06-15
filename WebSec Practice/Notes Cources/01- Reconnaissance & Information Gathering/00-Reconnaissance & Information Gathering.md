## 🔍 Reconnaissance & Information Gathering

**المرحلة الثانية من دورة اختبار الاختراق - جمع المعلومات عن الهدف**

---

### 🧭 تعريف المرحلة

* الهدف: التعرف على مكونات الهدف وجمع أكبر كم من المعلومات عنه.
* الطريقتان الأساسيتان:

  * **Active Reconnaissance** (استطلاع مباشر)
  * **Passive Reconnaissance** (استطلاع غير مباشر)

---

### 🆚 الفرق بين Active و Passive Recon

| النوع       | الوصف                       | مثال                     | المميزات  | العيوب             |
| ----------- | --------------------------- | ------------------------ | --------- | ------------------ |
| **Active**  | تفاعل مباشر مع الهدف        | تصفح الموقع              | دقة أعلى  | يترك آثار (IP، OS) |
| **Passive** | جمع معلومات دون تفاعل مباشر | استخدام أدوات مثل Shodan | أكثر سرية | قد لا تكون شاملة   |

---

### 🛠️ أدوات الاستطلاع

#### 1. **Shodan**

* محرك بحث مخصص للأجهزة المتصلة بالإنترنت.
* يقوم بعمل **scan** شامل لعناوين IPv4.
* يمكن استخدامه للبحث عن:

  * نوع السيرفر (Apache, Nginx)
  * البورتات المفتوحة
  * نظام التشغيل
  * الشهادات الرقمية
  * الثغرات المرتبطة بالإصدار

**مثال استخدام:**

```bash
apache country:"NL"
```

> يعرض سيرفرات Apache في هولندا.

---

#### 2. **Censys**

* أداة مشابهة لـ Shodan لكنها تعرض البيانات بشكل منظم أكثر.
* يمكنها إظهار:

  * الأنظمة المشغلة للسيرفر (Linux/Windows)
  * معلومات Load Balancer
  * شهادات SSL
  * الاستجابة (HTTP Status)
  * السب دومينز المرتبطة

---

#### 3. **crt.sh**

* موقع مختص بتحليل شهادات SSL/TLS.
* يفيد في:

  * معرفة **السب دومينز** الخاصة بالدومين.
  * التحقق من صلاحية الشهادة وتاريخ انتهائها.
  * معرفة أسماء الدومينات المرتبطة بنفس الشهادة.

---

### 🧠 خطوات عملية لجمع المعلومات

#### ✅ الخطوة الأولى:

* زيارة الموقع يدوياً (Active Recon).
* فحص:

  * الصفحات (Login, Register, Contact)
  * الـ JavaScript أو Client-Side Code
  * Headers والمعلومات المخفية

#### ✅ الخطوة الثانية:

* البدء بجمع معلومات من الأدوات السابقة (Passive Recon):

  * Shodan → معرفة الـ IPs وPorts وServices.
  * Censys → فحص الإصدار ونظام التشغيل.
  * crt.sh → استخراج قائمة السب دومينز.

---

### ⚠️ ملاحظات هامة

* يجب أن تكون **الدومينات أو السب دومينز** التي تقوم بفحصها **مذكورة ضمن الـ Scope** المسموح به من قبل صاحب المشروع.
* لا يجوز فحص خدمات خارج هذا النطاق (حتى وإن كانت مرتبطة تقنياً) لتفادي **مشاكل قانونية**.

---

### 📎 روابط مفيدة

* [Shodan](https://www.shodan.io/)
* [Censys](https://search.censys.io/)
* [crt.sh](https://crt.sh/)
* [builtwith](https://builtwith.com/)
* [Whois](https://whois.domaintools.com/)
* [mxtoolbox](https://mxtoolbox.com/)
* [GoogleDorking.md](https://gist.github.com/sundowndev/283efaddbcf896ab405488330d1bbc06)
* [GoogleDorking](https://www.exploit-db.com/google-hacking-databas)

---

### 🎯 الهدف النهائي

> توسعة نطاق **Attack Surface** من خلال تحديد:

* الأنظمة المستخدمة
* الخدمات المتاحة
* البورتات المفتوحة
* نقاط الضعف المحتملة


--- 

## 🔍 Reconnaissance & Information Gathering

**The Second Phase of the Penetration Testing Cycle - Gathering Information About the Target**

---

### 🧭 Phase Definition

* Objective: Identify the target's components and gather as much information about it as possible.
* Two Basic Methods:

* **Active Reconnaissance** (Direct Reconnaissance)
* **Passive Reconnaissance** (Indirect Reconnaissance)

---

### 🆚 The Difference Between Active and Passive Recon

| Type | Description | Example | Advantages | Disadvantages |
| ---------- | ----------- | ----------- | ------------------ |
| **Active** | Direct Interaction with the Target | Website Browsing | Higher Accuracy | Leaves Traces (IP, OS) |
| **Passive** | Gather Information Without Direct Interaction | Use Tools Like Shodan | More Secretive | May Not Be Comprehensive |

---

### 🛠️ Survey Tools

#### 1. **Shodan**

* A search engine dedicated to devices connected to the Internet.
* Performs a comprehensive **scan** of IPv4 addresses.
* Can be used to search for:

* Server type (Apache, Nginx)
* Open ports
* Operating system
* Digital certificates
* Version-related vulnerabilities

**Example usage:**

```bash
apache country:"NL"
```

> Displays Apache servers in the Netherlands.

---

#### 2. **Censys**

* A tool similar to Shodan but displays data in a more organized format.
* It can display:

* Server operating systems (Linux/Windows)
* Load Balancer information
* SSL certificates
* Response (HTTP Status)
* Associated subdomains

---

#### 3. **crt.sh**

* A website specializing in analyzing SSL/TLS certificates.
* Useful for:

* Identifying the subdomains of a domain.
* Verifying the validity and expiration date of the certificate.
* Identifying the domain names associated with the same certificate.

---

### 🧠 Practical steps to gather information

#### ✅ Step One:

* Manually visit the site (Active Recon).
* Check:

* Pages (Login, Register, Contact)
* JavaScript or Client-Side Code
* Headers and Hidden Information

#### ✅ Step Two:

* Start gathering information from the previous tools (Passive Recon):

* Shodan → Find IPs, Ports, and Services.
* Censys → Check the Version and Operating System.
* crt.sh → Extract the Subdomains List.

---

### ⚠️ Important Notes

* The domains or subdomains you are checking must be listed within the Scope allowed by the project owner.
* Services outside this scope (even if they are technically related) may not be checked to avoid legal issues.

---

### 📎 Useful Links

* [Shodan](https://www.shodan.io/)
* [Censys](https://search.censys.io/)
* [crt.sh](https://crt.sh/)

---

### 🎯 Ultimate Goal

> Expand the scope of **Attack Surface** by identifying:

* Systems used
* Services available
* Open ports
* Potential vulnerabilities

---

### By Abdelwahab Shandy 