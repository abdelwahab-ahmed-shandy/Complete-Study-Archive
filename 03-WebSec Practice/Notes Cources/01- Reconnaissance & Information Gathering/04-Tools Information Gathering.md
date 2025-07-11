	- Tool Description
	- How to Install
	- Usage Commands
	- Practical Examples
---
# 🛡️ **دليل أدوات Information Gathering الشامل**
## 🔸 1. WhatWeb

**الوصف:** تكشف التقنيات المستخدمة في مواقع الويب.

### ✅ التثبيت:
```
sudo apt install whatweb
```

### 🧪 الاستخدام:
```
`whatweb http://example.com`
```

### 🧾 أمثلة:

- فحص موقع واحد:
```
whatweb http://testphp.vulnweb.com
```

- وضع عدواني:
```
whatweb -a 3 http://example.com
```

- من ملف:
```
whatweb -i targets.txt
```

---
## 🔸 2. ffuf (Fuzz Faster U Fool)

**الوصف:** أداة Fuzzing لاكتشاف الملفات والمعلمات والدلائل.

### ✅ التثبيت:
```
sudo apt install ffuf
```
### 🧪 الاستخدام:
```
ffuf -u http://example.com/FUZZ -w wordlist.txt
```

### 🧾 أمثلة:

- دلائل:
```
ffuf -u http://testphp.vulnweb.com/FUZZ -w /usr/share/wordlists/dirb/common.txt
```

معلمات:
```
ffuf -u http://example.com/index.php?FUZZ=test -w params.txt
```

ملفات .php:
```
ffuf -u http://example.com/FUZZ.php -w list.txt
```

---
## 🔸 3. Nikto

**الوصف:** فحص خوادم الويب بحثًا عن ثغرات وإعدادات خاطئة.

### ✅ التثبيت:
```
sudo apt install nikto
```

### 🧪 الاستخدام:
```
nikto -h http://example.com
```

### 🧾 أمثلة:

- فحص على بورت معين:

```
nikto -h http://example.com -p 8080
```

إخراج النتائج في ملف:
```
nikto -h http://example.com -o result.txt
```

---
## 🔸 4. WPScan

**الوصف:** فحص ثغرات WordPress والمستخدمين والثيمات والإضافات.

### ✅ التثبيت:
```
sudo apt install wpscan
```

> تحتاج مفتاح API من [https://wpscan.com](https://wpscan.com)

### 🧪 الاستخدام:
```
wpscan --url http://example.com
```
### 🧾 أمثلة:

- المستخدمين:
```
wpscan --url http://example.com -e u
```
- الثغرات:
```
wpscan --url http://example.com --api-token YOUR_TOKEN
```

---
## 🔸 5. Nmap

**الوصف:** فحص الشبكة، المنافذ، الخدمات، أنظمة التشغيل.

### ✅ التثبيت:
```
sudo apt install nmap
```
### 🧪 الاستخدام:
```
nmap [options] [target]
```
### 🧾 أمثلة:

- فحص بسيط:
```
nmap 192.168.1.1
```
- مع كشف الخدمات:
```
nmap -sV -sC 192.168.1.1
```
- كشف نظام التشغيل:
```
nmap -O 192.168.1.1
```
- فحص نطاق:
```
nmap 192.168.1.0/24
```

---
## 🔸 6. dnsrecon

**الوصف:** جمع وتحليل سجلات DNS، ومحاولة zone transfer.

### ✅ التثبيت:
```
sudo apt install dnsrecon
```
### 🧪 الاستخدام:
```
dnsrecon -d example.com
```
### 🧾 أمثلة:

- محاولة zone transfer:
```
dnsrecon -d example.com -a
```
- brute force subdomains:
```
dnsrecon -d example.com -D wordlist.txt -t brt
```

---

## 🔸 7. theHarvester

**الوصف:** جمع الإيميلات، أسماء المستخدمين، الـ IPs من الإنترنت.

### ✅ التثبيت:
```
sudo apt install theharvester
```
### 🧪 الاستخدام:
```
`theHarvester -d example.com -b google`
```
### 🧾 أمثلة:

- البحث عبر Bing:
```
theHarvester -d example.com -b bing
```

---

## 🔸 8. Amass

**الوصف:** أفضل أداة لـ Subdomain Enumeration والتحقق.

### ✅ التثبيت:
```
sudo apt install amass
```
### 🧪 الاستخدام:
```
amass enum -d example.com`
```
### 🧾 أمثلة:
- استخدم Passive mode:
```
amass enum -passive -d example.com
```

