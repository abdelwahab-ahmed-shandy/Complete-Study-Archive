# Reconnaissance & Information Gathering

## المديول الثاني: استطلاع وجمع المعلومات

في هذا المديول نبدأ بأول خطوة عملية وهي الاستطلاع (Reconnaissance)

هدف هذه المرحلة هو معرفة كل ما يتعلق بالهدف ومكوناته وكيفية الوصول لمعلومات مفصلة عنه.

يتم الاستطلاع عن طريق أسلوبين:

1. **Active Reconnaissance**
2. **Passive Reconnaissance**

### الفرق الرئيسي بينهما:

* **Active Reconnaissance**: عندما نزور الموقع مباشرة ونستكشف محتوياته (مثل الصفحات والكود والتقنيات المستخدمة). هذا الاسلوب يسبت آثاراً على الويب سيرفر كرقم الآي بي ونوع المتصفح ونظام التشغيل.

* **Passive Reconnaissance**: نستخدم أدوات جانبية تنفذ عمليات الاستطلاع بدون تفاعل مباشر مع الموقع.

## أهم الأدوات لجمع المعلومات

### 1. **Shodan**

* محرك بحث لكل أنظمة الإنترنت (شبيه بـ Scanner)
* يمكنك البحث عن ويب سيرفرز معينة وتقنيات مع تحديد الدولة
* يعرض: Open Ports والخدمات المفتوحة ونوع السيرفر والمنظمة المستضيفة

### 2. **Censys**

* مشابهة لشودن ولكن أكثر تنظيماً في عرض البيانات
* يعرض: OS, Load Balancer, Open Ports, HTTP Status, SSL Certificate Info

### 3. **crt.sh (Certificate Transparency Logs)**

* يستعرض الدومينات والسب دومينات المرتبطة بشهادات SSL
* يمكن استعراض مواعيد انتهاء الشهادات والتجديد
* هذا يفيد في كشف الأنظمة الفعلية والسب دومينات للهدف

## ملاحظة مهمة:

قبل أي عملية مسح أو استطلاع لموقع ما يجب التأكد من أنه منضم للنطاق (نطاق العمل - Scope) المخصص لك من قبل العميل.

---

https://www.shodan.io/ 

https://www.shodan.io/search/examples 

https://search.censys.io/ 

https://crt.sh/

---

---

# Reconnaissance & Information Gathering

## Module Two: Survey and Information Gathering

In this module, we begin with the first practical step, which is survey (reconnaissance).

The goal of this stage is to learn everything about the target, its components, and how to access detailed information about it.

Surveying is conducted using two methods:

1. **Active Reconnaissance**
2. **Passive Reconnaissance**

### The main difference between them:

* **Active Reconnaissance**: When we visit the website directly and explore its contents (such as pages, code, and technologies used). This method leaves traces on the web server, such as the IP address, browser type, and operating system.

* **Passive Reconnaissance**: We use side tools that perform surveys without directly interacting with the website.

## The most important tools for gathering information

### 1. **Shodan**

* A search engine for all Internet systems (similar to Scanner)
* You can search for specific web servers and technologies by specifying the country
* Displays: Open Ports, Open Services, Server Type, and Hosting Organization

### 2. **Censys**

* Similar to Shodan, but more organized in data presentation
* Displays: OS, Load Balancer, Open Ports, HTTP Status, SSL Certificate Info

### 3. **crt.sh (Certificate Transparency Logs)**

* Displays domains and subdomains associated with SSL certificates
* Certificate expiration and renewal dates can be viewed
* This is useful for identifying the actual systems and subdomains of the target

## Important Note:

Before any scanning or survey of a website, you must ensure that it is affiliated with the domain (working scope) assigned to you by the client.

---

These are the steps for surveying and gathering initial information for the target. In the next steps, we will review tools for deep scanning.