---
## 🔸 9. Sublist3r
**الوصف:** أداة سريعة لاكتشاف الـ Subdomains.
### ✅ التثبيت:
```
sudo apt install sublist3r
```
### 🧪 الاستخدام:
```
sublist3r -d example.com
```

---
## 🔸 10. Recon-ng

**الوصف:** إطار متكامل لجمع المعلومات مثل Metasploit.
### ✅ التثبيت:
```
sudo apt install recon-ng
```
### 🧪 الاستخدام:
```
recon-ng
```
### 🧾 أمثلة داخل الأداة:
```
workspace create example modules load recon/domains-hosts/google_site set SOURCE example.com run
```

---
## 🔸 11. Maltego (GUI)

**الوصف:** أداة رسومية لرسم العلاقات وتحليل الكيانات.

	### ✅ التثبيت:
	- حمّل من: https://www.maltego.com/downloads/
	- تحتاج تسجيل حساب.
---
## 🔸 12. SpiderFoot

**الوصف:** أداة OSINT شاملة مع واجهة CLI وWeb.
### ✅ التثبيت:
```
sudo apt install spiderfoot
```
### 🧪 الاستخدام:
```
spiderfoot -s example.com -l 127.0.0.1:5001
```

---
## 🔸 13. Shodan CLI
**الوصف:** البحث عن الأجهزة المتصلة بالإنترنت.
### ✅ التثبيت:
```
pip install shodan shodan init YOUR_API_KEY
```
### 🧪 الاستخدام:
```
shodan search apache
```
---
## 🔸 14. Censys
**الوصف:** بديل لـ Shodan لجمع معلومات الخدمات والبورتات.
### ✅ التثبيت:
```
pip install censys
```
### 🧪 الاستخدام:
```
censys search "services.service_name: HTTP"
```

---
## 🔸 15. Metagoofil
**الوصف:** استخراج metadata من الملفات المنشورة علنًا.
### ✅ التثبيت:

```
git clone https://github.com/laramies/metagoofil cd metagoofil && sudo pip install -r requirements.txt
```
### 🧪 الاستخدام:
```
python metagoofil.py -d example.com -t pdf,doc -l 20 -o output -f result.html
```

---
# 📊 مقارنة مختصرة :

| الأداة       | الاستخدام الرئيسي               | واجهة   |
| ------------ | ------------------------------- | ------- |
| WhatWeb      | كشف تقنيات الويب                | CLI     |
| ffuf         | Fuzzing للملفات والدلائل        | CLI     |
| Nikto        | فحص ثغرات مواقع                 | CLI     |
| WPScan       | WordPress Vulnerability Scanner | CLI     |
| Nmap         | فحص الشبكة والمنافذ والخدمات    | CLI     |
| dnsrecon     | تحليل الـ DNS                   | CLI     |
| theHarvester | جمع إيميلات ومستخدمين           | CLI     |
| Amass        | Subdomain Enumeration           | CLI     |
| Sublist3r    | Subdomains سريع                 | CLI     |
| Recon-ng     | OSINT متكامل                    | CLI     |
| Maltego      | تحليل بصري وعلاقات              | GUI     |
| SpiderFoot   | جمع معلومات تلقائي OSINT        | GUI/CLI |
| Shodan       | بحث عن الأجهزة                  | CLI     |
| Censys       | بحث في الإنترنت العميق          | CLI     |
| Metagoofil   | استخراج Metadata                | CLI     |

---

	Abdelwahab Shandy